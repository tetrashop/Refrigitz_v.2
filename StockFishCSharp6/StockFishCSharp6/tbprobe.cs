using System;
using System.Collections.Generic;

public static class GlobalMembersTbprobe
{
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//  extern uint long psq[COLOR_NB][PIECE_TYPE_NB][SQUARE_NB];

	public static int MaxCardinality = 0;

	// Given a position with 6 or fewer pieces, produce a text string
	// of the form KQPvKRP, where "KQP" represents the white pieces if
	// mirror == 0 and the black pieces if mirror == 1.
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'str', so pointers on this parameter are left unchanged:
	internal static void prt_str(Position pos, sbyte * str, int mirror)
	{
	  Color color;
	  PieceType pt;
	  int i;

	  color = mirror == 0 ? Color.WHITE : Color.BLACK;
	  for (pt = PieceType.KING; pt >= PieceType.PAWN; --pt)
	  {
		for (i = GlobalMembersTbprobe.popcount<Max15>(pos.pieces(color, pt)); i > 0; i--)
		{
		  *str ++= GlobalMembersTbcore.pchr[6 - pt];
		}
	  }
	  *str ++= 'v';
	  color = ~color;
	  for (pt = PieceType.KING; pt >= PieceType.PAWN; --pt)
	  {
		for (i = GlobalMembersTbprobe.popcount<Max15>(pos.pieces(color, pt)); i > 0; i--)
		{
		  *str ++= GlobalMembersTbcore.pchr[6 - pt];
		}
	  }
	  *str ++= 0;
	}

	// Given a position, produce a 64-bit material signature key.
	// If the engine supports such a key, it should equal the engine's key.
	internal static ulong calc_key(Position pos, int mirror)
	{
	  Color color;
	  PieceType pt;
	  int i;
	  ulong key = 0;

	  color = mirror == 0 ? Color.WHITE : Color.BLACK;
	  for (pt = PieceType.PAWN; pt <= PieceType.KING; ++pt)
	  {
		for (i = GlobalMembersTbprobe.popcount<Max15>(pos.pieces(color, pt)); i > 0; i--)
		{
		  key ^= Zobrist.psq[(int)Color.WHITE][(int)pt][i - 1];
		}
	  }
	  color = ~color;
	  for (pt = PieceType.PAWN; pt <= PieceType.KING; ++pt)
	  {
		for (i = GlobalMembersTbprobe.popcount<Max15>(pos.pieces(color, pt)); i > 0; i--)
		{
		  key ^= Zobrist.psq[(int)Color.BLACK][(int)pt][i - 1];
		}
	  }

	  return key;
	}

	// Produce a 64-bit material key corresponding to the material combination
	// defined by pcs[16], where pcs[1], ..., pcs[6] is the number of white
	// pawns, ..., kings and pcs[9], ..., pcs[14] is the number of black
	// pawns, ..., kings.
	internal static ulong calc_key_from_pcs(int[] pcs, int mirror)
	{
	  int color;
	  PieceType pt;
	  int i;
	  ulong key = 0;

	  color = mirror == 0 ? 0 : 8;
	  for (pt = PieceType.PAWN; pt <= PieceType.KING; ++pt)
	  {
		for (i = 0; i < pcs[color + pt]; i++)
		{
		  key ^= Zobrist.psq[(int)Color.WHITE][(int)pt][i];
		}
	  }
	  color ^= 8;
	  for (pt = PieceType.PAWN; pt <= PieceType.KING; ++pt)
	  {
		for (i = 0; i < pcs[color + pt]; i++)
		{
		  key ^= Zobrist.psq[(int)Color.BLACK][(int)pt][i];
		}
	  }

	  return key;
	}

	public static bool is_little_endian()
	{
//C++ TO C# CONVERTER TODO TASK: Unions within methods are not supported in C#:
	//  union
	//  {
	//	int i;
	//	sbyte c[sizeof(int)];
	//  }
	  x;
	  x.i = 1;
	  return x.c[0] == 1;
	}

