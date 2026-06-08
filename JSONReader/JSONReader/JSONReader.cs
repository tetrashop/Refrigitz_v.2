using System;
using System.Collections.Generic;
using System.IO;

namespace JSONReader
{
    class JSONReader
    {
        String Read;
        List<String> Item;
        public List<SearchGoogle> ItemSearch;
        public bool OKResult = false;
        public JSONReader(String Path)
        {
            Item = new List<String>();
            Read = File.ReadAllText(Path);
            if (ReadJSON())
            {
                if (!ConvertToSearchGooleItem())
                    System.Windows.Forms.MessageBox.Show("خطای خوادن رشته2 ");
                else
                    OKResult = true;
            }
            else
                System.Windows.Forms.MessageBox.Show(" 1خطای خوادن رشته");
        }
        private DateTime ConvertJsonStringToDateTime(string jsonTime)
        {
            DateTime A = new DateTime();
            A = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(System.Convert.ToDouble(jsonTime) / 1000).ToLocalTime();
            return A;
        }

        bool ReadJSON()
        {
            bool OK = false;
            try
            {
                while (Read != "")
                {
                    String Dummy = Read;
                    Item.Add(Read.Substring(0, Read.IndexOf("}}") + 2));
                    Read = Read.Remove(0, Read.IndexOf(",") + 1);
                    if (Dummy == Read)
                        Read = "";

                }
                OK = true;
            }
            catch (Exception t)
            {
                OK = false;
            }

            return OK;
        }
        bool ConvertToSearchGooleItem()
        {

            bool OK = false;
            try
            {
                ItemSearch = new List<SearchGoogle>();
                int Len = 0;
                int LenDum = 0;
                String DummyA = "";
                while (Len < Item.Count)
                {
                    try
                    {
                        Read = Item[Len];
                        Read = Read.Remove(0, Read.IndexOf("c") + 4);
                        ItemSearch.Add(new SearchGoogle());
                        ItemSearch[LenDum].timestamp_usec = ConvertJsonStringToDateTime(Read.Substring(0, Read.IndexOf("\"")));
                        Read = Read.Remove(0, Read.IndexOf(":") + 2);
                        ItemSearch[LenDum].query_text = (Read.Substring(0, Read.IndexOf("\"")));
                        Len += 2;
                        LenDum++;
                    }
                    catch (Exception t)
                    {
                        try
                        {
                            DummyA = Read;
                            ItemSearch[LenDum].timestamp_usec = ConvertJsonStringToDateTime(Read.Substring(0, Read.IndexOf("\"")));
                            Read = Read.Remove(0, Read.IndexOf(":") + 2);
                            ItemSearch[LenDum].query_text = (Read.Substring(0, Read.IndexOf("\"")));
                            Len++;
                            LenDum++;
                        }
                        catch (Exception tt)
                        {
                            if (DummyA == Read)
                            {
                                Read = "";
                                Len++;
                            }
                        }
                    }
                }
                OK = true;
            }
            catch (Exception t)
            {
                System.Windows.Forms.MessageBox.Show(t.ToString());
                OK = false;
            }
            return OK;
        }

    }
}

