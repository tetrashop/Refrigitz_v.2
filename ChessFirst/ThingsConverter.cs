using System;
using System.Drawing;
using System.Text;
namespace ChessFirst
{
    [Serializable]
    public class ThingsConverter
    {

        StringBuilder Space = new StringBuilder("&nbsp;");
        //#pragma warning disable CS0414 // The field 'ThingsConverter.Spaces' is assigned but its value is never used
#pragma warning disable CS0414 // The field 'ThingsConverter.Spaces' is assigned but its value is never used
        int Spaces = 0;
#pragma warning restore CS0414 // The field 'ThingsConverter.Spaces' is assigned but its value is never used
        //#pragma warning restore CS0414 // The field 'ThingsConverter.Spaces' is assigned but its value is never used

        //Initiate Global Variables.
        public static bool LoadConvertTable = false;
        public static int[,] TableConverted = null;
        bool ArrangmentsChanged = true;
        public static bool ClickOcurred = false;
        public static bool ActOfClickEqualTow = false;
        public bool Convert = false;
        public bool ConvertedToMinister = false;
        public bool ConvertedToCastle = false;
        public bool ConvertedToElefant = false;
        public bool ConvertedToHourse = false;
        public int Max;
        public int RowS, ColumnS;
        Color color;
        int Order;
        int Current = 0;
        private int rowSource;
        private int columnSource;
        private int[,] tableS;
        private int v;

        //AllDraw. THIS;
        public ThingsConverter()
        { //long Time = TimeElapced.TimeNow();Spaces++;
        }
        //Constructor
        public ThingsConverter(bool Arrangments, int i, int j, Color a, int[,] Tab, int Ord, bool TB, int Cur//,ref AllDraw. THI
            )
        {
            //long Time = TimeElapced.TimeNow();Spaces++;
            //Initite Global Variables with Local Parameter.
            //THIS = THI;
            ArrangmentsChanged = Arrangments;
            RowS = i;
            ColumnS = j;
            color = a;
            Order = Ord;
            Current = Cur;

            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ThingsConverter:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
        }
        //return maximum of six type values 
        //clone a table
        int[,] CloneATable(int[,] Tab)
        {
            int[,] Tabl = new int[8, 8];
            for (var i = 0; i < 8; i++)
                for (var j = 0; j < 8; j++)
                    Tabl[i, j] = Tab[i, j];
            return Tabl;
        }

        public ThingsConverter(bool arrangmentsChanged, int rowSource, int columnSource, Color color, int[,] tableS, int order, int v)
        {
            //long Time = TimeElapced.TimeNow();Spaces++;
            ArrangmentsChanged = arrangmentsChanged;
            this.rowSource = rowSource;
            this.columnSource = columnSource;
            this.color = color;
            this.tableS = CloneATable(tableS);
            Order = order;
            this.v = v;
            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ThingsConverter:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
        }

