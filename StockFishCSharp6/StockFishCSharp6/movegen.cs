using System.Diagnostics;

public static class GlobalMembersMovegen
{
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'moveList', so pointers on this parameter are left unchanged:
	  public static ExtMove generate_castling<CastlingRight Cr, bool Checks, bool Chess960>(Position pos, ExtMove * moveList, Color us, CheckInfo ci)
	  {

		bool KingSide = (Cr == CastlingRight.WHITE_OO || Cr == CastlingRight.BLACK_OO);

		if (pos.castling_impeded(Cr) || pos.can_castle(Cr) == 0)
		{
			return moveList;
		}

		// After castling, the rook and king final positions are the same in Chess960
		// as they would be in standard chess.
		Square kfrom = pos.king_square(us);
		Square rfrom = pos.castling_rook_square(Cr);
		Square kto = GlobalMembersTypes.relative_square(us, KingSide ? Square.SQ_G1 : Square.SQ_C1);
		uint GlobalMembersBitboard.long enemies = pos.pieces(~us);

		Debug.Assert(pos.checkers() == 0);

		Square K = Chess960 ? kto > ((int)kfrom) != 0 ? Square.DELTA_W : Square.DELTA_E : KingSide ? Square.DELTA_W : Square.DELTA_E;

		for (Square s = kto; s != kfrom; s += K)
		{
			if ((pos.attackers_to(s) & enemies) != 0)
			{
				return moveList;
			}
		}

		// Because we generate only legal castling moves we need to verify that
		// when moving the castling rook we do not discover some hidden checker.
		// For instance an enemy queen in SQ_A1 when castling rook is in SQ_B1.
		if (Chess960 && (GlobalMembersBitboard.attacks_bb<PieceType.ROOK>(kto, pos.pieces() ^ rfrom) & pos.pieces(~us, PieceType.ROOK, PieceType.QUEEN)))
		{
			return moveList;
		}

		Move m = GlobalMembersTypes.make<MoveType.CASTLING>(kfrom, rfrom);

		if (Checks && !pos.gives_check(m, ci))
		{
			return moveList;
		}

		(moveList++).move = m;

		return moveList;
	  }


//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<GenType Type, Square Delta>
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'moveList', so pointers on this parameter are left unchanged:
	  public static ExtMove make_promotions<GenType Type, Square Delta>(ExtMove * moveList, Square to, CheckInfo ci)
	  {

		if (Type == GenType.CAPTURES || Type == GenType.EVASIONS || Type == GenType.NON_EVASIONS)
		{
			(moveList++).move = GlobalMembersTypes.make<MoveType.PROMOTION>(to - Delta, to, PieceType.QUEEN);
		}

		if (Type == GenType.QUIETS || Type == GenType.EVASIONS || Type == GenType.NON_EVASIONS)
		{
			(moveList++).move = GlobalMembersTypes.make<MoveType.PROMOTION>(to - Delta, to, PieceType.ROOK);
			(moveList++).move = GlobalMembersTypes.make<MoveType.PROMOTION>(to - Delta, to, PieceType.BISHOP);
			(moveList++).move = GlobalMembersTypes.make<MoveType.PROMOTION>(to - Delta, to, PieceType.KNIGHT);
		}

		// Knight promotion is the only promotion that can give a direct check
		// that's not already included in the queen promotion.
		if (Type == GenType.QUIET_CHECKS && (StepAttacksBB[(int)Piece.W_KNIGHT][(int)to] & (int)ci.ksq))
		{
			(moveList++).move = GlobalMembersTypes.make<MoveType.PROMOTION>(to - Delta, to, PieceType.KNIGHT);
		}
		else
		{
			()ci; // Silence a warning under MSVC
		}

		return moveList;
	  }


//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us, GenType Type>
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'moveList', so pointers on this parameter are left unchanged:
	  public static ExtMove generate_pawn_moves<Color Us, GenType Type>(Position pos, ExtMove * moveList, uint long target, CheckInfo ci)
	  {

		// Compute our parametrized parameters at compile time, named according to
		// the point of view of white side.
		Color Them = (Us == ((int)Color.WHITE) != 0 ? Color.BLACK : Color.WHITE);
		const uint GlobalMembersBitboard.long TRank8BB = (Us == ((int)Color.WHITE) != 0 ? Rank8BB : Rank1BB);
		const uint GlobalMembersBitboard.long TRank7BB = (Us == ((int)Color.WHITE) != 0 ? Rank7BB : Rank2BB);
		const uint GlobalMembersBitboard.long TRank3BB = (Us == ((int)Color.WHITE) != 0 ? Rank3BB : Rank6BB);
		Square Up = (Us == ((int)Color.WHITE) != 0 ? Square.DELTA_N : Square.DELTA_S);
		Square Right = (Us == ((int)Color.WHITE) != 0 ? Square.DELTA_NE : Square.DELTA_SW);
		Square Left = (Us == ((int)Color.WHITE) != 0 ? Square.DELTA_NW : Square.DELTA_SE);

		uint GlobalMembersBitboard.long emptySquares;

		uint GlobalMembersBitboard.long pawnsOn7 = pos.pieces(Us, PieceType.PAWN) & TRank7BB;
		uint GlobalMembersBitboard.long pawnsNotOn7 = pos.pieces(Us, PieceType.PAWN) & ~TRank7BB;

		uint GlobalMembersBitboard.long enemies = (Type == ((int)GenType.EVASIONS) != 0 ? pos.pieces(Them) & target: Type == ((int)GenType.CAPTURES) != 0 ? target : pos.pieces(Them));

		// Single and double pawn pushes, no promotions
		if (Type != GenType.CAPTURES)
		{
			emptySquares = (Type == GenType.QUIETS || Type == ((int)GenType.QUIET_CHECKS) != 0 ? target :~pos.pieces());

			uint GlobalMembersBitboard.long b1 = GlobalMembersBitboard.shift_bb<Up>(pawnsNotOn7) & emptySquares;
			uint GlobalMembersBitboard.long b2 = GlobalMembersBitboard.shift_bb<Up>(b1 & TRank3BB) & emptySquares;

			if (Type == GenType.EVASIONS) // Consider only blocking squares
			{
				b1 &= target;
				b2 &= target;
			}

			if (Type == GenType.QUIET_CHECKS)
			{
				b1 &= pos.attacks_from<PieceType.PAWN>(ci.ksq, Them);
				b2 &= pos.attacks_from<PieceType.PAWN>(ci.ksq, Them);

				// Add pawn pushes which give discovered check. This is possible only
				// if the pawn is not on the same file as the enemy king, because we
				// don't generate captures. Note that a possible discovery check
				// promotion has been already generated amongst the captures.
				if (pawnsNotOn7 & ci.dcCandidates)
				{
					uint GlobalMembersBitboard.long dc1 = GlobalMembersBitboard.shift_bb<Up>(pawnsNotOn7 & ci.dcCandidates) & emptySquares & ~GlobalMembersBitboard.file_bb(ci.ksq);
					uint GlobalMembersBitboard.long dc2 = GlobalMembersBitboard.shift_bb<Up>(dc1 & TRank3BB) & emptySquares;

					b1 |= dc1;
					b2 |= dc2;
				}
			}

			while (b1)
			{
				Square to = GlobalMembersBitboard.pop_lsb(ref b1);
				(moveList++).move = GlobalMembersTypes.make_move(to - Up, to);
			}

			while (b2)
			{
				Square to = GlobalMembersBitboard.pop_lsb(ref b2);
				(moveList++).move = GlobalMembersTypes.make_move(to - Up - Up, to);
			}
		}

		// Promotions and underpromotions
		if (pawnsOn7 && (Type != GenType.EVASIONS || (target & TRank8BB)))
		{
			if (Type == GenType.CAPTURES)
			{
				emptySquares = ~pos.pieces();
			}

			if (Type == GenType.EVASIONS)
			{
				emptySquares &= target;
			}

			uint GlobalMembersBitboard.long b1 = GlobalMembersBitboard.shift_bb<Right>(pawnsOn7) & enemies;
			uint GlobalMembersBitboard.long b2 = GlobalMembersBitboard.shift_bb<Left >(pawnsOn7) & enemies;
			uint GlobalMembersBitboard.long b3 = GlobalMembersBitboard.shift_bb<Up >(pawnsOn7) & emptySquares;

			while (b1)
			{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: moveList = make_promotions<Type, Right>(moveList, pop_lsb(&b1), ci);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
				moveList.CopyFrom(GlobalMembersMovegen.make_promotions<Type, Right>(new ExtMove(moveList), GlobalMembersBitboard.pop_lsb(ref b1), ci));
			}

			while (b2)
			{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: moveList = make_promotions<Type, Left >(moveList, pop_lsb(&b2), ci);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
				moveList.CopyFrom(GlobalMembersMovegen.make_promotions<Type, Left >(new ExtMove(moveList), GlobalMembersBitboard.pop_lsb(ref b2), ci));
			}

			while (b3)
			{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: moveList = make_promotions<Type, Up >(moveList, pop_lsb(&b3), ci);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
				moveList.CopyFrom(GlobalMembersMovegen.make_promotions<Type, Up >(new ExtMove(moveList), GlobalMembersBitboard.pop_lsb(ref b3), ci));
			}
		}

		// Standard and en-passant captures
		if (Type == GenType.CAPTURES || Type == GenType.EVASIONS || Type == GenType.NON_EVASIONS)
		{
			uint GlobalMembersBitboard.long b1 = GlobalMembersBitboard.shift_bb<Right>(pawnsNotOn7) & enemies;
			uint GlobalMembersBitboard.long b2 = GlobalMembersBitboard.shift_bb<Left >(pawnsNotOn7) & enemies;

			while (b1)
			{
				Square to = GlobalMembersBitboard.pop_lsb(ref b1);
				(moveList++).move = GlobalMembersTypes.make_move(to - Right, to);
			}

			while (b2)
			{
				Square to = GlobalMembersBitboard.pop_lsb(ref b2);
				(moveList++).move = GlobalMembersTypes.make_move(to - Left, to);
			}

			if (pos.ep_square() != Square.SQ_NONE)
			{
				Debug.Assert(GlobalMembersTypes.rank_of(pos.ep_square()) == GlobalMembersTypes.relative_rank(Us, Rank.RANK_6));

				// An en passant capture can be an evasion only if the checking piece
				// is the double pushed pawn and so is in the target. Otherwise this
				// is a discovery check and we are forced to do otherwise.
				if (Type == GenType.EVASIONS && !(target & (pos.ep_square() - Up)))
				{
					return moveList;
				}

				b1 = pawnsNotOn7 & pos.attacks_from<PieceType.PAWN>(pos.ep_square(), Them);

				Debug.Assert(b1);

				while (b1)
				{
					(moveList++).move = GlobalMembersTypes.make<MoveType.ENPASSANT>(GlobalMembersBitboard.pop_lsb(ref b1), pos.ep_square());
				}
			}
		}

		return moveList;
	  }


//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<PieceType Pt, bool Checks>
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'moveList', so pointers on this parameter are left unchanged:
	  public static FORCE_INLINE ExtMove generate_moves<PieceType Pt, bool Checks>(Position pos, ExtMove * moveList, Color us, uint long target, CheckInfo ci)
	  {

		Debug.Assert(Pt != PieceType.KING && Pt != PieceType.PAWN);

//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
		Square * pl = pos.list<Pt>(us);

		for (Square from = pl; from != Square.SQ_NONE; from = ++pl)
		{
			if (Checks)
			{
				if ((Pt == PieceType.BISHOP || Pt == PieceType.ROOK || Pt == PieceType.QUEEN) && !(PseudoAttacks[Pt][(int)from] & target & ci.checkSq[Pt]))
					continue;

				if (ci.dcCandidates && (ci.dcCandidates & (int)from))
					continue;
			}

			uint GlobalMembersBitboard.long b = pos.attacks_from<Pt>(from) & target;

			if (Checks)
			{
				b &= ci.checkSq[Pt];
			}

			while (b)
			{
				(moveList++).move = GlobalMembersTypes.make_move(from, GlobalMembersBitboard.pop_lsb(ref b));
			}
		}

		return moveList;
	  }


//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<Color Us, GenType Type>
  public static FORCE_INLINE ExtMove generate_all<Color Us, GenType Type>(Position pos, ExtMove * moveList, uint long target)
  {
	  return generate_all(pos, moveList, target, null);
  }
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'moveList', so pointers on this parameter are left unchanged:
//C++ TO C# CONVERTER NOTE: Overloaded method(s) are created above to convert the following method having default parameters:
//ORIGINAL LINE: FORCE_INLINE ExtMove* generate_all(const Position& pos, ExtMove* moveList, uint long target, const CheckInfo* ci = null)
	  public static FORCE_INLINE ExtMove generate_all<Color Us, GenType Type>(Position pos, ExtMove * moveList, uint long target, CheckInfo ci)
	  {

		bool Checks = Type == GenType.QUIET_CHECKS;

//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: moveList = generate_pawn_moves<Us, Type>(pos, moveList, target, ci);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
		moveList.CopyFrom(GlobalMembersMovegen.generate_pawn_moves<Us, Type>(pos, new ExtMove(moveList), target, ci));
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: moveList = generate_moves<KNIGHT, Checks>(pos, moveList, Us, target, ci);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
		moveList.CopyFrom(GlobalMembersMovegen.generate_moves<PieceType.KNIGHT, Checks>(pos, new ExtMove(moveList), Us, target, ci));
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: moveList = generate_moves<BISHOP, Checks>(pos, moveList, Us, target, ci);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
		moveList.CopyFrom(GlobalMembersMovegen.generate_moves<PieceType.BISHOP, Checks>(pos, new ExtMove(moveList), Us, target, ci));
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: moveList = generate_moves< ROOK, Checks>(pos, moveList, Us, target, ci);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
		moveList.CopyFrom(GlobalMembersMovegen.generate_moves< PieceType.ROOK, Checks>(pos, new ExtMove(moveList), Us, target, ci));
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: moveList = generate_moves< QUEEN, Checks>(pos, moveList, Us, target, ci);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
		moveList.CopyFrom(GlobalMembersMovegen.generate_moves< PieceType.QUEEN, Checks>(pos, new ExtMove(moveList), Us, target, ci));

		if (Type != GenType.QUIET_CHECKS && Type != GenType.EVASIONS)
		{
			Square ksq = pos.king_square(Us);
			uint GlobalMembersBitboard.long b = pos.attacks_from<PieceType.KING>(ksq) & target;
			while (b)
			{
				(moveList++).move = GlobalMembersTypes.make_move(ksq, GlobalMembersBitboard.pop_lsb(ref b));
			}
		}

		if (Type != GenType.CAPTURES && Type != GenType.EVASIONS && pos.can_castle(Us) != 0)
		{
			if (pos.is_chess960())
			{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: moveList = generate_castling<MakeCastling<Us, KING_SIDE>::right, Checks, true>(pos, moveList, Us, ci);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
				moveList.CopyFrom(GlobalMembersMovegen.generate_castling<MakeCastling<Us, CastlingSide.KING_SIDE>.right, Checks, true>(pos, new ExtMove(moveList), Us, ci));
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: moveList = generate_castling<MakeCastling<Us, QUEEN_SIDE>::right, Checks, true>(pos, moveList, Us, ci);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
				moveList.CopyFrom(GlobalMembersMovegen.generate_castling<MakeCastling<Us, CastlingSide.QUEEN_SIDE>.right, Checks, true>(pos, new ExtMove(moveList), Us, ci));
			}
			else
			{
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: moveList = generate_castling<MakeCastling<Us, KING_SIDE>::right, Checks, false>(pos, moveList, Us, ci);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
				moveList.CopyFrom(GlobalMembersMovegen.generate_castling<MakeCastling<Us, CastlingSide.KING_SIDE>.right, Checks, false>(pos, new ExtMove(moveList), Us, ci));
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created if it does not yet exist:
//ORIGINAL LINE: moveList = generate_castling<MakeCastling<Us, QUEEN_SIDE>::right, Checks, false>(pos, moveList, Us, ci);
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
				moveList.CopyFrom(GlobalMembersMovegen.generate_castling<MakeCastling<Us, CastlingSide.QUEEN_SIDE>.right, Checks, false>(pos, new ExtMove(moveList), Us, ci));
			}
		}

		return moveList;
	  }