	internal static byte decompress_pairs(PairsData d, ulong idx)
	{
	  bool isLittleEndian = GlobalMembersTbprobe.is_little_endian();
	  return isLittleEndian ? GlobalMembersTbcore.decompress_pairs<true >(d, idx) : GlobalMembersTbcore.decompress_pairs<false>(d, idx);
	}

	// probe_wdl_table and probe_dtz_table require similar adaptations.
	internal static int probe_wdl_table(Position pos, ref int success)
	{
	  TBEntry ptr;
	  TBHashEntry[] ptr2;
	  ulong idx;
	  ulong key;
	  int i;
	  byte res;
	  int[] p = new int[DefineConstants.TBPIECES];

	  // Obtain the position's material signature key.
	  key = pos.material_key();

	  // Test for KvK.
	  if (key == (Zobrist.psq[(int)Color.WHITE][(int)PieceType.KING][0] ^ Zobrist.psq[(int)Color.BLACK][(int)PieceType.KING][0]))
	  {
		return 0;
	  }

	  ptr2 = GlobalMembersTbcore.TB_hash[key >> (64 - DefineConstants.TBHASHBITS)];
	  for (i = 0; i < DefineConstants.HSHMAX; i++)
	  {
		if (ptr2[i].key == key)
			break;
	  }
	  if (i == DefineConstants.HSHMAX)
	  {
		success = 0;
		return 0;
	  }

	  ptr = ptr2[i].ptr;
	  if (ptr.ready == 0)
	  {
		LOCK(GlobalMembersTbcore.TB_mutex);
		if (ptr.ready == 0)
		{
		  string str = new string(new char[16]);
		  GlobalMembersTbprobe.prt_str(pos, str, ptr.key != key);
		  if (GlobalMembersTbcore.init_table_wdl(ptr, ref str) == 0)
		  {
			ptr2[i].key = 0UL;
			success = 0;
			UNLOCK(GlobalMembersTbcore.TB_mutex);
			return 0;
		  }
		  // Memory barrier to ensure ptr->ready = 1 is not reordered.
	#if _MSC_VER
		  _ReadWriteBarrier();
	#else
		  __asm__ __volatile__ = new __asm__("" global:::"memory");
	#endif
		  ptr.ready = 1;
		}
		UNLOCK(GlobalMembersTbcore.TB_mutex);
	  }

	  int bside;
	  int mirror;
	  int cmirror;
	  if (ptr.symmetric == 0)
	  {
		if (key != ptr.key)
		{
		  cmirror = 8;
		  mirror = 0x38;
		  bside = (pos.side_to_move() == Color.WHITE);
		}
		else
		{
		  cmirror = mirror = 0;
		  bside = !(pos.side_to_move() == Color.WHITE);
		}
	  }
	  else
	  {
		cmirror = (int)pos.side_to_move() == ((int)Color.WHITE) != 0 ? 0 : 8;
		mirror = (int)pos.side_to_move() == ((int)Color.WHITE) != 0 ? 0 : 0x38;
		bside = 0;
	  }

	  // p[i] is to contain the square 0-63 (A1-H8) for a piece of type
	  // pc[i] ^ cmirror, where 1 = white pawn, ..., 14 = black king.
	  // Pieces of the same type are guaranteed to be consecutive.
	  if (ptr.has_pawns == 0)
	  {
		TBEntry_piece entry = (TBEntry_piece)ptr;
		byte[] pc = entry.pieces[bside];
		for (i = 0; i < entry.num;)
		{
		  uint GlobalMembersBitboard.long bb = pos.pieces((Color)((pc[i] ^ cmirror) >> 3), (PieceType)(pc[i] & 0x07));
		  do
		  {
			p[i++] = (int)GlobalMembersBitboard.pop_lsb(ref bb);
		  } while (bb);
		}
		idx = GlobalMembersTbcore.encode_piece(entry, entry.norm[bside], p, entry.factor[bside]);
		res = GlobalMembersTbcore.decompress_pairs(entry.precomp[bside], idx);
	  }
	  else
	  {
		TBEntry_pawn entry = (TBEntry_pawn)ptr;
		int k = entry.file[0].pieces[0, 0] ^ cmirror;
		uint GlobalMembersBitboard.long bb = pos.pieces((Color)(k >> 3), (PieceType)(k & 0x07));
		i = 0;
		do
		{
		  p[i++] = (int)GlobalMembersBitboard.pop_lsb(ref bb) ^ mirror;
		} while (bb);
		int f = GlobalMembersTbcore.pawn_file(entry, p);
		byte[] pc = entry.file[f].pieces[bside];
		for (; i < entry.num;)
		{
		  bb = pos.pieces((Color)((pc[i] ^ cmirror) >> 3), (PieceType)(pc[i] & 0x07));
		  do
		  {
			p[i++] = (int)GlobalMembersBitboard.pop_lsb(ref bb) ^ mirror;
		  } while (bb);
		}
		idx = GlobalMembersTbcore.encode_pawn(entry, entry.file[f].norm[bside], p, entry.file[f].factor[bside]);
		res = GlobalMembersTbcore.decompress_pairs(entry.file[f].precomp[bside], idx);
	  }

	  return ((int)res) - 2;
	}