        //Convert Operation of Randomly All State Method.
        public bool ConvertOperation(int i, int j, Color a, int[,] Tab, int Ord, bool TB, int Cur)
        {
            //long Time = TimeElapced.TimeNow();Spaces++;
            Object OOO = new Object();
            lock (OOO)
            {
                //Initiate Global variables with Local One.
                RowS = i;
                ColumnS = j;
                color = a;
                Order = Ord;
                Current = Cur;
                //If Convert is Act and click tow time occured
                if (!Convert && (ActOfClickEqualTow || AllDraw.StateCC || (!AllDraw.Person)))

                {
                    Object O = new Object();
                    lock (O)
                    {
                        AllDraw.ConvertWait = true;
                    }

                    Object O1 = new Object();
                    lock (O1)
                    {
                        ClickOcurred = true;
                    }
                    //Set tow time click unclicked.
                    Object O2 = new Object();
                    lock (O2)
                    {
                        ActOfClickEqualTow = false;
                    }
                    if (!ArrangmentsChanged)
                    {
                        //Convert State Boolean Variable Consideration.
                        if (Order == 1 && ColumnS == 7)
                            Convert = true;
                        if (Order == -1 && ColumnS == 0)
                            Convert = true;
                    }
                    else
                    {
                        //Convert State Boolean Variable Consideration.
                        if (Order == 1 && ColumnS == 0)
                            Convert = true;
                        if (Order == -1 && ColumnS == 7)
                            Convert = true;
                    }
                    //If Converted is Occured the Operation od Set and table reference content occured.
                    if (Convert)
                    {
                        bool ASS = false; Object OOOAAA = new Object(); lock (OOOAAA) { ASS = AllDraw.Blitz; }
                        if (!ASS)
                        {
                            AllDraw.ConvertedKind = -1;
                            AllDraw.SodierConversionOcuured = true;
                            //Randomly Number of 4 kind Object.
                            int Rand = -1;
                            if (//AllDraw.Person && 
                                AllDraw.StateCP && AllDraw.THISSecradioButtonGrayOrderChecked)
                            {
                                if (AllDraw.OrderPlateDraw == 1)
                                {
                                    /* while (AllDraw.ConvertedKind == -1) { 
                                     }

                                     Rand = AllDraw.ConvertedKind;

                                     AllDraw.ConvertedKind = -2;
 */
                                    Rand = 0;
                                    ConvertedToMinister = true;
                                    AllDraw.ConvertedKind = -2;
                                }
                            }
                            else
                                if (//AllDraw.Person &&
                                AllDraw.StateCP && AllDraw.THISSecradioButtonBrownOrderChecked)
                            {
                                if (AllDraw.OrderPlateDraw == -1)
                                {
                                    //(new FormُSelectItems()).ShowDialog();
                                    /*  while (AllDraw.ConvertedKind == -1) {  
                                      }

                                      Rand = AllDraw.ConvertedKind;

                                      AllDraw.ConvertedKind = -2;
                                 */
                                    Rand = 0;
                                    ConvertedToMinister = true;
                                    AllDraw.ConvertedKind = -2;
                                }
                            }
                            else
                                Rand = (new Random()).Next(0, 4);
                            //If Rand is Equaled the Operation will cuased automaticcally base on Color..
                            if (Rand == 0)
                            {
                                if (Order == 1)
                                {
                                    // MinisterMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                    //MinisterHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                    Tab[RowS, ColumnS] = 5;
                                }
                                else if (Order == -1)
                                {
                                    //MinisterHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                    Tab[RowS, ColumnS] = -5;
                                }
                                ConvertedToMinister = true;
                            }
                            else if (Rand == 1)
                            {
                                if (Order == 1)
                                {
                                    //CastleMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                    //CastleHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                    Tab[RowS, ColumnS] = 4;
                                }
                                else if (Order == -1)
                                {
                                    //CastleHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                    Tab[RowS, ColumnS] = -4;
                                }
                                ConvertedToCastle = true;
                            }
                            else if (Rand == 2)
                            {
                                if (Order == 1)
                                {
                                    //HourseMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                    //HourseHight+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                    Tab[RowS, ColumnS] = 3;
                                }
                                else if (Order == -1)
                                {
                                    //HourseHight+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                    Tab[RowS, ColumnS] = -3;

                                }
                                ConvertedToHourse = true;
                            }
                            else
                            {
                                if (Order == 1)
                                {
                                    //ElefantMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                    //ElefantHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                    Tab[RowS, ColumnS] = 2;
                                }
                                else if (Order == -1)
                                {
                                    //ElefantHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                    Tab[RowS, ColumnS] = -2;
                                }
                                ConvertedToElefant = true;
                            }
                        }
                        else
                        {
                            if (AllDraw.OrderPlateDraw == 1)
                            {
                                AllDraw.ConvertedKind = -1;
                                AllDraw.SodierConversionOcuured = true;
                                //Randomly Number of 4 kind Object.
                                int Rand = -1;
                                if (//AllDraw.Person &&
                                    AllDraw.StateCP && AllDraw.THISSecradioButtonGrayOrderChecked)
                                {
                                    if (AllDraw.OrderPlateDraw == 1)
                                    {
                                        /* while (AllDraw.ConvertedKind == -1) {  
                                         }

                                         Rand = AllDraw.ConvertedKind;

                                         AllDraw.ConvertedKind = -2;
                                    */
                                        Rand = 0;
                                        ConvertedToMinister = true;
                                        AllDraw.ConvertedKind = -2;
                                    }
                                }
                                else
                                    if (//AllDraw.Person && 
                                    AllDraw.StateCP && AllDraw.THISSecradioButtonBrownOrderChecked)
                                {
                                    if (AllDraw.OrderPlateDraw == -1)
                                    {
                                        /*  while (AllDraw.ConvertedKind == -1) {  
                                          }

                                          Rand = AllDraw.ConvertedKind;

                                          AllDraw.ConvertedKind = -2;
                                      */
                                        Rand = 0;
                                        ConvertedToMinister = true;
                                        AllDraw.ConvertedKind = -2;
                                    }
                                }
                                else
                                    Rand = (new Random()).Next(0, 4);
                                //If Rand is Equaled the Operation will cuased automaticcally base on Color..
                                if (Rand == 0)
                                {
                                    if (Order == 1)
                                    {
                                        //  MinisterMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        //MinisterHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = 5;
                                    }
                                    else if (Order == -1)
                                    {
                                        //MinisterHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = -5;
                                    }
                                    ConvertedToMinister = true;
                                }
                                else if (Rand == 1)
                                {
                                    if (Order == 1)
                                    {
                                        //CastleMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        //CastleHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = 4;
                                    }
                                    else if (Order == -1)
                                    {
                                        //CastleHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = -4;
                                    }
                                    ConvertedToCastle = true;
                                }
                                else if (Rand == 2)
                                {
                                    if (Order == 1)
                                    {
                                        //HourseMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        //HourseHight+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = 3;
                                    }
                                    else if (Order == -1)
                                    {
                                        //HourseHight+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = -3;

                                    }
                                    ConvertedToHourse = true;
                                }
                                else
                                {
                                    if (Order == 1)
                                    {
                                        //ElefantMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        //ElefantHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = 2;
                                    }
                                    else if (Order == -1)
                                    {
                                        //ElefantHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = -2;
                                    }
                                    ConvertedToElefant = true;
                                }
                            }


                            else
                            {



                                AllDraw.ConvertedKind = -1;
                                AllDraw.SodierConversionOcuured = true;
                                //Randomly Number of 4 kind Object.
                                int Rand = -1;
                                if (//AllDraw.Person && 
                                    AllDraw.StateCP && AllDraw.THISSecradioButtonGrayOrderChecked)
                                {
                                    if (AllDraw.OrderPlateDraw == 1)
                                    {
                                        /*  while (AllDraw.ConvertedKind == -1) { 
                                          }

                                          Rand = AllDraw.ConvertedKind;

                                          AllDraw.ConvertedKind = -2;
                                    */
                                        Rand = 0;
                                        ConvertedToMinister = true;
                                        AllDraw.ConvertedKind = -2;
                                    }
                                }
                                else
                                    if (//AllDraw.Person && 
                                    AllDraw.StateCP && AllDraw.THISSecradioButtonBrownOrderChecked)
                                {
                                    if (AllDraw.OrderPlateDraw == -1)
                                    {
                                        /*   while (AllDraw.ConvertedKind == -1) { 
                                           }

                                           Rand = AllDraw.ConvertedKind;

                                           AllDraw.ConvertedKind = -2;
                                      */
                                        Rand = 0;
                                        ConvertedToMinister = true;
                                        AllDraw.ConvertedKind = -2;
                                    }
                                }
                                else
                                    Rand = (new Random()).Next(0, 4);
                                //If Rand is Equaled the Operation will cuased automaticcally base on Color..
                                if (Rand == 0)
                                {
                                    if (Order == 1)
                                    {
                                        //MinisterMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        //MinisterHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = 5;
                                    }
                                    else if (Order == -1)
                                    {
                                        //MinisterHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = -5;
                                    }
                                    ConvertedToMinister = true;
                                }
                                else if (Rand == 1)
                                {
                                    if (Order == 1)
                                    {
                                        //CastleMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        //CastleHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = 4;
                                    }
                                    else if (Order == -1)
                                    {
                                        //CastleHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = -4;
                                    }
                                    ConvertedToCastle = true;
                                }
                                else if (Rand == 2)
                                {
                                    if (Order == 1)
                                    {
                                        //HourseMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        //HourseHight+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = 3;
                                    }
                                    else if (Order == -1)
                                    {
                                        //HourseHight+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = -3;

                                    }
                                    ConvertedToHourse = true;
                                }
                                else
                                {
                                    if (Order == 1)
                                    {
                                        //ElefantMidle+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        //ElefantHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = 2;
                                    }
                                    else if (Order == -1)
                                    {
                                        //ElefantHigh+=0.00000000000000000000000000000000000000000000000000000000000000000000000001;
                                        Tab[RowS, ColumnS] = -2;
                                    }
                                    ConvertedToElefant = true;
                                }
                            }
                        }
                        AllDraw.ConvertWait = false;

                    }
                }
                AllDraw.ConvertWait = false;
                if (Convert)
                {
                    Object O = new Object();
                    lock (O)
                    {
                        TableConverted = new int[8, 8];
                        for (var iii = 0; iii < 8; iii++)
                            for (var jjj = 0; jjj < 8; jjj++)
                                TableConverted[iii, jjj] = Tab[iii, jjj];
                    }
                    Object O1 = new Object();
                    lock (O1)
                    {
                        LoadConvertTable = true;
                    }


                }

                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("ConvertOperation:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                //return Convert State.
                return Convert;
            }
        }
    }
}
//End of Documeatation.