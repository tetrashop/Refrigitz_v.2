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

/*
  The code in this file is based on the opening book code in PolyGlot
  by Fabien Letouzey. PolyGlot is available under the GNU General
  Public License, and can be downloaded from http://wbec-ridderkerk.nl
*/

#ifndef BOOK_H_INCLUDED
#define BOOK_H_INCLUDED

#include <fstream>
#include <string>

#include "position.h"
#include "rkiss.h"

class PolyglotBook : private std::ifstream {
public:
  PolyglotBook();
 ~PolyglotBook();
  Move probe(const Position& pos, const std::string& fName, bool pickBest);

private:
  template<typename T> PolyglotBook& operator>>(T& n);

  bool open(const char* fName);
  size_t find_first(Key key);

  RKISS rkiss;
  std::string fileName;
};

#endif // #ifndef BOOK_H_INCLUDED