	internal static int probe_dtz_table(Position pos, int wdl, ref int success)
	{
	  TBEntry ptr;
	  ulong idx;
	  int i;
	  int res;
	  int[] p = new int[DefineConstants.TBPIECES];

	  // Obtain the position's material signature key.
	  ulong key = pos.material_key();

	  if (GlobalMembersTbcore.DTZ_table[0].key1 != key && GlobalMembersTbcore.DTZ_table[0].key2 != key)
	  {
		for (i = 1; i < DefineConstants.DTZ_ENTRIES; i++)
		{
		  if (GlobalMembersTbcore.DTZ_table[i].key1 == key)
			  break;
		}
		if (i < DefineConstants.DTZ_ENTRIES)
		{
		  DTZTableEntry table_entry = GlobalMembersTbcore.DTZ_table[i];
		  for (; i > 0; i--)
		  {
			GlobalMembersTbcore.DTZ_table[i] = GlobalMembersTbcore.DTZ_table[i - 1];
		  }
		  GlobalMembersTbcore.DTZ_table[0] = table_entry;
		}
		else
		{
		  TBHashEntry[] ptr2 = GlobalMembersTbcore.TB_hash[key >> (64 - DefineConstants.TBHASHBITS)];
		  for (i = 0; i < DefineConstants.HSHMAX; i++)
		  {
			if (ptr2[i].key == key)
				break;
		  }
		  if (i == DefineConstants.HSHMAX)
		  {
			success = 0;
			return 0;
		  }
		  ptr = ptr2[i].ptr;
		  string str = new string(new char[16]);
		  int mirror = (ptr.key != key);
		  GlobalMembersTbprobe.prt_str(pos, str, mirror);
		  if (GlobalMembersTbcore.DTZ_table[DefineConstants.DTZ_ENTRIES - 1].entry != null)
		  {
			GlobalMembersTbcore.free_dtz_entry(GlobalMembersTbcore.DTZ_table[DefineConstants.DTZ_ENTRIES - 1].entry);
		  }
		  for (i = DefineConstants.DTZ_ENTRIES - 1; i > 0; i--)
		  {
			GlobalMembersTbcore.DTZ_table[i] = GlobalMembersTbcore.DTZ_table[i - 1];
		  }
		  GlobalMembersTbcore.load_dtz_table(ref str, GlobalMembersTbprobe.calc_key(pos, mirror), GlobalMembersTbprobe.calc_key(pos, mirror == 0));
		}
	  }

	  ptr = GlobalMembersTbcore.DTZ_table[0].entry;
	  if (ptr == null)
	  {
		success = 0;
		return 0;
	  }

	  int bside;
	  int mirror;
	  int cmirror;
	  if (ptr.symmetric == 0)
	  {
		if (key != ptr.key)
		{
		  cmirror = 8;
		  mirror = 0x38;
		  bside = (pos.side_to_move() == Color.WHITE);
		}
		else
		{
		  cmirror = mirror = 0;
		  bside = !(pos.side_to_move() == Color.WHITE);
		}
	  }
	  else
	  {
		cmirror = (int)pos.side_to_move() == ((int)Color.WHITE) != 0 ? 0 : 8;
		mirror = (int)pos.side_to_move() == ((int)Color.WHITE) != 0 ? 0 : 0x38;
		bside = 0;
	  }

	  if (ptr.has_pawns == 0)
	  {
		DTZEntry_piece entry = (DTZEntry_piece)ptr;
		if ((entry.flags & 1) != bside && entry.symmetric == 0)
		{
		  success = -1;
		  return 0;
		}
		byte[] pc = entry.pieces;
		for (i = 0; i < entry.num;)
		{
		  uint GlobalMembersBitboard.long bb = pos.pieces((Color)((pc[i] ^ cmirror) >> 3), (PieceType)(pc[i] & 0x07));
		  do
		  {
			p[i++] = (int)GlobalMembersBitboard.pop_lsb(ref bb);
		  } while (bb);
		}
		idx = GlobalMembersTbcore.encode_piece((TBEntry_piece)entry, entry.norm, p, entry.factor);
		res = GlobalMembersTbcore.decompress_pairs(entry.precomp, idx);

		if ((entry.flags & 2) != 0)
		{
		  res = entry.map[entry.map_idx[GlobalMembersTbcore.wdl_to_map[wdl + 2]] + res];
		}

		if (!(entry.flags & GlobalMembersTbcore.pa_flags[wdl + 2]) || (wdl & 1))
		{
		  res *= 2;
		}
	  }
	  else
	  {
		DTZEntry_pawn entry = (DTZEntry_pawn)ptr;
		int k = entry.file[0].pieces[0] ^ cmirror;
		uint GlobalMembersBitboard.long bb = pos.pieces((Color)(k >> 3), (PieceType)(k & 0x07));
		i = 0;
		do
		{
		  p[i++] = (int)GlobalMembersBitboard.pop_lsb(ref bb) ^ mirror;
		} while (bb);
		int f = GlobalMembersTbcore.pawn_file((TBEntry_pawn)entry, p);
		if ((entry.flags[f] & 1) != bside)
		{
		  success = -1;
		  return 0;
		}
		byte[] pc = entry.file[f].pieces;
		for (; i < entry.num;)
		{
		  bb = pos.pieces((Color)((pc[i] ^ cmirror) >> 3), (PieceType)(pc[i] & 0x07));
		  do
		  {
			p[i++] = (int)GlobalMembersBitboard.pop_lsb(ref bb) ^ mirror;
		  } while (bb);
		}
		idx = GlobalMembersTbcore.encode_pawn((TBEntry_pawn)entry, entry.file[f].norm, p, entry.file[f].factor);
		res = GlobalMembersTbcore.decompress_pairs(entry.file[f].precomp, idx);

		if ((entry.flags[f] & 2) != 0)
		{
		  res = entry.map[entry.map_idx[f, GlobalMembersTbcore.wdl_to_map[wdl + 2]] + res];
		}

		if (!(entry.flags[f] & GlobalMembersTbcore.pa_flags[wdl + 2]) || (wdl & 1))
		{
		  res *= 2;
		}
	  }

	  return res;
	}

