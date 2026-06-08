public class MainThread
{
//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public void idle_loop()
	{
    
	  while (!exit)
	  {
		  mutex.@lock();
    
		  thinking = false;
    
		  while (!thinking && !exit)
		  {
			  Threads.sleepCondition.notify_one(); // Wake up the UI thread if needed
			  sleepCondition.wait(mutex);
		  }
    
		  mutex.unlock();
    
		  if (!exit)
		  {
			  searching = true;
    
			  GlobalMembersSearch.think();
    
			  Debug.Assert(searching);
    
			  searching = false;
		  }
	  }
	}

	public void idle_loop()
	{
    
	  while (!exit)
	  {
		  mutex.@lock();
    
		  thinking = false;
    
		  while (!thinking && !exit)
		  {
			  Threads.sleepCondition.notify_one(); // Wake up the UI thread if needed
			  sleepCondition.wait(mutex);
		  }
    
		  mutex.unlock();
    
		  if (!exit)
		  {
			  searching = true;
    
			  GlobalMembersSearch.think();
    
			  Debug.Assert(searching);
    
			  searching = false;
		  }
	  }
	}

	public void idle_loop()
	{
    
	  while (!exit)
	  {
		  mutex.@lock();
    
		  thinking = false;
    
		  while (!thinking && !exit)
		  {
			  Threads.sleepCondition.notify_one(); // Wake up the UI thread if needed
			  sleepCondition.wait(mutex);
		  }
    
		  mutex.unlock();
    
		  if (!exit)
		  {
			  searching = true;
    
			  GlobalMembersSearch.think();
    
			  Debug.Assert(searching);
    
			  searching = false;
		  }
	  }
	}
}