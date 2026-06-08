using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryStudio
{
    [Serializable]
    public class Photo
    {
        Int32   PhotoNumber = new Int32();
        String  PhotoName   = null;
        Boolean PhotoType   = new Boolean();
        public Photo()
        { 
        }
        public Int32 PhotoNumberAccsess
        {
            get
            {
                return PhotoNumber;
            }
            set
            {
            PhotoNumber=value;
            }
        }
        public String PhotoNameAccess
        {
            get {
                return PhotoName;

            }
            set 
            {
                PhotoName = value;
            }
        }
        public Boolean PhotoTypeAccess
        {
            get 
            {
                return PhotoType;
            }
            set 
            {
                PhotoType = value;
            }
        }
    }
}
