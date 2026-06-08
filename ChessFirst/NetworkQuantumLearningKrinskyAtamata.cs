/*CopyRight Ramin Edjlal***************************2018*************************
 The Magic Table Game Satte Learing Quantum Atamata.****************************
 *******************************************************************************
 */
using System;
using System.IO;

namespace ChessFirst
{
    [Serializable]
    public class NetworkQuantumLearningKrinskyAtamata : LearningKrinskyAtamata
    {
        public static String Root = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        static void Log(Exception ex)
        {

            Object a = new Object();
            lock (a)
            {
                string stackTrace = ex.ToString();
                File.AppendAllText(Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
            }

        }

        int r, m, k;
        LearningKrinskyAtamata[,] Netfi;


        public NetworkQuantumLearningKrinskyAtamata(int r0, int m0, int k0) : base(r0, m0, k0)
        {
            Object o = new Object();
            lock (o)
            {
                Netfi = new LearningKrinskyAtamata[m0, k0];

                for (int j = 0; j < m0; j++)
                    for (int p = 0; p < k0; p++)
                        Netfi[j, p] = new LearningKrinskyAtamata(r0, m0, k0);

                r = r0;
                m = m0;
                k = k0;
            }
        }
        public double LearningAlgorithmRegardNet(int Row, int Column)
        {
            Object o = new Object();
            lock (o)
            {

                double Hu = 1;

                Netfi[Row, Column].LearningAlgorithmRegard();
                Hu = Netfi[Row, Column].alpha[State];

                return Hu;
            }
        }
        public int IsRewardActionNet(int Row, int Column)
        {
            Object o = new Object();
            lock (o)
            {
                if (Netfi[Row, Column].IsReward)
                    return 1;
                return -1;
            }
        }

        public double IsPenaltyActionNet(int Row, int Column)
        {
            Object o = new Object();
            lock (o)
            {
                if (Netfi[Row, Column].IsPenalty)
                    return 0;
                return -1;
            }
        }
        public double LearningAlgorithmPenaltyNet(int Row, int Column)
        {
            Object o = new Object();
            lock (o)
            {
                double Hu = 1;

                Netfi[Row, Column].LearningAlgorithmPenalty();
                Hu = Netfi[Row, Column].alpha[State];

                return Hu;
            }
        }
        public double LearingValue(int Row, int Column)
        {
            Object o = new Object();
            lock (o)
            {
                double Hu = 1;

                Hu = Netfi[Row, Column].alpha[State];

                return Hu;
            }
        }
    }
}