	// Add underpromotion captures to list of captures.
	internal static ExtMove add_underprom_caps(Position pos, ExtMove stack, ExtMove end)
	{
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
	  ExtMove * moves = new ExtMove();
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: ExtMove *extra = end;
	  ExtMove * extra = new ExtMove(end);

	  for (moves = stack; moves < end; moves++)
	  {
		Move move = moves.move;
		if (GlobalMembersTypes.type_of(move) == MoveType.PROMOTION && !pos.empty(GlobalMembersTypes.to_sq(move)))
		{
		  (*extra++).move = (Move)(move - (1 << 12));
		  (*extra++).move = (Move)(move - (2 << 12));
		  (*extra++).move = (Move)(move - (3 << 12));
		}
	  }

	  return extra;
	}

	internal static int probe_ab(Position pos, int alpha, int beta, ref int success)
	{
	  int v;
	  ExtMove[] stack = Arrays.InitializeWithDefaultInstances<ExtMove>(64);
	  ExtMove moves;
	  ExtMove end;
	  StateInfo st = new StateInfo();

	  // Generate (at least) all legal non-ep captures including (under)promotions.
	  // It is OK to generate more, as long as they are filtered out below.
	  if (pos.checkers() == 0)
	  {
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: end = generate<CAPTURES>(pos, stack);
		end = GlobalMembersMovegen.generate<GenType.CAPTURES>(pos, new ExtMove(stack));
		// Since underpromotion captures are not included, we need to add them.
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: end = add_underprom_caps(pos, stack, end);
		end = GlobalMembersTbprobe.add_underprom_caps(pos, new ExtMove(stack), end);
	  }
	  else
	  {
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: end = generate<EVASIONS>(pos, stack);
		end = GlobalMembersMovegen.generate<GenType.EVASIONS>(pos, new ExtMove(stack));
	  }

	  CheckInfo ci = new CheckInfo(pos);

	  for (moves = stack; moves < end; moves++)
	  {
		Move capture = moves.move;
		if (!pos.capture(capture) || GlobalMembersTypes.type_of(capture) == MoveType.ENPASSANT || !pos.legal(capture, ci.pinned))
		  continue;
		pos.do_move(capture, st, ci, pos.gives_check(capture, ci));
		v = -GlobalMembersTbprobe.probe_ab(pos, -beta, -alpha, ref success);
		pos.undo_move(capture);
		if (success == 0)
		{
			return 0;
		}
		if (v > alpha)
		{
		  if (v >= beta)
		  {
			success = 2;
			return v;
		  }
		  alpha = v;
		}
	  }

	  v = GlobalMembersTbprobe.probe_wdl_table(pos, ref success);
	  if (success == 0)
	  {
		  return 0;
	  }
	  if (alpha >= v)
	  {
		success = 1 + (alpha > 0);
		return alpha;
	  }
	  else
	  {
		success = 1;
		return v;
	  }
	}

