using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace RefregitzReader
{
    [Serializable]
    class RefregitzReader
    {
        List<String> Item;
        //public List<SearchGoogle> ItemSearch;
        public bool OKResult = false;
        public RefregitzReader(String Path)
        {

        }
        public DateTime ConvertRefregitzStringToDateTime(string RefregitzTime)
        {

            DateTime A = new DateTime();
            A = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(System.Convert.ToDouble(RefregitzTime) / 1000).ToLocalTime();
            return A;

        }

    }
}

