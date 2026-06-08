using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Refrigtz
{
    [Serializable]
    class ImportantNodes
    {

        List<Soldier> S;
        List<Elephant> E;
        List<Hourse> H;
        List<Bridge> B;
        List<Minister> M;
        List<King> K;
        public ImportantNodes()
        {
            S = new List<Soldier>(); 
            E = new List<Elephant>(); 
            H = new List<Hourse>(); 
            B = new List<Bridge>(); 
            M = new List<Minister>(); 
            K = new List<King>();
        }
        /// <summary>
        /// Only Table needs to constructe location arranged in six separated class
        /// </summary>
        /// <param name="Table"></param>
        public void Add(int[,] Table)
        {
            S.Add(new Soldier(Table));
            E.Add(new Elephant(Table));
            H.Add(new Hourse(Table));
            B.Add(new Bridge(Table));
            M.Add(new Minister(Table));
            K.Add(new King(Table)); 
        }
    }
    class Soldier
    {

        public int GrayNumbers = 0;
        public int BrowNumbers = 0;
        public List<int[]> Solders = new List<int[]>();
        public Soldier(int[,] Tabl)
        {
            SetSolders(Tabl);
        }
        public void SetSolders(int[,] Table)
        {

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == 1)
                    {
                        int[] RowColumn = new int[2];
                        RowColumn[0] = i;
                        RowColumn[1] = j;
                        Solders.Add(RowColumn);
                    }
                }
            GrayNumbers = Solders.Count;
            for (int i = Solders.Count; i < 8; i++)
            {
                int[] RowColumn = new int[2];
                RowColumn[0] = -1;
                RowColumn[1] = -1;
                Solders.Add(RowColumn);
            }
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == -1)
                    {
                        int[] RowColumn = new int[2];
                        RowColumn[0] = i;
                        RowColumn[1] = j;
                        Solders.Add(RowColumn);
                    }
                }
            BrowNumbers = Solders.Count;
            for (int i = Solders.Count; i < 16; i++)
            {
                int[] RowColumn = new int[2];
                RowColumn[0] = -1;
                RowColumn[1] = -1;
                Solders.Add(RowColumn);
            }

        }
    }
    class Elephant
    {

        public int GrayNumbers = 0;
        public int BrowNumbers = 0;
        public List<int[]> Elephants = new List<int[]>();
        public Elephant(int[,] Tabl)
        {
            SetElephants(Tabl);
        }
        public void SetElephants(int[,] Table)
        {

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == 2)
                    {
                        int[] RowColumn = new int[2];
                        RowColumn[0] = i;
                        RowColumn[1] = j;
                        Elephants.Add(RowColumn);
                    }
                }
            GrayNumbers = Elephants.Count;
            for (int i = Elephants.Count; i < 2; i++)
            {
                int[] RowColumn = new int[2];
                RowColumn[0] = -1;
                RowColumn[1] = -1;
                Elephants.Add(RowColumn);
            }
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == -1)
                    {
                        int[] RowColumn = new int[2];
                        RowColumn[0] = i;
                        RowColumn[1] = j;
                        Elephants.Add(RowColumn);
                    }
                }
            BrowNumbers = Elephants.Count;
            for (int i = Elephants.Count; i < 4; i++)
            {
                int[] RowColumn = new int[2];
                RowColumn[0] = -1;
                RowColumn[1] = -1;
                Elephants.Add(RowColumn);
            }

        }
    }
    class Hourse
    {

        public int GrayNumbers = 0;
        public int BrowNumbers = 0;
        public List<int[]> Hourses = new List<int[]>();
        public Hourse(int[,] Tabl)
        {
            SetHourses(Tabl);
        }
        public void SetHourses(int[,] Table)
        {

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == 3)
                    {
                        int[] RowColumn = new int[2];
                        RowColumn[0] = i;
                        RowColumn[1] = j;
                        Hourses.Add(RowColumn);
                    }
                }
            GrayNumbers = Hourses.Count;
            for (int i = Hourses.Count; i < 2; i++)
            {
                int[] RowColumn = new int[2];
                RowColumn[0] = -1;
                RowColumn[1] = -1;
                Hourses.Add(RowColumn);
            }
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == -3)
                    {
                        int[] RowColumn = new int[2];
                        RowColumn[0] = i;
                        RowColumn[1] = j;
                        Hourses.Add(RowColumn);
                    }
                }
            BrowNumbers = Hourses.Count;
            for (int i = Hourses.Count; i < 4; i++)
            {
                int[] RowColumn = new int[2];
                RowColumn[0] = -1;
                RowColumn[1] = -1;
                Hourses.Add(RowColumn);
            }

        }
    }
    class Bridge
    {

        public int GrayNumbers = 0;
        public int BrowNumbers = 0;
        public List<int[]> Bridges = new List<int[]>();
        public Bridge(int[,] Tabl)
        {
            SetBridges(Tabl);
        }
        public void SetBridges(int[,] Table)
        {

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == 4)
                    {
                        int[] RowColumn = new int[2];
                        RowColumn[0] = i;
                        RowColumn[1] = j;
                        Bridges.Add(RowColumn);
                    }
                }
            GrayNumbers = Bridges.Count;
            for (int i = Bridges.Count; i < 2; i++)
            {
                int[] RowColumn = new int[2];
                RowColumn[0] = -1;
                RowColumn[1] = -1;
                Bridges.Add(RowColumn);
            }
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == -4)
                    {
                        int[] RowColumn = new int[2];
                        RowColumn[0] = i;
                        RowColumn[1] = j;
                        Bridges.Add(RowColumn);
                    }
                }
            BrowNumbers = Bridges.Count;
            for (int i = Bridges.Count; i < 4; i++)
            {
                int[] RowColumn = new int[2];
                RowColumn[0] = -1;
                RowColumn[1] = -1;
                Bridges.Add(RowColumn);
            }

        }
    }
    class Minister
    {

        public int GrayNumbers = 0;
        public int BrowNumbers = 0;
        public List<int[]> Ministers = new List<int[]>();
        public Minister(int[,] Tabl)
        {
            SetMinisters(Tabl);
        }
        public void SetMinisters(int[,] Table)
        {

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == 5)
                    {
                        int[] RowColumn = new int[2];
                        RowColumn[0] = i;
                        RowColumn[1] = j;
                        Ministers.Add(RowColumn);
                    }
                }
            for (int i = Ministers.Count; i < 1; i++)
            {
                int[] RowColumn = new int[2];
                RowColumn[0] = -1;
                RowColumn[1] = -1;
                Ministers.Add(RowColumn);
            }
            GrayNumbers = Ministers.Count;
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == -5)
                    {
                        int[] RowColumn = new int[2];
                        RowColumn[0] = i;
                        RowColumn[1] = j;
                        Ministers.Add(RowColumn);
                    }
                }
            BrowNumbers = Ministers.Count;
            for (int i = Ministers.Count; i < 2; i++)
            {
                int[] RowColumn = new int[2];
                RowColumn[0] = -1;
                RowColumn[1] = -1;
                Ministers.Add(RowColumn);
            }

        }
    }
    class King
    {

        public int GrayNumbers = 0;
        public int BrowNumbers = 0;
        public List<int[]> Kings = new List<int[]>();
        public King(int[,] Tabl)
        {
            SetKings(Tabl);
        }
        public void SetKings(int[,] Table)
        {

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == 6)
                    {
                        int[] RowColumn = new int[2];
                        RowColumn[0] = i;
                        RowColumn[1] = j;
                        Kings.Add(RowColumn);
                    }
                }

            GrayNumbers = Kings.Count;

            for (int i = Kings.Count; i < 1; i++)
            {
                int[] RowColumn = new int[2];
                RowColumn[0] = -1;
                RowColumn[1] = -1;
                Kings.Add(RowColumn);
            }
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == -6)
                    {
                        int[] RowColumn = new int[2];
                        RowColumn[0] = i;
                        RowColumn[1] = j;
                        Kings.Add(RowColumn);
                    }
                }
            BrowNumbers = Kings.Count;
            for (int i = Kings.Count; i < 2; i++)
            {
                int[] RowColumn = new int[2];
                RowColumn[0] = -1;
                RowColumn[1] = -1;
                Kings.Add(RowColumn);
            }

        }
    }
}
