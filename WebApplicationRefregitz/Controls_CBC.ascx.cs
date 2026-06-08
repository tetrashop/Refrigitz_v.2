//
//   Class writen by GIDEON LOUW   (MCSD)
//   You can reuse the code as you wish
//   If you want to keep the above you are welcome
//   If you modify it and add additional code - please send me copy too - gideonlouw@hotmail.com
//   Thank you..
//
//
//
//   Number Relations
//   1 = a8
//   2 = b8
//   3 = c8
//   4 = d8
//   5 = e8
//   6 = f8
//   7 = g8
//   8 = h8
//   9 = a7
//   10= b7
//   11= c7
//   12= d7
//   13= e7
//   14= f7
//   15= g7
//   16= h7
//   17= a6
//   18= b6
//   19= c6
//   20= d6
//   21= e6
//   22= f6
//   23= g6
//   24= h6
//   25= a5
//   26= b5
//   27= c5
//   28= d5
//   29= e5
//   30= f5
//   31= g5
//   32= h5
//   33= a4
//   34= b4
//   35= c4
//   36= d4
//   37= e4
//   38= f4
//   39= g4
//   40= h4
//   41= a3
//   42= b3
//   43= c3
//   44= d3
//   45= e3
//   46= f3
//   47= g3
//   48= h3
//   49= a2
//   50= b2
//   51= c2
//   52= d2
//   53= e2
//   54= f2
//   55= g2
//   56= h2
//   57= a1
//   58= b1
//   59= c1
//   60= d1
//   61= e1
//   62= f1
//   63= g1
//   64= h1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RefrigtzW;
namespace WebApplicationRefregitzTow
{
    public partial class Controls_CBC : System.Web.UI.UserControl
    {
        /*;
        */
        public static int MouseClicked = 0;
        public static int CurrentClickedNumber;
        public static bool Found = false;
        public static Control _1 = null;
        public static Control _2 = null;
        public double MaxHuristicxT = Double.MinValue;
        public bool MovementsAStarGreedyHuristicFound = false;
        public bool IIgnoreSelfObjects = false;
        public bool UsePenaltyRegardMechnisam = true;
        public bool BestMovments = false;
        public bool PredictHuristic = true;
        public bool OnlySelf = false;
        public bool AStarGreedyHuristic = false;

        bool ArrangmentsChanged = true;
        System.Threading.Thread t;
        /// <summary>
        /// recursively finds a child control of the specified parent.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Control FindControlRecursive(string id)
        {
            if (this == null) return null;
            //try to find the control at the current level
            Control ctrl = this.FindControl(id);

            if (ctrl == null)
            {
                //search the children
                foreach (Control child in this.Controls)
                {
                    ctrl = this.FindControlRecursive(id);

                    if (ctrl != null) break;
                }
            }
            return ctrl;
        }

