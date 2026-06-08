using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
namespace RefrigtzW
{
    class Syncronization
    {
        //Error Handling.
        static void Log(Exception ex)
        {
            try
            {
                string stackTrace = ex.ToString();
                File.AppendAllText(FormRefrigtz.Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
            }
            catch (Exception t) {  }
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
                t.Suspend();

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
                t.Resume();

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