	// This routine treats a position with en passant captures as one without.
	internal static int probe_dtz_no_ep(Position pos, ref int success)
	{
	  int wdl;
	  int dtz;

	  wdl = GlobalMembersTbprobe.probe_ab(pos, -2, 2, ref success);
	  if (success == 0)
	  {
		  return 0;
	  }

	  if (wdl == 0)
	  {
		  return 0;
	  }

	  if (success == 2)
	  {
		return wdl == 2 ? 1 : 101;
	  }

	  ExtMove[] stack = Arrays.InitializeWithDefaultInstances<ExtMove>(192);
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
	  ExtMove * moves = new ExtMove();
	  ExtMove end = null;
	  StateInfo st = new StateInfo();
	  CheckInfo ci = new CheckInfo(pos);

	  if (wdl > 0)
	  {
		// Generate at least all legal non-capturing pawn moves
		// including non-capturing promotions.
		if (pos.checkers() == 0)
		{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: end = generate<NON_EVASIONS>(pos, stack);
		  end = GlobalMembersMovegen.generate<GenType.NON_EVASIONS>(pos, new ExtMove(stack));
		}
		else
		{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: end = generate<EVASIONS>(pos, stack);
		  end = GlobalMembersMovegen.generate<GenType.EVASIONS>(pos, new ExtMove(stack));
		}

		for (moves = stack; moves < end; moves++)
		{
		  Move move = moves.move;
		  if (GlobalMembersTypes.type_of(pos.moved_piece(move)) != PieceType.PAWN || pos.capture(move) || !pos.legal(move, ci.pinned))
			continue;
		  pos.do_move(move, st, ci, pos.gives_check(move, ci));
		  int v = -GlobalMembersTbprobe.probe_ab(pos, -2, -wdl + 1, ref success);
		  pos.undo_move(move);
		  if (success == 0)
		  {
			  return 0;
		  }
		  if (v == wdl)
		  {
			return v == 2 ? 1 : 101;
		  }
		}
	  }

	  dtz = 1 + GlobalMembersTbprobe.probe_dtz_table(pos, wdl, ref success);
	  if (success >= 0)
	  {
		if ((wdl & 1) != 0)
		{
			dtz += 100;
		}
		return wdl >= 0 ? dtz : -dtz;
	  }

	  if (wdl > 0)
	  {
		int best = 0xffff;
		for (moves = stack; moves < end; moves++)
		{
		  Move move = moves.move;
		  if (pos.capture(move) || GlobalMembersTypes.type_of(pos.moved_piece(move)) == PieceType.PAWN || !pos.legal(move, ci.pinned))
			continue;
		  pos.do_move(move, st, ci, pos.gives_check(move, ci));
		  int v = -GlobalMembersTbprobe.probe_dtz(pos, ref success);
		  pos.undo_move(move);
		  if (success == 0)
		  {
			  return 0;
		  }
		  if (v > 0 && v + 1 < best)
		  {
			best = v + 1;
		  }
		}
		return best;
	  }
	  else
	  {
		int best = -1;
		if (pos.checkers() == 0)
		{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: end = generate<NON_EVASIONS>(pos, stack);
		  end = GlobalMembersMovegen.generate<GenType.NON_EVASIONS>(pos, new ExtMove(stack));
		}
		else
		{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: end = generate<EVASIONS>(pos, stack);
		  end = GlobalMembersMovegen.generate<GenType.EVASIONS>(pos, new ExtMove(stack));
		}
		for (moves = stack; moves < end; moves++)
		{
		  int v;
		  Move move = moves.move;
		  if (!pos.legal(move, ci.pinned))
			continue;
		  pos.do_move(move, st, ci, pos.gives_check(move, ci));
		  if (st.rule50 == 0)
		  {
			if (wdl == -2)
			{
				v = -1;
			}
			else
			{
			  v = GlobalMembersTbprobe.probe_ab(pos, 1, 2, ref success);
			  v = (v == 2) ? 0 : -101;
			}
		  }
		  else
		  {
			v = -GlobalMembersTbprobe.probe_dtz(pos, ref success) - 1;
		  }
		  pos.undo_move(move);
		  if (success == 0)
		  {
			  return 0;
		  }
		  if (v < best)
		  {
			best = v;
		  }
		}
		return best;
	  }
	}