	/// generate<CAPTURES> generates all pseudo-legal captures and queen
	/// promotions. Returns a pointer to the end of the move list.
	///
	/// generate<QUIETS> generates all pseudo-legal non-captures and
	/// underpromotions. Returns a pointer to the end of the move list.
	///
	/// generate<NON_EVASIONS> generates all pseudo-legal captures and
	/// non-captures. Returns a pointer to the end of the move list.

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<GenType Type>
	public static ExtMove generate<GenType Type>(Position pos, ExtMove moveList)
	{

	  Debug.Assert(Type == GenType.CAPTURES || Type == GenType.QUIETS || Type == GenType.NON_EVASIONS);
	  Debug.Assert(pos.checkers() == 0);

	  Color us = pos.side_to_move();

	  uint GlobalMembersBitboard.long target = Type == ((int)GenType.CAPTURES) != 0 ? pos.pieces(~us) : Type == ((int)GenType.QUIETS) != 0 ?~pos.pieces() : Type == ((int)GenType.NON_EVASIONS) != 0 ?~pos.pieces(us) : 0;

	  return us == ((int)Color.WHITE) != 0 ? GlobalMembersMovegen.generate_all<Color.WHITE, Type>(pos, moveList, target) : GlobalMembersMovegen.generate_all<Color.BLACK, Type>(pos, moveList, target);
	}

/// generate<QUIET_CHECKS> generates all pseudo-legal non-captures and knight
/// underpromotions that give check. Returns a pointer to the end of the move list.

