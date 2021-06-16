public class Bitboards
{
//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public string pretty(uint long b)
	{
    
	  string s = "+---+---+---+---+---+---+---+---+\n";
    
	  for (Rank r = Rank.RANK_8; r >= Rank.RANK_1; --r)
	  {
		  for (File f = File.FILE_A; f <= File.FILE_H; ++f)
		  {
			  s.append((b & (int)GlobalMembersTypes.make_square(f, r)) != 0 ? "| X " : "|   ");
		  }
    
		  s.append("|\n+---+---+---+---+---+---+---+---+\n");
	  }
    
	  return s;
	}

	public void init()
	{
    
	  for (Square s = Square.SQ_A1; s <= Square.SQ_H8; ++s)
	  {
		  SquareBB[(int)s] = 1UL << s;
		  BSFTable[GlobalMembersBitboard.bsf_index(SquareBB[(int)s])] = s;
	  }
    
	  for (uint long b = 1; b < 256; ++b)
	  {
		  MS1BTable[b] = GlobalMembersBitboard.more_than_one(b) ? MS1BTable[b - 1] : GlobalMembersBitboard.lsb(b);
	  }
    
	  for (File f = File.FILE_A; f <= File.FILE_H; ++f)
	  {
		  FileBB[(int)f] = f > ((int)File.FILE_A) != 0 ? FileBB[(int)f - 1] << 1 : FileABB;
	  }
    
	  for (Rank r = Rank.RANK_1; r <= Rank.RANK_8; ++r)
	  {
		  RankBB[(int)r] = r > ((int)Rank.RANK_1) != 0 ? RankBB[(int)r - 1] << 8 : Rank1BB;
	  }
    
	  for (File f = File.FILE_A; f <= File.FILE_H; ++f)
	  {
		  AdjacentFilesBB[(int)f] = (f > ((int)File.FILE_A) != 0 ? FileBB[(int)f - 1] : 0) | (f < ((int)File.FILE_H) != 0 ? FileBB[(int)f + 1] : 0);
	  }
    
	  for (Rank r = Rank.RANK_1; r < Rank.RANK_8; ++r)
	  {
		  InFrontBB[(int)Color.WHITE][(int)r] = ~(InFrontBB[(int)Color.BLACK][(int)r + 1] = InFrontBB[(int)Color.BLACK][(int)r] | RankBB[(int)r]);
	  }
    
	  for (Color c = Color.WHITE; c <= Color.BLACK; ++c)
	  {
		  for (Square s = Square.SQ_A1; s <= Square.SQ_H8; ++s)
		  {
			  ForwardBB[(int)c][(int)s] = InFrontBB[(int)c][(int)GlobalMembersTypes.rank_of(s)] & FileBB[(int)GlobalMembersTypes.file_of(s)];
			  PawnAttackSpan[(int)c][(int)s] = InFrontBB[(int)c][(int)GlobalMembersTypes.rank_of(s)] & AdjacentFilesBB[(int)GlobalMembersTypes.file_of(s)];
			  PassedPawnMask[(int)c][(int)s] = ForwardBB[(int)c][(int)s] | PawnAttackSpan[(int)c][(int)s];
		  }
	  }
    
	  for (Square s1 = Square.SQ_A1; s1 <= Square.SQ_H8; ++s1)
	  {
		  for (Square s2 = Square.SQ_A1; s2 <= Square.SQ_H8; ++s2)
		  {
			  if (s1 != s2)
			  {
				  SquareDistance[(int)s1, (int)s2] = Math.Max(GlobalMembersBitboard.distance<File>(s1, s2), GlobalMembersBitboard.distance<Rank>(s1, s2));
				  DistanceRingBB[(int)s1][SquareDistance[(int)s1, (int)s2] - 1] |= s2;
			  }
		  }
	  }
    
	  int[,] steps = {{, 0, 0, 0, 0, 0, 0, 0, 0}, {7, 9, 0, 0, 0, 0, 0, 0, 0}, {17, 15, 10, 6, -6, -10, -15, -17, 0}, {, 0, 0, 0, 0, 0, 0, 0, 0}, {, 0, 0, 0, 0, 0, 0, 0, 0}, {, 0, 0, 0, 0, 0, 0, 0, 0}, {9, 7, -7, -9, 8, 1, -1, -8, 0}};
    
	  for (Color c = Color.WHITE; c <= Color.BLACK; ++c)
	  {
		  for (PieceType pt = PieceType.PAWN; pt <= PieceType.KING; ++pt)
		  {
			  for (Square s = Square.SQ_A1; s <= Square.SQ_H8; ++s)
			  {
				  for (int i = 0; steps[(int)pt, i] != 0; ++i)
				  {
					  Square to = s + Square(c == ((int)Color.WHITE) != 0 ? steps[(int)pt, i] : -steps[(int)pt, i]);
    
					  if (GlobalMembersTypes.is_ok(to) && GlobalMembersBitboard.distance(s, to) < 3)
					  {
						  StepAttacksBB[(int)GlobalMembersTypes.make_piece(c, pt)][(int)s] |= to;
					  }
				  }
			  }
		  }
	  }
    
	  Square[] RookDeltas = {Square.DELTA_N, Square.DELTA_E, Square.DELTA_S, Square.DELTA_W};
	  Square[] BishopDeltas = {Square.DELTA_NE, Square.DELTA_SE, Square.DELTA_SW, Square.DELTA_NW};
    
	  GlobalMembersBitboard.init_magics(RookTable, RookAttacks, RookMagics, RookMasks, RookShifts, RookDeltas, GlobalMembersBitboard.magic_index<PieceType.ROOK>);
	  GlobalMembersBitboard.init_magics(BishopTable, BishopAttacks, BishopMagics, BishopMasks, BishopShifts, BishopDeltas, GlobalMembersBitboard.magic_index<PieceType.BISHOP>);
    
	  for (Square s1 = Square.SQ_A1; s1 <= Square.SQ_H8; ++s1)
	  {
		  PseudoAttacks[(int)PieceType.QUEEN][(int)s1] = PseudoAttacks[(int)PieceType.BISHOP][(int)s1] = GlobalMembersBitboard.attacks_bb<PieceType.BISHOP>(s1, 0);
		  PseudoAttacks[(int)PieceType.QUEEN][(int)s1] |= PseudoAttacks[(int)PieceType.ROOK][(int)s1] = GlobalMembersBitboard.attacks_bb< PieceType.ROOK>(s1, 0);
    
		  for (Square s2 = Square.SQ_A1; s2 <= Square.SQ_H8; ++s2)
		  {
			  Piece pc = (PseudoAttacks[(int)PieceType.BISHOP][(int)s1] & (int)s2) ? Piece.W_BISHOP : (PseudoAttacks[(int)PieceType.ROOK][(int)s1] & (int)s2) ? Piece.W_ROOK : Piece.NO_PIECE;
    
			  if (pc == Piece.NO_PIECE)
				  continue;
    
			  LineBB[(int)s1][(int)s2] = (GlobalMembersBitboard.attacks_bb(pc, s1, 0) & GlobalMembersBitboard.attacks_bb(pc, s2, 0)) | (int)s1 | (int)s2;
			  BetweenBB[(int)s1][(int)s2] = GlobalMembersBitboard.attacks_bb(pc, s1, SquareBB[(int)s2]) & GlobalMembersBitboard.attacks_bb(pc, s2, SquareBB[(int)s1]);
		  }
	  }
	}

	public string pretty(uint long b)
	{
    
	  string s = "+---+---+---+---+---+---+---+---+\n";
    
	  for (Rank r = Rank.RANK_8; r >= Rank.RANK_1; --r)
	  {
		  for (File f = File.FILE_A; f <= File.FILE_H; ++f)
		  {
			  s.append((b & (int)GlobalMembersTypes.make_square(f, r)) != 0 ? "| X " : "|   ");
		  }
    
		  s.append("|\n+---+---+---+---+---+---+---+---+\n");
	  }
    
	  return s;
	}

	public void init()
	{
    
	  for (Square s = Square.SQ_A1; s <= Square.SQ_H8; ++s)
	  {
		  SquareBB[(int)s] = 1UL << s;
		  BSFTable[GlobalMembersBitboard.bsf_index(SquareBB[(int)s])] = s;
	  }
    
	  for (uint long b = 1; b < 256; ++b)
	  {
		  MS1BTable[b] = GlobalMembersBitboard.more_than_one(b) ? MS1BTable[b - 1] : GlobalMembersBitboard.lsb(b);
	  }
    
	  for (File f = File.FILE_A; f <= File.FILE_H; ++f)
	  {
		  FileBB[(int)f] = f > ((int)File.FILE_A) != 0 ? FileBB[(int)f - 1] << 1 : FileABB;
	  }
    
	  for (Rank r = Rank.RANK_1; r <= Rank.RANK_8; ++r)
	  {
		  RankBB[(int)r] = r > ((int)Rank.RANK_1) != 0 ? RankBB[(int)r - 1] << 8 : Rank1BB;
	  }
    
	  for (File f = File.FILE_A; f <= File.FILE_H; ++f)
	  {
		  AdjacentFilesBB[(int)f] = (f > ((int)File.FILE_A) != 0 ? FileBB[(int)f - 1] : 0) | (f < ((int)File.FILE_H) != 0 ? FileBB[(int)f + 1] : 0);
	  }
    
	  for (Rank r = Rank.RANK_1; r < Rank.RANK_8; ++r)
	  {
		  InFrontBB[(int)Color.WHITE][(int)r] = ~(InFrontBB[(int)Color.BLACK][(int)r + 1] = InFrontBB[(int)Color.BLACK][(int)r] | RankBB[(int)r]);
	  }
    
	  for (Color c = Color.WHITE; c <= Color.BLACK; ++c)
	  {
		  for (Square s = Square.SQ_A1; s <= Square.SQ_H8; ++s)
		  {
			  ForwardBB[(int)c][(int)s] = InFrontBB[(int)c][(int)GlobalMembersTypes.rank_of(s)] & FileBB[(int)GlobalMembersTypes.file_of(s)];
			  PawnAttackSpan[(int)c][(int)s] = InFrontBB[(int)c][(int)GlobalMembersTypes.rank_of(s)] & AdjacentFilesBB[(int)GlobalMembersTypes.file_of(s)];
			  PassedPawnMask[(int)c][(int)s] = ForwardBB[(int)c][(int)s] | PawnAttackSpan[(int)c][(int)s];
		  }
	  }
    
	  for (Square s1 = Square.SQ_A1; s1 <= Square.SQ_H8; ++s1)
	  {
		  for (Square s2 = Square.SQ_A1; s2 <= Square.SQ_H8; ++s2)
		  {
			  if (s1 != s2)
			  {
				  SquareDistance[(int)s1, (int)s2] = Math.Max(GlobalMembersBitboard.distance<File>(s1, s2), GlobalMembersBitboard.distance<Rank>(s1, s2));
				  DistanceRingBB[(int)s1][SquareDistance[(int)s1, (int)s2] - 1] |= s2;
			  }
		  }
	  }
    
	  int[,] steps = {{, 0, 0, 0, 0, 0, 0, 0, 0}, {7, 9, 0, 0, 0, 0, 0, 0, 0}, {17, 15, 10, 6, -6, -10, -15, -17, 0}, {, 0, 0, 0, 0, 0, 0, 0, 0}, {, 0, 0, 0, 0, 0, 0, 0, 0}, {, 0, 0, 0, 0, 0, 0, 0, 0}, {9, 7, -7, -9, 8, 1, -1, -8, 0}};
    
	  for (Color c = Color.WHITE; c <= Color.BLACK; ++c)
	  {
		  for (PieceType pt = PieceType.PAWN; pt <= PieceType.KING; ++pt)
		  {
			  for (Square s = Square.SQ_A1; s <= Square.SQ_H8; ++s)
			  {
				  for (int i = 0; steps[(int)pt, i] != 0; ++i)
				  {
					  Square to = s + Square(c == ((int)Color.WHITE) != 0 ? steps[(int)pt, i] : -steps[(int)pt, i]);
    
					  if (GlobalMembersTypes.is_ok(to) && GlobalMembersBitboard.distance(s, to) < 3)
					  {
						  StepAttacksBB[(int)GlobalMembersTypes.make_piece(c, pt)][(int)s] |= to;
					  }
				  }
			  }
		  }
	  }
    
	  Square[] RookDeltas = {Square.DELTA_N, Square.DELTA_E, Square.DELTA_S, Square.DELTA_W};
	  Square[] BishopDeltas = {Square.DELTA_NE, Square.DELTA_SE, Square.DELTA_SW, Square.DELTA_NW};
    
	  GlobalMembersBitboard.init_magics(RookTable, RookAttacks, RookMagics, RookMasks, RookShifts, RookDeltas, GlobalMembersBitboard.magic_index<PieceType.ROOK>);
	  GlobalMembersBitboard.init_magics(BishopTable, BishopAttacks, BishopMagics, BishopMasks, BishopShifts, BishopDeltas, GlobalMembersBitboard.magic_index<PieceType.BISHOP>);
    
	  for (Square s1 = Square.SQ_A1; s1 <= Square.SQ_H8; ++s1)
	  {
		  PseudoAttacks[(int)PieceType.QUEEN][(int)s1] = PseudoAttacks[(int)PieceType.BISHOP][(int)s1] = GlobalMembersBitboard.attacks_bb<PieceType.BISHOP>(s1, 0);
		  PseudoAttacks[(int)PieceType.QUEEN][(int)s1] |= PseudoAttacks[(int)PieceType.ROOK][(int)s1] = GlobalMembersBitboard.attacks_bb< PieceType.ROOK>(s1, 0);
    
		  for (Square s2 = Square.SQ_A1; s2 <= Square.SQ_H8; ++s2)
		  {
			  Piece pc = (PseudoAttacks[(int)PieceType.BISHOP][(int)s1] & (int)s2) ? Piece.W_BISHOP : (PseudoAttacks[(int)PieceType.ROOK][(int)s1] & (int)s2) ? Piece.W_ROOK : Piece.NO_PIECE;
    
			  if (pc == Piece.NO_PIECE)
				  continue;
    
			  LineBB[(int)s1][(int)s2] = (GlobalMembersBitboard.attacks_bb(pc, s1, 0) & GlobalMembersBitboard.attacks_bb(pc, s2, 0)) | (int)s1 | (int)s2;
			  BetweenBB[(int)s1][(int)s2] = GlobalMembersBitboard.attacks_bb(pc, s1, SquareBB[(int)s2]) & GlobalMembersBitboard.attacks_bb(pc, s2, SquareBB[(int)s1]);
		  }
	  }
	}

	public string pretty(uint long b)
	{
    
	  string s = "+---+---+---+---+---+---+---+---+\n";
    
	  for (Rank r = Rank.RANK_8; r >= Rank.RANK_1; --r)
	  {
		  for (File f = File.FILE_A; f <= File.FILE_H; ++f)
		  {
			  s.append((b & (int)GlobalMembersTypes.make_square(f, r)) != 0 ? "| X " : "|   ");
		  }
    
		  s.append("|\n+---+---+---+---+---+---+---+---+\n");
	  }
    
	  return s;
	}

	public void init()
	{
    
	  for (Square s = Square.SQ_A1; s <= Square.SQ_H8; ++s)
	  {
		  SquareBB[(int)s] = 1UL << s;
		  BSFTable[GlobalMembersBitboard.bsf_index(SquareBB[(int)s])] = s;
	  }
    
	  for (uint long b = 1; b < 256; ++b)
	  {
		  MS1BTable[b] = GlobalMembersBitboard.more_than_one(b) ? MS1BTable[b - 1] : GlobalMembersBitboard.lsb(b);
	  }
    
	  for (File f = File.FILE_A; f <= File.FILE_H; ++f)
	  {
		  FileBB[(int)f] = f > ((int)File.FILE_A) != 0 ? FileBB[(int)f - 1] << 1 : FileABB;
	  }
    
	  for (Rank r = Rank.RANK_1; r <= Rank.RANK_8; ++r)
	  {
		  RankBB[(int)r] = r > ((int)Rank.RANK_1) != 0 ? RankBB[(int)r - 1] << 8 : Rank1BB;
	  }
    
	  for (File f = File.FILE_A; f <= File.FILE_H; ++f)
	  {
		  AdjacentFilesBB[(int)f] = (f > ((int)File.FILE_A) != 0 ? FileBB[(int)f - 1] : 0) | (f < ((int)File.FILE_H) != 0 ? FileBB[(int)f + 1] : 0);
	  }
    
	  for (Rank r = Rank.RANK_1; r < Rank.RANK_8; ++r)
	  {
		  InFrontBB[(int)Color.WHITE][(int)r] = ~(InFrontBB[(int)Color.BLACK][(int)r + 1] = InFrontBB[(int)Color.BLACK][(int)r] | RankBB[(int)r]);
	  }
    
	  for (Color c = Color.WHITE; c <= Color.BLACK; ++c)
	  {
		  for (Square s = Square.SQ_A1; s <= Square.SQ_H8; ++s)
		  {
			  ForwardBB[(int)c][(int)s] = InFrontBB[(int)c][(int)GlobalMembersTypes.rank_of(s)] & FileBB[(int)GlobalMembersTypes.file_of(s)];
			  PawnAttackSpan[(int)c][(int)s] = InFrontBB[(int)c][(int)GlobalMembersTypes.rank_of(s)] & AdjacentFilesBB[(int)GlobalMembersTypes.file_of(s)];
			  PassedPawnMask[(int)c][(int)s] = ForwardBB[(int)c][(int)s] | PawnAttackSpan[(int)c][(int)s];
		  }
	  }
    
	  for (Square s1 = Square.SQ_A1; s1 <= Square.SQ_H8; ++s1)
	  {
		  for (Square s2 = Square.SQ_A1; s2 <= Square.SQ_H8; ++s2)
		  {
			  if (s1 != s2)
			  {
				  SquareDistance[(int)s1, (int)s2] = Math.Max(GlobalMembersBitboard.distance<File>(s1, s2), GlobalMembersBitboard.distance<Rank>(s1, s2));
				  DistanceRingBB[(int)s1][SquareDistance[(int)s1, (int)s2] - 1] |= s2;
			  }
		  }
	  }
    
	  int[,] steps = {{, 0, 0, 0, 0, 0, 0, 0, 0}, {7, 9, 0, 0, 0, 0, 0, 0, 0}, {17, 15, 10, 6, -6, -10, -15, -17, 0}, {, 0, 0, 0, 0, 0, 0, 0, 0}, {, 0, 0, 0, 0, 0, 0, 0, 0}, {, 0, 0, 0, 0, 0, 0, 0, 0}, {9, 7, -7, -9, 8, 1, -1, -8, 0}};
    
	  for (Color c = Color.WHITE; c <= Color.BLACK; ++c)
	  {
		  for (PieceType pt = PieceType.PAWN; pt <= PieceType.KING; ++pt)
		  {
			  for (Square s = Square.SQ_A1; s <= Square.SQ_H8; ++s)
			  {
				  for (int i = 0; steps[(int)pt, i] != 0; ++i)
				  {
					  Square to = s + Square(c == ((int)Color.WHITE) != 0 ? steps[(int)pt, i] : -steps[(int)pt, i]);
    
					  if (GlobalMembersTypes.is_ok(to) && GlobalMembersBitboard.distance(s, to) < 3)
					  {
						  StepAttacksBB[(int)GlobalMembersTypes.make_piece(c, pt)][(int)s] |= to;
					  }
				  }
			  }
		  }
	  }
    
	  Square[] RookDeltas = {Square.DELTA_N, Square.DELTA_E, Square.DELTA_S, Square.DELTA_W};
	  Square[] BishopDeltas = {Square.DELTA_NE, Square.DELTA_SE, Square.DELTA_SW, Square.DELTA_NW};
    
	  GlobalMembersBitboard.init_magics(RookTable, RookAttacks, RookMagics, RookMasks, RookShifts, RookDeltas, GlobalMembersBitboard.magic_index<PieceType.ROOK>);
	  GlobalMembersBitboard.init_magics(BishopTable, BishopAttacks, BishopMagics, BishopMasks, BishopShifts, BishopDeltas, GlobalMembersBitboard.magic_index<PieceType.BISHOP>);
    
	  for (Square s1 = Square.SQ_A1; s1 <= Square.SQ_H8; ++s1)
	  {
		  PseudoAttacks[(int)PieceType.QUEEN][(int)s1] = PseudoAttacks[(int)PieceType.BISHOP][(int)s1] = GlobalMembersBitboard.attacks_bb<PieceType.BISHOP>(s1, 0);
		  PseudoAttacks[(int)PieceType.QUEEN][(int)s1] |= PseudoAttacks[(int)PieceType.ROOK][(int)s1] = GlobalMembersBitboard.attacks_bb< PieceType.ROOK>(s1, 0);
    
		  for (Square s2 = Square.SQ_A1; s2 <= Square.SQ_H8; ++s2)
		  {
			  Piece pc = (PseudoAttacks[(int)PieceType.BISHOP][(int)s1] & (int)s2) ? Piece.W_BISHOP : (PseudoAttacks[(int)PieceType.ROOK][(int)s1] & (int)s2) ? Piece.W_ROOK : Piece.NO_PIECE;
    
			  if (pc == Piece.NO_PIECE)
				  continue;
    
			  LineBB[(int)s1][(int)s2] = (GlobalMembersBitboard.attacks_bb(pc, s1, 0) & GlobalMembersBitboard.attacks_bb(pc, s2, 0)) | (int)s1 | (int)s2;
			  BetweenBB[(int)s1][(int)s2] = GlobalMembersBitboard.attacks_bb(pc, s1, SquareBB[(int)s2]) & GlobalMembersBitboard.attacks_bb(pc, s2, SquareBB[(int)s1]);
		  }
	  }
	}
}