/*********************************************************************************************************************************************************
 * Ramin Edjlal CopyRight 2017 http://edjlal.sellfile.ir**************************************************************************************************
 * The Information on Handling Controls and Variable Misleading*******************************************************************************************(+)
 * User Interface Drawing Objects Color side Misleading.**************************************************************************************************(+)
 * Some Movemnts have Illegal Movment Move.***************************************************************************************************************(+)
 * Thinking and User Interface Mechansiam Leading to Mislead.*********************************************************************************************{+}
 * MalFunction to Knowledge of static definition of UserControls due to variable count.*******************************************************************{+}
 * Virtuallization of Graphics is Not Valid.**************************************************************************************************************<+>
 * Thinking is Correct but virtualization on hitting is misleading.***************************************************************************************<+>
 * Mouse Event Handling Error.****************************************************************************************************************************<+>
 * When is Order of Person Thinking is Occured.***********************************************************************************************************<+>
 * Different Graphics Load Situation is in One Table State.***********************************************************************************************<+>
 * Program Work Without Loading Virtuallization.**********************************************************************************************************<+>
 * Moving QC_OK. Table Content Load Misleading.***********************************************************************************************************(+)
 * Table Virtualization Initiatating Misleading.**********************************************************************************************************(+)
 * Program Variable Content Misleading.*******************************************************************************************************************(+)
 * Program Controls ucc Arrangments by uc Adding Misleading.**********************************************************************************************(+)
 * All Virtuallization Exept Thinking is Correct.*********************************************************************************************************
 * Soldeir Conversion Not Work.***************************************************************************************************************************
 * *******************************************************************************************************************************************************
 * *******************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Media;
using System.Web.UI.WebControls;

namespace WebApplicationRefregitzTow
{

    public partial class _Default : Page
    {
        public static bool First = true;
        public static Control uc;
        //public static Controls_CBC ucc;
        public static int No = 0;
         public _Default()
        {
            PlaceHolder1 = new PlaceHolder();
            Label2 = new Label();
           // Iniziate();
        }
        public void Iniziate()
        {
           WebApplicationRefregitzTow._Default.uc = (Control)Page.LoadControl("Controls_CBC.ascx");
           // WebApplicationRefregitzTow._Default.ucc = new WebApplicationRefregitzTow.Controls_CBC();
            //uc.ID = "AddBPOP";
           // ucc.Controls.Add(uc);

            /*                for (int i = 0; i < 8; i++)
                                for (int j = 0; j < 8; j++)
                                {
                                    string ctrlName = "Image" + ((i*8+j) + 1).ToString();
                                    string ctrlNameP = "Panel" + ((i*8+j) + 1).ToString();
                                    string ctrlNameC = "CheckBox" + ((i*8+j) + 1).ToString();

                                    Control c = uc.FindControl(ctrlName);
                                    Control cP = uc.FindControl(ctrlNameP);
                                    Control cC = uc.FindControl(ctrlNameC);
                                    ucc.Controls.Add(c);
                                    ucc.Controls.Add(cP);
                                    ucc.Controls.Add(cC);
                                }
              */
        }
        public void AddBPOP()
        {//
           // PlaceHolder1.Controls.Clear();
           // PlaceHolder1.Controls.Add(uc);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            //Inizialization();
            RefrigtzW.FormRefrigtz.ArrangmentsChanged = true;
            RefrigtzW.FormRefrigtz.Blitz = true;

            if (First)
            {
                RefrigtzW.FormRefrigtz t = new RefrigtzW.FormRefrigtz(false);
                if (!System.IO.File.Exists(Server.MapPath(@"~/Database\\CurrentBank.accdb").ToLower()))
                {
                    System.IO.File.Copy(Server.MapPath(@"~/Database\\MainBank\\ChessBank.accdb"), Server.MapPath(@"~/Database\\CurrentBank.accdb"));
                    t.CreateConfigurationTable();
                    t.InsertTableAtDataBase(RefrigtzW.FormRefrigtz.Table);
                    // RefrigtzW.FormRefrigtz.MovmentsNumber++;
                    RefrigtzW.AllDraw.TableListAction.Clear();
                    RefrigtzW.AllDraw.TableListAction.Add(RefrigtzW.FormRefrigtz.Table);
                }
                System.Threading.Thread tt = new System.Threading.Thread(new System.Threading.ThreadStart(t.Load));
                tt.Start();
                while (!RefrigtzW.FormRefrigtz.ReadF) ;
                PlaceHolder1_Load(sender, e);
                First = false;

            }
            bool? addBPOP = ViewState["AddBPOP"] as bool?;
            if (addBPOP.HasValue && addBPOP.Value)
            {
                AddBPOP();
            }
        }

       /* public void Inizialization()
        {
            Control lblMove = uc.FindControl("lblMove");
            Control lblMove1 = uc.FindControl("lblMove1");
            Control lblMove2 = uc.FindControl("lblMove2");
            ucc.lblMove = (Label)lblMove;
            ucc.lblMove1 = (Label)lblMove1;
            ucc.lblMove2 = (Label)lblMove2;

            // ucc.LoadStart();
            //do
            //  {


            int[,] Tab = new int[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    Tab[i, j] = RefrigtzW.FormRefrigtz.Table[i, j];

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    string ctrlName = "Image" + ((i * 8 + j) + 1).ToString();
                    string ctrlNameP = "Panel" + ((i * 8 + j) + 1).ToString();
                    string ctrlNameC = "CheckBox" + ((i * 8 + j) + 1).ToString();

                    Control c = uc.FindControl(ctrlName);
                    Control cP = uc.FindControl(ctrlNameP);
                    Control cC = uc.FindControl(ctrlNameC);
                    if (c != null)
                    {
                        try
                        {
                            ucc.Controls.Add(c);
                            ucc.Controls.Add(cP);
                            ucc.Controls.Add(cC);
                        }

                        catch (Exception t)
                        {
                        }
                    }


                    //((CheckBox)cC).AutoPostBack = true;
                }

        }
        */ 
        public void Setucc(int C, string ChessImage, bool V)
        {
            /*if (C == 1)
                ucc.Image1.ImageUrl = ChessImage;
            else
                if (C == 2)
                    ucc.Image2.ImageUrl = ChessImage;
            if (C == 3)
                ucc.Image3.ImageUrl = ChessImage;
            if (C == 4)
                ucc.Image4.ImageUrl = ChessImage;
            if (C == 5)
                ucc.Image5.ImageUrl = ChessImage;
            if (C == 6)
                ucc.Image6.ImageUrl = ChessImage;
            if (C == 7)
                ucc.Image7.ImageUrl = ChessImage;
            if (C == 8)
                ucc.Image8.ImageUrl = ChessImage;
            if (C == 9)
                ucc.Image9.ImageUrl = ChessImage;
            if (C == 10)
                ucc.Image10.ImageUrl = ChessImage;
            if (C == 11)
                ucc.Image11.ImageUrl = ChessImage;
            if (C == 12)
                ucc.Image12.ImageUrl = ChessImage;
            if (C == 13)
                ucc.Image13.ImageUrl = ChessImage;
            if (C == 14)
                ucc.Image14.ImageUrl = ChessImage;
            if (C == 15)
                ucc.Image15.ImageUrl = ChessImage;
            if (C == 16)
                ucc.Image16.ImageUrl = ChessImage;
            if (C == 17)
                ucc.Image17.ImageUrl = ChessImage;
            if (C == 18)
                ucc.Image18.ImageUrl = ChessImage;
            if (C == 19)
                ucc.Image19.ImageUrl = ChessImage;
            if (C == 20)
                ucc.Image20.ImageUrl = ChessImage;
            if (C == 21)
                ucc.Image21.ImageUrl = ChessImage;
            if (C == 22)
                ucc.Image22.ImageUrl = ChessImage;
            if (C == 23)
                ucc.Image23.ImageUrl = ChessImage;
            if (C == 24)
                ucc.Image14.ImageUrl = ChessImage;
            if (C == 25)
                ucc.Image25.ImageUrl = ChessImage;
            if (C == 26)
                ucc.Image26.ImageUrl = ChessImage;
            if (C == 27)
                ucc.Image27.ImageUrl = ChessImage;
            if (C == 28)
                ucc.Image28.ImageUrl = ChessImage;
            if (C == 29)
                ucc.Image29.ImageUrl = ChessImage;
            if (C == 30)
                ucc.Image30.ImageUrl = ChessImage;
            if (C == 31)
                ucc.Image32.ImageUrl = ChessImage;
            if (C == 33)
                ucc.Image33.ImageUrl = ChessImage;
            if (C == 34)
                ucc.Image34.ImageUrl = ChessImage;
            if (C == 35)
                ucc.Image35.ImageUrl = ChessImage;
            if (C == 36)
                ucc.Image36.ImageUrl = ChessImage;
            if (C == 37)
                ucc.Image37.ImageUrl = ChessImage;
            if (C == 38)
                ucc.Image38.ImageUrl = ChessImage;
            if (C == 39)
                ucc.Image39.ImageUrl = ChessImage;
            if (C == 40)
                ucc.Image40.ImageUrl = ChessImage;
            if (C == 41)
                ucc.Image41.ImageUrl = ChessImage;
            if (C == 42)
                ucc.Image42.ImageUrl = ChessImage;
            if (C == 43)
                ucc.Image43.ImageUrl = ChessImage;
            if (C == 44)
                ucc.Image44.ImageUrl = ChessImage;
            if (C == 45)
                ucc.Image45.ImageUrl = ChessImage;
            if (C == 46)
                ucc.Image46.ImageUrl = ChessImage;
            if (C == 47)
                ucc.Image47.ImageUrl = ChessImage;
            if (C == 48)
                ucc.Image48.ImageUrl = ChessImage;
            if (C == 49)
                ucc.Image49.ImageUrl = ChessImage;
            if (C == 50)
                ucc.Image50.ImageUrl = ChessImage;
            if (C == 51)
                ucc.Image51.ImageUrl = ChessImage;
            if (C == 52)
                ucc.Image52.ImageUrl = ChessImage;
            if (C == 53)
                ucc.Image53.ImageUrl = ChessImage;
            if (C == 54)
                ucc.Image54.ImageUrl = ChessImage;
            if (C == 55)
                ucc.Image55.ImageUrl = ChessImage;
            if (C == 56)
                ucc.Image56.ImageUrl = ChessImage;
            if (C == 57)
                ucc.Image57.ImageUrl = ChessImage;
            if (C == 58)
                ucc.Image58.ImageUrl = ChessImage;
            if (C == 59)
                ucc.Image59.ImageUrl = ChessImage;
            if (C == 60)
                ucc.Image60.ImageUrl = ChessImage;
            if (C == 61)
                ucc.Image61.ImageUrl = ChessImage;
            if (C == 62)
                ucc.Image62.ImageUrl = ChessImage;
            if (C == 63)
                ucc.Image63.ImageUrl = ChessImage;
            if (C == 64)
                ucc.Image64.ImageUrl = ChessImage;
             */
          /*  string ctrlName = "Image" + C.ToString();
            string ctrlNameP = "Panel" + C.ToString();
            string ctrlNameC = "CheckBox" + C.ToString();

            Control c = ucc.FindControl(ctrlName);
            Control cP = ucc.FindControl(ctrlNameP);
            Control cC = ucc.FindControl(ctrlNameC);
            try
            {
                ((Image)c).ImageUrl = ChessImage;
                ((Panel)cP).Visible = V;
                ((CheckBox)cC).Checked = V;
            }
            catch (Exception)
            {
            }



           
           */ 
        }

        
        public void LoadPlaceHolder()
        {
        //    if (!RefrigtzW.FormRefrigtz.ReadF)
          //      while (!RefrigtzW.FormRefrigtz.LoadPlaceHolder && !RefrigtzW.FormRefrigtz.ReadF) ;
            //else
            //{
              //  System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(UserControlLoad));
               // t.Start();
                //while (!RefrigtzW.FormRefrigtz.LoadPlaceHolder) ;
           // }

            Iniziate();
            try
            {
                if (uc != null)
                {
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(uc);
                }

            }
            catch (Exception t)
            {
            }
            RefrigtzW.FormRefrigtz.LoadPlaceHolder = false;
        }
        public void PlaceHolder1_Load(object sender, EventArgs e)
        {
            if (RefrigtzW.FormRefrigtz.OrderPlate == 1)
                Label2.Text = "Do Somthing.";
            else
                Label2.Text = "Thinking...";            //System.Threading.Thread ttt = new System.Threading.Thread(new System.Threading.ThreadStart(LoadPlaceHolder));
            //ttt.Start();
            LoadPlaceHolder();

        }
        public void PlaceHolder1_UnLoad(object sender, EventArgs e)
        {

            //System.Threading.Thread ttt = new System.Threading.Thread(new System.Threading.ThreadStart(LoadPlaceHolder));
            //ttt.Start();


        }

        protected void Label2_Load(object sender, EventArgs e)
        {

        }

        protected void PlaceHolder1_Disposed(object sender, EventArgs e)
        {

        }

       


    }
}