	// Explicit template instantiations
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'moveList', so pointers on this parameter are left unchanged:
	public static ExtMove generate(Position pos, ExtMove * moveList)
	{

	  Debug.Assert(pos.checkers() == 0);

	  Color us = pos.side_to_move();
	  CheckInfo ci = new CheckInfo(pos);
	  uint GlobalMembersBitboard.long dc = ci.dcCandidates;

	  while (dc)
	  {
		 Square from = GlobalMembersBitboard.pop_lsb(ref dc);
		 PieceType pt = GlobalMembersTypes.type_of(pos.piece_on(from));

		 if (pt == PieceType.PAWN)
			 continue; // Will be generated together with direct checks

		 uint GlobalMembersBitboard.long b = pos.attacks_from(Piece(pt), from) & ~pos.pieces();

		 if (pt == PieceType.KING)
		 {
			 b &= ~PseudoAttacks[(int)PieceType.QUEEN][(int)ci.ksq];
		 }

		 while (b)
		 {
			 (moveList++).move = GlobalMembersTypes.make_move(from, GlobalMembersBitboard.pop_lsb(ref b));
		 }
	  }

//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: return us == WHITE ? generate_all<WHITE, QUIET_CHECKS>(pos, moveList, ~pos.pieces(), &ci) : generate_all<BLACK, QUIET_CHECKS>(pos, moveList, ~pos.pieces(), &ci);
	  return us == ((int)Color.WHITE) != 0 ? GlobalMembersMovegen.generate_all<Color.WHITE, GenType.QUIET_CHECKS>(pos, new ExtMove(moveList), ~pos.pieces(), ci) : GlobalMembersMovegen.generate_all<Color.BLACK, GenType.QUIET_CHECKS>(pos, new ExtMove(moveList), ~pos.pieces(), ci);
	}

/// generate<EVASIONS> generates all pseudo-legal check evasions when the side
/// to move is in check. Returns a pointer to the end of the move list.
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'moveList', so pointers on this parameter are left unchanged:
	public static ExtMove generate(Position pos, ExtMove * moveList)
	{

	  Debug.Assert(pos.checkers());

	  Color us = pos.side_to_move();
	  Square ksq = pos.king_square(us);
	  uint GlobalMembersBitboard.long sliderAttacks = 0;
	  uint GlobalMembersBitboard.long sliders = pos.checkers() & ~pos.pieces(PieceType.KNIGHT, PieceType.PAWN);

	  // Find all the squares attacked by slider checkers. We will remove them from
	  // the king evasions in order to skip known illegal moves, which avoids any
	  // useless legality checks later on.
	  while (sliders)
	  {
		  Square checksq = GlobalMembersBitboard.pop_lsb(ref sliders);
		  sliderAttacks |= LineBB[(int)checksq][(int)ksq] ^ checksq;
	  }

	  // Generate evasions for king, capture and non capture moves
	  uint GlobalMembersBitboard.long b = pos.attacks_from<PieceType.KING>(ksq) & ~pos.pieces(us) & ~sliderAttacks;
	  while (b)
	  {
		  (moveList++).move = GlobalMembersTypes.make_move(ksq, GlobalMembersBitboard.pop_lsb(ref b));
	  }

	  if (GlobalMembersBitboard.more_than_one(pos.checkers()))
	  {
		  return moveList; // Double check, only a king move can save the day
	  }

	  // Generate blocking evasions or captures of the checking piece
	  Square checksq = GlobalMembersBitboard.lsb(pos.checkers());
	  uint GlobalMembersBitboard.long target = GlobalMembersBitboard.between_bb(checksq, ksq) | (int)checksq;

//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: return us == WHITE ? generate_all<WHITE, EVASIONS>(pos, moveList, target) : generate_all<BLACK, EVASIONS>(pos, moveList, target);
	  return us == ((int)Color.WHITE) != 0 ? GlobalMembersMovegen.generate_all<Color.WHITE, GenType.EVASIONS>(pos, new ExtMove(moveList), target) : GlobalMembersMovegen.generate_all<Color.BLACK, GenType.EVASIONS>(pos, new ExtMove(moveList), target);
	}

/// generate<LEGAL> generates all the legal moves in the given position

//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'moveList', so pointers on this parameter are left unchanged:
	public static ExtMove generate(Position pos, ExtMove * moveList)
	{

	  uint GlobalMembersBitboard.long pinned = pos.pinned_pieces(pos.side_to_move());
	  Square ksq = pos.king_square(pos.side_to_move());
//C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: ExtMove* cur = moveList;
	  ExtMove * cur = new ExtMove(moveList);

//C++ TO C# CONVERTER WARNING: The following line was determined to be a copy constructor call - this should be verified and a copy constructor should be created if it does not yet exist:
//ORIGINAL LINE: moveList = pos.checkers() ? generate<EVASIONS >(pos, moveList) : generate<NON_EVASIONS>(pos, moveList);
	  moveList = pos.checkers() != 0 ? GlobalMembersMovegen.generate<GenType.EVASIONS >(pos, new ExtMove(moveList)) : GlobalMembersMovegen.generate<GenType.NON_EVASIONS>(pos, new ExtMove(moveList));
	  while (cur != moveList)
	  {
		  if ((pinned || GlobalMembersTypes.from_sq(cur.move) == ksq || GlobalMembersTypes.type_of(cur.move) == MoveType.ENPASSANT) && !pos.legal(cur.move, pinned))
		  {
			  cur.move = (--moveList).move;
		  }
		  else
		  {
			  ++cur;
		  }
	  }

	  return moveList;
	}
}

/*
  Stockfish, a UCI chess playing engine derived from Glaurung 2.1
  Copyright (C) 2004-2008 Tord Romstad (Glaurung author)
  Copyright (C) 2008-2015 Marco Costalba, Joona Kiiski, Tord Romstad

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



//C++ TO C# CONVERTER NOTE: C# does not allow anonymous namespaces:
//namespace

//C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
//ORIGINAL LINE: template<CastlingRight Cr, bool Checks, bool Chess960>
