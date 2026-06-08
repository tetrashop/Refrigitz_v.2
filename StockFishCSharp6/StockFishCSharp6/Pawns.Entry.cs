namespace Pawns

	public class Entry
	{
//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
		public Value shelter_storm<Color Us>(Position pos, Square ksq)
		{
        
		  Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
        
        
		  uint GlobalMembersBitboard.long b = pos.pieces(PieceType.PAWN) & (GlobalMembersBitboard.in_front_bb(Us, GlobalMembersTypes.rank_of(ksq)) | GlobalMembersBitboard.rank_bb(ksq));
		  uint GlobalMembersBitboard.long ourPawns = b & pos.pieces(Us);
		  uint GlobalMembersBitboard.long theirPawns = b & pos.pieces(Them);
		  Value safety = MaxSafetyBonus;
		  File center = Math.Max(File.FILE_B, Math.Min(File.FILE_G, GlobalMembersTypes.file_of(ksq)));
        
		  for (File f = center - File(1); f <= center + File(1); ++f)
		  {
			  b = ourPawns & GlobalMembersBitboard.file_bb(f);
			  Rank rkUs = b ? GlobalMembersTypes.relative_rank(Us, GlobalMembersBitboard.backmost_sq(Us, b)) : Rank.RANK_1;
        
			  b = theirPawns & GlobalMembersBitboard.file_bb(f);
			  Rank rkThem = b ? GlobalMembersTypes.relative_rank(Us, GlobalMembersBitboard.frontmost_sq(Them, b)) : Rank.RANK_1;
        
			  safety -= ShelterWeakness[Math.Min(f, File.FILE_H - f), (int)rkUs] + StormDanger [(int)f == GlobalMembersTypes.file_of(ksq) && rkThem == GlobalMembersTypes.relative_rank(Us, ksq) + 1 ? BlockedByKing : rkUs == ((int)Rank.RANK_1) != 0 ? NoFriendlyPawn : rkThem == rkUs + 1 ? BlockedByPawn : Unblocked, Math.Min(f, File.FILE_H - f), (int)rkThem];
		  }
        
		  return safety;
		}

		public Score do_king_safety<Color Us>(Position pos, Square ksq)
		{
        
		  kingSquares[Us] = ksq;
		  castlingRights[Us] = pos.can_castle(Us);
		  minKingPawnDistance[Us] = 0;
        
		  uint GlobalMembersBitboard.long pawns = pos.pieces(Us, PieceType.PAWN);
		  if (pawns)
		  {
			  while (!(DistanceRingBB[(int)ksq][minKingPawnDistance[Us]++] & pawns))
			  {
			  }
		  }
        
		  if (GlobalMembersTypes.relative_rank(Us, ksq) > Rank.RANK_4)
		  {
			  return GlobalMembersTypes.make_score(0, -16 * minKingPawnDistance[Us]);
		  }
        
		  Value bonus = shelter_storm<Us>(pos, ksq);
        
		  // If we can castle use the bonus after the castling if it is bigger
		  if (pos.can_castle(MakeCastling<Us, CastlingSide.KING_SIDE>.right) != 0)
		  {
			  bonus = Math.Max(bonus, shelter_storm<Us>(pos, GlobalMembersTypes.relative_square(Us, Square.SQ_G1)));
		  }
        
		  if (pos.can_castle(MakeCastling<Us, CastlingSide.QUEEN_SIDE>.right) != 0)
		  {
			  bonus = Math.Max(bonus, shelter_storm<Us>(pos, GlobalMembersTypes.relative_square(Us, Square.SQ_C1)));
		  }
        
		  return GlobalMembersTypes.make_score(bonus, -16 * minKingPawnDistance[Us]);
		}

		public Value shelter_storm<Color Us>(Position pos, Square ksq)
		{
        
		  Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
        
        
		  uint GlobalMembersBitboard.long b = pos.pieces(PieceType.PAWN) & (GlobalMembersBitboard.in_front_bb(Us, GlobalMembersTypes.rank_of(ksq)) | GlobalMembersBitboard.rank_bb(ksq));
		  uint GlobalMembersBitboard.long ourPawns = b & pos.pieces(Us);
		  uint GlobalMembersBitboard.long theirPawns = b & pos.pieces(Them);
		  Value safety = MaxSafetyBonus;
		  File center = Math.Max(File.FILE_B, Math.Min(File.FILE_G, GlobalMembersTypes.file_of(ksq)));
        
		  for (File f = center - File(1); f <= center + File(1); ++f)
		  {
			  b = ourPawns & GlobalMembersBitboard.file_bb(f);
			  Rank rkUs = b ? GlobalMembersTypes.relative_rank(Us, GlobalMembersBitboard.backmost_sq(Us, b)) : Rank.RANK_1;
        
			  b = theirPawns & GlobalMembersBitboard.file_bb(f);
			  Rank rkThem = b ? GlobalMembersTypes.relative_rank(Us, GlobalMembersBitboard.frontmost_sq(Them, b)) : Rank.RANK_1;
        
			  safety -= ShelterWeakness[Math.Min(f, File.FILE_H - f), (int)rkUs] + StormDanger [(int)f == GlobalMembersTypes.file_of(ksq) && rkThem == GlobalMembersTypes.relative_rank(Us, ksq) + 1 ? BlockedByKing : rkUs == ((int)Rank.RANK_1) != 0 ? NoFriendlyPawn : rkThem == rkUs + 1 ? BlockedByPawn : Unblocked, Math.Min(f, File.FILE_H - f), (int)rkThem];
		  }
        
		  return safety;
		}

		public Score do_king_safety<Color Us>(Position pos, Square ksq)
		{
        
		  kingSquares[Us] = ksq;
		  castlingRights[Us] = pos.can_castle(Us);
		  minKingPawnDistance[Us] = 0;
        
		  uint GlobalMembersBitboard.long pawns = pos.pieces(Us, PieceType.PAWN);
		  if (pawns)
		  {
			  while (!(DistanceRingBB[(int)ksq][minKingPawnDistance[Us]++] & pawns))
			  {
			  }
		  }
        
		  if (GlobalMembersTypes.relative_rank(Us, ksq) > Rank.RANK_4)
		  {
			  return GlobalMembersTypes.make_score(0, -16 * minKingPawnDistance[Us]);
		  }
        
		  Value bonus = shelter_storm<Us>(pos, ksq);
        
		  // If we can castle use the bonus after the castling if it is bigger
		  if (pos.can_castle(MakeCastling<Us, CastlingSide.KING_SIDE>.right) != 0)
		  {
			  bonus = Math.Max(bonus, shelter_storm<Us>(pos, GlobalMembersTypes.relative_square(Us, Square.SQ_G1)));
		  }
        
		  if (pos.can_castle(MakeCastling<Us, CastlingSide.QUEEN_SIDE>.right) != 0)
		  {
			  bonus = Math.Max(bonus, shelter_storm<Us>(pos, GlobalMembersTypes.relative_square(Us, Square.SQ_C1)));
		  }
        
		  return GlobalMembersTypes.make_score(bonus, -16 * minKingPawnDistance[Us]);
		}

		public Value shelter_storm<Color Us>(Position pos, Square ksq)
		{
        
		  Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
        
        
		  uint GlobalMembersBitboard.long b = pos.pieces(PieceType.PAWN) & (GlobalMembersBitboard.in_front_bb(Us, GlobalMembersTypes.rank_of(ksq)) | GlobalMembersBitboard.rank_bb(ksq));
		  uint GlobalMembersBitboard.long ourPawns = b & pos.pieces(Us);
		  uint GlobalMembersBitboard.long theirPawns = b & pos.pieces(Them);
		  Value safety = MaxSafetyBonus;
		  File center = Math.Max(File.FILE_B, Math.Min(File.FILE_G, GlobalMembersTypes.file_of(ksq)));
        
		  for (File f = center - File(1); f <= center + File(1); ++f)
		  {
			  b = ourPawns & GlobalMembersBitboard.file_bb(f);
			  Rank rkUs = b ? GlobalMembersTypes.relative_rank(Us, GlobalMembersBitboard.backmost_sq(Us, b)) : Rank.RANK_1;
        
			  b = theirPawns & GlobalMembersBitboard.file_bb(f);
			  Rank rkThem = b ? GlobalMembersTypes.relative_rank(Us, GlobalMembersBitboard.frontmost_sq(Them, b)) : Rank.RANK_1;
        
			  safety -= ShelterWeakness[Math.Min(f, File.FILE_H - f), (int)rkUs] + StormDanger [(int)f == GlobalMembersTypes.file_of(ksq) && rkThem == GlobalMembersTypes.relative_rank(Us, ksq) + 1 ? BlockedByKing : rkUs == ((int)Rank.RANK_1) != 0 ? NoFriendlyPawn : rkThem == rkUs + 1 ? BlockedByPawn : Unblocked, Math.Min(f, File.FILE_H - f), (int)rkThem];
		  }
        
		  return safety;
		}

		public Score do_king_safety<Color Us>(Position pos, Square ksq)
		{
        
		  kingSquares[Us] = ksq;
		  castlingRights[Us] = pos.can_castle(Us);
		  minKingPawnDistance[Us] = 0;
        
		  uint GlobalMembersBitboard.long pawns = pos.pieces(Us, PieceType.PAWN);
		  if (pawns)
		  {
			  while (!(DistanceRingBB[(int)ksq][minKingPawnDistance[Us]++] & pawns))
			  {
			  }
		  }
        
		  if (GlobalMembersTypes.relative_rank(Us, ksq) > Rank.RANK_4)
		  {
			  return GlobalMembersTypes.make_score(0, -16 * minKingPawnDistance[Us]);
		  }
        
		  Value bonus = shelter_storm<Us>(pos, ksq);
        
		  // If we can castle use the bonus after the castling if it is bigger
		  if (pos.can_castle(MakeCastling<Us, CastlingSide.KING_SIDE>.right) != 0)
		  {
			  bonus = Math.Max(bonus, shelter_storm<Us>(pos, GlobalMembersTypes.relative_square(Us, Square.SQ_G1)));
		  }
        
		  if (pos.can_castle(MakeCastling<Us, CastlingSide.QUEEN_SIDE>.right) != 0)
		  {
			  bonus = Math.Max(bonus, shelter_storm<Us>(pos, GlobalMembersTypes.relative_square(Us, Square.SQ_C1)));
		  }
        
		  return GlobalMembersTypes.make_score(bonus, -16 * minKingPawnDistance[Us]);
		}
	}
}