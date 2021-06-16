using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Refrigtz
{
    [Serializable]
    public static class TakeRoot
    {
        static AllDraw Node = null;
        //  POINTER IS THE MEMMERY LOCATION OF LAST MOVMENTS.
        public static AllDraw Pointer=null;
        
        public static void CalculateRootGray(AllDraw Curent)
        {
            try
            {
                if (Node != null)
                {
                    if (Node.Dept != null)
                        Pointer.Dept = Curent;
                    else
                        Node.Dept = Curent;
                }
                else
                    Node = Curent;
            }
            catch (Exception tt)
            {
                return;
            }
            return;
        }
       
    }
}
