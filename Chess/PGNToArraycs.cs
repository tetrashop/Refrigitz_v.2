using System;
using System.Collections.Generic;

namespace Chess
{
    //main
    public class PGNToArraycs
    {
        public String[] Lines;
        public List<PGN> Game = new List<PGN>();
        public List<String> gamese = new List<String>();

        public PGNToArraycs(String filename)
        {
            Lines = System.IO.File.ReadAllLines(filename);
        }
        PGNToArraycs()
        {
        }
        public void PGNToArraycsMethod()
        {

            int j = 0;
            for (int i = 1; i < Lines.Length - 1; i++)
            {
                if (Lines[i - 1] == "" && Lines[i + 1] == "")
                {
                    Game.Add(new PGN());
                    Game[j].PGNToArraycsSplit(Lines[i]);
                    gamese.Add(Lines[i]);
                    j++;
                }

            }


        }
    }
    public class PGN
    {
        public List<String> MoveText = new List<String>();

        public static int Index = 1;
        public static int Len = 0;

        public PGN()
        {

        }
        public void PGNToArraycsSplit(String Game)
        {


            try
            {
                Index = 1;
                do
                {
                    MoveText.Add(Game.Substring(Game.IndexOf(System.Convert.ToString(Index) + "."), Game.IndexOf(System.Convert.ToString(Index + 1) + ".") - Game.IndexOf(System.Convert.ToString(Index) + ".")));
                    Index++;
                } while (true);

            }
            catch (Exception t)
            {

                try
                {
                    MoveText.Add(Game.Substring(Game.IndexOf(System.Convert.ToString(Index) + "."), Game.IndexOf("1-0") - Game.IndexOf(System.Convert.ToString(Index) + ".")));

                }
                catch (Exception tt)
                {
                    MoveText.Add(Game.Substring(Game.IndexOf(System.Convert.ToString(Index) + "."), Game.IndexOf("0-1") - Game.IndexOf(System.Convert.ToString(Index) + ".")));

                }
            }
        }
    }
}
