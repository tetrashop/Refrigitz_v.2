/*
  Stockfish, a UCI chess playing engine derived from Glaurung 2.1
  Copyright (C) 2004-2008 Tord Romstad (Glaurung author)
  Copyright (C) 2008-2014 Marco Costalba, Joona Kiiski, Tord Romstad

  Stockfish is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  Stockfish is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#include <cstring>
#include <iostream>

#include "bitboard.h"
#include "tt.h"
#include "platform.h"   // needed for Lp

TranspositionTable TT; // Our global transposition table

void CREATE_MEM(void **,int,uint64_t);
void CREATE_MEM2(void **,uint64_t);
void FREE_MEM(void *);

/// TranspositionTable::resize() sets the size of the transposition table,
/// measured in megabytes. Transposition table consists of a power of 2 number
/// of clusters and each cluster consists of ClusterSize number of TTEntry.

void TranspositionTable::set_size2(uint64_t mbSize)
{
	uint64_t size,msize;

	if(mbSize)
	{
		set_size(mbSize);
		return;
	}
	for(msize=16384;msize;msize>>=1)
	{
		size=ClusterSize<<msb((msize<<20)/sizeof(TTEntry[ClusterSize]));
		hashMask=size-ClusterSize;
		FREE_MEM(mem);
		mem=NULL;
		CREATE_MEM2(&mem,size*sizeof(TTEntry));
		if(mem)
			break;
	}
	if(msize)
	{
		memset(mem,0,size*sizeof(TTEntry));
		table=(TTEntry*)((uintptr_t(mem)+CACHE_LINE_SIZE-1)&~(CACHE_LINE_SIZE-1));
	}
	else
		set_size(32);
}

void TranspositionTable::set_size(uint64_t mbSize)
{
	assert(msb((mbSize<<20)/sizeof(TTEntry))<32);
	uint64_t size=ClusterSize<<msb((mbSize<<20)/sizeof(TTEntry[ClusterSize]));

	if(hashMask==size-ClusterSize)
	{
		memset(mem,0,size*sizeof(TTEntry));
		return;
	}
	hashMask=size-ClusterSize;
	FREE_MEM(mem);
	mem=NULL;
	CREATE_MEM(&mem,64,size*sizeof(TTEntry));
	if(!mem)
	{
		std::cerr<<"Failed to allocate "<<mbSize<<" MB for transposition table."<<std::endl;
		exit(EXIT_FAILURE);
	}
	memset(mem,0,size*sizeof(TTEntry));
	table=(TTEntry*)((uintptr_t(mem)+CACHE_LINE_SIZE-1)&~(CACHE_LINE_SIZE-1));
}

/// TranspositionTable::clear() overwrites the entire transposition table
/// with zeroes. It is called whenever the table is resized, or when the
/// user asks the program to clear the table (from the UCI interface).

void TranspositionTable::clear()
{
	std::memset(table,0,(hashMask+ClusterSize)*sizeof(TTEntry));
}

/// TranspositionTable::probe()looks up the current position in the
/// transposition table. Returns a pointer to the TTEntry or NULL if
/// position is not found.

const TTEntry* TranspositionTable::probe(const Key key) const
{
	TTEntry* tte=first_entry(key);
	uint32_t key32=key>>32;

	for(unsigned i=0;i<ClusterSize;++i,++tte)
		if(tte->key32==key32)
		{
			tte->generation8=generation;//Refresh
				return tte;
		}
	return NULL;
}

/// Returns an approximation of the hashtable occupation during a search
/// (the hash is x permill full)

uint16_t TranspositionTable::full() const
{ 
	uint16_t full_count=0;
	TTEntry *pipo;

	pipo=table;
	for(unsigned i=1000;i;i--,pipo++)
		if(pipo->generation()==generation)
			full_count++;
	return full_count;
}

/// TranspositionTable::store() writes a new entry containing position key and
/// valuable information of current position. The lowest order bits of position
/// key are used to decide in which cluster the position will be placed.
/// When a new entry is written and there are no empty entries available in the
/// cluster, it replaces the least valuable of the entries. A TTEntry t1 is considered
/// to be more valuable than a TTEntry t2 if t1 is from the current search and t2
/// is from a previous search, or if the depth of t1 is bigger than the depth of t2.

void TranspositionTable::store(const Key key,Value v,Bound b,Depth d,Move m,Value statV)
{
	TTEntry *tte,*replace;
	uint32_t key32=key>>32;//Use the high 32 bits as key inside the cluster

	tte=replace=first_entry(key);

	for(unsigned i=0;i<ClusterSize;++i,++tte)
	{
		if((!tte->key32)|(tte->key32==key32)) // Empty or overwrite old
		{
			if(!m)
 				m=tte->move(); // Preserve any existing ttMove
			replace=tte;
			break;
		}

	// Implement replace strategy

		if((replace->generation8==generation)^(((replace->generation8==generation)^(tte->depth16<replace->depth16))&(((tte->generation8==generation)|(tte->bound()==BOUND_EXACT))^(tte->depth16<replace->depth16))))
			replace=tte;

	}
	replace->save(key32,v,b,d,m,generation,statV);
}

