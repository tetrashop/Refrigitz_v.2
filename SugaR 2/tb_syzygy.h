/*
  Copyright (c) 2013 Ronald de Man
  This file may be redistributed and/or modified without restrictions.

  tb_syzygy.cpp contains the Stockfish-specific routines of the
  tablebase probing code. It should be relatively easy to adapt
  this code to other chess engines.
*/

// The probing code currently expects a little-endian architecture (e.g. x86).

// Define DECOMP64 when compiling for a 64-bit platform.
// 32-bit is only supported for 5-piece tables, because tables are mmap()ed
// into memory.
#ifndef TBPROBE_H
#define TBPROBE_H

namespace Tablebases {

extern int TBLargest;

void init(const std::string& path);
int probe_wdl(Position& pos, int *success);
int probe_dtz(Position& pos, int *success);
bool root_probe(Position& pos, Value& TBScore);
bool root_probe_wdl(Position& pos, Value& TBScore);

}

#endif
