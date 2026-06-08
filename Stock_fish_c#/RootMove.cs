public class RootMove
{
//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public bool extract_ponder_from_tt(Position pos)
	{
    
		StateInfo st = new StateInfo();
		bool ttHit;
    
		Debug.Assert(pv.size() == 1);
    
		if (!pv[0])
		{
			return false;
		}
    
		pos.do_move(pv[0], st, pos.gives_check(pv[0]));
		TTEntry tte = GlobalMembersTt.TT.probe(pos.key(), ref ttHit);
    
		if (ttHit)
		{
			Move m = tte.move(); // Local copy to be SMP safe
			if (new MoveList<GenType.LEGAL>(pos).contains(m))
			{
				pv.push_back(m);
			}
		}
    
		pos.undo_move(pv[0]);
		return pv.size() > 1;
	}
}