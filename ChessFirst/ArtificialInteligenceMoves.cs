using ChessFirst;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

public class ArtificialInteligenceMove
{
    public static bool UpdateIsRunning = true;
    public static ArtificialInteligenceMove tta;
    int LevelMul = 1;
    int Order = 1;
    public int x, y, x1, y1;

    ChessFirstForm t = null;

    bool Idle = false;
    public static bool IdleProgress = true;
    public ArtificialInteligenceMove(ChessFirstForm tt)
    {
        //Awake ();
        t = tt;
        var ttt = new Thread(new ThreadStart(ThinkingIdle));
        ttt.Start();

        //ttt.Join ();

    }


    Color OrderColor(int Ord)
    {
        Object O = new Object();
        lock (O)
        {
            Color a = Color.Gray;
            if (Ord == -1)
                a = Color.Brown;
            return a;
        }
    }
    public void ThinkingIdle()
    {
        object O = new object();
        lock (O)
        {
            bool ReadyZero = true;
            do
            {
                if (t != null)
                {
                    if (t.LoadP || Idle)
                    {
                        if (AllDraw.CalIdle == 0 && ReadyZero)
                        {
                            ReadyZero = false;

                        }
                        if (AllDraw.CalIdle == 0 && (!ArtificialInteligenceMove.UpdateIsRunning)
                        )
                        {

                            bool Blit = AllDraw.Blitz;
                            AllDraw.Blitz = false;
                            Idle = true;
                            AllDraw.TimeInitiation = (DateTime.Now.Hour * 60 * 60 * 1000 + DateTime.Now.Minute * 60 * 1000 + DateTime.Now.Second * 1000);
                            AllDraw.MaxAStarGreedy = AllDraw.PlatformHelperProcessorCount * LevelMul;
                            AllDraw.StoreInitMaxAStarGreedy = t.Draw.CurrentMaxLevel; AllDraw.MaxAStarGreedy = 0;

                            var arrayA = Task.Factory.StartNew(() => t.Draw.InitiateAStarGreedyt(PlatformHelper.ProcessorCount + AllDraw.StoreInitMaxAStarGreedy - AllDraw.MaxAStarGreedy, 1, 4, OrderColor(t.Draw.OrderP), CloneATable(t.brd.GetTable()), t.Draw.OrderP, false, false, 0));
                            //var arrayA =Task.Factory.StartNew(() =>	t.Play(-1,-1));
                            arrayA.Wait();
                            object i = new object();

                            lock (i)
                            {
                                bool LoadTree = false;
                                (new TakeRoot()).Save(false, false, t, ref LoadTree, false, false, false, false, false, false, false, true);
                            }
                            AllDraw.Blitz = Blit;
                            //							Thread.Sleep(50);
                            LevelMul++;
                            IdleProgress = false;
                            AllDraw.MaxAStarGreedy = t.Draw.CurrentMaxLevel;
                            AllDraw.CalIdle = 1;
                            ArtificialInteligenceMove.UpdateIsRunning = true;
                        }
                        while (AllDraw.CalIdle == 2)
                        {
                            Thread.Sleep(100);
                            //AllDraw.CalIdle=5;
                        }
                        //						if(AllDraw.CalIdle==2)
                        //						{
                        //							Debug.Log("Ready to 5 base");
                        //
                        //							AllDraw.CalIdle=5;
                        //						}
                        //						Debug.Log("Ready to 0 base");

                        /*if(AllDraw.CalIdle==5)
						{		AllDraw.CalIdle=1;
//						        AllDraw.IdleInWork=false;

							//Debug.Log("Ready to 1 base");
							ReadyZero=true;
						}*/

                        while (AllDraw.CalIdle == 1)
                        {

                            Thread.Sleep(100);
                        }
                        /*while(ArtificialInteligenceMove.UpdateIsRunning)
						{	
							//Thread.Sleep(1);
						}*/

                        AllDraw.IdleInWork = true;
                        IdleProgress = true;
                        UpdateIsRunning = false;
                    }
                }
            } while (AllDraw.CalIdle != 3);

        }
    }
    int[,] CloneATable(int[,] Tab)
    {
        object O = new object();
        lock (O)
        {
            int[,] Tabl = new int[8, 8];
            for (var i = 0; i < 8; i++)
                for (var j = 0; j < 8; j++)
                    Tabl[i, j] = Tab[i, j];

            return Tabl;
        }
    }

}