	internal static int[] wdl_to_dtz = {-1, -101, 0, 101, 1};

	// Check whether there has been at least one repetition of positions
	// since the last capture or pawn move.
	internal static int has_repeated(StateInfo st)
	{
	  while (true)
	  {
		int i = 4;
		int e = Math.Min(st.rule50, st.pliesFromNull);
		if (e < i)
		{
		  return 0;
		}
		StateInfo stp = st.previous.previous;
		do
		{
		  stp = stp.previous.previous;
		  if (stp.key == st.key)
		  {
			return 1;
		  }
		  i += 2;
		} while (i <= e);
		st = st.previous;
	  }
	}

	internal static Value[] wdl_to_Value = {-Value.VALUE_MATE + MAX_PLY + 1, Value.VALUE_DRAW - 2, Value.VALUE_DRAW, Value.VALUE_DRAW + 2, Value.VALUE_MATE - MAX_PLY - 1};
}

/*
  Copyright (c) 2013 Ronald de Man
  This file may be redistributed and/or modified without restrictions.

  tbprobe.cpp contains the Stockfish-specific routines of the
  tablebase probing code. It should be relatively easy to adapt
  this code to other chess engines.
*/






// Probe the WDL table for a particular position.
// If *success != 0, the probe was successful.
// The return value is from the point of view of the side to move:
// -2 : loss
// -1 : loss, but draw under 50-move rule
//  0 : draw
//  1 : win, but draw under 50-move rule
//  2 : win

