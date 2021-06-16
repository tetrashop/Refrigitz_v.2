/***********************************************************************************
 * Ramin Edjlal*********************************************************************
 CopyRighted 1398/0802**************************************************************
 TetraShop.Ir***********************************************************************
 ***********************************************************************************/
using GalleryStudio;
using ImageTextDeepLearning;
using System;
using System.IO;


namespace Refrigtz
{
    [Serializable]
    internal
    //Main class od serialization
    class TakeRoot
    {
        //Constructed
        public TakeRoot() { }
        //Load 
        public AllKeyboardOfWorld Load(string AllKeyboardOfWorldKindString)
        {
            //Create deserilized constructor object
            AllKeyboardOfWorldMemmoty tr = new AllKeyboardOfWorldMemmoty();
            //Load Middle Targets.
            try
            {
                //when file exist
                if (File.Exists(AllKeyboardOfWorldKindString))
                {

                    //load
                    tr.Load(AllKeyboardOfWorldKindString);
                    //when successfull
                    if (tr.Current != null)
                    {
                        System.Windows.Forms.MessageBox.Show("Load Completed.");
                    }
                    //delete file
                    File.Delete(AllKeyboardOfWorldKindString);
                }
            }
            catch (Exception) { }
            return tr.Current;
        }
        //save main file
        public bool Save(AllKeyboardOfWorld Curent, string AllKeyboardOfWorldKindString
            )
        {

            try
            {
                //when there is not file
                if (!File.Exists(AllKeyboardOfWorldKindString))
                {
                    //Create constructor object
                    AllKeyboardOfWorldMemmoty rt = new AllKeyboardOfWorldMemmoty
                    {
                        //assign main object
                        Current = Curent
                    };
                    //write on disk
                    rt.RewriteAllKeyboardOfWorld(AllKeyboardOfWorldKindString);
                }
                else//when there is
                      if (File.Exists(AllKeyboardOfWorldKindString))
                {
                    //delete existence file on disk
                    File.Delete(AllKeyboardOfWorldKindString);
                    //create constructor object
                    AllKeyboardOfWorldMemmoty rt = new AllKeyboardOfWorldMemmoty
                    {
                        //Assign main object
                        Current = Curent
                    };
                    //write on disk
                    rt.RewriteAllKeyboardOfWorld(AllKeyboardOfWorldKindString);
                }
                //when there is no exeption return successfull
                return true;
            }
            catch (Exception)
            {
                //when there is exeption return unsuccessfull
                return false;
            }
        }
    }
}
