using System.Collections.Generic;

namespace ContourAnalysisNS
{
    public class ResultsOfSupposed
    {
        public static List<string> mined = new List<string>();
        private static readonly List<List<string>> Strlogic = new List<List<string>>();
        private static readonly List<List<int[]>> StrlogicIndex = new List<List<int[]>>();
        private static readonly List<List<string>> teloIndex = new List<List<string>>();
        public static bool MindedIsVerb(List<string> te, List<List<string>> telo)
        {
            bool Is = false;
            Strlogic.Clear();
            mined.Clear();
            StrlogicIndex.Clear();
            teloIndex.Clear();

            for (int p = 0; p < telo.Count; p++)
            {
                for (int q = 0; q < telo[p].Count; q++)
                {
                    MindedIsVerb(te, telo, true, true, false, false, p, q, -1, -1);

                    for (int r = 0; r < telo[p].Count; r++)
                    {
                        if (q == r)
                        {
                            continue;
                        }

                        MindedIsVerb(te, telo, true, true, true, false, p, q, r, -1);

                        for (int s = 0; s < telo[p].Count; s++)
                        {
                            if (s == q)
                            {
                                continue;
                            }

                            MindedIsVerb(te, telo, true, true, true, true, p, q, r, s);

                        }
                    }
                }
            }
            for (int p = 0; p < Strlogic.Count; p++)
            {
                for (int q = 0; q < Strlogic[p].Count; q++)
                {

                    if (Strlogic[p][q] == "q")
                    {
                        string s = teloIndex[p][q] + "! \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "p->r")
                    {
                        string s = teloIndex[p][q] + " " + teloIndex[p][q] + " است. \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "~p")
                    {
                        string s = teloIndex[p][q] + " نیست. \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "p&&q")
                    {
                        string s = " نیست" + teloIndex[p][q] + " نباشد که " + teloIndex[p][q] + " نیست. \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "S")
                    {
                        string s = "";
                        if (StrlogicIndex[p][q][0] > 1)
                        {
                            s = teloIndex[p][0] + "! \r\n";
                        }
                        else
                        {
                            s = teloIndex[p][q] + "! \r\n";
                        }

                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "p->q")
                    {
                        string s = teloIndex[p][q] + teloIndex[p][q] + " است. \r\n";
                    }

                    if (Strlogic[p][q] == "p")
                    {
                        string s = teloIndex[p][q] + "! \r\n";
                    }

                    if (Strlogic[p][q] == "r")
                    {
                        string s = teloIndex[p][q] + "! \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "p||q->r")
                    {
                        string s = teloIndex[p][q] + " یا " + teloIndex[p][q] + " " + teloIndex[p][q] + " است. \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "q||s")
                    {
                        string s = "";
                        if (StrlogicIndex[p][q][2] != -1)
                        {
                            s = teloIndex[p][q] + " یا " + teloIndex[p][q] + "! \r\n";
                        }
                        else
                        {
                            s = teloIndex[p][q] + "! \r\n";
                        }

                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "!p||!q")
                    {
                        string s = "نه " + teloIndex[p][q] + " نه " + teloIndex[p][q] + "! \r\n";
                        mined.Add(s);
                    }

                }

            }

            return Is;
        }
        public static bool MindedSomeVerb(List<string> te, List<List<string>> telo, string verb)
        {
            bool Is = false;
            Strlogic.Clear();
            mined.Clear();
            StrlogicIndex.Clear();
            teloIndex.Clear();
            for (int p = 0; p < telo.Count; p++)
            {
                for (int q = 0; q < telo[p].Count; q++)
                {
                    MindedIsVerb(te, telo, true, true, false, false, p, q, -1, -1);

                    for (int r = 0; r < telo[p].Count; r++)
                    {
                        if (p == r)
                        {
                            continue;
                        }

                        MindedIsVerb(te, telo, true, true, true, false, p, q, r, -1);

                        for (int s = 0; s < telo[p].Count; s++)
                        {
                            if (s == q)
                            {
                                continue;
                            }

                            MindedIsVerb(te, telo, true, true, true, true, p, q, r, s);

                        }
                    }
                }
            }
            for (int p = 0; p < Strlogic.Count; p++)
            {
                for (int q = 0; q < Strlogic[p].Count; q++)
                {

                    if (Strlogic[p][q] == "q")
                    {
                        string s = teloIndex[p][q] + "! \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "p->r")
                    {
                        string s = teloIndex[p][q] + " " + teloIndex[p][q] + " " + verb + ". \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "~p")
                    {
                        string s = teloIndex[p][q] + " " + "ن" + verb + " \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "p&&q")
                    {
                        string s = "ن" + verb + " " + teloIndex[p][q] + " نباشد که " + teloIndex[p][q] + " " + "ن" + verb + ". \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "S")
                    {
                        string s = "";
                        if (StrlogicIndex[p][q][0] > 1)
                        {
                            s = teloIndex[p][0] + "! \r\n";
                        }
                        else
                        {
                            s = teloIndex[p][q] + "! \r\n";
                        }

                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "p->q")
                    {
                        string s = teloIndex[p][q] + teloIndex[p][q] + " " + "ن" + verb + " \r\n";
                    }

                    if (Strlogic[p][q] == "p")
                    {
                        string s = teloIndex[p][q] + "! \r\n";
                    }

                    if (Strlogic[p][q] == "r")
                    {
                        string s = teloIndex[p][q] + "! \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "p||q->r")
                    {
                        string s = teloIndex[p][q] + " یا " + teloIndex[p][q] + " " + teloIndex[p][q] + " " + verb + " \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "q||s")
                    {
                        string s = "";
                        if (StrlogicIndex[p][q][2] != -1)
                        {
                            s = teloIndex[p][q] + " یا " + teloIndex[p][q] + "! \r\n";
                        }
                        else
                        {
                            s = teloIndex[p][q] + "! \r\n";
                        }

                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "!p||!q")
                    {
                        string s = "نه " + teloIndex[p][q] + " نه " + teloIndex[p][q] + "! \r\n";
                        mined.Add(s);
                    }

                }

            }


            return Is;
        }
        public static bool MindedWasVerb(List<string> te, List<List<string>> telo)
        {
            bool Is = false;
            Strlogic.Clear();
            mined.Clear();
            StrlogicIndex.Clear();
            teloIndex.Clear();

            for (int p = 0; p < telo.Count; p++)
            {
                for (int q = 0; q < telo[p].Count; q++)
                {
                    MindedIsVerb(te, telo, true, true, false, false, p, q, -1, -1);

                    for (int r = 0; r < telo[p].Count; r++)
                    {
                        if (p == r)
                        {
                            continue;
                        }

                        MindedIsVerb(te, telo, true, true, true, false, p, q, r, -1);

                        for (int s = 0; s < telo[p].Count; s++)
                        {
                            if (s == q)
                            {
                                continue;
                            }

                            MindedIsVerb(te, telo, true, true, true, true, p, q, r, s);

                        }
                    }
                }
            }
            for (int p = 0; p < Strlogic.Count; p++)
            {
                for (int q = 0; q < Strlogic[p].Count; q++)
                {

                    if (Strlogic[p][q] == "q")
                    {
                        string s = teloIndex[p][q] + "! \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "p->r")
                    {
                        string s = teloIndex[p][q] + " " + teloIndex[p][q] + " بود. \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "~p")
                    {
                        string s = teloIndex[p][q] + " نبود. \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "p&&q")
                    {
                        string s = " نبود" + teloIndex[p][q] + " نباشد که " + teloIndex[p][q] + " نبود. \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "S")
                    {
                        string s = "";
                        if (StrlogicIndex[p][q][0] > 1)
                        {
                            s = teloIndex[p][0] + "! \r\n";
                        }
                        else
                        {
                            s = teloIndex[p][q] + "! \r\n";
                        }

                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "p->q")
                    {
                        string s = teloIndex[p][q] + teloIndex[p][q] + " بود. \r\n";
                    }

                    if (Strlogic[p][q] == "p")
                    {
                        string s = teloIndex[p][q] + "! \r\n";
                    }

                    if (Strlogic[p][q] == "r")
                    {
                        string s = teloIndex[p][q] + "! \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "p||q->r")
                    {
                        string s = teloIndex[p][q] + " یا " + teloIndex[p][q] + " " + teloIndex[p][q] + " بود. \r\n";
                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "q||s")
                    {
                        string s = "";
                        if (StrlogicIndex[p][q][2] != -1)
                        {
                            s = teloIndex[p][q] + " یا " + teloIndex[p][q] + "! \r\n";
                        }
                        else
                        {
                            s = teloIndex[p][q] + "! \r\n";
                        }

                        mined.Add(s);
                    }

                    if (Strlogic[p][q] == "!p||!q")
                    {
                        string s = "نه " + teloIndex[p][q] + " نه " + teloIndex[p][q] + "! \r\n";
                        mined.Add(s);
                    }

                }

            }

            return Is;
        }
        public static void MindedIsVerb(List<string> te, List<List<string>> telo, bool p, bool q, bool r, bool s, int pp, int qq, int rr, int ss)
        {
            string se = "";
            int[] n = new int[4];
            n[0] = pp;
            n[1] = qq;
            n[2] = rr;
            n[3] = ss;
            Strlogic.Add(new List<string>());
            StrlogicIndex.Add(new List<int[]>());
            teloIndex.Add(new List<string>());

            PandPgivesQIsQ(p, q, ref se);
            Strlogic[Strlogic.Count - 1].Add(se);
            teloIndex[teloIndex.Count - 1].Add(telo[pp][qq]);
            StrlogicIndex[StrlogicIndex.Count - 1].Add(n);
            se = "";

            PgivesQandQgivesRIsPgivesR(p, q, r, ref se);
            Strlogic[Strlogic.Count - 1].Add(se);
            teloIndex[teloIndex.Count - 1].Add(telo[pp][qq]);
            StrlogicIndex[StrlogicIndex.Count - 1].Add(n);
            se = "";

            PgivesQandnotQIsnotP(p, q, ref se);
            Strlogic[Strlogic.Count - 1].Add(se);
            teloIndex[teloIndex.Count - 1].Add(telo[pp][qq]);
            StrlogicIndex[StrlogicIndex.Count - 1].Add(n);
            se = "";

            PQIsPANDQ(p, q, ref se);
            Strlogic[Strlogic.Count - 1].Add(se);
            teloIndex[teloIndex.Count - 1].Add(telo[pp][qq]);
            StrlogicIndex[StrlogicIndex.Count - 1].Add(n);
            se = "";

            Contradiction(p, q, ref se);
            Strlogic[Strlogic.Count - 1].Add(se);
            teloIndex[teloIndex.Count - 1].Add(telo[pp][qq]);
            StrlogicIndex[StrlogicIndex.Count - 1].Add(n);
            se = "";

            ContradictionSample(p, q, r, ref se);
            Strlogic[Strlogic.Count - 1].Add(se);
            teloIndex[teloIndex.Count - 1].Add(telo[pp][qq]);
            StrlogicIndex[StrlogicIndex.Count - 1].Add(n);
            se = "";

            /*PandQ(p, q, ref se);
            Strlogic[Strlogic.Count-1].Add(se);
          teloIndex[teloIndex.Count - 1].Add(telo[pp][qq]);
            StrlogicIndex[StrlogicIndex.Count - 1].Add(n);
      se = "";*/

            /*PorQandnotPgivesQ(p, q, ref se);
            Strlogic[Strlogic.Count-1].Add(se);
       teloIndex[teloIndex.Count - 1].Add(telo[pp][qq]);
        
           StrlogicIndex[StrlogicIndex.Count - 1].Add(n);
      se = "";*/

            PQandPgivesQgivesRisR(p, q, r, ref se);
            Strlogic[Strlogic.Count - 1].Add(se);
            teloIndex[teloIndex.Count - 1].Add(telo[pp][qq]);
            StrlogicIndex[StrlogicIndex.Count - 1].Add(n);
            se = "";

            PgivesQandQgivesRisPOrQgivesR(p, q, r, ref se);
            Strlogic[Strlogic.Count - 1].Add(se);
            teloIndex[teloIndex.Count - 1].Add(telo[pp][qq]);
            StrlogicIndex[StrlogicIndex.Count - 1].Add(n);
            se = "";

            PgivesQandRgivesSandPorRIsQorS(p, q, r, s, ref se);
            Strlogic[Strlogic.Count - 1].Add(se);
            teloIndex[teloIndex.Count - 1].Add(telo[pp][qq]);
            StrlogicIndex[StrlogicIndex.Count - 1].Add(n);
            se = "";

            PgivesQandRgivesSandnotPornotRIsnotPornotQ(p, q, r, s, ref se);
            Strlogic[Strlogic.Count - 1].Add(se);
            teloIndex[teloIndex.Count - 1].Add(telo[pp][qq]);
            StrlogicIndex[StrlogicIndex.Count - 1].Add(n);
            se = "";
        }
        public static bool PandPgivesQIsQ(bool p, bool q, ref string Re)
        {
            bool s = p && ((!p) || q);
            if (s)
            {
                Re = "q";
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PgivesQandQgivesRIsPgivesR(bool p, bool q, bool r, ref string Re)
        {
            bool s = ((!p) || q) && ((!p) || r);
            if (s)
            {
                Re = "p->r";
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PgivesQandnotQIsnotP(bool p, bool q, ref string Re)
        {
            bool s = ((!p) || q) && ((!q));
            if (s)
            {
                Re = "~p";
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PQIsPANDQ(bool p, bool q, ref string Re)
        {
            bool s = (p) && (q);
            if (s)
            {
                Re = "p&&Q";
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Contradiction(bool s, bool f, ref string Re)
        {
            bool a = (s) || (f);
            if (a)
            {
                Re = "S";
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ContradictionSample(bool p, bool q, bool f, ref string Re)
        {
            bool a = ((!(p && (!q))) || (f));
            if (a)
            {
                Re = "p->q";
                return true;
            }
            else
            {
                return false;
            }
        }
        /*public static bool PandQ(bool p, bool q, ref string Re)
        {
            bool a = (p && q);
            if (a)
            {
                Re = "p";
                return true;
            }
            else
                return false;
        }*/
        /*public static bool PorQandnotPgivesQ(bool p, bool q, ref string Re)
        {
            bool a = (p || q) && (!p);
            if (a)
            {
                Re = "q";
                return true;
            }
            else
                return false;
        }*/
        public static bool PQandPgivesQgivesRisR(bool p, bool q, bool r, ref string Re)
        {
            bool a = (p && q) && (((!p) || ((!q) || r)));
            if (a)
            {
                Re = "r";
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PgivesQandQgivesRisPOrQgivesR(bool p, bool q, bool r, ref string Re)
        {
            bool a = ((!p) || q) && ((!q) || r);
            if (a)
            {
                Re = "p||q->r";
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PgivesQandRgivesSandPorRIsQorS(bool p, bool q, bool r, bool s, ref string Re)
        {
            bool a = ((!p) || q) && ((!r) || s) && (p || r);
            if (a)
            {
                Re = "q||s";
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PgivesQandRgivesSandnotPornotRIsnotPornotQ(bool p, bool q, bool r, bool s, ref string Re)
        {
            bool a = ((!p) || q) && ((!r) || s) && ((!q) || (!!s));
            if (a)
            {
                Re = "!p||!q";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
