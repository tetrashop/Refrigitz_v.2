public class MovePicker
{
//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public MovePicker(Position p, Move ttm, Depth d, Stats<false, Value> h, Move cm, Move fm, Search.Stack s)
	{
		this.pos = p;
		this.history = h;
		this.depth = d;
    
	  Debug.Assert(d > Depth.DEPTH_ZERO);
    
	  cur = end = moves;
	  endBadCaptures = moves + GlobalMembersTypes.MAX_MOVES - 1;
	  countermoves = cm;
	  followupmoves = fm;
	  ss = s;
    
	  if (pos.checkers())
	  {
		  stage = Stages.EVASION;
	  }
    
	  else
	  {
		  stage = Stages.MAIN_SEARCH;
	  }
    
	  ttMove = (((int)ttm) != 0 && pos.pseudo_legal(ttm) ? ttm : Move.MOVE_NONE);
	  end += (ttMove != Move.MOVE_NONE);
	}

	public MovePicker(Position p, Move ttm, Depth d, Stats<false, Value> h, Square s)
	{
		this.pos = p;
		this.history = h;
		this.cur = moves;
		this.end = moves;
    
	  Debug.Assert(d <= Depth.DEPTH_ZERO);
    
	  if (pos.checkers())
	  {
		  stage = Stages.EVASION;
	  }
    
	  else if (d > Depth.DEPTH_QS_NO_CHECKS)
	  {
		  stage = Stages.QSEARCH_0;
	  }
    
	  else if (d > Depth.DEPTH_QS_RECAPTURES)
	  {
		  stage = Stages.QSEARCH_1;
	  }
    
	  else
	  {
		  stage = Stages.RECAPTURE;
		  recaptureSquare = s;
		  ttm = Move.MOVE_NONE;
	  }
    
	  ttMove = (((int)ttm) != 0 && pos.pseudo_legal(ttm) ? ttm : Move.MOVE_NONE);
	  end += (ttMove != Move.MOVE_NONE);
	}

	public MovePicker(Position p, Move ttm, Stats<false, Value> h, PieceType pt)
	{
		this.pos = p;
		this.history = h;
		this.cur = moves;
		this.end = moves;
    
	  Debug.Assert(!pos.checkers());
    
	  stage = Stages.PROBCUT;
    
	  // In ProbCut we generate only captures that are better than the parent's
	  // captured piece.
	  captureThreshold = GlobalMembersPosition.PieceValue[(int)Phase.MG, (int)pt];
	  ttMove = (((int)ttm) != 0 && pos.pseudo_legal(ttm) ? ttm : Move.MOVE_NONE);
    
	  if (ttMove && (!pos.capture(ttMove) || pos.see(ttMove) <= captureThreshold))
	  {
		  ttMove = Move.MOVE_NONE;
	  }
    
	  end += (ttMove != Move.MOVE_NONE);
	}

	public void generate_next_stage()
	{
    
	  cur = moves;
    
	  switch (++stage)
	  {
    
	  case Stages.CAPTURES_S1:
	case Stages.CAPTURES_S3:
	case Stages.CAPTURES_S4:
	case Stages.CAPTURES_S5:
	case Stages.CAPTURES_S6:
		  end = GlobalMembersMovegen.generate<GenType.CAPTURES>(pos, moves);
		  score<GenType.CAPTURES>();
		  return;
    
	  case Stages.KILLERS_S1:
		  cur = killers;
		  end = cur + 2;
    
		  killers[0].move = ss.killers[0];
		  killers[1].move = ss.killers[1];
		  killers[2].move = killers[3].move = Move.MOVE_NONE;
		  killers[4].move = killers[5].move = Move.MOVE_NONE;
    
		  // Please note that following code is racy and could yield to rare (less
		  // than 1 out of a million) duplicated entries in SMP case. This is harmless.
    
		  // Be sure countermoves are different from killers
		  for (int i = 0; i < 2; ++i)
		  {
			  if (countermoves[i] != (cur + 0).move && countermoves[i] != (cur + 1).move)
			  {
				  (end++).move = countermoves[i];
			  }
		  }
    
		  // Be sure followupmoves are different from killers and countermoves
		  for (int i = 0; i < 2; ++i)
		  {
			  if (followupmoves[i] != (cur + 0).move && followupmoves[i] != (cur + 1).move && followupmoves[i] != (cur + 2).move && followupmoves[i] != (cur + 3).move)
			  {
				  (end++).move = followupmoves[i];
			  }
		  }
		  return;
    
	  case Stages.QUIETS_1_S1:
		  endQuiets = end = GlobalMembersMovegen.generate<GenType.QUIETS>(pos, moves);
		  score<GenType.QUIETS>();
		  end = std.partition(cur, end, GlobalMembersMovepick.has_positive_value);
		  GlobalMembersMovepick.insertion_sort(cur, end);
		  return;
    
	  case Stages.QUIETS_2_S1:
		  cur = end;
		  end = endQuiets;
		  if (depth >= 3 * Depth.ONE_PLY)
		  {
			  GlobalMembersMovepick.insertion_sort(cur, end);
		  }
		  return;
    
	  case Stages.BAD_CAPTURES_S1:
		  // Just pick them in reverse order to get MVV/LVA ordering
		  cur = moves + GlobalMembersTypes.MAX_MOVES - 1;
		  end = endBadCaptures;
		  return;
    
	  case Stages.EVASIONS_S2:
		  end = GlobalMembersMovegen.generate<GenType.EVASIONS>(pos, moves);
		  if (end > moves + 1)
		  {
			  score<GenType.EVASIONS>();
		  }
		  return;
    
	  case Stages.QUIET_CHECKS_S3:
		  end = GlobalMembersMovegen.generate<GenType.QUIET_CHECKS>(pos, moves);
		  return;
    
	  case Stages.EVASION:
	case Stages.QSEARCH_0:
	case Stages.QSEARCH_1:
	case Stages.PROBCUT:
	case Stages.RECAPTURE:
		  stage = Stages.STOP;
		  /* Fall through */
    
	//C++ TO C# CONVERTER TODO TASK: C# does not allow fall-through from a non-empty 'case':
	  case Stages.STOP:
		  end = cur + 1; // Avoid another next_phase() call
		  return;
    
	  default:
		  Debug.Assert(false);
		  break;
	  }
	}

	public MovePicker(Position p, Move ttm, Depth d, Stats<false, Value> h, Move cm, Move fm, Search.Stack s)
	{
		this.pos = p;
		this.history = h;
		this.depth = d;
    
	  Debug.Assert(d > Depth.DEPTH_ZERO);
    
	  cur = end = moves;
	  endBadCaptures = moves + GlobalMembersTypes.MAX_MOVES - 1;
	  countermoves = cm;
	  followupmoves = fm;
	  ss = s;
    
	  if (pos.checkers())
	  {
		  stage = Stages.EVASION;
	  }
    
	  else
	  {
		  stage = Stages.MAIN_SEARCH;
	  }
    
	  ttMove = (((int)ttm) != 0 && pos.pseudo_legal(ttm) ? ttm : Move.MOVE_NONE);
	  end += (ttMove != Move.MOVE_NONE);
	}

	public MovePicker(Position p, Move ttm, Depth d, Stats<false, Value> h, Square s)
	{
		this.pos = p;
		this.history = h;
		this.cur = moves;
		this.end = moves;
    
	  Debug.Assert(d <= Depth.DEPTH_ZERO);
    
	  if (pos.checkers())
	  {
		  stage = Stages.EVASION;
	  }
    
	  else if (d > Depth.DEPTH_QS_NO_CHECKS)
	  {
		  stage = Stages.QSEARCH_0;
	  }
    
	  else if (d > Depth.DEPTH_QS_RECAPTURES)
	  {
		  stage = Stages.QSEARCH_1;
	  }
    
	  else
	  {
		  stage = Stages.RECAPTURE;
		  recaptureSquare = s;
		  ttm = Move.MOVE_NONE;
	  }
    
	  ttMove = (((int)ttm) != 0 && pos.pseudo_legal(ttm) ? ttm : Move.MOVE_NONE);
	  end += (ttMove != Move.MOVE_NONE);
	}

	public MovePicker(Position p, Move ttm, Stats<false, Value> h, PieceType pt)
	{
		this.pos = p;
		this.history = h;
		this.cur = moves;
		this.end = moves;
    
	  Debug.Assert(!pos.checkers());
    
	  stage = Stages.PROBCUT;
    
	  // In ProbCut we generate only captures that are better than the parent's
	  // captured piece.
	  captureThreshold = GlobalMembersPosition.PieceValue[(int)Phase.MG, (int)pt];
	  ttMove = (((int)ttm) != 0 && pos.pseudo_legal(ttm) ? ttm : Move.MOVE_NONE);
    
	  if (ttMove && (!pos.capture(ttMove) || pos.see(ttMove) <= captureThreshold))
	  {
		  ttMove = Move.MOVE_NONE;
	  }
    
	  end += (ttMove != Move.MOVE_NONE);
	}

	public void generate_next_stage()
	{
    
	  cur = moves;
    
	  switch (++stage)
	  {
    
	  case Stages.CAPTURES_S1:
	case Stages.CAPTURES_S3:
	case Stages.CAPTURES_S4:
	case Stages.CAPTURES_S5:
	case Stages.CAPTURES_S6:
		  end = GlobalMembersMovegen.generate<GenType.CAPTURES>(pos, moves);
		  score<GenType.CAPTURES>();
		  return;
    
	  case Stages.KILLERS_S1:
		  cur = killers;
		  end = cur + 2;
    
		  killers[0].move = ss.killers[0];
		  killers[1].move = ss.killers[1];
		  killers[2].move = killers[3].move = Move.MOVE_NONE;
		  killers[4].move = killers[5].move = Move.MOVE_NONE;
    
		  // Please note that following code is racy and could yield to rare (less
		  // than 1 out of a million) duplicated entries in SMP case. This is harmless.
    
		  // Be sure countermoves are different from killers
		  for (int i = 0; i < 2; ++i)
		  {
			  if (countermoves[i] != (cur + 0).move && countermoves[i] != (cur + 1).move)
			  {
				  (end++).move = countermoves[i];
			  }
		  }
    
		  // Be sure followupmoves are different from killers and countermoves
		  for (int i = 0; i < 2; ++i)
		  {
			  if (followupmoves[i] != (cur + 0).move && followupmoves[i] != (cur + 1).move && followupmoves[i] != (cur + 2).move && followupmoves[i] != (cur + 3).move)
			  {
				  (end++).move = followupmoves[i];
			  }
		  }
		  return;
    
	  case Stages.QUIETS_1_S1:
		  endQuiets = end = GlobalMembersMovegen.generate<GenType.QUIETS>(pos, moves);
		  score<GenType.QUIETS>();
		  end = std.partition(cur, end, GlobalMembersMovepick.has_positive_value);
		  GlobalMembersMovepick.insertion_sort(cur, end);
		  return;
    
	  case Stages.QUIETS_2_S1:
		  cur = end;
		  end = endQuiets;
		  if (depth >= 3 * Depth.ONE_PLY)
		  {
			  GlobalMembersMovepick.insertion_sort(cur, end);
		  }
		  return;
    
	  case Stages.BAD_CAPTURES_S1:
		  // Just pick them in reverse order to get MVV/LVA ordering
		  cur = moves + GlobalMembersTypes.MAX_MOVES - 1;
		  end = endBadCaptures;
		  return;
    
	  case Stages.EVASIONS_S2:
		  end = GlobalMembersMovegen.generate<GenType.EVASIONS>(pos, moves);
		  if (end > moves + 1)
		  {
			  score<GenType.EVASIONS>();
		  }
		  return;
    
	  case Stages.QUIET_CHECKS_S3:
		  end = GlobalMembersMovegen.generate<GenType.QUIET_CHECKS>(pos, moves);
		  return;
    
	  case Stages.EVASION:
	case Stages.QSEARCH_0:
	case Stages.QSEARCH_1:
	case Stages.PROBCUT:
	case Stages.RECAPTURE:
		  stage = Stages.STOP;
		  /* Fall through */
    
	//C++ TO C# CONVERTER TODO TASK: C# does not allow fall-through from a non-empty 'case':
	  case Stages.STOP:
		  end = cur + 1; // Avoid another next_phase() call
		  return;
    
	  default:
		  Debug.Assert(false);
		  break;
	  }
	}

	public MovePicker(Position p, Move ttm, Depth d, Stats<false, Value> h, Move cm, Move fm, Search.Stack s)
	{
		this.pos = p;
		this.history = h;
		this.depth = d;
    
	  Debug.Assert(d > Depth.DEPTH_ZERO);
    
	  cur = end = moves;
	  endBadCaptures = moves + GlobalMembersTypes.MAX_MOVES - 1;
	  countermoves = cm;
	  followupmoves = fm;
	  ss = s;
    
	  if (pos.checkers())
	  {
		  stage = Stages.EVASION;
	  }
    
	  else
	  {
		  stage = Stages.MAIN_SEARCH;
	  }
    
	  ttMove = (((int)ttm) != 0 && pos.pseudo_legal(ttm) ? ttm : Move.MOVE_NONE);
	  end += (ttMove != Move.MOVE_NONE);
	}

	public MovePicker(Position p, Move ttm, Depth d, Stats<false, Value> h, Square s)
	{
		this.pos = p;
		this.history = h;
		this.cur = moves;
		this.end = moves;
    
	  Debug.Assert(d <= Depth.DEPTH_ZERO);
    
	  if (pos.checkers())
	  {
		  stage = Stages.EVASION;
	  }
    
	  else if (d > Depth.DEPTH_QS_NO_CHECKS)
	  {
		  stage = Stages.QSEARCH_0;
	  }
    
	  else if (d > Depth.DEPTH_QS_RECAPTURES)
	  {
		  stage = Stages.QSEARCH_1;
	  }
    
	  else
	  {
		  stage = Stages.RECAPTURE;
		  recaptureSquare = s;
		  ttm = Move.MOVE_NONE;
	  }
    
	  ttMove = (((int)ttm) != 0 && pos.pseudo_legal(ttm) ? ttm : Move.MOVE_NONE);
	  end += (ttMove != Move.MOVE_NONE);
	}

	public MovePicker(Position p, Move ttm, Stats<false, Value> h, PieceType pt)
	{
		this.pos = p;
		this.history = h;
		this.cur = moves;
		this.end = moves;
    
	  Debug.Assert(!pos.checkers());
    
	  stage = Stages.PROBCUT;
    
	  // In ProbCut we generate only captures that are better than the parent's
	  // captured piece.
	  captureThreshold = GlobalMembersPosition.PieceValue[(int)Phase.MG, (int)pt];
	  ttMove = (((int)ttm) != 0 && pos.pseudo_legal(ttm) ? ttm : Move.MOVE_NONE);
    
	  if (ttMove && (!pos.capture(ttMove) || pos.see(ttMove) <= captureThreshold))
	  {
		  ttMove = Move.MOVE_NONE;
	  }
    
	  end += (ttMove != Move.MOVE_NONE);
	}

	public void generate_next_stage()
	{
    
	  cur = moves;
    
	  switch (++stage)
	  {
    
	  case Stages.CAPTURES_S1:
	case Stages.CAPTURES_S3:
	case Stages.CAPTURES_S4:
	case Stages.CAPTURES_S5:
	case Stages.CAPTURES_S6:
		  end = GlobalMembersMovegen.generate<GenType.CAPTURES>(pos, moves);
		  score<GenType.CAPTURES>();
		  return;
    
	  case Stages.KILLERS_S1:
		  cur = killers;
		  end = cur + 2;
    
		  killers[0].move = ss.killers[0];
		  killers[1].move = ss.killers[1];
		  killers[2].move = killers[3].move = Move.MOVE_NONE;
		  killers[4].move = killers[5].move = Move.MOVE_NONE;
    
		  // Please note that following code is racy and could yield to rare (less
		  // than 1 out of a million) duplicated entries in SMP case. This is harmless.
    
		  // Be sure countermoves are different from killers
		  for (int i = 0; i < 2; ++i)
		  {
			  if (countermoves[i] != (cur + 0).move && countermoves[i] != (cur + 1).move)
			  {
				  (end++).move = countermoves[i];
			  }
		  }
    
		  // Be sure followupmoves are different from killers and countermoves
		  for (int i = 0; i < 2; ++i)
		  {
			  if (followupmoves[i] != (cur + 0).move && followupmoves[i] != (cur + 1).move && followupmoves[i] != (cur + 2).move && followupmoves[i] != (cur + 3).move)
			  {
				  (end++).move = followupmoves[i];
			  }
		  }
		  return;
    
	  case Stages.QUIETS_1_S1:
		  endQuiets = end = GlobalMembersMovegen.generate<GenType.QUIETS>(pos, moves);
		  score<GenType.QUIETS>();
		  end = std.partition(cur, end, GlobalMembersMovepick.has_positive_value);
		  GlobalMembersMovepick.insertion_sort(cur, end);
		  return;
    
	  case Stages.QUIETS_2_S1:
		  cur = end;
		  end = endQuiets;
		  if (depth >= 3 * Depth.ONE_PLY)
		  {
			  GlobalMembersMovepick.insertion_sort(cur, end);
		  }
		  return;
    
	  case Stages.BAD_CAPTURES_S1:
		  // Just pick them in reverse order to get MVV/LVA ordering
		  cur = moves + GlobalMembersTypes.MAX_MOVES - 1;
		  end = endBadCaptures;
		  return;
    
	  case Stages.EVASIONS_S2:
		  end = GlobalMembersMovegen.generate<GenType.EVASIONS>(pos, moves);
		  if (end > moves + 1)
		  {
			  score<GenType.EVASIONS>();
		  }
		  return;
    
	  case Stages.QUIET_CHECKS_S3:
		  end = GlobalMembersMovegen.generate<GenType.QUIET_CHECKS>(pos, moves);
		  return;
    
	  case Stages.EVASION:
	case Stages.QSEARCH_0:
	case Stages.QSEARCH_1:
	case Stages.PROBCUT:
	case Stages.RECAPTURE:
		  stage = Stages.STOP;
		  /* Fall through */
    
	//C++ TO C# CONVERTER TODO TASK: C# does not allow fall-through from a non-empty 'case':
	  case Stages.STOP:
		  end = cur + 1; // Avoid another next_phase() call
		  return;
    
	  default:
		  Debug.Assert(false);
		  break;
	  }
	}
}