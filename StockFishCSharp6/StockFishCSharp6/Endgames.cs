public class Endgames
{
//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public Endgames()
	{
    
	  add<EndgameType.KPK>("KPK");
	  add<EndgameType.KNNK>("KNNK");
	  add<EndgameType.KBNK>("KBNK");
	  add<EndgameType.KRKP>("KRKP");
	  add<EndgameType.KRKB>("KRKB");
	  add<EndgameType.KRKN>("KRKN");
	  add<EndgameType.KQKP>("KQKP");
	  add<EndgameType.KQKR>("KQKR");
    
	  add<EndgameType.KNPK>("KNPK");
	  add<EndgameType.KNPKB>("KNPKB");
	  add<EndgameType.KRPKR>("KRPKR");
	  add<EndgameType.KRPKB>("KRPKB");
	  add<EndgameType.KBPKB>("KBPKB");
	  add<EndgameType.KBPKN>("KBPKN");
	  add<EndgameType.KBPPKB>("KBPPKB");
	  add<EndgameType.KRPPKRP>("KRPPKRP");
	}

	public void Dispose()
	{
    
	  for_each(m1.begin(), m1.end(), GlobalMembersEndgame.delete_endgame<M1>);
	  for_each(m2.begin(), m2.end(), GlobalMembersEndgame.delete_endgame<M2>);
	}

	public void add<EndgameType E>(string code)
	{
    
	  map((Endgame<E>*)0)[GlobalMembersEndgame.key(code, Color.WHITE)] = new Endgame<E>(Color.WHITE);
	  map((Endgame<E>*)0)[GlobalMembersEndgame.key(code, Color.BLACK)] = new Endgame<E>(Color.BLACK);
	}

	public Endgames()
	{
    
	  add<EndgameType.KPK>("KPK");
	  add<EndgameType.KNNK>("KNNK");
	  add<EndgameType.KBNK>("KBNK");
	  add<EndgameType.KRKP>("KRKP");
	  add<EndgameType.KRKB>("KRKB");
	  add<EndgameType.KRKN>("KRKN");
	  add<EndgameType.KQKP>("KQKP");
	  add<EndgameType.KQKR>("KQKR");
    
	  add<EndgameType.KNPK>("KNPK");
	  add<EndgameType.KNPKB>("KNPKB");
	  add<EndgameType.KRPKR>("KRPKR");
	  add<EndgameType.KRPKB>("KRPKB");
	  add<EndgameType.KBPKB>("KBPKB");
	  add<EndgameType.KBPKN>("KBPKN");
	  add<EndgameType.KBPPKB>("KBPPKB");
	  add<EndgameType.KRPPKRP>("KRPPKRP");
	}

	public void Dispose()
	{
    
	  for_each(m1.begin(), m1.end(), GlobalMembersEndgame.delete_endgame<M1>);
	  for_each(m2.begin(), m2.end(), GlobalMembersEndgame.delete_endgame<M2>);
	}

	public void add<EndgameType E>(string code)
	{
    
	  map((Endgame<E>*)0)[GlobalMembersEndgame.key(code, Color.WHITE)] = new Endgame<E>(Color.WHITE);
	  map((Endgame<E>*)0)[GlobalMembersEndgame.key(code, Color.BLACK)] = new Endgame<E>(Color.BLACK);
	}

	public Endgames()
	{
    
	  add<EndgameType.KPK>("KPK");
	  add<EndgameType.KNNK>("KNNK");
	  add<EndgameType.KBNK>("KBNK");
	  add<EndgameType.KRKP>("KRKP");
	  add<EndgameType.KRKB>("KRKB");
	  add<EndgameType.KRKN>("KRKN");
	  add<EndgameType.KQKP>("KQKP");
	  add<EndgameType.KQKR>("KQKR");
    
	  add<EndgameType.KNPK>("KNPK");
	  add<EndgameType.KNPKB>("KNPKB");
	  add<EndgameType.KRPKR>("KRPKR");
	  add<EndgameType.KRPKB>("KRPKB");
	  add<EndgameType.KBPKB>("KBPKB");
	  add<EndgameType.KBPKN>("KBPKN");
	  add<EndgameType.KBPPKB>("KBPPKB");
	  add<EndgameType.KRPPKRP>("KRPPKRP");
	}

	public void Dispose()
	{
    
	  for_each(m1.begin(), m1.end(), GlobalMembersEndgame.delete_endgame<M1>);
	  for_each(m2.begin(), m2.end(), GlobalMembersEndgame.delete_endgame<M2>);
	}

	public void add<EndgameType E>(string code)
	{
    
	  map((Endgame<E>*)0)[GlobalMembersEndgame.key(code, Color.WHITE)] = new Endgame<E>(Color.WHITE);
	  map((Endgame<E>*)0)[GlobalMembersEndgame.key(code, Color.BLACK)] = new Endgame<E>(Color.BLACK);
	}

	public Endgames()
	{
    
	  add<EndgameType.KPK>("KPK");
	  add<EndgameType.KNNK>("KNNK");
	  add<EndgameType.KBNK>("KBNK");
	  add<EndgameType.KRKP>("KRKP");
	  add<EndgameType.KRKB>("KRKB");
	  add<EndgameType.KRKN>("KRKN");
	  add<EndgameType.KQKP>("KQKP");
	  add<EndgameType.KQKR>("KQKR");
    
	  add<EndgameType.KNPK>("KNPK");
	  add<EndgameType.KNPKB>("KNPKB");
	  add<EndgameType.KRPKR>("KRPKR");
	  add<EndgameType.KRPKB>("KRPKB");
	  add<EndgameType.KBPKB>("KBPKB");
	  add<EndgameType.KBPKN>("KBPKN");
	  add<EndgameType.KBPPKB>("KBPPKB");
	  add<EndgameType.KRPPKRP>("KRPPKRP");
	}

	public void Dispose()
	{
    
	  for_each(m1.begin(), m1.end(), GlobalMembersEndgame.delete_endgame<M1>);
	  for_each(m2.begin(), m2.end(), GlobalMembersEndgame.delete_endgame<M2>);
	}

	public void add<EndgameType E>(string code)
	{
    
	  map((Endgame<E>*)0)[GlobalMembersEndgame.key(code, Color.WHITE)] = new Endgame<E>(Color.WHITE);
	  map((Endgame<E>*)0)[GlobalMembersEndgame.key(code, Color.BLACK)] = new Endgame<E>(Color.BLACK);
	}
}