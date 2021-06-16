/**************************************************************************
 * Ramin Edjlal.***********************************************************
 * Timer is Working Reversely***********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Timer Order Decreasing Not Work!*****************************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Timer Not Worked.********************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Timer Scheduling For Regard and Set Point Malfunctions.******************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Timer Set Point of Text Malfunctioned.***********************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Thinking Finished Begin At New Time Text Box.****************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Timer Changing Start Stop Function Failed.*******************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Timer MalFunction.*******************************************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Visual Studio Timer and Visualization du to Internet Access Malfunction**RS*****0.12**4**Managements and Cuation Programing**(+)
 * Dynamic Timer Dept. First Increment or Decrement Malfunction.************RS*****0.12**4**Managements and Cuation Programing**(+)
 * No Logically Idea For Managements of Dynamic Dept. First Max Dept.*******RS*****0.12**4**Managements and Cuation Programing**(+)
 * Timer Malfunction When Leave Foreground The Program.*********************RS*****0.12**4**Managements and Cuation Programing**(+)
 * Divison By Zero No Reasonly.*********************************************RS*****0.12**4**Managements and Cuation Programing**(+)
 * 1395/1/16***************************************************************
 * Timer Not Worked.********************************************************RS*****0.12**4**Managements and Cuation Programing**(+):(Not Set in this instatnt of analysis:Similarity is act.)
 * ************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
namespace Refrigtz
{

    public class Timer
    {
        //Initiate Variables. static and local for three timer.
        public static int StoreAllDrawCount = 0;
        public static bool UseDoubleTime = false;
        public static long DeptiLevelMax=0;
        public static bool DeptFirstSearch; 
        long ConstTimer = 0;
        double DeptFirstMidleTimer = 0;
        long DeptFirstLastTime = 0;
        public static bool Text = false;
        public long Times = 5 * 60 * 1000;
        long TimesBegin = 0;
        public bool EndTime = false;
        Thread t;
        public bool Paused = true;
        public bool TextChanged = true;
        public int Sign = -1;
        bool Infinity = false;
        static void Log(Exception ex)
        {
            try
            {
                string stackTrace = ex.ToString();
                File.AppendAllText("ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
            }
            catch (Exception t) { Log(t); }
        }
        //Constructive Tow Kind of Timer. Decreased timer and Incresed timer.
        public Timer(bool SignPositive)
        {
            
                //For Infinity Timer until end.
                if (SignPositive)
                {
                    Times = 0;
                    Sign = 1;
                    Infinity = true;
                }
            

        }
        //Initiate Timer.
        public void TimerInitiate()
        {
            t = new Thread(new ThreadStart(timerThread));
            t.Start();
        }
        //Main Timer of Threading.
        void timerThread()
        {


            do
            {
                //When timer stop sleep and checked for 500 ms.
                while (Paused)
                {
                   System.Threading.Thread.Sleep(800);
                };
                //When timr begin store current time.
                long t1 = DateTime.Now.Hour * 3600000 + DateTime.Now.Minute * 60000
                    + DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;


                do
                {
                    System.Threading.Thread.Sleep(800);
                }
                //Cal for every 1 second.
                while (DateTime.Now.Hour * 3600000 + DateTime.Now.Minute * 60000
                   + DateTime.Now.Second * 1000 + DateTime.Now.Millisecond - t1 < 1000);
                //Dec of inc one second.
                Times = Times + 1000 * Sign;

                //Local Variabe of Timer changed.
                TextChanged = true;

                //While  Condition is true for operations. 
            } while (Times > 0 || Infinity);

            //Indicating of end timer.
            EndTime = true;
        }
        //Access to Private Timer Value of Long.
        public long TimesAccess
        {
            get { return Times; }
            set { Times = value; }


        }
        public long TimesConstAccess
        {
            get { return ConstTimer; }
            set { ConstTimer = value; }


        }
        //Dept First MAx Level Condition checked.
        public int DeptiLevelMaxInitiate(Timer TimerColor, int Depti)
        {
            //int PowerEx = 4;
            int Increase = 0;//Initaiate
            Increase = 1;
            int PowerEx = 3;
            //When Ok.
            if (Sign != 1)
            {
                /*if ((System.Math.Pow((DeptiLevelMax - StoreAllDrawCount) * DeptFirstMidleTimer, PowerEx) + System.Math.Pow(TimerColor.TimesAccess, PowerEx) > System.Math.Pow((DeptiLevelMax - StoreAllDrawCount) * DeptFirstMidleTimer, PowerEx) + System.Math.Pow((Depti - StoreAllDrawCount) * DeptFirstMidleTimer, PowerEx)))
                {
                    Increase = 1;

                }
                else//When is Cancled.
                {
                    if ((System.Math.Pow((DeptiLevelMax - StoreAllDrawCount) * DeptFirstMidleTimer, PowerEx) + System.Math.Pow(TimerColor.TimesAccess, PowerEx) < System.Math.Pow((DeptiLevelMax - StoreAllDrawCount) * DeptFirstMidleTimer, PowerEx) + System.Math.Pow((Depti - StoreAllDrawCount) * DeptFirstMidleTimer, PowerEx)))
                    {
                        Increase = -1;
                    }
                }*/
                if (Times - 120000 < 0)
                    Increase = -1;
                else
                    Increase = 1;
                //Value
            }
            return Increase;
        }
        //Set Dept First Level Max Variables.
        public void SetDeptFirstTimer()
        {
            if (DeptFirstLastTime == 0)
                DeptFirstLastTime = 0;
            else
                DeptFirstLastTime = Times - DeptFirstLastTime;
            if (StoreAllDrawCount == 0)
                DeptFirstMidleTimer = 0;
        }
        //Cal Midle (Avarage) Dept First Some static variables.
        public void MidleDeptFirstTimer(int Depti)
        {
            try
            {
                long Dummy = DeptFirstLastTime;
                DeptFirstLastTime = Times - DeptFirstLastTime;
                //Division By Zero No Reasonaly.
                DeptFirstMidleTimer = ((Dummy * (Depti - StoreAllDrawCount)) + DeptFirstLastTime) / ((Depti - StoreAllDrawCount + 1));
            }
            catch (DivideByZeroException t)
            {
                Log(t);
            }
        }
        //Strat timer function.
        public void StartTime()
        {
            if (Sign != 1)
            {
                //Resume Suspended MAin Thread.
                TimerInitiate();
                //When Begin Timer Valuee is Zero cal.
                if (TimesBegin == 0)
                    TimesBegin = DateTime.Now.Hour * 3600000 + DateTime.Now.Minute * 60000
                                + DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
            }
            //Set to Thread Paused.
             Paused = false;

        }

        //Stop Timer.
        public void StopTime()
        {if (Sign != 1)
            {
                //When Dept First is not act or Double time is not act.
                if (!DeptFirstSearch || !UseDoubleTime)
                {
                    //Cal Remaining timer value.
                    long Remaining = Times;
                    //When Remaining timer is greter than zero.
                    if (Remaining > 0)
                        Remaining = 0;
                    //When Regrad timer is valuable.
                    if ((DateTime.Now.Hour * 3600000 + DateTime.Now.Minute * 60000
                            + DateTime.Now.Second * 1000 + DateTime.Now.Millisecond - TimesBegin) < 5000)
                        Times = 5 * 60 * 1000 + 60000 + Remaining;
                    else
                        Times = 5 * 60 * 1000 + Remaining;
                    //Const timer value.
                    ConstTimer = 5 * 60 * 1000 + Remaining;
                }
                else
                {
                    //Same as else.
                    long Remaining = Times;
                    if (Remaining > 0)
                        Remaining = 0;

                    if ((DateTime.Now.Hour * 3600000 + DateTime.Now.Minute * 60000
                      + DateTime.Now.Second * 1000 + DateTime.Now.Millisecond - TimesBegin) < 10000)
                        Times = 10 * 60 * 1000 + 60000 + Remaining;
                    else
                        Times = 10 * 60 * 1000 + Remaining;
                    ConstTimer = 10 * 60 * 1000 + Remaining;
                }
                TimesBegin = 0;
                Paused = true;
                //Suspend timer.
                t.Abort();
            }
            Paused = true;
          
        }
        public String ReturnTime()
        {
            //Cal and return timer string.
            String Minute = (Times / 60000).ToString();
            String Second = ((Times - System.Convert.ToInt64(Times / 60000) * 60000) / 1000).ToString();

            return Minute + ":" + Second;
        }
    }
}