// Probe the DTZ table for a particular position.
// If *success != 0, the probe was successful.
// The return value is from the point of view of the side to move:
//         n < -100 : loss, but draw under 50-move rule
// -100 <= n < -1   : loss in n ply (assuming 50-move counter == 0)
//         0        : draw
//     1 < n <= 100 : win in n ply (assuming 50-move counter == 0)
//   100 < n        : win, but draw under 50-move rule
//
// The return value n can be off by 1: a return value -n can mean a loss
// in n+1 ply and a return value +n can mean a win in n+1 ply. This
// cannot happen for tables with positions exactly on the "edge" of
// the 50-move rule.
//
// This implies that if dtz > 0 is returned, the position is certainly
// a win if dtz + 50-move-counter <= 99. Care must be taken that the engine
// picks moves that preserve dtz + 50-move-counter <= 99.
//
// If n = 100 immediately after a capture or pawn move, then the position
// is also certainly a win, and during the whole phase until the next
// capture or pawn move, the inequality to be preserved is
// dtz + 50-movecounter <= 100.
//
// In short, if a move is available resulting in dtz + 50-move-counter <= 99,
// then do not accept moves leading to dtz + 50-move-counter == 100.
//

// Use the DTZ tables to filter out moves that don't preserve the win or draw.
// If the position is lost, but DTZ is fairly high, only keep moves that
// maximise DTZ.
//
// A return value false indicates that not all probes were successful and that
// no moves were filtered out.
#if RootMoveVector_ConditionalDefinition1
{
  int success;

  int dtz = GlobalMembersTbprobe.probe_dtz(pos, ref success);
  if (success == 0)
  {
	  return false;
  }

  StateInfo st = new StateInfo();
  CheckInfo ci = new CheckInfo(pos);

  // Probe each move.
  for (uint i = 0; i < rootMoves.Count; i++)
  {
	Move move = rootMoves[i].pv[0];
	pos.do_move(move, st, ci, pos.gives_check(move, ci));
	int v = 0;
	if (pos.checkers() != 0 && dtz > 0)
	{
	  ExtMove[] s = Arrays.InitializeWithDefaultInstances<ExtMove>(192);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: if (generate<LEGAL>(pos, s) == s)
	  if (GlobalMembersMovegen.generate<GenType.LEGAL>(pos, new ExtMove(s)) == s)
	  {
		v = 1;
	  }
	}
	if (v == 0)
	{
	  if (st.rule50 != 0)
	  {
		v = -GlobalMembersTbprobe.probe_dtz(pos, ref success);
		if (v > 0)
		{
			v++;
		}
		else if (v < 0)
		{
			v--;
		}
	  }
	  else
	  {
		v = -GlobalMembersTbprobe.probe_wdl(pos, ref success);
		v = wdl_to_dtz[v + 2];
	  }
	}
	pos.undo_move(move);
	if (success == 0)
	{
		return false;
	}
	rootMoves[i].score = (Value)v;
  }

  // Obtain 50-move counter for the root position.
  // In Stockfish there seems to be no clean way, so we do it like this:
  int cnt50 = st.previous.rule50;

  // Use 50-move counter to determine whether the root position is
  // won, lost or drawn.
  int wdl = 0;
  if (dtz > 0)
  {
	wdl = (dtz + cnt50 <= 100) ? 2 : 1;
  }
  else if (dtz < 0)
  {
	wdl = (-dtz + cnt50 <= 100) ? - 2 : -1;
  }

  // Determine the score to report to the user.
  score = wdl_to_Value[wdl + 2];
  // If the position is winning or losing, but too few moves left, adjust the
  // score to show how close it is to winning or losing.
  // NOTE: int(PawnValueEg) is used as scaling factor in score_to_uci().
  if (wdl == 1 && dtz <= 100)
  {
	score = (Value)(((200 - dtz - cnt50) * (int)Value.PawnValueEg) / 200);
  }
  else if (wdl == -1 && dtz >= -100)
  {
	score = -(Value)(((200 + dtz - cnt50) * (int)Value.PawnValueEg) / 200);
  }

  // Now be a bit smart about filtering out moves.
  uint j = 0;
  if (dtz > 0) // winning (or 50-move rule draw)
  {
	int best = 0xffff;
	for (uint i = 0; i < rootMoves.Count; i++)
	{
	  int v = rootMoves[i].score;
	  if (v > 0 && v < best)
	  {
		best = v;
	  }
	}
	int max = best;
	// If the current phase has not seen repetitions, then try all moves
	// that stay safely within the 50-move budget, if there are any.
	if (GlobalMembersTbprobe.has_repeated(st.previous) == 0 && best + cnt50 <= 99)
	{
	  max = 99 - cnt50;
	}
	for (uint i = 0; i < rootMoves.Count; i++)
	{
	  int v = rootMoves[i].score;
	  if (v > 0 && v <= max)
	  {
		rootMoves[j++] = rootMoves[i];
	  }
	}
  } // losing (or 50-move rule draw)
  else if (dtz < 0)
  {
	int best = 0;
	for (uint i = 0; i < rootMoves.Count; i++)
	{
	  int v = rootMoves[i].score;
	  if (v < best)
	  {
		best = v;
	  }
	}
	// Try all moves, unless we approach or have a 50-move rule draw.
	if (-best * 2 + cnt50 < 100)
	{
	  return true;
	}
	for (uint i = 0; i < rootMoves.Count; i++)
	{
	  if (rootMoves[i].score == best)
	  {
		rootMoves[j++] = rootMoves[i];
	  }
	}
  } // drawing
  else
  {
	// Try all moves that preserve the draw.
	for (uint i = 0; i < rootMoves.Count; i++)
	{
	  if (rootMoves[i].score == 0)
	  {
		rootMoves[j++] = rootMoves[i];
	  }
	}
  }
  rootMoves.resize(j, new Search.RootMove(Move.MOVE_NONE));

  return true;
}

