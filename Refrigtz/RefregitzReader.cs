using System;
using System.Collections.Generic;
namespace RefregitzReader
{
    [Serializable]
    class RefregitzReader
    {
        //#pragma warning disable CS0169 // The field 'RefregitzReader.Item' is never used
        List<String> Item;
        //#pragma warning restore CS0169 // The field 'RefregitzReader.Item' is never used
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

