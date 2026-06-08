using System;
using System.IO;
using System.Threading;
namespace Refrigtz
{
    [Serializable]
    class Syncronization
    {
        //Error Handling.
        static void Log(Exception ex)
        {
            try
            {
                Object a = new Object();
                lock (a)
                {
                    string stackTrace = ex.ToString();
                    File.AppendAllText(FormRefrigtz.Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
                }
            }
            catch (Exception t) { Log(t); }
        }
        //
        bool LastState = false;
        public Syncronization(Thread t, int a)
        {
            try
            {
                if (a == 1)
                {
                    LastState = Mutex(t);
                }
                else if (a == 2)
                {
                    LastState = Event(t);
                }
                else if (a == 3)
                {
                    LastState = Semaphore(t);
                }
            }
            catch (Exception tt)
            {
                Log(tt);
            }
        }
        bool Mutex(Thread t)
        {
            try
            {
                //#pragma warning disable CS0618 // 'Thread.Suspend()' is obsolete: 'Thread.Suspend has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202'
                t.Suspend();
                //#pragma warning restore CS0618 // 'Thread.Suspend()' is obsolete: 'Thread.Suspend has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202'

            }
            catch (Exception tt)
            {
                Log(tt);
            }
            return true;
        }
        bool Event(Thread t)
        {
            try
            {
                t.Start();

            }
            catch (Exception tt)
            {
                Log(tt);
            }
            return true;
        }
        bool Semaphore(Thread t)
        {
            try
            {
                //#pragma warning disable CS0618 // 'Thread.Resume()' is obsolete: 'Thread.Resume has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202'
                t.Resume();
                //#pragma warning restore CS0618 // 'Thread.Resume()' is obsolete: 'Thread.Resume has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202'

            }
            catch (Exception tt)
            {
                Log(tt);
            }
            return true;
        }
    }
}
//End of Documents.
