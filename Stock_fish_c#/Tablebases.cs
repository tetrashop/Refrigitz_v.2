public class Tablebases
{
//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public void filter_root_moves(Position pos, List<RootMove> rootMoves)
	{
    
		RootInTB = false;
		UseRule50 = GlobalMembersUcioption.Options["Syzygy50MoveRule"];
		ProbeDepth = GlobalMembersUcioption.Options["SyzygyProbeDepth"] * Depth.ONE_PLY;
		Cardinality = GlobalMembersUcioption.Options["SyzygyProbeLimit"];
    
		// Skip TB probing when no TB found: !TBLargest -> !TB::Cardinality
		if (Cardinality > MaxCardinality)
		{
			Cardinality = MaxCardinality;
			ProbeDepth = Depth.DEPTH_ZERO;
		}
    
		if (Cardinality < GlobalMembersBenchmark.popcount(pos.pieces()) || pos.can_castle(CastlingRight.ANY_CASTLING) != 0)
			return;
    
		// If the current root position is in the tablebases, then RootMoves
		// contains only moves that preserve the draw or the win.
		RootInTB = root_probe(pos, rootMoves, TB.Score);
    
		if (RootInTB)
		{
			Cardinality = 0; // Do not probe tablebases during the search
		}
    
		else // If DTZ tables are missing, use WDL tables as a fallback
		{
			// Filter out moves that do not preserve the draw or the win.
			RootInTB = root_probe_wdl(pos, rootMoves, TB.Score);
    
			// Only probe during search if winning
			if (RootInTB && TB.Score <= Value.VALUE_DRAW)
			{
				Cardinality = 0;
			}
		}
    
		if (RootInTB && !UseRule50)
		{
			TB.Score = TB.Score > ((int)Value.VALUE_DRAW) != 0 ? Value.VALUE_MATE - MAX_PLY - 1 : TB.Score < ((int)Value.VALUE_DRAW) != 0 ? - Value.VALUE_MATE + MAX_PLY + 1 : Value.VALUE_DRAW;
		}
	}
}