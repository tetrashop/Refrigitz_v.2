/**************************************************************************************************************
 * Ramin Edjlal Copyright 1397/04/20 **************************************************************************
 * 1397/04/26:Problem in Seirlization Recurisvely of linked list for refrigitz.********************************
 * ************************************************************************************************************
 */
using ImageTextDeepLearning;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace GalleryStudio
{
    //clas for store in file
    [Serializable]
    internal class AllKeyboardOfWorldMemmoty
    {

        //initiate global vars
        public AllKeyboardOfWorld Current = null;

        //Constructor
        public AllKeyboardOfWorldMemmoty()
        {

        }


        //async rewite on file
        private void RewriteAllDrawRec(BinaryFormatter Formatters, FileStream DummyFileStream)
        {
            object o = new object();
            lock (o)
            {
                //when exist
                if (Current != null)
                {
                    //serilized to write
                    //Current.Clone(AllDrawCurrentAccess);
                    Formatters.Serialize(DummyFileStream, this);

                }
            }
        }

        //write on disk main
        public void RewriteAllKeyboardOfWorld(string SAllKeyboardOfWorld)
        {
            object oo = new object();
            lock (oo)
            {
                //initiate and call
                FileStream DummyFileStream = null;
                FileInfo DummyFileInfo = new FileInfo(SAllKeyboardOfWorld);
                DummyFileInfo.Delete();
                DummyFileStream = new FileStream(SAllKeyboardOfWorld, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
                BinaryFormatter Formatters = new BinaryFormatter();
                DummyFileStream.Seek(0, SeekOrigin.Begin);
                RewriteAllDrawRec(Formatters, DummyFileStream);
                DummyFileStream.Flush(); DummyFileStream.Close();
            }
        }

        //Load main
        public AllKeyboardOfWorld Load(string SAllKeyboardOfWorld)
        {
            object o = new object();
            lock (o)
            {
                //initiate and call
                FileStream DummyFileStream = new FileStream(SAllKeyboardOfWorld, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
                BinaryFormatter Formatters = new BinaryFormatter();

                Current = LoadrEC(DummyFileStream, Formatters);

                DummyFileStream.Flush();
                DummyFileStream.Close();

                return Current;
            }
        }
        //Load
        public AllKeyboardOfWorld LoadrEC(FileStream DummyFileStream, BinaryFormatter Formatters)
        {
            //Local vars
            AllKeyboardOfWorld Dummy = null;
            object o = new object();
            lock (o)
            {
                //begin
                DummyFileStream.Seek(0, SeekOrigin.Begin);
                //while exist
                while (DummyFileStream.Position < DummyFileStream.Length)
                {
                    //load on deserialized
                    Dummy = (AllKeyboardOfWorld)Formatters.Deserialize(DummyFileStream);
                }

                return Dummy;

            }
        }
    }
}
