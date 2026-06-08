using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Refrigtz
{

    public class ThingsConverter
    {
        //Initiate Global Variables.
        bool ArrangmentsChanged = false;
        public static bool ClickOcurred = false;
        public static bool ActOfClickEqualTow = false;
        public bool Convert = false;
        public bool ConvertedToMinister = false;
        public bool ConvertedToBridge = false;
        public bool ConvertedToElefant = false;
        public bool ConvertedToHourse = false;
        public int Max;
        public int Row, Column;
        Color color;
        int Order;
        int Current = 0;
        FormRefrigtz THIS;
        public ThingsConverter()
        { }
        //Constructor
        public ThingsConverter(bool Arrangments, int i, int j, Color a, int[,] Tab, int Ord, bool TB, int Cur,ref FormRefrigtz THI)
        {
            //Initite Global Variables with Local Parameter.
            THIS = THI;
            ArrangmentsChanged = Arrangments;
            Row = i;
            Column = j;
            color = a;
            Order = Ord;
            Current = Cur;


        }
        //Convert Operation of Randomly All State Method.
        public bool ConvertOperation(int i, int j, Color a, int[,] Tab, int Ord, bool TB, int Cur)
        {
            //Initiate Global variables with Local One.
            Row = i;
            Column = j;
            color = a;
            Order = Ord;
            Current = Cur;
            //If Convert is Act and click tow time occured
            if (!Convert && ActOfClickEqualTow)
            {
                ClickOcurred = true;
                //Set tow time click unclicked.
                ActOfClickEqualTow = false;
                if (!ArrangmentsChanged)
                {
                    //Convert State Boolean Variable Consideration.
                    if (Order == 1 && Column == 7)
                        Convert = true;
                    if (Order == -1 && Column == 0)
                        Convert = true;
                }
                else
                {
                    //Convert State Boolean Variable Consideration.
                    if (Order == 1 && Column == 0)
                        Convert = true;
                    if (Order == -1 && Column == 7)
                        Convert = true;
                }
                //If Converted is Occured the Operation od Set and table reference content occured.
                if (Convert)
                {
                    if (!FormRefrigtz.Blitz)
                    {
                        FormُSelectItems.Items = 0;
                        AllDraw.SodierConversionOcuured = true;
                        //Randomly Number of 4 kind Object.
                        int Rand = -1;
                        if (FormRefrigtz.Person && FormRefrigtz.StateCP && THIS.Sec.radioButtonGrayOrder.Checked)
                        {
                            if (FormRefrigtz.OrderPlate == 1)
                            {
                                (new FormُSelectItems()).ShowDialog();

                                Rand = FormُSelectItems.Items;
                            }
                        }
                        else
                            if (FormRefrigtz.Person && FormRefrigtz.StateCP && THIS.Sec.radioButtonBrownOrder.Checked)
                            {
                                if (FormRefrigtz.OrderPlate == -1)
                                {
                                    (new FormُSelectItems()).ShowDialog();

                                    Rand = FormُSelectItems.Items;
                                }
                            }
                            else
                                Rand = (new Random()).Next(0, 4);
                        //If Rand is Equaled the Operation will cuased automaticcally Base on Color..
                        if (Rand == 0)
                        {
                            if (Order == 1)
                            {
                                // MinisterMidle++;
                                //MinisterHigh++;
                                Tab[Row, Column] = 5;
                            }
                            else if (Order == -1)
                            {
                                //MinisterHigh++;
                                Tab[Row, Column] = -5;
                            }
                            ConvertedToMinister = true;
                        }
                        else if (Rand == 1)
                        {
                            if (Order == 1)
                            {
                                //BridgeMidle++;
                                //BridgeHigh++;
                                Tab[Row, Column] = 4;
                            }
                            else if (Order == -1)
                            {
                                //BridgeHigh++;
                                Tab[Row, Column] = -4;
                            }
                            ConvertedToBridge = true;
                        }
                        else if (Rand == 2)
                        {
                            if (Order == 1)
                            {
                                //HourseMidle++;
                                //HourseHight++;
                                Tab[Row, Column] = 3;
                            }
                            else if (Order == -1)
                            {
                                //HourseHight++;
                                Tab[Row, Column] = -3;

                            }
                            ConvertedToHourse = true;
                        }
                        else
                        {
                            if (Order == 1)
                            {
                                //ElefantMidle++;
                                //ElefantHigh++;
                                Tab[Row, Column] = 2;
                            }
                            else if (Order == -1)
                            {
                                //ElefantHigh++;
                                Tab[Row, Column] = -2;
                            }
                            ConvertedToElefant = true;
                        }
                    }
                    else
                    {
                        if (FormRefrigtz.OrderPlate == 1)
                        {
                            FormُSelectItems.Items = 0;
                            AllDraw.SodierConversionOcuured = true;
                            //Randomly Number of 4 kind Object.
                            int Rand = -1;
                            if (FormRefrigtz.Person && FormRefrigtz.StateCP && THIS.Sec.radioButtonGrayOrder.Checked)
                            {
                                if (FormRefrigtz.OrderPlate == 1)
                                {
                                    (new FormُSelectItems()).ShowDialog();

                                    Rand = FormُSelectItems.Items;
                                }
                            }
                            else
                                if (FormRefrigtz.Person && FormRefrigtz.StateCP && THIS.Sec.radioButtonBrownOrder.Checked)
                                {
                                    if (FormRefrigtz.OrderPlate == -1)
                                    {
                                        (new FormُSelectItems()).ShowDialog();

                                        Rand = FormُSelectItems.Items;
                                    }
                                }
                                else
                                    Rand = (new Random()).Next(0, 4);
                            //If Rand is Equaled the Operation will cuased automaticcally Base on Color..
                            if (Rand == 0)
                            {
                                if (Order == 1)
                                {
                                    //  MinisterMidle++;
                                    //MinisterHigh++;
                                    Tab[Row, Column] = 5;
                                }
                                else if (Order == -1)
                                {
                                    //MinisterHigh++;
                                    Tab[Row, Column] = -5;
                                }
                                ConvertedToMinister = true;
                            }
                            else if (Rand == 1)
                            {
                                if (Order == 1)
                                {
                                    //BridgeMidle++;
                                    //BridgeHigh++;
                                    Tab[Row, Column] = 4;
                                }
                                else if (Order == -1)
                                {
                                    //BridgeHigh++;
                                    Tab[Row, Column] = -4;
                                }
                                ConvertedToBridge = true;
                            }
                            else if (Rand == 2)
                            {
                                if (Order == 1)
                                {
                                    //HourseMidle++;
                                    //HourseHight++;
                                    Tab[Row, Column] = 3;
                                }
                                else if (Order == -1)
                                {
                                    //HourseHight++;
                                    Tab[Row, Column] = -3;

                                }
                                ConvertedToHourse = true;
                            }
                            else
                            {
                                if (Order == 1)
                                {
                                    //ElefantMidle++;
                                    //ElefantHigh++;
                                    Tab[Row, Column] = 2;
                                }
                                else if (Order == -1)
                                {
                                    //ElefantHigh++;
                                    Tab[Row, Column] = -2;
                                }
                                ConvertedToElefant = true;
                            }
                        }


                        else
                        {



                            FormُSelectItems.Items = 0;
                            AllDraw.SodierConversionOcuured = true;
                            //Randomly Number of 4 kind Object.
                            int Rand = -1;
                            if (FormRefrigtz.Person && FormRefrigtz.StateCP && THIS.Sec.radioButtonGrayOrder.Checked)
                            {
                                if (FormRefrigtz.OrderPlate == 1)
                                {
                                    (new FormُSelectItems()).ShowDialog();

                                    Rand = FormُSelectItems.Items;
                                }
                            }
                            else
                                if (FormRefrigtz.Person && FormRefrigtz.StateCP && THIS.Sec.radioButtonBrownOrder.Checked)
                                {
                                    if (FormRefrigtz.OrderPlate == -1)
                                    {
                                        (new FormُSelectItems()).ShowDialog();

                                        Rand = FormُSelectItems.Items;
                                    }
                                }
                                else
                                    Rand = (new Random()).Next(0, 4);
                            //If Rand is Equaled the Operation will cuased automaticcally Base on Color..
                            if (Rand == 0)
                            {
                                if (Order == 1)
                                {
                                    //MinisterMidle++;
                                    //MinisterHigh++;
                                    Tab[Row, Column] = 5;
                                }
                                else if (Order == -1)
                                {
                                    //MinisterHigh++;
                                    Tab[Row, Column] = -5;
                                }
                                ConvertedToMinister = true;
                            }
                            else if (Rand == 1)
                            {
                                if (Order == 1)
                                {
                                    //BridgeMidle++;
                                    //BridgeHigh++;
                                    Tab[Row, Column] = 4;
                                }
                                else if (Order == -1)
                                {
                                    //BridgeHigh++;
                                    Tab[Row, Column] = -4;
                                }
                                ConvertedToBridge = true;
                            }
                            else if (Rand == 2)
                            {
                                if (Order == 1)
                                {
                                    //HourseMidle++;
                                    //HourseHight++;
                                    Tab[Row, Column] = 3;
                                }
                                else if (Order == -1)
                                {
                                    //HourseHight++;
                                    Tab[Row, Column] = -3;

                                }
                                ConvertedToHourse = true;
                            }
                            else
                            {
                                if (Order == 1)
                                {
                                    //ElefantMidle++;
                                    //ElefantHigh++;
                                    Tab[Row, Column] = 2;
                                }
                                else if (Order == -1)
                                {
                                    //ElefantHigh++;
                                    Tab[Row, Column] = -2;
                                }
                                ConvertedToElefant = true;
                            }
                        }
                    }
                    FormRefrigtz.ConvertWait = false;
                    return Convert;
                }
            }
            FormRefrigtz.ConvertWait = false;
            //return Convert State.
            return Convert;

        }
    }
}
//End of Documeatation.