        void SetLoadUserControl()
        {
            do
            {
                while (!WebApplicationRefregitzTow.Controls_CBC.Found) ;
                UserControlLoad();
            } while (true);
        }
        public void CheckData(int CheckBoxNr, string BlockNumber, bool Checked)
        {


            string ChessImage = "";
            //lblErr.Text = "Checking data.."

            //NoMove = Set to FirstMove
            //FirstMove = Move already took place = set to No Move

            if (lblMove1.Text == "NoMove")
            {

                //Set the hidden variables
                lblMove.Text = CheckBoxNr.ToString();
                lblMove1.Text = "FirstMove";


            }
            else
            {

                //Must Move now
                int MoveTo = 0;
                MoveTo = CheckBoxNr;

                int MoveFrom = 0;
                MoveFrom = System.Convert.ToInt32(lblMove.Text);

                if (MoveTo == MoveFrom)
                {
                    //No Move Take Place
                    goto EndSection;
                }

                if (MoveTo != 0)
                {
                    if (FormRefrigtz.OrderPlate == 1)
                    {
                        int Row1 = (MoveFrom - 1) % 8;
                        int Column1 = (MoveFrom - 1) / 8;
                        int Row2 = (MoveTo - 1) % 8;
                        int Column2 = (MoveTo - 1) / 8;
                        System.Drawing.Color A = System.Drawing.Color.Gray;
                        if (FormRefrigtz.OrderPlate == -1)
                            A = System.Drawing.Color.Brown;
                        if ((Column1 == Column2) && (Row1 == Row2 - 2))
                        {



                            if ((new ChessRules(MovementsAStarGreedyHuristicFound,IIgnoreSelfObjects,UsePenaltyRegardMechnisam,BestMovments,PredictHuristic,OnlySelf,AStarGreedyHuristic,ArrangmentsChanged,7, FormRefrigtz.Table, FormRefrigtz.OrderPlate, Row1, Column1)).Rules(Row1, Column1, Row2, Column2, A, 7))
                            {

                                FormRefrigtz.Table[Row1 - 2, Column1] = FormRefrigtz.Table[Row1, Column1];
                                FormRefrigtz.Table[Row1 - 1, Column1] = FormRefrigtz.Table[Row1, 7];
                                FormRefrigtz.Table[Row1, 7] = 0;
                                MouseClicked++;
                                Found = true;
                            }
                            else
                                MouseClicked = 0;

                        }

                        else if ((Column1 == Column2) && (Row1 == Row2 + 2))
                        {
                            if ((new ChessRules(MovementsAStarGreedyHuristicFound,IIgnoreSelfObjects,UsePenaltyRegardMechnisam,BestMovments,PredictHuristic,OnlySelf,AStarGreedyHuristic,ArrangmentsChanged,-7, FormRefrigtz.Table, FormRefrigtz.OrderPlate, Row1, Column1)).Rules(Row1, Column1, Row2, Column2, A, -7))
                            {
                                FormRefrigtz.Table[Row1 + 2, Column1] = FormRefrigtz.Table[Row1, Column1];
                                FormRefrigtz.Table[Row1 + 3, Column1] = FormRefrigtz.Table[Row1, 0];
                                FormRefrigtz.Table[Row1, 0] = 0;
                                MouseClicked++;
                                Found = true;
                            }
                        }
                        else
                        {
                            if ((new ChessRules(MovementsAStarGreedyHuristicFound,IIgnoreSelfObjects,UsePenaltyRegardMechnisam,BestMovments,PredictHuristic,OnlySelf,AStarGreedyHuristic,ArrangmentsChanged,FormRefrigtz.Table[Row1, Column1], FormRefrigtz.Table, FormRefrigtz.OrderPlate, Row1, Column1)).Rules(Row1, Column1, Row2, Column2, A, FormRefrigtz.Table[Row1, Column1]))
                            {
                                ThingsConverter t = new ThingsConverter();
                                t.ConvertOperation(Row2, Column2, A, FormRefrigtz.Table, FormRefrigtz.OrderPlate, false, 0);
                                if (t.Convert)
                                {
                                    int Hit = FormRefrigtz.Table[Row2, Column2];
                                    bool HitVal = false;
                                    if (Hit != 0)
                                        HitVal = true;

                                    FormRefrigtz.Table[Row1, Column1] = 0;
                                    if (t.ConvertedToMinister)
                                        FormRefrigtz.Table[Row2, Column2] = 5;
                                    else if (t.ConvertedToBridge)
                                        FormRefrigtz.Table[Row2, Column2] = 4;
                                    else if (t.ConvertedToHourse)
                                        FormRefrigtz.Table[Row2, Column2] = 3;
                                    else if (t.ConvertedToElefant)
                                        FormRefrigtz.Table[Row2, Column2] = 2;                                   
                                }                               
                                else
                                {
                                    FormRefrigtz.Table[Row2, Column2] = FormRefrigtz.Table[Row1, Column1];
                                    FormRefrigtz.Table[Row1, Column1] = 0;
                                    MouseClicked++;
                                    Found = true;
                                }
                            }
                        }
                    }
                }
            //*****************************************
            //               TODO:
            //Now add a procedure to do the validation of the move
            //The logic example castling or see if valid move, etc
            //
            //*****************************************
            //   PROCEDUREVALIDATEMOVE(MoveFrom,MoveTo)

    BeginSection:


                //Move From Section
                switch (MoveFrom)
                {
                    case 1:

                        ChessImage = System.Convert.ToString(Image1.ImageUrl);
                        Panel1.Visible = false;
                        break;

                    case 2:

                        ChessImage = System.Convert.ToString(Image2.ImageUrl);
                        Panel2.Visible = false;
                        break;

                    case 3:

                        ChessImage = System.Convert.ToString(Image3.ImageUrl);
                        Panel3.Visible = false;
                        break;

                    case 4:

                        ChessImage = System.Convert.ToString(Image4.ImageUrl);
                        Panel4.Visible = false;
                        break;

                    case 5:

                        ChessImage = System.Convert.ToString(Image5.ImageUrl);
                        Panel5.Visible = false;
                        break;

                    case 6:

                        ChessImage = System.Convert.ToString(Image6.ImageUrl);
                        Panel6.Visible = false;
                        break;

                    case 7:

                        ChessImage = System.Convert.ToString(Image7.ImageUrl);
                        Panel7.Visible = false;
                        break;

                    case 8:

                        ChessImage = System.Convert.ToString(Image8.ImageUrl);
                        Panel8.Visible = false;
                        break;

                    case 9:

                        ChessImage = System.Convert.ToString(Image9.ImageUrl);
                        Panel9.Visible = false;
                        break;

                    case 10:

                        ChessImage = System.Convert.ToString(Image10.ImageUrl);
                        Panel10.Visible = false;
                        break;

                    case 11:

                        ChessImage = System.Convert.ToString(Image11.ImageUrl);
                        Panel11.Visible = false;
                        break;

                    case 12:

                        ChessImage = System.Convert.ToString(Image12.ImageUrl);
                        Panel12.Visible = false;
                        break;

                    case 13:

                        ChessImage = System.Convert.ToString(Image13.ImageUrl);
                        Panel13.Visible = false;
                        break;

                    case 14:

                        ChessImage = System.Convert.ToString(Image14.ImageUrl);
                        Panel14.Visible = false;
                        break;

                    case 15:

                        ChessImage = System.Convert.ToString(Image15.ImageUrl);
                        Panel15.Visible = false;
                        break;

                    case 16:

                        ChessImage = System.Convert.ToString(Image16.ImageUrl);
                        Panel16.Visible = false;
                        break;

                    case 17:

                        ChessImage = System.Convert.ToString(Image17.ImageUrl);
                        Panel17.Visible = false;
                        break;

                    case 18:

                        ChessImage = System.Convert.ToString(Image18.ImageUrl);
                        Panel18.Visible = false;
                        break;

                    case 19:

                        ChessImage = System.Convert.ToString(Image19.ImageUrl);
                        Panel19.Visible = false;
                        break;

                    case 20:

                        ChessImage = System.Convert.ToString(Image20.ImageUrl);
                        Panel20.Visible = false;
                        break;

                    case 21:

                        ChessImage = System.Convert.ToString(Image21.ImageUrl);
                        Panel21.Visible = false;
                        break;

                    case 22:

                        ChessImage = System.Convert.ToString(Image22.ImageUrl);
                        Panel22.Visible = false;
                        break;

                    case 23:

                        ChessImage = System.Convert.ToString(Image23.ImageUrl);
                        Panel23.Visible = false;
                        break;

                    case 24:

                        ChessImage = System.Convert.ToString(Image24.ImageUrl);
                        Panel24.Visible = false;
                        break;

                    case 25:

                        ChessImage = System.Convert.ToString(Image25.ImageUrl);
                        Panel25.Visible = false;
                        break;

                    case 26:

                        ChessImage = System.Convert.ToString(Image26.ImageUrl);
                        Panel26.Visible = false;
                        break;

                    case 27:

                        ChessImage = System.Convert.ToString(Image27.ImageUrl);
                        Panel27.Visible = false;
                        break;

                    case 28:

                        ChessImage = System.Convert.ToString(Image28.ImageUrl);
                        Panel28.Visible = false;
                        break;

                    case 29:

                        ChessImage = System.Convert.ToString(Image29.ImageUrl);
                        Panel29.Visible = false;
                        break;

                    case 30:

                        ChessImage = System.Convert.ToString(Image30.ImageUrl);
                        Panel30.Visible = false;
                        break;

                    case 31:

                        ChessImage = System.Convert.ToString(Image31.ImageUrl);
                        Panel31.Visible = false;
                        break;

                    case 32:

                        ChessImage = System.Convert.ToString(Image32.ImageUrl);
                        Panel32.Visible = false;
                        break;

                    case 33:

                        ChessImage = System.Convert.ToString(Image33.ImageUrl);
                        Panel33.Visible = false;
                        break;

                    case 34:

                        ChessImage = System.Convert.ToString(Image34.ImageUrl);
                        Panel34.Visible = false;
                        break;

                    case 35:

                        ChessImage = System.Convert.ToString(Image35.ImageUrl);
                        Panel35.Visible = false;
                        break;

                    case 36:

                        ChessImage = System.Convert.ToString(Image36.ImageUrl);
                        Panel36.Visible = false;
                        break;

                    case 37:

                        ChessImage = System.Convert.ToString(Image37.ImageUrl);
                        Panel37.Visible = false;
                        break;

                    case 38:

                        ChessImage = System.Convert.ToString(Image38.ImageUrl);
                        Panel38.Visible = false;
                        break;

                    case 39:

                        ChessImage = System.Convert.ToString(Image39.ImageUrl);
                        Panel39.Visible = false;
                        break;

                    case 40:

                        ChessImage = System.Convert.ToString(Image40.ImageUrl);
                        Panel40.Visible = false;
                        break;

                    case 41:

                        ChessImage = System.Convert.ToString(Image41.ImageUrl);
                        Panel41.Visible = false;
                        break;

                    case 42:

                        ChessImage = System.Convert.ToString(Image42.ImageUrl);
                        Panel42.Visible = false;
                        break;

                    case 43:

                        ChessImage = System.Convert.ToString(Image43.ImageUrl);
                        Panel43.Visible = false;
                        break;

                    case 44:

                        ChessImage = System.Convert.ToString(Image44.ImageUrl);
                        Panel44.Visible = false;
                        break;

                    case 45:

                        ChessImage = System.Convert.ToString(Image45.ImageUrl);
                        Panel45.Visible = false;
                        break;

                    case 46:

                        ChessImage = System.Convert.ToString(Image46.ImageUrl);
                        Panel46.Visible = false;
                        break;

                    case 47:

                        ChessImage = System.Convert.ToString(Image47.ImageUrl);
                        Panel47.Visible = false;
                        break;

                    case 48:

                        ChessImage = System.Convert.ToString(Image48.ImageUrl);
                        Panel48.Visible = false;
                        break;

                    case 49:

                        ChessImage = System.Convert.ToString(Image49.ImageUrl);
                        Panel49.Visible = false;
                        break;

                    case 50:

                        ChessImage = System.Convert.ToString(Image50.ImageUrl);
                        Panel50.Visible = false;
                        break;

                    case 51:

                        ChessImage = System.Convert.ToString(Image51.ImageUrl);
                        Panel51.Visible = false;
                        break;

                    case 52:

                        ChessImage = System.Convert.ToString(Image52.ImageUrl);
                        Panel52.Visible = false;
                        break;

                    case 53:

                        ChessImage = System.Convert.ToString(Image53.ImageUrl);
                        Panel53.Visible = false;
                        break;

                    case 54:

                        ChessImage = System.Convert.ToString(Image54.ImageUrl);
                        Panel54.Visible = false;
                        break;

                    case 55:

                        ChessImage = System.Convert.ToString(Image55.ImageUrl);
                        Panel55.Visible = false;
                        break;

                    case 56:

                        ChessImage = System.Convert.ToString(Image56.ImageUrl);
                        Panel56.Visible = false;
                        break;

                    case 57:

                        ChessImage = System.Convert.ToString(Image57.ImageUrl);
                        Panel57.Visible = false;
                        break;

                    case 58:

                        ChessImage = System.Convert.ToString(Image58.ImageUrl);
                        Panel58.Visible = false;
                        break;

                    case 59:

                        ChessImage = System.Convert.ToString(Image59.ImageUrl);
                        Panel59.Visible = false;
                        break;

                    case 60:

                        ChessImage = System.Convert.ToString(Image60.ImageUrl);
                        Panel60.Visible = false;
                        break;

                    case 61:

                        ChessImage = System.Convert.ToString(Image61.ImageUrl);
                        Panel61.Visible = false;
                        break;

                    case 62:

                        ChessImage = System.Convert.ToString(Image62.ImageUrl);
                        Panel62.Visible = false;
                        break;

                    case 63:

                        ChessImage = System.Convert.ToString(Image63.ImageUrl);
                        Panel63.Visible = false;
                        break;

                    case 64:

                        ChessImage = System.Convert.ToString(Image64.ImageUrl);
                        Panel64.Visible = false;
                        break;


                }

                //Can not move a blank block
                if (string.IsNullOrEmpty(ChessImage))
                {
                    goto EndSection;
                }



                //Move To Section
                switch (MoveTo)
                {
                    case 1:

                        //Display Box
                        Panel1.Visible = true;
                        Image1.ImageUrl = ChessImage;
                        break;

                    case 2:
                        Panel2.Visible = true;
                        Image2.ImageUrl = ChessImage;
                        break;
                    case 3:
                        Panel3.Visible = true;
                        Image3.ImageUrl = ChessImage;
                        break;

                    case 4:
                        Panel4.Visible = true;
                        Image4.ImageUrl = ChessImage;
                        break;

                    case 5:
                        Panel5.Visible = true;
                        Image5.ImageUrl = ChessImage;
                        break;

                    case 6:
                        Panel6.Visible = true;
                        Image6.ImageUrl = ChessImage;
                        break;

                    case 7:
                        Panel7.Visible = true;
                        Image7.ImageUrl = ChessImage;
                        break;

                    case 8:
                        Panel8.Visible = true;
                        Image8.ImageUrl = ChessImage;
                        break;

                    case 9:

                        //Display Box
                        Panel9.Visible = true;
                        Image9.ImageUrl = ChessImage;
                        break;

                    case 10:
                        Panel10.Visible = true;
                        Image10.ImageUrl = ChessImage;
                        break;
                    case 11:
                        Panel11.Visible = true;
                        Image11.ImageUrl = ChessImage;
                        break;

                    case 12:
                        Panel12.Visible = true;
                        Image12.ImageUrl = ChessImage;
                        break;

                    case 13:
                        Panel13.Visible = true;
                        Image13.ImageUrl = ChessImage;
                        break;

                    case 14:
                        Panel14.Visible = true;
                        Image14.ImageUrl = ChessImage;
                        break;

                    case 15:
                        Panel15.Visible = true;
                        Image15.ImageUrl = ChessImage;
                        break;

                    case 16:
                        Panel16.Visible = true;
                        Image16.ImageUrl = ChessImage;
                        break;

                    case 17:

                        //Display Box
                        Panel17.Visible = true;
                        Image17.ImageUrl = ChessImage;
                        break;

                    case 18:
                        Panel18.Visible = true;
                        Image18.ImageUrl = ChessImage;
                        break;
                    case 19:
                        Panel19.Visible = true;
                        Image19.ImageUrl = ChessImage;
                        break;

                    case 20:
                        Panel20.Visible = true;
                        Image20.ImageUrl = ChessImage;
                        break;

                    case 21:
                        Panel21.Visible = true;
                        Image21.ImageUrl = ChessImage;
                        break;

                    case 22:
                        Panel22.Visible = true;
                        Image22.ImageUrl = ChessImage;
                        break;

                    case 23:
                        Panel23.Visible = true;
                        Image23.ImageUrl = ChessImage;
                        break;

                    case 24:
                        Panel24.Visible = true;
                        Image24.ImageUrl = ChessImage;
                        break;

                    case 25:

                        //Display Box
                        Panel25.Visible = true;
                        Image25.ImageUrl = ChessImage;
                        break;

                    case 26:
                        Panel26.Visible = true;
                        Image26.ImageUrl = ChessImage;
                        break;
                    case 27:
                        Panel27.Visible = true;
                        Image27.ImageUrl = ChessImage;
                        break;

                    case 28:
                        Panel28.Visible = true;
                        Image28.ImageUrl = ChessImage;
                        break;

                    case 29:
                        Panel29.Visible = true;
                        Image29.ImageUrl = ChessImage;
                        break;

                    case 30:
                        Panel30.Visible = true;
                        Image30.ImageUrl = ChessImage;
                        break;

                    case 31:
                        Panel31.Visible = true;
                        Image31.ImageUrl = ChessImage;
                        break;

                    case 32:
                        Panel32.Visible = true;
                        Image32.ImageUrl = ChessImage;
                        break;

                    case 33:

                        //Display Box
                        Panel33.Visible = true;
                        Image33.ImageUrl = ChessImage;
                        break;

                    case 34:
                        Panel34.Visible = true;
                        Image34.ImageUrl = ChessImage;
                        break;
                    case 35:
                        Panel35.Visible = true;
                        Image35.ImageUrl = ChessImage;
                        break;

                    case 36:
                        Panel36.Visible = true;
                        Image36.ImageUrl = ChessImage;
                        break;

                    case 37:
                        Panel37.Visible = true;
                        Image37.ImageUrl = ChessImage;
                        break;

                    case 38:
                        Panel38.Visible = true;
                        Image38.ImageUrl = ChessImage;
                        break;

                    case 39:
                        Panel39.Visible = true;
                        Image39.ImageUrl = ChessImage;
                        break;

                    case 40:
                        Panel40.Visible = true;
                        Image40.ImageUrl = ChessImage;
                        break;

                    case 41:

                        //Display Box
                        Panel41.Visible = true;
                        Image41.ImageUrl = ChessImage;
                        break;

                    case 42:
                        Panel42.Visible = true;
                        Image42.ImageUrl = ChessImage;
                        break;
                    case 43:
                        Panel43.Visible = true;
                        Image43.ImageUrl = ChessImage;
                        break;

                    case 44:
                        Panel44.Visible = true;
                        Image44.ImageUrl = ChessImage;
                        break;

                    case 45:
                        Panel45.Visible = true;
                        Image45.ImageUrl = ChessImage;
                        break;

                    case 46:
                        Panel46.Visible = true;
                        Image46.ImageUrl = ChessImage;
                        break;

                    case 47:
                        Panel47.Visible = true;
                        Image47.ImageUrl = ChessImage;
                        break;

                    case 48:
                        Panel48.Visible = true;
                        Image48.ImageUrl = ChessImage;
                        break;

                    case 49:

                        //Display Box
                        Panel49.Visible = true;
                        Image49.ImageUrl = ChessImage;
                        break;

                    case 50:
                        Panel50.Visible = true;
                        Image50.ImageUrl = ChessImage;
                        break;
                    case 51:
                        Panel51.Visible = true;
                        Image51.ImageUrl = ChessImage;
                        break;

                    case 52:
                        Panel52.Visible = true;
                        Image52.ImageUrl = ChessImage;
                        break;

                    case 53:
                        Panel53.Visible = true;
                        Image53.ImageUrl = ChessImage;
                        break;

                    case 54:
                        Panel54.Visible = true;
                        Image54.ImageUrl = ChessImage;
                        break;

                    case 55:
                        Panel55.Visible = true;
                        Image55.ImageUrl = ChessImage;
                        break;

                    case 56:
                        Panel56.Visible = true;
                        Image56.ImageUrl = ChessImage;
                        break;

                    case 57:

                        //Display Box
                        Panel57.Visible = true;
                        Image57.ImageUrl = ChessImage;
                        break;

                    case 58:
                        Panel58.Visible = true;
                        Image58.ImageUrl = ChessImage;
                        break;
                    case 59:
                        Panel59.Visible = true;
                        Image59.ImageUrl = ChessImage;
                        break;

                    case 60:
                        Panel60.Visible = true;
                        Image60.ImageUrl = ChessImage;
                        break;

                    case 61:
                        Panel61.Visible = true;
                        Image61.ImageUrl = ChessImage;
                        break;

                    case 62:
                        Panel62.Visible = true;
                        Image62.ImageUrl = ChessImage;
                        break;

                    case 63:
                        Panel63.Visible = true;
                        Image63.ImageUrl = ChessImage;
                        break;

                    case 64:
                        Panel64.Visible = true;
                        Image64.ImageUrl = ChessImage;
                        break;

                }

                //Do a check for castle
                ChessImage = ChessImage.ToLower();
                if (ChessImage == "Images/wking.gif")
                {
                    //Do a check to see if king move from (e1)
                    if (MoveFrom == 61 & MoveTo == 63)
                    {
                        //Castle was true = so move rook
                        MoveFrom = 64;
                        MoveTo = 62;
                        goto BeginSection;
                    }
                    //Do a check to look for long castle
                    if (MoveFrom == 61 & MoveTo == 59)
                    {
                        //Castle to long side
                        MoveFrom = 57;
                        MoveTo = 60;
                        goto BeginSection;
                    }
                }

                //Do same check for black king castle
                if (ChessImage == "Images/bking.gif")
                {
                    //Do a check to see if king move from (e1)
                    if (MoveFrom == 5 & MoveTo == 7)
                    {
                        //Castle was true = so move rook
                        MoveFrom = 8;
                        MoveTo = 6;
                        goto BeginSection;
                    }
                    //Do a check to look for long castle
                    if (MoveFrom == 5 & MoveTo == 3)
                    {
                        //Castle to long side
                        MoveFrom = 1;
                        MoveTo = 4;
                        goto BeginSection;
                    }
                }


            EndSection:

                //Set the hidden variables
                lblMove.Text = CheckBoxNr.ToString();
                lblMove1.Text = "NoMove";

                //Now clear all checkboxes
                ClearCheckbox();
                //WebApplicationRefregitzTow._Default.ucc.ClearCheckbox();
            }
            UserControlLoad();
        }