// Use the WDL tables to filter out moves that don't preserve the win or draw.
// This is a fallback for the case that some or all DTZ tables are missing.
//
// A return value false indicates that not all probes were successful and that
// no moves were filtered out.
#if RootMoveVector_ConditionalDefinition1
{
  int success;

  int wdl = GlobalMembersTbprobe.probe_wdl(pos, ref success);
  if (success == 0)
  {
	  return false;
  }
  score = wdl_to_Value[wdl + 2];

  StateInfo st = new StateInfo();
  CheckInfo ci = new CheckInfo(pos);

  int best = -2;

  // Probe each move.
  for (uint i = 0; i < rootMoves.Count; i++)
  {
	Move move = rootMoves[i].pv[0];
	pos.do_move(move, st, ci, pos.gives_check(move, ci));
	int v = -GlobalMembersTbprobe.probe_wdl(pos, ref success);
	pos.undo_move(move);
	if (success == 0)
	{
		return false;
	}
	rootMoves[i].score = (Value)v;
	if (v > best)
	{
	  best = v;
	}
  }

  uint j = 0;
  for (uint i = 0; i < rootMoves.Count; i++)
  {
	if (rootMoves[i].score == best)
	{
	  rootMoves[j++] = rootMoves[i];
	}
  }
  rootMoves.resize(j, new Search.RootMove(Move.MOVE_NONE));

  return true;
}

