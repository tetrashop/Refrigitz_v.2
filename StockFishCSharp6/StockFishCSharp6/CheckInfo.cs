public class CheckInfo
{
//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public CheckInfo(Position pos)
	{
    
	  Color them = ~pos.side_to_move();
	  ksq = pos.king_square(them);
    
	  pinned = pos.pinned_pieces(pos.side_to_move());
	  dcCandidates = pos.discovered_check_candidates();
    
	  checkSq[(int)PieceType.PAWN] = pos.attacks_from<PieceType.PAWN>(ksq, them);
	  checkSq[(int)PieceType.KNIGHT] = pos.attacks_from<PieceType.KNIGHT>(ksq);
	  checkSq[(int)PieceType.BISHOP] = pos.attacks_from<PieceType.BISHOP>(ksq);
	  checkSq[(int)PieceType.ROOK] = pos.attacks_from<PieceType.ROOK>(ksq);
	  checkSq[(int)PieceType.QUEEN] = checkSq[(int)PieceType.BISHOP] | checkSq[(int)PieceType.ROOK];
	  checkSq[(int)PieceType.KING] = 0;
	}

	public CheckInfo(Position pos)
	{
    
	  Color them = ~pos.side_to_move();
	  ksq = pos.king_square(them);
    
	  pinned = pos.pinned_pieces(pos.side_to_move());
	  dcCandidates = pos.discovered_check_candidates();
    
	  checkSq[(int)PieceType.PAWN] = pos.attacks_from<PieceType.PAWN>(ksq, them);
	  checkSq[(int)PieceType.KNIGHT] = pos.attacks_from<PieceType.KNIGHT>(ksq);
	  checkSq[(int)PieceType.BISHOP] = pos.attacks_from<PieceType.BISHOP>(ksq);
	  checkSq[(int)PieceType.ROOK] = pos.attacks_from<PieceType.ROOK>(ksq);
	  checkSq[(int)PieceType.QUEEN] = checkSq[(int)PieceType.BISHOP] | checkSq[(int)PieceType.ROOK];
	  checkSq[(int)PieceType.KING] = 0;
	}

	public CheckInfo(Position pos)
	{
    
	  Color them = ~pos.side_to_move();
	  ksq = pos.king_square(them);
    
	  pinned = pos.pinned_pieces(pos.side_to_move());
	  dcCandidates = pos.discovered_check_candidates();
    
	  checkSq[(int)PieceType.PAWN] = pos.attacks_from<PieceType.PAWN>(ksq, them);
	  checkSq[(int)PieceType.KNIGHT] = pos.attacks_from<PieceType.KNIGHT>(ksq);
	  checkSq[(int)PieceType.BISHOP] = pos.attacks_from<PieceType.BISHOP>(ksq);
	  checkSq[(int)PieceType.ROOK] = pos.attacks_from<PieceType.ROOK>(ksq);
	  checkSq[(int)PieceType.QUEEN] = checkSq[(int)PieceType.BISHOP] | checkSq[(int)PieceType.ROOK];
	  checkSq[(int)PieceType.KING] = 0;
	}
}