        /*public void SetImages()
        {
           // do
          //  {
                //if (Page.IsValid)
             //   {
                    int[,] Tab = new int[8, 8];
                    for (int i = 0; i < 8; i++)
                        for (int j = 0; j < 8; j++)
                            Tab[i, j] = RefrigtzW.FormRefrigtz.Table[i, j];

                    for (int i = 0; i < 8; i++)
                        for (int j = 0; j < 8; j++)
                        {
                            string ctrlName = "Image" + ((j * 8 + i) + 1).ToString();
                            string ctrlNameP = "Panel" + ((j * 8 + i) + 1).ToString();
                            Control c = FindControl(ctrlName);
                            Control cP = FindControl(ctrlNameP);
                            if (c != null)
                            {
                                if (Tab[i, j] == 1)
                                {
                                    ((Image)c).ImageUrl = "~/Images/WPawn.gif";
                                    ((Panel)cP).Visible = true;

                                }
                                else
                                    if (Tab[i, j] == 2)
                                    {
                                        ((Image)c).ImageUrl = "~/Images/Wbishop.gif";
                                        ((Panel)cP).Visible = true;
                                    }
                                    else
                                        if (Tab[i, j] == 3)
                                        {
                                            ((Image)c).ImageUrl = "~/Images/Wknight.gif";
                                            ((Panel)cP).Visible = true;
                                        }
                                        else
                                            if (Tab[i, j] == 4)
                                            {
                                                ((Image)c).ImageUrl = "~/Images/Wrook.gif";
                                                ((Panel)cP).Visible = true;
                                            }
                                            else
                                                if (Tab[i, j] == 5)
                                                {
                                                    ((Image)c).ImageUrl = "~/Images/Wqueen.gif";
                                                    ((Panel)cP).Visible = true;
                                                }
                                                else
                                                    if (Tab[i, j] == 6)
                                                    {
                                                        ((Image)c).ImageUrl = "~/Images/WKing.gif";
                                                        ((Panel)cP).Visible = true;
                                                    }
                                                    else
                                                        if (Tab[i, j] == -1)
                                                        {
                                                            ((Image)c).ImageUrl = "~/Images/bPawn.gif";
                                                            ((Panel)cP).Visible = true;
                                                        }
                                                        else
                                                            if (Tab[i, j] == -2)
                                                            {
                                                                ((Image)c).ImageUrl = "~/Images/bbishop.gif";
                                                                ((Panel)cP).Visible = true;
                                                            }
                                                            else
                                                                if (Tab[i, j] == -3)
                                                                {
                                                                    ((Image)c).ImageUrl = "~/Images/bknight.gif";
                                                                    ((Panel)cP).Visible = true;
                                                                }
                                                                else
                                                                    if (Tab[i, j] == -4)
                                                                    {
                                                                        ((Image)c).ImageUrl = "~/Images/brook.gif";
                                                                        ((Panel)cP).Visible = true;
                                                                    }
                                                                    else
                                                                        if (Tab[i, j] == -5)
                                                                        {
                                                                            ((Image)c).ImageUrl = "~/Images/bqueen.gif";
                                                                            ((Panel)cP).Visible = true;
                                                                        }
                                                                        else
                                                                            if (Tab[i, j] == -6)
                                                                            {
                                                                                ((Image)c).ImageUrl = "~/Images/bking.gif";
                                                                                ((Panel)cP).Visible = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                ((Image)c).ImageUrl = "";
                                                                                ((Panel)cP).Visible = false;
                                                                            }
                            }
                        }
                    //stem.Threading.Thread.Sleep(1000);
             //   }
            //  } while (true);
        }
    */
        protected void CheckBox1_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox1.Checked == true)
            {

                CheckData(1, "a8", true);

            }
            else
            {

                CheckData(1, "a8", false);

            }



        }

        protected void CheckBox2_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox2.Checked == true)
            {

                CheckData(2, "b8", true);

            }
            else
            {

                CheckData(2, "b8", false);

            }


        }

        protected void CheckBox3_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox3.Checked == true)
            {

                CheckData(3, "c8", true);

            }
            else
            {

                CheckData(3, "c8", false);

            }


        }

        public void LoadStart()
        {

            //Load the Start controls
            //Firstly load the start pieces + Display Panels
            Image1.ImageUrl = "Images/brook.gif";
            Panel1.Visible = true;
            Image2.ImageUrl = "Images/bknight.gif";
            Panel2.Visible = true;
            Image3.ImageUrl = "Images/bbishop.gif";
            Panel3.Visible = true;
            Image4.ImageUrl = "Images/bqueen.gif";
            Panel4.Visible = true;
            Image5.ImageUrl = "Images/bking.gif";
            Panel5.Visible = true;
            Image6.ImageUrl = "Images/bbishop.gif";
            Panel6.Visible = true;
            Image7.ImageUrl = "Images/bknight.gif";
            Panel7.Visible = true;
            Image8.ImageUrl = "Images/brook.gif";
            Panel8.Visible = true;
            Image9.ImageUrl = "Images/bpawn.gif";
            Panel9.Visible = true;
            Image10.ImageUrl = "Images/bpawn.gif";
            Panel10.Visible = true;
            Image11.ImageUrl = "Images/bpawn.gif";
            Panel11.Visible = true;
            Image12.ImageUrl = "Images/bpawn.gif";
            Panel12.Visible = true;
            Image13.ImageUrl = "Images/bpawn.gif";
            Panel13.Visible = true;
            Image14.ImageUrl = "Images/bpawn.gif";
            Panel14.Visible = true;
            Image15.ImageUrl = "Images/bpawn.gif";
            Panel15.Visible = true;
            Image16.ImageUrl = "Images/bpawn.gif";
            Panel16.Visible = true;

            Image17.ImageUrl = "";
            Panel17.Visible = false;
            Image18.ImageUrl = "";
            Panel18.Visible = false;
            Image19.ImageUrl = "";
            Panel19.Visible = false;
            Image20.ImageUrl = "";
            Panel20.Visible = false;
            Image21.ImageUrl = "";
            Panel21.Visible = false;
            Image22.ImageUrl = "";
            Panel22.Visible = false;
            Image23.ImageUrl = "";
            Panel23.Visible = false;
            Image24.ImageUrl = "";
            Panel24.Visible = false;
            Image25.ImageUrl = "";
            Panel25.Visible = false;
            Image26.ImageUrl = "";
            Panel26.Visible = false;
            Image27.ImageUrl = "";
            Panel27.Visible = false;
            Image28.ImageUrl = "";
            Panel28.Visible = false;
            Image29.ImageUrl = "";
            Panel29.Visible = false;
            Image30.ImageUrl = "";
            Panel30.Visible = false;
            Image31.ImageUrl = "";
            Panel31.Visible = false;
            Image32.ImageUrl = "";
            Panel32.Visible = false;
            Image33.ImageUrl = "";
            Panel33.Visible = false;
            Image34.ImageUrl = "";
            Panel34.Visible = false;
            Image35.ImageUrl = "";
            Panel35.Visible = false;
            Image36.ImageUrl = "";
            Panel36.Visible = false;
            Image37.ImageUrl = "";
            Panel37.Visible = false;
            Image38.ImageUrl = "";
            Panel38.Visible = false;
            Image39.ImageUrl = "";
            Panel39.Visible = false;
            Image40.ImageUrl = "";
            Panel40.Visible = false;
            Image41.ImageUrl = "";
            Panel41.Visible = false;
            Image42.ImageUrl = "";
            Panel42.Visible = false;
            Image43.ImageUrl = "";
            Panel43.Visible = false;
            Image44.ImageUrl = "";
            Panel44.Visible = false;
            Image45.ImageUrl = "";
            Panel45.Visible = false;
            Image46.ImageUrl = "";
            Panel46.Visible = false;
            Image47.ImageUrl = "";
            Panel47.Visible = false;
            Image48.ImageUrl = "";
            Panel48.Visible = false;

            Image49.ImageUrl = "Images/WPawn.gif";
            Panel49.Visible = true;
            Image50.ImageUrl = "Images/WPawn.gif";
            Panel50.Visible = true;
            Image51.ImageUrl = "Images/WPawn.gif";
            Panel51.Visible = true;
            Image52.ImageUrl = "Images/WPawn.gif";
            Panel52.Visible = true;
            Image53.ImageUrl = "Images/WPawn.gif";
            Panel53.Visible = true;
            Image54.ImageUrl = "Images/WPawn.gif";
            Panel54.Visible = true;
            Image55.ImageUrl = "Images/WPawn.gif";
            Panel55.Visible = true;
            Image56.ImageUrl = "Images/WPawn.gif";
            Panel56.Visible = true;
            Image57.ImageUrl = "Images/WRook.gif";
            Panel57.Visible = true;
            Image58.ImageUrl = "Images/WKnight.gif";
            Panel58.Visible = true;
            Image59.ImageUrl = "Images/WBishop.gif";
            Panel59.Visible = true;
            Image60.ImageUrl = "Images/WQueen.gif";
            Panel60.Visible = true;
            Image61.ImageUrl = "Images/WKing.gif";
            Panel61.Visible = true;
            Image62.ImageUrl = "Images/WBishop.gif";
            Panel62.Visible = true;
            Image63.ImageUrl = "Images/WKnight.gif";
            Panel63.Visible = true;
            Image64.ImageUrl = "Images/WRook.gif";
            UserControlLoad();
            //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(SetImages));
            //t.Start();

        }
        public void UserControlLoad()
        {
            while (!RefrigtzW.FormRefrigtz.ReadF) ;
            //RefrigtzW.FormRefrigtz.LoadPlaceHolder = false;
            //RefrigtzW.FormRefrigtz.LoadPlaceHolder = false;
            Control lblMove = this.FindControl("lblMove");
            Control lblMove1 = this.FindControl("lblMove1");
            Control lblMove2 = this.FindControl("lblMove2");
            //lblMove = (Label)lblMove;
            //lblMove1 = (Label)lblMove1;
            //lblMove2 = (Label)lblMove2;

            // LoadStart();
            //do
            //  {

            //if (RefrigtzW.FormRefrigtz.LoadPlaceHolder)
            {
                int[,] Tab = new int[8, 8];
                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                        Tab[i, j] = RefrigtzW.FormRefrigtz.Table[i, j];

                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        string ctrlName = "Image" + ((j * 8 + i) + 1).ToString();
                        string ctrlNameP = "Panel" + ((j * 8 + i) + 1).ToString();
                        string ctrlNameC = "CheckBox" + ((j * 8 + i) + 1).ToString();

                        Control c = this.FindControl(ctrlName);
                        Control cP = this.FindControl(ctrlNameP);
                        Control cC = this.FindControl(ctrlNameC);
                        if (c != null)
                        {
                            if (Tab[i, j] == 1)
                            {
                                ((Image)c).ImageUrl = "~/Images/WPawn.gif";
                                ((Panel)cP).Visible = true;
                                //Setucc(((j*8+i) + 1), "~/Images/WPawn.gif", true);

                            }
                            else
                                if (Tab[i, j] == 2)
                                {
                                    ((Image)c).ImageUrl = "~/Images/Wbishop.gif";
                                    ((Panel)cP).Visible = true;
                                    //Setucc(((j*8+i) + 1), "~/Images/Wbishop.gif", true);
                                }
                                else
                                    if (Tab[i, j] == 3)
                                    {
                                        ((Image)c).ImageUrl = "~/Images/Wknight.gif";
                                        ((Panel)cP).Visible = true;
                                        //Setucc(((j*8+i) + 1), "~/Images/Wknight.gif", true);
                                    }
                                    else
                                        if (Tab[i, j] == 4)
                                        {
                                            ((Image)c).ImageUrl = "~/Images/Wrook.gif";
                                            ((Panel)cP).Visible = true;
                                            //Setucc(((j*8+i) + 1), "~/Images/Wrook.gif", true);
                                        }
                                        else
                                            if (Tab[i, j] == 5)
                                            {
                                                ((Image)c).ImageUrl = "~/Images/Wqueen.gif";
                                                ((Panel)cP).Visible = true;
                                                //Setucc(((j*8+i) + 1), "~/Images/Wqueen.gif", true);
                                            }
                                            else
                                                if (Tab[i, j] == 6)
                                                {
                                                    ((Image)c).ImageUrl = "~/Images/WKing.gif";
                                                    ((Panel)cP).Visible = true;
                                                    //Setucc(((j*8+i) + 1), "~/Images/WKing.gif", true);
                                                }
                                                else
                                                    if (Tab[i, j] == -1)
                                                    {
                                                        ((Image)c).ImageUrl = "~/Images/bPawn.gif";
                                                        ((Panel)cP).Visible = true;
                                                        //Setucc(((j*8+i) + 1), "~/Images/bPawn.gif", true);
                                                    }
                                                    else
                                                        if (Tab[i, j] == -2)
                                                        {
                                                            ((Image)c).ImageUrl = "~/Images/bbishop.gif";
                                                            ((Panel)cP).Visible = true;
                                                            //Setucc(((j*8+i) + 1), "~/Images/bbishop.gif", true);
                                                        }
                                                        else
                                                            if (Tab[i, j] == -3)
                                                            {
                                                                ((Image)c).ImageUrl = "~/Images/bknight.gif";
                                                                ((Panel)cP).Visible = true;
                                                                //Setucc(((j*8+i) + 1), "~/Images/bknight.gif", true);
                                                            }
                                                            else
                                                                if (Tab[i, j] == -4)
                                                                {
                                                                    ((Image)c).ImageUrl = "~/Images/brook.gif";
                                                                    ((Panel)cP).Visible = true;
                                                                    //Setucc(((j*8+i) + 1), "~/Images/brook.gif", true);
                                                                }
                                                                else
                                                                    if (Tab[i, j] == -5)
                                                                    {
                                                                        ((Image)c).ImageUrl = "~/Images/bqueen.gif";
                                                                        ((Panel)cP).Visible = true;
                                                                        //Setucc(((j*8+i) + 1), "~/Images/bqueen.gif", true);
                                                                    }
                                                                    else
                                                                        if (Tab[i, j] == -6)
                                                                        {
                                                                            ((Image)c).ImageUrl = "~/Images/bking.gif";
                                                                            ((Panel)cP).Visible = true;
                                                                            //Setucc(((j*8+i) + 1), "~/Images/bking.gif", true);
                                                                        }
                                                                        else
                                                                        {
                                                                            ((Image)c).ImageUrl = "";
                                                                            ((Panel)cP).Visible = false;
                                                                            //Setucc(((j*8+i) + 1), "", false);
                                                                        }
                        }
                        //((CheckBox)cC).AutoPostBack = true;




                    }
            }
            // else
            {
                /*for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                    {
                       // string ctrlName = "Image" + ((j*8+i) + 1).ToString();
                      //  string ctrlNameP = "Panel" + ((j*8+i) + 1).ToString();
                     //   string ctrlNameC = "CheckBox" + ((j*8+i) + 1).ToString();

                     //   Control c = this.FindControl(ctrlName);
                    //    Control cP = this.FindControl(ctrlNameP);
                   //     Control cC = this.FindControl(ctrlNameC);


                        //((CheckBox)cC).AutoPostBack = true;
                        if (cC != null)
                        {
                            if (((CheckBox)cC).Checked && (System.Convert.ToInt32(((Label)lblMove).Text) != (j*8+i) + 1) && ((Label)lblMove1).Text != "NoMove")
                            {
                                lblMove = new Label();
                                lblMove.Text = ((Label)lblMove).Text;
                                lblMove1 = new Label();
                                lblMove1.Text = ((Label)lblMove1).Text;

                                CheckData(((j*8+i) + 1), CreateString((j*8+i) + 1), true);
                                ClearCheckbox();
                                _2 = cC;
                                ((CheckBox)_1).Checked = false;
                                ((CheckBox)_2).Checked = false;
                                lblMove = this.FindControl("lblMove");
                                lblMove1 = this.FindControl("lblMove1");
                                lblMove2 = this.FindControl("lblMove2");
                                ((Label)lblMove).Text = lblMove.Text;
                                ((Label)lblMove1).Text = lblMove1.Text;

                            }
                            else
                                if (((CheckBox)cC).Checked && ((Label)lblMove1).Text == "NoMove")
                                {

                                    lblMove = new Label();
                                    lblMove.Text = ((Label)lblMove).Text;
                                    lblMove1 = new Label();
                                    lblMove1.Text = ((Label)lblMove1).Text;

                                    //Label1.Text = "Take Second Box";
                                    lblMove.Text = ((j*8+i) + 1).ToString();
                                    CheckData(((j*8+i) + 1), CreateString((j*8+i) + 1), true);
                                    _1 = cC;
                                    ((Label)lblMove).Text = lblMove.Text;
                                    ((Label)lblMove1).Text = lblMove1.Text;
                                }

                        }
                        else
                        {


                            //CheckData(((i*8+j) + 1), CreateString((i*8+j) + 1), false);
                        }



                  



                    }
                 */
            }

            if (WebApplicationRefregitzTow.Controls_CBC.Found)
            {
                RefrigtzW.FormRefrigtz.ThinkingA = true;
                WebApplicationRefregitzTow.Controls_CBC.Found = false;
            }
            //RefrigtzW.FormRefrigtz.LoadPlaceHolder = true;

            /* try
             {

                 if (!IsPostBack)
                 {

                 }
                 else
                 {
                     if (WebApplicationRefregitzTow.Controls_CBC.Found)
                     {
                         Response.Redirect("~/Default.aspx?element_id=2");

                     }

                 }

             }
             
             catch (Exception ex)
             {

             }
             */
            /* if (RefrigtzW.FormRefrigtz.OrderPlate == 1)
             {
                 Label2.Text = "Do SomeThings";
             }
             else
             {
                 Label2.Text = "Thinking...";
             }
             */
            //Page.Response.Redirect("~/Default.aspx");
            // } while (true);
            //RefrigtzW.FormRefrigtz.LoadPlaceHolder = true;

        }

        protected void Page_Load(object sender, System.EventArgs e)
        {



            if (!Page.IsPostBack)
            {
                LoadStart();
            }
            else
            {

                t = new System.Threading.Thread(new System.Threading.ThreadStart(UserControlLoad));
                t.Start();
            }
        }

        public void ClearCheckbox()
        {

            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked = false;
            CheckBox6.Checked = false;
            CheckBox7.Checked = false;
            CheckBox8.Checked = false;
            CheckBox9.Checked = false;
            CheckBox10.Checked = false;
            CheckBox11.Checked = false;
            CheckBox12.Checked = false;
            CheckBox13.Checked = false;
            CheckBox14.Checked = false;
            CheckBox15.Checked = false;
            CheckBox16.Checked = false;
            CheckBox17.Checked = false;
            CheckBox18.Checked = false;
            CheckBox19.Checked = false;
            CheckBox20.Checked = false;
            CheckBox21.Checked = false;
            CheckBox22.Checked = false;
            CheckBox23.Checked = false;
            CheckBox24.Checked = false;
            CheckBox25.Checked = false;
            CheckBox26.Checked = false;
            CheckBox27.Checked = false;
            CheckBox28.Checked = false;
            CheckBox29.Checked = false;
            CheckBox30.Checked = false;
            CheckBox31.Checked = false;
            CheckBox32.Checked = false;
            CheckBox33.Checked = false;
            CheckBox34.Checked = false;
            CheckBox35.Checked = false;
            CheckBox36.Checked = false;
            CheckBox37.Checked = false;
            CheckBox38.Checked = false;
            CheckBox39.Checked = false;
            CheckBox40.Checked = false;
            CheckBox41.Checked = false;
            CheckBox42.Checked = false;
            CheckBox43.Checked = false;
            CheckBox44.Checked = false;
            CheckBox45.Checked = false;
            CheckBox46.Checked = false;
            CheckBox47.Checked = false;
            CheckBox48.Checked = false;
            CheckBox49.Checked = false;
            CheckBox50.Checked = false;
            CheckBox51.Checked = false;
            CheckBox52.Checked = false;
            CheckBox53.Checked = false;
            CheckBox54.Checked = false;
            CheckBox55.Checked = false;
            CheckBox56.Checked = false;
            CheckBox57.Checked = false;
            CheckBox58.Checked = false;
            CheckBox59.Checked = false;
            CheckBox60.Checked = false;
            CheckBox61.Checked = false;
            CheckBox62.Checked = false;
            CheckBox63.Checked = false;
            CheckBox64.Checked = false;

        }

        protected void CheckBox4_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox4.Checked == true)
            {

                CheckData(4, "d8", true);

            }
            else
            {

                CheckData(4, "d8", false);

            }

        }

        protected void CheckBox5_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox5.Checked == true)
            {

                CheckData(5, "e8", true);

            }
            else
            {

                CheckData(5, "e8", false);

            }

        }

        protected void CheckBox6_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox6.Checked == true)
            {

                CheckData(6, "f8", true);

            }
            else
            {

                CheckData(6, "f8", false);

            }

        }

        protected void CheckBox7_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox7.Checked == true)
            {

                CheckData(7, "g8", true);

            }
            else
            {

                CheckData(7, "g8", false);

            }

        }

        protected void CheckBox8_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox8.Checked == true)
            {

                CheckData(8, "h8", true);

            }
            else
            {

                CheckData(8, "h8", false);

            }

        }
        public string CreateString(int a)
        {
            if (a == 1)
                return "a8";
            else

                if (a == 2)
                    return "b8";
            if (a == 3)
                return "c8";
            if (a == 4)
                return "d8";
            if (a == 5)
                return "e8";
            if (a == 6)
                return "f8";
            if (a == 7)
                return "g8";
            if (a == 8)
                return "h8";
            if (a == 9)
                return "a7";
            if (a == 10)
                return "b7";
            if (a == 11)
                return "c7";
            if (a == 12)
                return "d7";
            if (a == 13)
                return "e7";
            if (a == 14)
                return "f7";
            if (a == 15)
                return "g7";
            if (a == 16)
                return "h7";
            if (a == 17)
                return "a6";
            if (a == 18)
                return "b6";
            if (a == 19)
                return "c6";
            if (a == 20)
                return "d6";
            if (a == 21)
                return "e6";
            if (a == 22)
                return "f6";
            if (a == 23)
                return "g6";
            if (a == 24)
                return "h6";
            if (a == 25)
                return "a5";
            if (a == 26)
                return "b5";
            if (a == 27)
                return "c5";
            if (a == 28)
                return "d5";
            if (a == 29)
                return "e5";
            if (a == 30)
                return "f5";
            if (a == 31)
                return "g5";
            if (a == 32)
                return "h5";
            if (a == 33)
                return "a4";
            if (a == 34)
                return "b4";
            if (a == 35)
                return "c4";
            if (a == 36)
                return "d4";
            if (a == 37)
                return "e4";
            if (a == 38)
                return "f4";
            if (a == 39)
                return "g4";
            if (a == 40)
                return "h4";
            if (a == 41)
                return "a3";
            if (a == 42)
                return "b3";
            if (a == 43)
                return "c3";
            if (a == 44)
                return "d3";
            if (a == 45)
                return "e3";
            if (a == 46)
                return "f3";
            if (a == 47)
                return "g3";
            if (a == 48)
                return "h3";
            if (a == 49)
                return "a2";
            if (a == 50)
                return "b2";
            if (a == 51)
                return "c2";
            if (a == 52)
                return "d2";
            if (a == 53)
                return "e2";
            if (a == 54)
                return "f2";
            if (a == 55)
                return "g2";
            if (a == 56)
                return "h2";
            if (a == 57)
                return "a1";
            if (a == 58)
                return "b1";
            if (a == 59)
                return "c1";
            if (a == 60)
                return "d1";
            if (a == 61)
                return "e1";
            if (a == 62)
                return "f1";
            if (a == 63)
                return "g1";
            if (a == 64)
                return "h1";
            return "";

        }
        protected void CheckBox9_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox9.Checked == true)
            {

                CheckData(9, "a7", true);

            }
            else
            {

                CheckData(9, "a7", false);

            }

        }

        protected void CheckBox10_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox10.Checked == true)
            {

                CheckData(10, "b7", true);

            }
            else
            {

                CheckData(10, "b7", false);

            }

        }

        protected void CheckBox11_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox11.Checked == true)
            {

                CheckData(11, "c7", true);

            }
            else
            {

                CheckData(11, "c7", false);

            }

        }

        protected void CheckBox12_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox12.Checked == true)
            {

                CheckData(12, "d7", true);

            }
            else
            {

                CheckData(12, "d7", false);

            }

        }

        protected void CheckBox13_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox13.Checked == true)
            {

                CheckData(13, "e7", true);

            }
            else
            {

                CheckData(13, "e7", false);

            }

        }

        protected void CheckBox14_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox14.Checked == true)
            {

                CheckData(14, "f7", true);

            }
            else
            {

                CheckData(14, "f7", false);

            }

        }

        protected void CheckBox15_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox15.Checked == true)
            {

                CheckData(15, "g7", true);

            }
            else
            {

                CheckData(15, "g7", false);

            }

        }

        protected void CheckBox16_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox16.Checked == true)
            {

                CheckData(16, "h7", true);

            }
            else
            {

                CheckData(16, "h7", false);

            }

        }

        protected void CheckBox17_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox17.Checked == true)
            {

                CheckData(17, "a6", true);

            }
            else
            {

                CheckData(17, "a6", false);

            }

        }

        protected void CheckBox18_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox18.Checked == true)
            {

                CheckData(18, "b6", true);

            }
            else
            {

                CheckData(18, "b6", false);

            }

        }

        protected void CheckBox19_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox19.Checked == true)
            {

                CheckData(19, "c6", true);

            }
            else
            {

                CheckData(19, "c6", false);

            }

        }

        protected void CheckBox20_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox20.Checked == true)
            {

                CheckData(20, "d6", true);

            }
            else
            {

                CheckData(20, "d6", false);

            }

        }

        protected void CheckBox21_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox21.Checked == true)
            {

                CheckData(21, "e6", true);

            }
            else
            {

                CheckData(21, "e6", false);

            }

        }

        protected void CheckBox22_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox22.Checked == true)
            {

                CheckData(22, "f6", true);

            }
            else
            {

                CheckData(22, "f6", false);

            }

        }

        protected void CheckBox23_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox23.Checked == true)
            {

                CheckData(23, "g6", true);

            }
            else
            {

                CheckData(23, "g6", false);

            }

        }

        protected void CheckBox24_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox24.Checked == true)
            {

                CheckData(24, "h6", true);

            }
            else
            {

                CheckData(24, "h6", false);

            }

        }

        protected void CheckBox25_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox25.Checked == true)
            {

                CheckData(25, "a5", true);

            }
            else
            {

                CheckData(25, "a5", false);

            }

        }

        protected void CheckBox26_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox26.Checked == true)
            {

                CheckData(26, "b5", true);

            }
            else
            {

                CheckData(26, "b5", false);

            }

        }

        protected void CheckBox27_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox27.Checked == true)
            {

                CheckData(27, "c5", true);

            }
            else
            {

                CheckData(27, "c5", false);

            }

        }

        protected void CheckBox28_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox28.Checked == true)
            {

                CheckData(28, "d5", true);

            }
            else
            {

                CheckData(28, "d5", false);

            }

        }

        protected void CheckBox29_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox29.Checked == true)
            {

                CheckData(29, "e5", true);

            }
            else
            {

                CheckData(29, "e5", false);

            }

        }

        protected void CheckBox30_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox30.Checked == true)
            {

                CheckData(30, "f5", true);

            }
            else
            {

                CheckData(30, "f5", false);

            }

        }

        protected void CheckBox31_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox31.Checked == true)
            {

                CheckData(31, "g5", true);

            }
            else
            {

                CheckData(31, "g5", false);

            }

        }

        protected void CheckBox32_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox32.Checked == true)
            {

                CheckData(32, "h5", true);

            }
            else
            {

                CheckData(32, "h5", false);

            }

        }

        protected void CheckBox33_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox33.Checked == true)
            {

                CheckData(33, "a4", true);

            }
            else
            {

                CheckData(33, "a4", false);

            }

        }

        protected void CheckBox34_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox34.Checked == true)
            {

                CheckData(34, "b4", true);

            }
            else
            {

                CheckData(34, "b4", false);

            }

        }

        protected void CheckBox35_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox35.Checked == true)
            {

                CheckData(35, "c4", true);

            }
            else
            {

                CheckData(35, "c4", false);

            }

        }

        protected void CheckBox36_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox36.Checked == true)
            {

                CheckData(36, "d4", true);

            }
            else
            {

                CheckData(36, "d4", false);

            }

        }

        protected void CheckBox37_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox37.Checked == true)
            {

                CheckData(37, "e4", true);

            }
            else
            {

                CheckData(37, "e4", false);

            }

        }

        protected void CheckBox38_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox38.Checked == true)
            {

                CheckData(38, "f4", true);

            }
            else
            {

                CheckData(38, "f4", false);

            }

        }

        protected void CheckBox39_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox39.Checked == true)
            {

                CheckData(39, "g4", true);

            }
            else
            {

                CheckData(39, "g4", false);

            }

        }

        protected void CheckBox40_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox40.Checked == true)
            {

                CheckData(40, "h4", true);

            }
            else
            {

                CheckData(40, "h4", false);

            }

        }

        protected void CheckBox41_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox41.Checked == true)
            {

                CheckData(41, "a3", true);

            }
            else
            {

                CheckData(41, "a3", false);

            }

        }

        protected void CheckBox42_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox42.Checked == true)
            {

                CheckData(42, "b3", true);

            }
            else
            {

                CheckData(42, "b3", false);

            }

        }

        protected void CheckBox43_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox43.Checked == true)
            {

                CheckData(43, "c3", true);

            }
            else
            {

                CheckData(43, "c3", false);

            }

        }

        protected void CheckBox44_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox44.Checked == true)
            {

                CheckData(44, "d3", true);

            }
            else
            {

                CheckData(44, "d3", false);

            }

        }

        protected void CheckBox45_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox45.Checked == true)
            {

                CheckData(45, "e3", true);

            }
            else
            {

                CheckData(45, "e3", false);

            }

        }

        protected void CheckBox46_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox46.Checked == true)
            {

                CheckData(46, "f3", true);

            }
            else
            {

                CheckData(46, "f3", false);

            }

        }

        protected void CheckBox47_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox47.Checked == true)
            {

                CheckData(47, "g3", true);

            }
            else
            {

                CheckData(47, "g3", false);

            }

        }

        protected void CheckBox48_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox48.Checked == true)
            {

                CheckData(48, "h3", true);

            }
            else
            {

                CheckData(48, "h3", false);

            }

        }

        protected void CheckBox49_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox49.Checked == true)
            {

                CheckData(49, "a2", true);

            }
            else
            {

                CheckData(49, "a2", false);

            }

        }

        protected void CheckBox50_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox50.Checked == true)
            {

                CheckData(50, "b2", true);

            }
            else
            {

                CheckData(50, "b2", false);

            }

        }

        protected void CheckBox51_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox51.Checked == true)
            {

                CheckData(51, "c2", true);

            }
            else
            {

                CheckData(51, "c2", false);

            }

        }

        protected void CheckBox52_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox52.Checked == true)
            {

                CheckData(52, "d2", true);

            }
            else
            {

                CheckData(52, "d2", false);

            }

        }

        protected void CheckBox53_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox53.Checked == true)
            {

                CheckData(53, "e2", true);

            }
            else
            {

                CheckData(53, "e2", false);

            }

        }

        protected void CheckBox54_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox54.Checked == true)
            {

                CheckData(54, "f2", true);

            }
            else
            {

                CheckData(54, "f2", false);

            }

        }

        protected void CheckBox55_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox55.Checked == true)
            {

                CheckData(55, "g2", true);

            }
            else
            {

                CheckData(55, "g2", false);

            }

        }

        protected void CheckBox56_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox56.Checked == true)
            {

                CheckData(56, "h2", true);

            }
            else
            {

                CheckData(56, "h2", false);

            }

        }

        protected void CheckBox57_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox57.Checked == true)
            {

                CheckData(57, "a1", true);

            }
            else
            {

                CheckData(57, "a1", false);

            }

        }

        protected void CheckBox58_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox58.Checked == true)
            {

                CheckData(58, "b1", true);

            }
            else
            {

                CheckData(58, "b1", false);

            }

        }

        protected void CheckBox59_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox59.Checked == true)
            {

                CheckData(59, "c1", true);

            }
            else
            {

                CheckData(59, "c1", false);

            }

        }

        protected void CheckBox60_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox60.Checked == true)
            {

                CheckData(60, "d1", true);

            }
            else
            {

                CheckData(60, "d1", false);

            }

        }

        protected void CheckBox61_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox61.Checked == true)
            {

                CheckData(61, "e1", true);

            }
            else
            {

                CheckData(61, "e1", false);

            }

        }

        protected void CheckBox62_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox62.Checked == true)
            {

                CheckData(62, "f1", true);

            }
            else
            {

                CheckData(62, "f1", false);

            }

        }

        protected void CheckBox63_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox63.Checked == true)
            {

                CheckData(63, "g1", true);

            }
            else
            {

                CheckData(63, "g1", false);

            }

        }

        protected void CheckBox64_CheckedChanged(object sender, System.EventArgs e)
        {

            if (CheckBox64.Checked == true)
            {

                CheckData(64, "h1", true);

            }
            else
            {

                CheckData(64, "h1", false);

            }

        }

        protected void CheckBox4_CheckedChanged1(object sender, System.EventArgs e)
        {

        }
    }
}