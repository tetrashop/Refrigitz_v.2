using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace GalleryStudio
{
    class RefregitzOperator
    {
        string SAllDraw = "AllDraw.asd";
         public void RewriteCusomers(RefregizMemmory p)
        {
            FileStream DummyFileStream = null;
            try
            {
                RefregizMemmory t = p.CustomersNodeAccess;
                FileInfo DummyFileInfo = new FileInfo(SAllDraw);
                DummyFileInfo.Delete();
                DummyFileStream = new FileStream(SAllDraw, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
                BinaryFormatter Formatters = new BinaryFormatter();
                DummyFileStream.Seek(0, SeekOrigin.Begin);
                while (t != null)
                {
                    Formatters.Serialize(DummyFileStream, t.CustomersCurrentAccess);
                    t = t.CustomersNextAccess;
                }
                DummyFileStream.Close();
            }
            catch (NullReferenceException o)
            {
                Console.WriteLine(o.Message.ToString());
            }
            catch (IOException o)
            {
                Console.WriteLine(o.Message.ToString());
            }

        }
        public Customers GetRefregiz(int No)
        {
            FileStream DummyFileStream = null;
            DummyFileStream = new FileStream(SAllDraw, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
            int p = 0;
            Customers Dummy = null;
            BinaryFormatter Formatters = new BinaryFormatter();
            DummyFileStream.Seek(0, SeekOrigin.Begin);
            try
            {
                while (p <= No)
                {
                    if (DummyFileStream.Length >= DummyFileStream.Position)
                        Dummy = (Customers)Formatters.Deserialize(DummyFileStream);
                    else
                        Dummy = null;
                    p++;
                }
                DummyFileStream.Flush(); DummyFileStream.Close();
            }
            catch (SerializationException t)
            {
                Console.WriteLine(t.Message.ToString());
                Dummy = null;
            }
            return Dummy;
        }
        
    }
}
