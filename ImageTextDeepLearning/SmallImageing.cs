using System;
using System.Collections.Generic;
using System.Drawing;
//#pragma warning disable CS0105 // The using directive for 'System.Threading.Tasks' appeared previously in this namespace
//#pragma warning restore CS0105 // The using directive for 'System.Threading.Tasks' appeared previously in this namespace
namespace ImageTextDeepLearning
{
    //Splitation and conjunction class
    internal class SmallImageing
    {
        //Initiate global vars
        public int i = 0, j = 0;
        public Image Root = null;
        public Image RootConjuction = null;
        public int index = -1, RootWidth = -1, RootHeight = -1, PiceX = -1, PiceY = -1;
        public List<Image> imgarray = null;
        public List<int[]> imgarrayindex = new List<int[]>();
        public bool Splited = false, Conjucted = false;
        public bool SplitedBegin = false, ConjuctedBegin = false;
        //Constructor
        public SmallImageing(Image Roo, int PicX = 1, int PicY = 1)
        {
            Root = Roo;
            RootWidth = Root.Width;
            RootHeight = Root.Height;
            PiceX = PicX;
            PiceY = PicY;
            //Splitation(PiceX, PiceY);
        }
        //Split image to each pixel
        public bool Splitation(System.Windows.Forms.PictureBox d)
        {
            try
            {
                //when is ready
                if (Root != null)
                {
                    //initiate...
                    SplitedBegin = true;
                    ConjuctedBegin = false;
                    imgarray = new List<Image>();
                    index = 0;
                    //for every width
                    //Parallel.For(0, Root.Width, i =>
                    for (i = 0; i < Root.Width; i += PiceX)
                    {
                        //for every height
                        //Parallel.For(0, Root.Height, j =>
                        for (j = 0; j < Root.Height; j += PiceY)
                        {
                            object O = new object();
                            lock (O)
                            {
                                //create a image of picex and picey to an image
                                imgarray.Add(new Bitmap(PiceX, PiceY));
                                //increase
                                index++;
                                //write pices to an empty image
                                Graphics graphics = Graphics.FromImage(imgarray[imgarray.Count - 1]);
                                graphics.DrawImage(Root, new Rectangle(0, 0, PiceX, PiceY), new Rectangle(i, j, PiceX, PiceY), GraphicsUnit.Pixel);
                                graphics.Dispose();
                                //show image on main picture box
                                d.BackgroundImage = imgarray[imgarray.Count - 1];
                                d.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                                d.Refresh();
                                d.Update();
                                //add index
                                int[] a = new int[2];
                                a[0] = i;
                                a[1] = j;
                                imgarrayindex.Add(a);
                            }
                        }//);
                    }//);
                    //set
                    Splited = true;
                    Conjucted = false;
                }
                else//when is not ready return unssuccessfull
                {
                    return false;
                }
            }
            catch (Exception)
            {
                //when is exeption return unsuccessfull
                return false;
            }
            //return successfull
            return true;
        }
        //Conjunction
        public bool Conjunction(System.Windows.Forms.PictureBox d, System.Windows.Forms.PictureBox b)
        {
            try
            {
                //when is splited
                if (Splited)
                {
                    //initiate...
                    ConjuctedBegin = true;
                    SplitedBegin = false;
                    RootConjuction = new Bitmap(RootWidth, RootHeight);
                    index = imgarray.Count;
                    //for evey items of list
                    //Parallel.For(0, index, i =>
                    for (i = 0; i < index; i++)
                    {
                        object O = new object();
                        lock (O)
                        {
                            //create graphics of main empty image
                            Graphics graphics = Graphics.FromImage(RootConjuction);
                            //store index
                            int k = imgarrayindex[i][0];
                            int p = imgarrayindex[i][1];
                            //write picess on main image
                            graphics.DrawImage(imgarray[i], new Rectangle(k, p, PiceX, PiceY), new Rectangle(0, 0, RootWidth, RootHeight), GraphicsUnit.Pixel);
                            //Assign and prepair
                            d.BackgroundImage = imgarray[i];
                            d.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            d.Refresh();
                            d.Update();
                            b.BackgroundImage = RootConjuction;
                            b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                            b.Refresh();
                            b.Update();
                            graphics.Dispose();
                        }
                    }//);
                    //initiate
                    Conjucted = true;
                    Splited = false;
                    imgarray.Clear();
                }
                else//when is not ready return unsuccessfull
                {
                    return false;
                }
            }
            catch (Exception)
            {
                //when there is an exeption return unsuccessfull
                return false;
            }
            //return successfull
            return true;
        }
    }
}
