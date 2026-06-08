public class Bitbases
{
//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public bool probe(Square wksq, Square wpsq, Square bksq, Color us)
	{
    
	  Debug.Assert(GlobalMembersTypes.file_of(wpsq) <= File.FILE_D);
    
	  uint idx = GlobalMembersBitbase.index(us, bksq, wksq, wpsq);
	  return KPKBitbase[idx / 32] & (1 << (idx & 0x1F));
	}

	public void init()
	{
    
	  uint idx;
	  uint repeat = 1;
	  List<KPKPosition> db = new List<KPKPosition>();
	  db.Capacity = MAX_INDEX;
    
	  // Initialize db with known win / draw positions
	  for (idx = 0; idx < MAX_INDEX; ++idx)
	  {
		  db.Add(new KPKPosition(idx));
	  }
    
	  // Iterate through the positions until none of the unknown positions can be
	  // changed to either wins or draws (15 cycles needed).
	  while (repeat != 0)
	  {
		  for (repeat = idx = 0; idx < MAX_INDEX; ++idx)
		  {
			  repeat |= (db[idx] == Result.UNKNOWN && db[idx].classify(db) != Result.UNKNOWN);
		  }
	  }
    
	  // Map 32 results into one KPKBitbase[] entry
	  for (idx = 0; idx < MAX_INDEX; ++idx)
	  {
		  if (db[idx] == Result.WIN)
		  {
			  KPKBitbase[idx / 32] |= 1 << (idx & 0x1F);
		  }
	  }
	}

	public bool probe(Square wksq, Square wpsq, Square bksq, Color us)
	{
    
	  Debug.Assert(GlobalMembersTypes.file_of(wpsq) <= File.FILE_D);
    
	  uint idx = GlobalMembersBitbase.index(us, bksq, wksq, wpsq);
	  return KPKBitbase[idx / 32] & (1 << (idx & 0x1F));
	}

	public void init()
	{
    
	  uint idx;
	  uint repeat = 1;
	  List<KPKPosition> db = new List<KPKPosition>();
	  db.Capacity = MAX_INDEX;
    
	  // Initialize db with known win / draw positions
	  for (idx = 0; idx < MAX_INDEX; ++idx)
	  {
		  db.Add(new KPKPosition(idx));
	  }
    
	  // Iterate through the positions until none of the unknown positions can be
	  // changed to either wins or draws (15 cycles needed).
	  while (repeat != 0)
	  {
		  for (repeat = idx = 0; idx < MAX_INDEX; ++idx)
		  {
			  repeat |= (db[idx] == Result.UNKNOWN && db[idx].classify(db) != Result.UNKNOWN);
		  }
	  }
    
	  // Map 32 results into one KPKBitbase[] entry
	  for (idx = 0; idx < MAX_INDEX; ++idx)
	  {
		  if (db[idx] == Result.WIN)
		  {
			  KPKBitbase[idx / 32] |= 1 << (idx & 0x1F);
		  }
	  }
	}

	public bool probe(Square wksq, Square wpsq, Square bksq, Color us)
	{
    
	  Debug.Assert(GlobalMembersTypes.file_of(wpsq) <= File.FILE_D);
    
	  uint idx = GlobalMembersBitbase.index(us, bksq, wksq, wpsq);
	  return KPKBitbase[idx / 32] & (1 << (idx & 0x1F));
	}

	public void init()
	{
    
	  uint idx;
	  uint repeat = 1;
	  List<KPKPosition> db = new List<KPKPosition>();
	  db.Capacity = MAX_INDEX;
    
	  // Initialize db with known win / draw positions
	  for (idx = 0; idx < MAX_INDEX; ++idx)
	  {
		  db.Add(new KPKPosition(idx));
	  }
    
	  // Iterate through the positions until none of the unknown positions can be
	  // changed to either wins or draws (15 cycles needed).
	  while (repeat != 0)
	  {
		  for (repeat = idx = 0; idx < MAX_INDEX; ++idx)
		  {
			  repeat |= (db[idx] == Result.UNKNOWN && db[idx].classify(db) != Result.UNKNOWN);
		  }
	  }
    
	  // Map 32 results into one KPKBitbase[] entry
	  for (idx = 0; idx < MAX_INDEX; ++idx)
	  {
		  if (db[idx] == Result.WIN)
		  {
			  KPKBitbase[idx / 32] |= 1 << (idx & 0x1F);
		  }
	  }
	}
}