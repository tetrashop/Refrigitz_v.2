/*
# Sugar, a UCI chess playing engine derived from Stockfish
# Copyright (C) 2008-2014 Marco Costalba, Joona Kiiski, Tord Romstad
# Sugar is free software: you can redistribute it and/or modify
# it under the terms of the GNU General Public License as published by
# the Free Software Foundation, either version 3 of the License, or
# (at your option) any later version.
#
# Sugar is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU General Public License for more details.
#
# You should have received a copy of the GNU General Public License
# along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#include <iostream>

#include "bitboard.h"
#include "evaluate.h"
#include "position.h"
#include "searching.h"
#include "tb_syzygy.h"
#include "thread.h"
#include "tt.h"
#include "ucioption.h"

void SETUP_PRIVILEGES();
void FREE_MEM(void *);
int main(int argc, char* argv[]) {

#ifndef BENCH
  SETUP_PRIVILEGES();
#endif
  std::cout << engine_info() << std::endl;

  UCI::init(Options);
  Bitboards::init();
  Position::init();
  Bitbases::init_kpk();
  Search::init();
  Pawns::init();
  Eval::init();
  Threads.init();
  TT.set_size2(Options["Hash"]);
  Tablebases::init(Options["SyzygyPath"]);

  UCI::loop(argc, argv);


  FREE_MEM(TT.mem);  
  TT.mem=NULL;
  Threads.exit();
}
