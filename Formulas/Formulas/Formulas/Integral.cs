//ERROR19824201984  :The FX Has no Sample.
//ERRORCORECTION209874 :The above error is corected.
//=========================================================
//ERROR981724 :ATX Error Has Ocured in DerivasionFX.refer to page 172.
//=========================================================
//LOCATION9781249843 :Need to Indicating null.refer to page 180.
//=========================================================
//ERRORCORECTION984102934809 :The corection of error.refer to page 180.
//=========================================================
//ERRORCORECTION97918724 :Error corrected.refer to page 180.
//=========================================================
//ERROR019824098 :The first node is null until now.refer to page 181.
//=========================================================
//ERROR307040131222  :Ther method give wrong at (Derivasion I).refre to page 182.
//=========================================================
//ERROR31714213 :efer to page 182 and read the error description.
//=========================================================
//ERRORCORECTION918729348 :The Error is here .refer to page 218.
//ERROR9816243 :The Thread error is occured from here.refer to page 218.
//ERRORCORECTION09119824 :The error may occured from here.refer to page 218.
//=========================================================
//ERRORCORRECTION872318712 :The Dummy has no ay effect.refer to page 218.
//=========================================================
//ERROR02323909 : The invalid error.refer to page 220.
//=========================================================
//ERROR198274897234 :The Queficient must subtract to num.refer to page 221.
//ERRORCORECTION18726387 :The error is here .refer to page 221.
//ERRORCORECTION0921849823 :The number soud mul to minuse one.refer to page 221.
//=========================================================
//ERROR3170405060 :Refer to page 225.
//=========================================================
//LOCATION306070 :Refer top page 225.
//=========================================================
//LOCATION3060607080 :Teh simplifierfxsimplifier has encounterd an error.
//=========================================================
//LOCATION307060 :Refer to page 227.
//=========================================================
//LOCATION3040507060 :Refer to page 238.
//=========================================================
//LOCATION31745232 :refe to page 238.
//=========================================================
//ERRORCORECTION19824334 :the New Dummy set at MUL.refer o page 240.
//=========================================================
//LOCATION127864876234 :Refer to page 242.
//=========================================================
//ERRORCORECION89179287 :the Copy may be useful.refer to page 250.
//=========================================================
//LCOCATION1286871264 :Refer to page 255.
//=========================================================
//ERROR30174152 :Refer to page 261.
//=========================================================
//ERRORCORECTION66456546464:The Multiplicative Queficient Solved with Erro Calculation.
//=========================================================
//ERRORCORECTION444546544:The Multiply Constant number at independence variable is resolved:1394/3/30
//=========================================================
//ERRORCORECTION644344654554:The Derivasion Should be Copy.:1394/4/9
//=========================================================
//ERRORCORECTION6546544644544:The Power Integral Power and The Multiplication Integral Recursive Integral resolved:1394/4/9
//=========================================================

namespace Formulas
{
    static class Integral
    {
        static float Queficient = (float)1.0;
        static public bool IntegralSignPositive = false;
        static AddToTreeTreeLinkList INTEGRALS = new AddToTreeTreeLinkList();
        static AddToTreeTreeLinkList ANSWERS = new AddToTreeTreeLinkList();
        static AddToTreeTreeLinkList FDeviosionByG = new AddToTreeTreeLinkList();
        static AddToTreeTreeLinkList FMulAtG = new AddToTreeTreeLinkList();
        static StackBoolean stk = new StackBoolean();

        static public AddToTree.Tree IntegralOfFX(AddToTree.Tree Node, ref UknownIntegralSolver UIS)
        {
            do
            {
                INTEGRALS.DELETEFromTreeFirstNode();
            } while (!(INTEGRALS.ISEmpty()));
            do
            {
                FDeviosionByG.DELETEFromTreeFirstNode();
            } while (!(FDeviosionByG.ISEmpty()));
            do
            {
                FMulAtG.DELETEFromTreeFirstNode();
            } while (!(FMulAtG.ISEmpty()));

            FMulAtG.ADDToTree(Node.CopyNewTree(Node));

            AddToTree.Tree Dummy = new AddToTree.Tree(null, false);
            //Node = Simplifier.SimplifierFx(Node);
            Dummy = Integral.IntegralCalculator(Node.CopyNewTree(Node), ref UIS);
            return Dummy;
        }
        static public int NumberOfElements(AddToTree.Tree Dummy)
        {
            int i = 0;
            if (Dummy == null)
                return 0;
            else
                i++;
            i = i + Integral.NumberOfElements(Dummy.LeftSideAccess);
            i = i + Integral.NumberOfElements(Dummy.RightSideAccess);
            return i;
        }
        static public int NumberOfElementsSet(Set Dummy)
        {
            int i = 0;
            if (Dummy == null)
                return 0;
            else
                i++;
            i = i + Integral.NumberOfElementsSet(Dummy.LeftSideAccess);
            i = i + Integral.NumberOfElementsSet(Dummy.RightSideAccess);
            return i;
        }
        static public int NumberOfFunctionElementsSet(Set Dummy)
        {
            int i = 0;
            if (Dummy == null)
                return 0;
            else
                if ((Dummy.StringSampleAccess.Length) >= 2)
                i++;
            i = i + Integral.NumberOfFunctionElementsSet(Dummy.LeftSideAccess);
            i = i + Integral.NumberOfFunctionElementsSet(Dummy.RightSideAccess);
            return i;
        }
        //ERRORCORECTION66456546464:The Multiplicative Queficient Solved with Erro Calculation.
        //ERRORCORECTION644344654554:The Derivasion Should be Copy.:1394/4/9
        //ERRORCORECTION6546544644544:The Power Integral Power and The Multiplication Integral Recursive Integral resolved:1394/4/9
        static AddToTree.Tree IntegralCalculator(AddToTree.Tree Node, ref UknownIntegralSolver UIS)
        {
            UIS.SetLableValue(UIS.label17, "Integral Begin.");
            int INCREASE = 2147483647;

            AddToTree.Tree Dummy = new AddToTree.Tree(null, false);

            AddToTree.Tree DummyEqual = new AddToTree.Tree(null, false);
            if (Node == null)
                return Dummy;


            //bool IntegralA = false;
            UIS.SetLableValue(UIS.label17, "Integral Begin  Simplifier.");
            Node = Simplifier.SimplifierFx(Node.CopyNewTree(Node), ref UIS);

            Node = ChangeFunction.ChangeFunctionFx(Node.CopyNewTree(Node), ref UIS);

            INTEGRALS.ADDToTree(Node);




            if (IS.ISindependenceVaribaleOrNumber(Node.SampleAccess))
            {
                UIS.SetLableValue(UIS.label17, "Integral Independence or Variable Finder.");
                Dummy = Integral.ConsTantFuctionIntegral(Node);
                return Dummy;
            }
            else
            if ((IS.IsFunction(Node.SampleAccess)) && (IS.ISindependenceVaribale(Node.LeftSideAccess.SampleAccess)))
            {
                UIS.SetLableValue(UIS.label17, "Integral Function Finder.");
                Dummy = Integral.ConsTantFuctionIntegral(Node.CopyNewTree(Node));
                return Dummy;
            }
            else
                    if (Node.LeftSideAccess != null)
                if (Node.LeftSideAccess.LeftSideAccess == null)
                    if (Node.LeftSideAccess.RightSideAccess == null)
                        if ((IS.IsFunction(Node.SampleAccess)) || (IS.ISindependenceVaribaleOrNumber(Node.SampleAccess)))
                        {
                            UIS.SetLableValue(UIS.label17, "Integral Function Finder.");
                            Dummy = Integral.ConsTantFuctionIntegral(Node.CopyNewTree(Node));
                            return Dummy;
                        }
                        else
                    if (Node.LeftSideAccess != null)
                            if (Node.LeftSideAccess.LeftSideAccess == null)
                                if (Node.LeftSideAccess.RightSideAccess == null)
                                    if (Node.RightSideAccess != null)
                                        if (Node.RightSideAccess.LeftSideAccess == null)
                                            if (Node.LeftSideAccess.RightSideAccess == null)
                                                if (IS.IsPower(Node.SampleAccess) && IS.ISindependenceVaribaleOrNumber(Node.RightSideAccess.SampleAccess) && IS.IsNumber(Node.LeftSideAccess.SampleAccess))
                                                {
                                                    UIS.SetLableValue(UIS.label17, "Integral exponential.");
                                                    AddToTree.Tree DummyONE = new AddToTree.Tree("1", false);
                                                    AddToTree.Tree DummyONEDivide = new AddToTree.Tree("/", false);
                                                    AddToTree.Tree DummyDivide = new AddToTree.Tree("/", false);
                                                    AddToTree.Tree DummyLn = new AddToTree.Tree("Ln", false);
                                                    AddToTree.Tree DummyNumber = new AddToTree.Tree(Node.LeftSideAccess.SampleAccess, false);
                                                    AddToTree.Tree DummyInde = Node.CopyNewTree(Node);

                                                    DummyONE.LeftSideAccess = null;
                                                    DummyONE.RightSideAccess = null;


                                                    DummyNumber.LeftSideAccess = null;
                                                    DummyNumber.RightSideAccess = null;

                                                    DummyLn.SetLefTandRightCommonlySide(DummyNumber, null);
                                                    DummyLn.LeftSideAccess.ThreadAccess = DummyLn;
                                                    DummyLn.RightSideAccess = null;

                                                    DummyDivide.SetLefTandRightCommonlySide(DummyONE, DummyLn);
                                                    DummyDivide.LeftSideAccess.ThreadAccess = DummyDivide;
                                                    DummyDivide.RightSideAccess.ThreadAccess = DummyDivide;


                                                    Dummy = new AddToTree.Tree("*", false);
                                                    Dummy.SetLefTandRightCommonlySide(DummyDivide, DummyInde);
                                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                                                    return Dummy;
                                                }
            if (KnownIntegralFormulla.KnownIntegralFormullaFx(Node) != null)
            {
                UIS.SetLableValue(UIS.label17, "Integral UnownIntegral Finder.");
                return KnownIntegralFormulla.KnownIntegralFormullaFx(Node.CopyNewTree(Node));
            }
            //ERRORCORECTION444546544:The Multiply Constant number at independence variable is resolved:1394/3/30
            if (Node.SampleAccess == "*")
            {
                UIS.SetLableValue(UIS.label17, "Integral F(X)*G(X).");

                FDeviosionByG.ADDToTree(null);



                int HOLDE = 0;
                //UIS.label4.Text = "F(x)*G(X)";

                INCREASE = INCREASE / 5;



                UIS.SetProgressValue(UIS.progressBar2, 0);
                AddToTree.Tree PONE = new AddToTree.Tree(null, false);
                AddToTree.Tree PTOW = new AddToTree.Tree(null, false);

                AddToTree.Tree DummyONE = new AddToTree.Tree("*", false);
                AddToTree.Tree DummyDerivationF = new AddToTree.Tree("*", false);
                AddToTree.Tree DummyTOW = new AddToTree.Tree("*", false);

                AddToTree.Tree DummyHOLDE = new AddToTree.Tree(null, false);

                PONE = Node.CopyNewTree(Node.LeftSideAccess);
                PTOW = Node.CopyNewTree(Node.RightSideAccess);

                UIS.SetProgressValue(UIS.progressBar2, INCREASE + UIS.progressBar2.Value);

                HOLDE = UIS.progressBar2.Value;

                Queficient = (float)1.0;

                DummyHOLDE = Integral.IntegralCalculator(PTOW.CopyNewTree(PTOW), ref UIS);

                UIS.SetLableValue(UIS.label17, "Integral F(X)*G(X).");




                UIS.SetProgressValue(UIS.progressBar2, HOLDE);

                DummyDerivationF = Derivasion.DerivasionOfFX(PONE.CopyNewTree(PONE), ref UIS);
                DummyTOW.SetLefTandRightCommonlySide(DummyDerivationF, DummyHOLDE);
                DummyTOW.LeftSideAccess.ThreadAccess = DummyTOW;
                DummyTOW.RightSideAccess.ThreadAccess = DummyTOW;

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                DummyTOW = Simplifier.SimplifierFx(DummyTOW, ref UIS);

                DummyONE.SetLefTandRightCommonlySide(PONE.CopyNewTree(PONE), DummyHOLDE.CopyNewTree(DummyHOLDE));
                DummyONE.LeftSideAccess.ThreadAccess = DummyONE;
                DummyONE.RightSideAccess.ThreadAccess = DummyONE;

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                DummyONE = Simplifier.SimplifierFx(DummyONE, ref UIS);

                UIS.SetProgressValue(UIS.progressBar2, INCREASE + UIS.progressBar2.Value);




                if (DummyTOW.SampleAccess == null)
                    DummyTOW.SampleAccess = "0";








                //if ((IntegralRecursiveMulatFG.IntegralRecursiveMulatFGFx(FMulAtG.CopyLinkList(), DummyTOW,ref UIS)))
                if (!(IntegralRecursiveMulatFG.IntegralRecursiveMulatFPowerGFx(Node, DummyTOW, ref UIS, ref Queficient)))
                {
                    double CIntegralG = 0, QDerivasion = 0;
                    if (DummyHOLDE.SampleAccess == "*")
                    {
                        if (IS.IsNumber(DummyHOLDE.LeftSideAccess.SampleAccess))
                            CIntegralG = System.Convert.ToDouble(DummyHOLDE.LeftSideAccess.SampleAccess);
                        else
                            if (IS.IsNumber(DummyHOLDE.RightSideAccess.SampleAccess))
                            CIntegralG = System.Convert.ToDouble(DummyHOLDE.RightSideAccess.SampleAccess);
                        else
                            CIntegralG = 1.0;

                    }
                    else
                        if (IS.IsNumber(DummyHOLDE.SampleAccess))
                        CIntegralG = System.Convert.ToDouble(DummyHOLDE.SampleAccess);
                    else
                        CIntegralG = 1.0;
                    if (DummyDerivationF.SampleAccess == "*")
                    {
                        if (IS.IsNumber(DummyDerivationF.LeftSideAccess.SampleAccess))
                            QDerivasion = System.Convert.ToDouble(DummyDerivationF.LeftSideAccess.SampleAccess);
                        else
                            if (IS.IsNumber(DummyDerivationF.RightSideAccess.SampleAccess))
                            QDerivasion = System.Convert.ToDouble(DummyDerivationF.RightSideAccess.SampleAccess);
                        else
                            QDerivasion = 1.0;

                    }
                    else
                        if (IS.IsNumber(DummyDerivationF.SampleAccess))
                        QDerivasion = System.Convert.ToDouble(DummyDerivationF.SampleAccess);
                    else
                        QDerivasion = 1.0;
                    DummyTOW.SetLefTandRightCommonlySide(null, null);
                    //Queficient = (float)System.Math.Round(1 / Queficient);
                    if (IntegralSignPositive)
                        DummyTOW.SampleAccess = (CIntegralG / (1 - QDerivasion)).ToString();
                    else
                        DummyTOW.SampleAccess = (CIntegralG / (1 + QDerivasion)).ToString();


                    Dummy.SampleAccess = "*";
                    Dummy.SetLefTandRightCommonlySide(Node, DummyTOW);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy = Simplifier.SimplifierFx(Dummy, ref UIS);
                    UIS.SetProgressValue(UIS.progressBar2, 2147483647);
                    return Dummy;

                }
                else
                {
                    if (DummyTOW != null)
                    {
                        HOLDE = UIS.progressBar2.Value;

                        FMulAtG.ADDToTree(DummyTOW.CopyNewTree(DummyTOW));

                        DummyTOW = ChangeFunction.ChangeFunctionFx(DummyTOW, ref UIS);

                        Queficient = (float)1.0;

                        DummyTOW = Integral.IntegralCalculator(DummyTOW.CopyNewTree(DummyTOW), ref UIS);

                        UIS.SetLableValue(UIS.label17, "Integral F(X)*G(X).");

                        if (DummyTOW == null)
                            return DummyONE;

                        UIS.SetProgressValue(UIS.progressBar2, HOLDE);

                        Dummy.SampleAccess = "-";
                        Dummy.SetLefTandRightCommonlySide(DummyONE, DummyTOW);
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                        Dummy = Simplifier.SimplifierFx(Dummy, ref UIS);
                        UIS.SetProgressValue(UIS.progressBar2, 2147483647);
                        return Dummy;
                    }
                    else
                    {
                        UIS.SetProgressValue(UIS.progressBar2, 2147483647);
                        return DummyONE;
                    }
                }





                /*
                AddToTree.Tree P = new AddToTree.Tree(null, false); 
                P = Node.CopyNewTree(Node.LeftSideAccess);
                P.ThreadAccess        = null;
                P                     = Integral.IntegralCalculator(P,ref UIS);
                P = Simplifier.SimplifierFx(P,ref UIS);

                AddToTree.Tree PONE = new AddToTree.Tree(null, false);
                //AddToTree.Tree PTOW = new AddToTree.Tree(null, false);
                //AddToTree.Tree PTHREE = new AddToTree.Tree(null, false);
                //AddToTree.Tree PFOUR = new AddToTree.Tree(null, false);
                //AddToTree.Tree PFIVE = new AddToTree.Tree(null, false);

                PONE = PONE.CopyNewTree(P);
                //PTOW = PTOW.CopyNewTree(P);
                //PTHREE = PTHREE.CopyNewTree(P);
                //PFOUR = PFOUR.CopyNewTree(P);
                //PFIVE = PFIVE.CopyNewTree(P);

                AddToTree.Tree G = new AddToTree.Tree(null, false); 
                G = Node.CopyNewTree(Node.RightSideAccess);
                G.ThreadAccess        = null;                
                G                     = Integral.IntegralCalculator(G,ref UIS);

                G = Simplifier.SimplifierFx(G,ref UIS);

                //G = Simplifier.SimplifierFx(G);

                AddToTree.Tree GONE = new AddToTree.Tree(null, false);
                AddToTree.Tree GTOW = new AddToTree.Tree(null, false);
                AddToTree.Tree GTHREE = new AddToTree.Tree(null, false);
                AddToTree.Tree GFOUR = new AddToTree.Tree(null, false);
                //AddToTree.Tree GFIVE = new AddToTree.Tree(null, false);

                GONE = GONE.CopyNewTree(G);
                GTOW = GTOW.CopyNewTree(G);
                GTHREE = GTHREE.CopyNewTree(G);
                GFOUR = GFOUR.CopyNewTree(G);
                //GFIVE = GFIVE.CopyNewTree(G);

                AddToTree.Tree HX = new AddToTree.Tree(null, false);

                AddToTree.Tree TX = new AddToTree.Tree(null, false);
                AddToTree.Tree TXONE = new AddToTree.Tree(null, false);
                AddToTree.Tree TXTOW = new AddToTree.Tree(null, false);
                AddToTree.Tree MX    = new AddToTree.Tree(null, false);
                AddToTree.Tree MXONE = new AddToTree.Tree(null, false);
                AddToTree.Tree MXTOW = new AddToTree.Tree(null, false);
                
                AddToTree.Tree ATX = new AddToTree.Tree(null, false);
                AddToTree.Tree BTX = new AddToTree.Tree(null, false);
                AddToTree.Tree CTX = new AddToTree.Tree(null, false);
                AddToTree.Tree DONETX = new AddToTree.Tree(null, false);
                AddToTree.Tree DTX = new AddToTree.Tree(null, false);
                AddToTree.Tree EONETX = new AddToTree.Tree(null, false);
                AddToTree.Tree ETOWTX = new AddToTree.Tree(null, false);
                AddToTree.Tree ETHREETX = new AddToTree.Tree(null, false);
                AddToTree.Tree ETX = new AddToTree.Tree(null, false);
                AddToTree.Tree FONETX = new AddToTree.Tree(null, false);
                AddToTree.Tree FTOWTX = new AddToTree.Tree(null, false);
                AddToTree.Tree FTX = new AddToTree.Tree(null, false);

                AddToTree.Tree AMX = new AddToTree.Tree(null, false);
                AddToTree.Tree BMX = new AddToTree.Tree(null, false);
                AddToTree.Tree CMX = new AddToTree.Tree(null, false);                
                AddToTree.Tree DMX = new AddToTree.Tree(null, false);
                AddToTree.Tree EMX = new AddToTree.Tree(null, false);
                AddToTree.Tree FMX = new AddToTree.Tree(null, false);

                //AddToTree.Tree SIX      = new AddToTree.Tree("-6", false);
                //AddToTree.Tree THREE    = new AddToTree.Tree("3", false);
                //AddToTree.Tree THREETOW = new AddToTree.Tree("3", false);
                //AddToTree.Tree ONE      = new AddToTree.Tree("-1", false);
                //AddToTree.Tree TOW      = new AddToTree.Tree("2", false);
                //AddToTree.Tree TOWLast  = new AddToTree.Tree("2", false);
                //AddToTree.Tree CZERO    = new AddToTree.Tree("2", false);
                //AddToTree.Tree CONE     = new AddToTree.Tree("-1", false);
                //AddToTree.Tree CTHREE   = new AddToTree.Tree("C", false);

                AddToTree.Tree TXDE = new AddToTree.Tree("*", false);
                AddToTree.Tree TXCF = new AddToTree.Tree("*", false);
                AddToTree.Tree TXAD = new AddToTree.Tree("*", false);
                AddToTree.Tree TXBC = new AddToTree.Tree("*", false);

                AddToTree.Tree MXAF = new AddToTree.Tree("*", false);
                AddToTree.Tree MXBE = new AddToTree.Tree("*", false);
                AddToTree.Tree MXAD = new AddToTree.Tree("*", false);
                AddToTree.Tree MXBC = new AddToTree.Tree("*", false);

                //AddToTree.Tree BELOW = new AddToTree.Tree(null, false);
                //AddToTree.Tree THREEBELOW = new AddToTree.Tree("3", false);
                //AddToTree.Tree TOWBELOW = new AddToTree.Tree("2", false);
                //AddToTree.Tree PTHREEBELOW = new AddToTree.Tree("*", false);
                //AddToTree.Tree GTOWBELOW = new AddToTree.Tree("*", false);

                AddToTree.Tree ONEHX = new AddToTree.Tree("1",false);

                HX.SetLefTandRightCommonlySide(ONEHX,P);
                HX.LeftSideAccess.ThreadAccess = HX;
                HX.RightSideAccess.ThreadAccess = HX;
                HX.SampleAccess = "/";

                UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                 HX = Simplifier.SimplifierFx(HX,ref UIS);

                //ATX = GONE.CopyNewTree(GONE);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE); 

                AddToTree.Tree ONETX                 = new AddToTree.Tree("1", false);
                AddToTree.Tree ONEPERTOWATX = new AddToTree.Tree("0.5", false);
                AddToTree.Tree ONETXMINUSEONEPRTOW   = new AddToTree.Tree("*", false);

                ONETXMINUSEONEPRTOW.SetLefTandRightCommonlySide(ONEPERTOWATX,GONE);
                ONETXMINUSEONEPRTOW.LeftSideAccess.ThreadAccess = ONETXMINUSEONEPRTOW;
                ONETXMINUSEONEPRTOW.RightSideAccess.ThreadAccess = ONETXMINUSEONEPRTOW;

                ATX.SetLefTandRightCommonlySide(ONETX,ONETXMINUSEONEPRTOW);
                ATX.LeftSideAccess.ThreadAccess = ATX;
                ATX.RightSideAccess.ThreadAccess = ATX;
                ATX.SampleAccess = "-";
                
               
               

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE); 

                ATX = Simplifier.SimplifierFx(ATX,ref UIS);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE); 

                BTX.SampleAccess = "-0.5";

                AddToTree.Tree ONEPERTOWCTX = new AddToTree.Tree("-0.5", false);

                CTX.SetLefTandRightCommonlySide(ONEPERTOWCTX,GTOW);
                CTX.LeftSideAccess.ThreadAccess = CTX;
                CTX.RightSideAccess.ThreadAccess = CTX;
                CTX.SampleAccess = "*";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                CTX = Simplifier.SimplifierFx(CTX,ref UIS);

                DTX.SampleAccess = "0.5";

                AddToTree.Tree ONEETXONE = new AddToTree.Tree("1",false);
                AddToTree.Tree ONEPERTOWTXTOW = new AddToTree.Tree("0.5",false);

                ETX.SetLefTandRightCommonlySide(ONEETXONE,GTHREE);
                ETX.LeftSideAccess.ThreadAccess = ETX;
                ETX.RightSideAccess.ThreadAccess = ETX;
                ETX.SampleAccess = "/";

                ETX.SetLefTandRightCommonlySide(ETX.CopyNewTree(ETX),ONEPERTOWTXTOW);
                ETX.LeftSideAccess.ThreadAccess = ETX;
                ETX.RightSideAccess.ThreadAccess = ETX;
                ETX.SampleAccess = "-";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;
                //ERROR30174152 :Refer to page 261.
                ETX = Simplifier.SimplifierFx(ETX,ref UIS);



                FTX.SampleAccess = "0.5";

                //FTX = Simplifier.SimplifierFx(FTX);

                AMX = ATX.CopyNewTree(ATX);
                BMX = BTX.CopyNewTree(BTX);
                CMX = CTX.CopyNewTree(CTX);
                DMX = DTX.CopyNewTree(DTX);
                EMX = ETX.CopyNewTree(ETX);
                FMX = FTX.CopyNewTree(FTX);

                AddToTree.Tree DTXCOPY = DTX.CopyNewTree(DTX);

                TXDE.SetLefTandRightCommonlySide(DTX,ETX);
                TXDE.LeftSideAccess.ThreadAccess = TXDE;
                TXDE.RightSideAccess.ThreadAccess = TXDE;
                TXDE.SampleAccess = "*";
                //LOCATION3040507060 :Refer to page 238.

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                TXDE = Simplifier.SimplifierFx(TXDE,ref UIS);

                AddToTree.Tree CTXCOPY = CTX.CopyNewTree(CTX);

                TXCF.SetLefTandRightCommonlySide(CTX,FTX);
                TXCF.LeftSideAccess.ThreadAccess = TXCF;
                TXCF.RightSideAccess.ThreadAccess = TXCF;
                TXCF.SampleAccess = "*";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                TXCF = Simplifier.SimplifierFx(TXCF,ref UIS);
                //ERRORCORECION89179287 :the Copy may be useful.refer to page 250.
                

                TXAD.SetLefTandRightCommonlySide(ATX,DTXCOPY);
                TXAD.LeftSideAccess.ThreadAccess = TXAD;
                TXAD.RightSideAccess.ThreadAccess = TXAD;
                TXAD.SampleAccess = "*";

                //LOCATION127864876234 :Refer to page 242.               
                System.Media.SystemSounds.Beep.Play();

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                TXAD = Simplifier.SimplifierFx(TXAD,ref UIS);
                
                

                TXBC.SetLefTandRightCommonlySide(BTX,CTXCOPY);
                TXBC.LeftSideAccess.ThreadAccess = TXBC;
                TXBC.RightSideAccess.ThreadAccess = TXBC;
                TXBC.SampleAccess = "*";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                TXBC = Simplifier.SimplifierFx(TXBC,ref UIS);

                MXAD = TXAD.CopyNewTree(TXAD);
                MXBC = TXBC.CopyNewTree(TXBC);

                MXAF.SetLefTandRightCommonlySide(AMX,FMX);
                MXAF.LeftSideAccess.ThreadAccess = MXAF;
                MXAF.RightSideAccess.ThreadAccess = MXAF;
                MXAF.SampleAccess = "*";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                MXAF = Simplifier.SimplifierFx(MXAF,ref UIS);

                MXBE.SetLefTandRightCommonlySide(BMX,EMX);
                MXBE.LeftSideAccess.ThreadAccess = MXBE;
                MXBE.RightSideAccess.ThreadAccess = MXBE;
                MXBE.SampleAccess = "*";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                MXBE = Simplifier.SimplifierFx(MXBE,ref UIS);

                TXONE.SetLefTandRightCommonlySide(TXDE,TXCF);
                TXONE.LeftSideAccess.ThreadAccess = TXONE;
                TXONE.RightSideAccess.ThreadAccess = TXONE;
                TXONE.SampleAccess = "-";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                TXONE = Simplifier.SimplifierFx(TXONE,ref UIS);

                TXTOW.SetLefTandRightCommonlySide(TXAD,TXBC);
                TXTOW.LeftSideAccess.ThreadAccess = TXTOW;
                TXTOW.RightSideAccess.ThreadAccess = TXTOW;
                TXTOW.SampleAccess = "-";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                TXTOW = Simplifier.SimplifierFx(TXTOW,ref UIS);

                TX.SetLefTandRightCommonlySide(TXONE, TXTOW);
                TX.LeftSideAccess.ThreadAccess = TX;
                TX.RightSideAccess.ThreadAccess = TX;
                TX.SampleAccess = "/";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                TX = Simplifier.SimplifierFx(TX,ref UIS);

                MXONE.SetLefTandRightCommonlySide(MXAF,MXBE);
                MXONE.LeftSideAccess.ThreadAccess = MXONE;
                MXONE.RightSideAccess.ThreadAccess = MXONE;
                MXONE.SampleAccess = "-";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                MXONE = Simplifier.SimplifierFx(MXONE,ref UIS);

                MXTOW.SetLefTandRightCommonlySide(MXAD,MXBC);
                MXTOW.LeftSideAccess.ThreadAccess = MXTOW;
                MXTOW.RightSideAccess.ThreadAccess = MXTOW;
                MXTOW.SampleAccess = "-";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                MXTOW = Simplifier.SimplifierFx(MXTOW,ref UIS);

                MX.SetLefTandRightCommonlySide(MXONE, MXTOW);
                MX.LeftSideAccess.ThreadAccess = MX;
                MX.RightSideAccess.ThreadAccess = MX;
                MX.SampleAccess = "/";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;
                MX = Simplifier.SimplifierFx(MX,ref UIS);

                AddToTree.Tree DummyONE   = new AddToTree.Tree(null, false);
                AddToTree.Tree DummyTOW   = new AddToTree.Tree(null, false);
                AddToTree.Tree DummyTHREE = new AddToTree.Tree(null, false);
                
                
                DummyONE.SetLefTandRightCommonlySide(HX,PONE);
                DummyONE.LeftSideAccess.ThreadAccess = DummyONE;
                DummyONE.RightSideAccess.ThreadAccess = DummyONE;
                DummyONE.SampleAccess = "*";

                 UIS.progressBar2.Value =  UIS.progressBar2.Value + INCREASE;

                DummyONE = Simplifier.SimplifierFx(DummyONE,ref UIS);

                DummyTOW.SetLefTandRightCommonlySide(TX,GFOUR);
                DummyTOW.LeftSideAccess.ThreadAccess = DummyTOW;
                DummyTOW.RightSideAccess.ThreadAccess = DummyTOW;
                DummyTOW.SampleAccess = "*";

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE); 

                DummyTOW = Simplifier.SimplifierFx(DummyTOW,ref UIS);                

                DummyTHREE.SetLefTandRightCommonlySide(DummyONE,DummyTOW);
                DummyTHREE.LeftSideAccess.ThreadAccess = DummyTHREE;
                DummyTHREE.RightSideAccess.ThreadAccess = DummyTHREE;
                DummyTHREE.SampleAccess = "+";

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE); 

                //LCOCATION1286871264 :Refer to page 255.
                DummyTHREE = Simplifier.SimplifierFx(DummyTHREE,ref UIS);

                Dummy.SetLefTandRightCommonlySide(MX,DummyTHREE);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
                Dummy.SampleAccess = "+";
                */
                //UIS.progressBar2.Value = 2147483647;
                /*
                 ///suitable for X^m+....
                
                AddToTree.Tree FTX = new AddToTree.Tree(null, false);
                AddToTree.Tree G = new AddToTree.Tree(null, false);
                AddToTree.Tree FPRIN   = new AddToTree.Tree(null, false);
                AddToTree.Tree INTGONE = new AddToTree.Tree(null, false);
                AddToTree.Tree INTGTOW = new AddToTree.Tree(null, false);

                AddToTree.Tree DONETX   = new AddToTree.Tree("*", false);
                AddToTree.Tree DTOW   = new AddToTree.Tree("*", false);
                AddToTree.Tree DTHREE = new AddToTree.Tree("-", false);

                int Left = Integral.NumberOfElements(Node.LeftSideAccess);
                int Right = Integral.NumberOfElements(Node.RightSideAccess);

                if (Left < Right)
                    Node.SetLefTandRightCommonlySide(Node.RightSideAccess,Node.LeftSideAccess);
                if (Node != null)
                    if (Node.RightSideAccess != null)
                        if (IS.IsNumber(Node.RightSideAccess.SampleAccess))
                            Node.SetLefTandRightCommonlySide(Node.RightSideAccess, Node.LeftSideAccess);

                FTX       =Node.LeftSideAccess;
                FTX.ThreadAccess = null;
                FPRIN   =Derivasion.DerivasionOfFX(FTX);
                G = Node.RightSideAccess;
                G.ThreadAccess = null;
                //ERROR9816243 :The Thread error is occured from here.
                INTGONE =Integral.IntegralCalculator(G);
                //INTGTOW =Integral.IntegralCalculator(Node.RightSideAccess);
                INTGTOW = INTGONE;
                INTGTOW.ThreadAccess = null;

                DONETX.SetLefTandRightCommonlySide(FTX,INTGONE);
                DONETX.LeftSideAccess.ThreadAccess = DONETX;
                DONETX.RightSideAccess.ThreadAccess = DONETX;

                DTOW.SetLefTandRightCommonlySide(FPRIN,INTGTOW);
                DTOW.LeftSideAccess.ThreadAccess = DTOW;
                DTOW.RightSideAccess.ThreadAccess = DTOW;
                //LOCATION3060607080 :Teh simplifierfxsimplifier has encounterd an error.
                DTOW = Simplifier.SimplifierFx(DTOW);

                if(DTOW.SampleAccess!=null)
                DTOW = Integral.IntegralCalculator(DTOW);

                DTHREE.SetLefTandRightCommonlySide(DONETX,DTOW);
                DTHREE.LeftSideAccess.ThreadAccess = DTHREE;
                DTHREE.RightSideAccess.ThreadAccess = DTHREE;

                Dummy = DTHREE;
                */
                /*AddToTreeTreeLinkList AA      = new AddToTreeTreeLinkList();
                AddToTreeTreeLinkList BA      = new AddToTreeTreeLinkList();
                AddToTreeTreeLinkList CA      = new AddToTreeTreeLinkList();
                AddToTreeTreeLinkList DA      = new AddToTreeTreeLinkList();
                AddToTreeTreeLinkList EA      = new AddToTreeTreeLinkList();
                AddToTreeTreeLinkList FA      = new AddToTreeTreeLinkList();
                AddToTree.Tree TX = new AddToTree.Tree(null, false);
                AddToTree.Tree MX = new AddToTree.Tree(null, false);
                AddToTree.Tree ATX = new AddToTree.Tree(null, false);
                AddToTree.Tree BTX      = new AddToTree.Tree(null, false);
                AddToTree.Tree CTX      = new AddToTree.Tree(null, false);
                AddToTree.Tree DTX      = new AddToTree.Tree(null, false);
                AddToTree.Tree ETX      = new AddToTree.Tree(null, false);
                AddToTree.Tree FTX      = new AddToTree.Tree(null, false);;
                AddToTree.Tree FXMULGX       = new AddToTree.Tree(null, false);
                AddToTree.Tree HolderAA = new AddToTree.Tree(null, false);
                AddToTree.Tree HolderAB = new AddToTree.Tree(null, false);
                AddToTree.Tree HolderAC = new AddToTree.Tree(null, false);
                AddToTree.Tree HolderAD = new AddToTree.Tree(null, false);
                AddToTree.Tree HolderAE = new AddToTree.Tree(null, false);
                AddToTree.Tree HolderAF = new AddToTree.Tree(null, false);

                AddToTree.Tree EC = new AddToTree.Tree(null, false);
                AddToTree.Tree AF = new AddToTree.Tree(null, false);
                AddToTree.Tree AE = new AddToTree.Tree(null, false);
                AddToTree.Tree BD = new AddToTree.Tree(null, false);
                AddToTree.Tree DF = new AddToTree.Tree(null, false);
                AddToTree.Tree BC = new AddToTree.Tree(null, false);                
                

                AddToTree.Tree DummyOne = new AddToTree.Tree(null, false);
                AddToTree.Tree DummyTow = new AddToTree.Tree(null, false);
                AddToTree.Tree DummyThree = new AddToTree.Tree(null, false);
                AddToTree.Tree DummyFour = new AddToTree.Tree(null, false);
                AddToTree.Tree DummyFive = new AddToTree.Tree(null, false);

                
                FXMULGX.SetLefTandRightCommonlySide(Node.LeftSideAccess,Node.RightSideAccess);
                FXMULGX.SampleAccess="*";
                FXMULGX.LeftSideAccess.ThreadAccess=FXMULGX;
                FXMULGX.RightSideAccess.ThreadAccess=FXMULGX;

                int i = 0;
                while (true)
                {
                    ATX=Integral.XMulDerivisionOfFx(i,Node.LeftSideAccess,null);
                    BTX=Integral.XMulDerivisionOfFx(i, Node.RightSideAccess, null);
                    CTX=Integral.XMulDerivisionOfFx(i,FXMULGX,null);
                    DTX=Integral.XPowerIMulFXPerGXDerI(i,Node.LeftSideAccess,null);
                    ETX=Integral.XPowerIMulFXPerGXDerI(i,Node.RightSideAccess,null);
                    FTX=Integral.XPowerIMulFXPerGXDerI(i,FXMULGX,null);
                    ATX = Simplifier.SimplifierFx(ATX);
                    BTX = Simplifier.SimplifierFx(BTX);
                    CTX = Simplifier.SimplifierFx(CTX);
                    DTX = Simplifier.SimplifierFx(DTX);
                    ETX = Simplifier.SimplifierFx(ETX);
                    FTX = Simplifier.SimplifierFx(FTX);

                    if (ATX.SampleAccess == null)
                        if (BTX.SampleAccess == null)
                            if (CTX.SampleAccess == null)
                                if (DTX.SampleAccess.ToLower() == "c")
                                    if (ETX.SampleAccess.ToLower() == "c")
                                        if (FTX.SampleAccess.ToLower() == "c")
                                            break;
                    if (ATX.SampleAccess != null)
                    AA.ADDToTree(ATX);
                    if (BTX.SampleAccess != null)
                    BA.ADDToTree(BTX);
                    if (CTX.SampleAccess != null)
                    CA.ADDToTree(CTX); 
                    if (DTX.SampleAccess != null)
                    DA.ADDToTree(DTX);
                    if (ETX.SampleAccess != null)
                    EA.ADDToTree(ETX); 
                    if (FTX.SampleAccess != null)
                    FA.ADDToTree(FTX); 
                    
                    
                    i++;
                }

                do
                {
                    //ERROR019824098 :The first node is null until now.refer to page 181.
                    HolderAA = AA.DELETEFromTreeFirstNode();
                    if (HolderAA != null)
                    if (HolderAA.SampleAccess != null)
                    {
                        Dummy.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy), HolderAA);
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                        Dummy.SampleAccess = "+";
                    }
                } while (HolderAA != null);
                Dummy = Simplifier.SimplifierFx(Dummy);
                HolderAA = Dummy.CopyNewTree(Dummy);

                Dummy = null;
                Dummy = new AddToTree.Tree(null, false);
                do
                {
                    HolderAB = BA.DELETEFromTreeFirstNode();
                    if (HolderAB != null)
                    if (HolderAB.SampleAccess != null)
                    {
                        Dummy.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy), HolderAA);
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                        Dummy.SampleAccess = "+";
                    }
                } while (HolderAB != null);

                Dummy = Simplifier.SimplifierFx(Dummy);
                HolderAB = Dummy.CopyNewTree(Dummy);


                Dummy = null;
                Dummy = new AddToTree.Tree(null, false);
                
                do
                {
                    HolderAC = CA.DELETEFromTreeFirstNode();
                    if (HolderAC != null)
                    if (HolderAC.SampleAccess != null)
                    {
                        Dummy.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy), HolderAC);
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                        Dummy.SampleAccess = "+";
                    }
                } while (HolderAC != null);

                Dummy = Simplifier.SimplifierFx(Dummy);
                HolderAC = Dummy;

                Dummy = null;
                Dummy = new AddToTree.Tree(null, false);
                
                do
                {
                    HolderAD = DA.DELETEFromTreeFirstNode();
                    if (HolderAD != null)
                    if (HolderAD.SampleAccess != null)
                    {
                        Dummy.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy), HolderAD);
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                        Dummy.SampleAccess = "+";
                    }
                } while (HolderAD!= null);

                Dummy = Simplifier.SimplifierFx(Dummy);
                HolderAD = Dummy;

                Dummy = null;
                Dummy = new AddToTree.Tree(null, false);
                
                do
                {
                    HolderAE = EA.DELETEFromTreeFirstNode();
                    if (HolderAE != null)
                    if (HolderAE.SampleAccess != null)
                    {
                        Dummy.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy), HolderAE);
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                        Dummy.SampleAccess = "+";
                    }
                } while (HolderAE != null);

                Dummy = Simplifier.SimplifierFx(Dummy);
                HolderAE = Dummy;

                Dummy = null;
                Dummy = new AddToTree.Tree(null, false);
                
                do
                {
                    HolderAF = FA.DELETEFromTreeFirstNode();
                    if (HolderAF != null)
                    if (HolderAF.SampleAccess != null)
                    {
                        Dummy.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy), HolderAF);
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                        Dummy.SampleAccess = "+";
                    }
                } while (HolderAF != null);

                HolderAF = Dummy;

                if ((HolderAE.SampleAccess != null) && (HolderAC.SampleAccess != null))
                {
                EC.SetLefTandRightCommonlySide(HolderAE,HolderAC);
                EC.SampleAccess = "*";
                if (HolderAE != null)
                EC.LeftSideAccess.ThreadAccess = EC;
                if (HolderAC != null)
                EC.RightSideAccess.ThreadAccess = EC;
                }

                EC = Simplifier.SimplifierFx(EC);

                if ((HolderAA.SampleAccess != null) && (HolderAF.SampleAccess != null))
                {
                    AF.SampleAccess = "2";
                    AF.SetLefTandRightCommonlySide(HolderAA, HolderAF);
                    AF.SampleAccess = "^";
                    if (HolderAD != null)
                        AF.LeftSideAccess.ThreadAccess = AF;
                    if (HolderAF != null)
                        AF.RightSideAccess.ThreadAccess = AF;
                }

                AF = Simplifier.SimplifierFx(AF);

                if ((HolderAA.SampleAccess != null) && (HolderAE.SampleAccess != null))
                {
                    AE.SetLefTandRightCommonlySide(HolderAA, HolderAE);
                    AE.SampleAccess = "*";
                    if (HolderAA != null)
                        AE.LeftSideAccess.ThreadAccess = AE;
                    if (HolderAE != null)
                        AE.RightSideAccess.ThreadAccess = AE;
                }

                AE = Simplifier.SimplifierFx(AE);

                if ((HolderAB.SampleAccess != null) && (HolderAD.SampleAccess != null))
                {
                    BD.SetLefTandRightCommonlySide(HolderAB, HolderAD);
                    BD.SampleAccess = "*";
                    if (HolderAB != null)
                        BD.LeftSideAccess.ThreadAccess = BD;
                    if (HolderAD != null)
                        BD.RightSideAccess.ThreadAccess = BD;
                }

                BD = Simplifier.SimplifierFx(BD);

                if ((EC.SampleAccess != null) || (DF.SampleAccess != null))
                {
                    DummyOne.SetLefTandRightCommonlySide(EC,DF);
                    DummyOne.SampleAccess = "-";
                    if (AE != null)
                        DummyOne.LeftSideAccess.ThreadAccess = DummyOne;
                    if (DF != null)
                        DummyOne.RightSideAccess.ThreadAccess = DummyOne;
                }

                DummyOne = Simplifier.SimplifierFx(DummyOne);

                if ((AE.SampleAccess != null) || (BD.SampleAccess != null))
                {
                    DummyTow.SetLefTandRightCommonlySide(AE, BD);
                    DummyTow.SampleAccess = "-";
                    if (AE != null)
                        DummyTow.LeftSideAccess.ThreadAccess = DummyTow;
                    if (BD != null)
                        DummyTow.RightSideAccess.ThreadAccess = DummyTow;
                }

                DummyTow = Simplifier.SimplifierFx(DummyTow);

                if ((DummyOne.SampleAccess != null) && (DummyTow.SampleAccess != null))
                {
                    TX.SetLefTandRightCommonlySide(DummyOne, DummyTow);
                    if (DummyOne != null)
                        TX.LeftSideAccess.ThreadAccess = TX;
                    if (DummyTow != null)
                        TX.RightSideAccess.ThreadAccess = TX;
                    TX.SampleAccess = "/";
                }

                TX = Simplifier.SimplifierFx(TX);

                if ((HolderAA.SampleAccess != null) && (HolderAF.SampleAccess != null))
                {
                    AF.SetLefTandRightCommonlySide(HolderAA, HolderAF);
                    AF.SampleAccess = "*";
                    if (HolderAF != null)
                        AF.LeftSideAccess.ThreadAccess = AF;
                    if (HolderAD != null)
                        AF.RightSideAccess.ThreadAccess = AF;
                }

                AF = Simplifier.SimplifierFx(AF);

                if ((HolderAB.SampleAccess != null) && (HolderAC.SampleAccess != null))
                {
                    BC.SetLefTandRightCommonlySide(HolderAB, HolderAC);
                    BC.SampleAccess = "*";
                    if (HolderAB != null)
                        BC.LeftSideAccess.ThreadAccess = BC;
                    if (HolderAC != null)
                        BC.RightSideAccess.ThreadAccess = BC;
                }

                BC = Simplifier.SimplifierFx(BC);

                if ((AF.SampleAccess != null) || (BC.SampleAccess != null))
                {
                    DummyThree.SetLefTandRightCommonlySide(AF, BC);
                    DummyThree.SampleAccess = "-";
                    if (AF != null)
                        DummyThree.LeftSideAccess.ThreadAccess = DummyThree;
                    if (BC != null)
                        DummyThree.RightSideAccess.ThreadAccess = DummyThree;
                }

                DummyThree = Simplifier.SimplifierFx(DummyThree);

                if ((DummyThree.SampleAccess != null) && (DummyTow.SampleAccess != null))
                {
                    MX.SetLefTandRightCommonlySide(DummyThree, DummyTow);
                    if (DummyOne != null)
                        MX.LeftSideAccess.ThreadAccess = MX;
                    if (DummyTow != null)
                        MX.RightSideAccess.ThreadAccess = MX;
                    MX.SampleAccess = "/";
                }

                MX = Simplifier.SimplifierFx(MX);
                
                AddToTree.Tree DummyTX = Integral.IntegralCalculator(Node.LeftSideAccess);

                DummyTX = Simplifier.SimplifierFx(DummyTX);

                if ((TX.SampleAccess != null) && (DummyTX.SampleAccess != null))
                {
                    DummyFour.SetLefTandRightCommonlySide(TX, DummyTX);
                    DummyFour.SampleAccess = "*";
                    if (TX != null)
                        DummyFour.LeftSideAccess.ThreadAccess = DummyFour;
                    if (DummyFour.RightSideAccess != null)
                        DummyFour.RightSideAccess.ThreadAccess = DummyFour;
                }

                AddToTree.Tree DummyX = Integral.IntegralCalculator(Node.RightSideAccess);
                if ((DummyFive.SampleAccess != null) && (DummyX.SampleAccess != null))
                {
                    DummyFive.SetLefTandRightCommonlySide(MX, DummyX);
                    DummyFive.SampleAccess = "*";
                    if (MX != null)
                        DummyFive.LeftSideAccess.ThreadAccess = DummyFive;
                    if (DummyFive.RightSideAccess != null)
                        DummyFive.RightSideAccess.ThreadAccess = DummyFive;
                }

                DummyFour = Simplifier.SimplifierFx(DummyFour);
                DummyFive = Simplifier.SimplifierFx(DummyFive);

            if (Dummy == null)
                Dummy = new AddToTree.Tree(null, false);

                Dummy.SetLefTandRightCommonlySide(DummyFour, DummyFive);
                Dummy.SampleAccess = "+";
                if (DummyOne!= null)
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                if (DummyTow != null)
                Dummy.RightSideAccess.ThreadAccess = Dummy;

            Dummy = Simplifier.SimplifierFx(Dummy);
                 */

            }
            else
                if (Node.SampleAccess == "/")
            {
                UIS.SetLableValue(UIS.label17, "Integral F(X)/G(X).");
                FMulAtG.ADDToTree(null);

                INCREASE = INCREASE / 7;

                UIS.SetProgressValue(UIS.progressBar2, 0);

                AddToTree.Tree PONE = new AddToTree.Tree("/", false);
                AddToTree.Tree PTOW = new AddToTree.Tree(null, false);
                AddToTree.Tree PTHREE = new AddToTree.Tree(null, false);
                AddToTree.Tree TOW = new AddToTree.Tree("2", false);
                AddToTree.Tree ONE = new AddToTree.Tree("1", false);

                PONE.SetLefTandRightCommonlySide(Node.CopyNewTree(Node.LeftSideAccess), Node.CopyNewTree(Node.RightSideAccess));
                PONE.LeftSideAccess.ThreadAccess = PONE;
                PONE.RightSideAccess.ThreadAccess = PONE;

                UIS.SetLableValue(UIS.label17, "Derivtion Of G(X).");

                PTOW = Derivasion.DerivasionOfFX(Node.RightSideAccess.CopyNewTree(Node.RightSideAccess), ref UIS);

                PTOW = Simplifier.SimplifierFx(PTOW, ref UIS);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                int HOLDE = UIS.progressBar2.Value;

                PTOW.SetLefTandRightCommonlySide(PTOW.CopyNewTree(PTOW), Integral.IntegralCalculator(Node.LeftSideAccess.CopyNewTree(Node.LeftSideAccess), ref UIS));
                PTOW.LeftSideAccess.ThreadAccess = PTOW;
                PTOW.RightSideAccess.ThreadAccess = PTOW;
                PTOW.SampleAccess = "*";

                UIS.SetProgressValue(UIS.progressBar2, HOLDE);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                TOW.SetLefTandRightCommonlySide(Node.CopyNewTree(Node.RightSideAccess), TOW.CopyNewTree(TOW));
                TOW.LeftSideAccess.ThreadAccess = TOW;
                TOW.RightSideAccess.ThreadAccess = TOW;
                TOW.SampleAccess = "^";

                AddToTree.Tree C = new AddToTree.Tree("C", false);

                /*PTHREE.SetLefTandRightCommonlySide(C.CopyNewTree(C), Derivasion.DerivasionOfFX(Node.CopyNewTree(Node.RightSideAccess)));
                PTHREE.LeftSideAccess.ThreadAccess = PTHREE;
                PTHREE.RightSideAccess.ThreadAccess = PTHREE;
                PTHREE.SampleAccess = "*";
                */

                UIS.SetLableValue(UIS.label17, "Derivtion Of G(X).");
                PTHREE = Derivasion.DerivasionOfFX(Node.RightSideAccess.CopyNewTree(Node.RightSideAccess), ref UIS);

                PTHREE.SetLefTandRightCommonlySide(PTHREE.CopyNewTree(PTHREE), TOW.CopyNewTree(TOW));
                PTHREE.LeftSideAccess.ThreadAccess = PTHREE;
                PTHREE.RightSideAccess.ThreadAccess = PTHREE;
                PTHREE.SampleAccess = "/";

                PTHREE = Simplifier.SimplifierFx(PTHREE, ref UIS);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                PTOW.SetLefTandRightCommonlySide(PTOW.CopyNewTree(PTOW), TOW);
                PTOW.LeftSideAccess.ThreadAccess = PTOW;
                PTOW.RightSideAccess.ThreadAccess = PTOW;
                PTOW.SampleAccess = "/";

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                //PTOW = Simplifier.SimplifierFx(PTOW, ref UIS);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                AddToTree.Tree HOLDERONE = new AddToTree.Tree(null, false);
                AddToTree.Tree HOLDERTOW = new AddToTree.Tree(null, false);


                HOLDERONE = INTEGRALS.DELETEFromTreeFirstNode();
                HOLDERTOW = INTEGRALS.DELETEFromTreeFirstNode();



                if (((EqualToObject.IsEqualWithOutThreadConsiderationCommonly(PTOW.RightSideAccess, HOLDERTOW.RightSideAccess)) && ((HOLDERTOW.SampleAccess == PTOW.SampleAccess)) && (IS.IsNumber(HOLDERTOW.LeftSideAccess.SampleAccess)) && (IS.IsNumber(PTOW.LeftSideAccess.SampleAccess))) || ((EqualToObject.IsEqualWithOutThreadConsiderationCommonly(PTOW, HOLDERTOW))))
                {
                    INTEGRALS.ADDToTree(HOLDERTOW);
                    INTEGRALS.ADDToTree(HOLDERONE);
                }
                else
                {
                    INTEGRALS.ADDToTree(HOLDERTOW);
                    INTEGRALS.ADDToTree(HOLDERONE);

                    HOLDE = UIS.progressBar2.Value;

                    PTOW = ChangeFunction.ChangeFunctionFx(PTOW, ref UIS);

                    PTOW = Integral.IntegralCalculator(PTOW.CopyNewTree(PTOW), ref UIS);

                    UIS.SetProgressValue(UIS.progressBar2, HOLDE);
                }
                if (((EqualToObject.IsEqualWithOutThreadConsiderationCommonly(PTOW.RightSideAccess, HOLDERTOW.RightSideAccess)) && ((HOLDERTOW.SampleAccess == PTOW.SampleAccess)) && (IS.IsNumber(HOLDERTOW.LeftSideAccess.SampleAccess)) && (IS.IsNumber(PTOW.LeftSideAccess.SampleAccess))) || ((EqualToObject.IsEqualWithOutThreadConsiderationCommonly(PTOW, HOLDERTOW))))
                {
                    Dummy.SetLefTandRightCommonlySide(C, PONE);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy.SampleAccess = "*";
                    FDeviosionByG.ADDToTree(Dummy);
                }
                else
                {
                    Dummy.SetLefTandRightCommonlySide(PONE, PTOW);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy.SampleAccess = "+";
                }

                Dummy = Simplifier.SimplifierFx(Dummy, ref UIS);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                HOLDE = UIS.progressBar2.Value;

                Dummy.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy), Integral.IntegralCalculator(PTHREE.CopyNewTree(PTHREE), ref UIS));
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
                Dummy.SampleAccess = "+";

                UIS.SetProgressValue(UIS.progressBar2, HOLDE);
                /*                    AddToTree.Tree PONE = new AddToTree.Tree(null, false);
                                    AddToTree.Tree PTOW = new AddToTree.Tree("/", false);
                                    AddToTree.Tree ONE = new AddToTree.Tree("1", false);

                                    AddToTree.Tree DummyONE = new AddToTree.Tree("*", false);
                                    AddToTree.Tree DummyTOW = new AddToTree.Tree("*", false);

                                    PONE = Node.CopyNewTree(Node.LeftSideAccess);

                                    UIS.progressBar2.Value=UIS.progressBar2.Value+INCREASE;

                                    PTOW.SetLefTandRightCommonlySide(ONE,Node.CopyNewTree(Node.RightSideAccess));
                                    PTOW.LeftSideAccess.ThreadAccess = PTOW;
                                    PTOW.RightSideAccess.ThreadAccess = PTOW;

                                    //UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE); 




                                    //PTOW = Integral.IntegralCalculator(PTOW, ref UIS);

                                    AddToTree.Tree X = new AddToTree.Tree("x", false);

                                    PTOW.SetLefTandRightCommonlySide(X.CopyNewTree(X),PTOW.CopyNewTree(PTOW));
                                    PTOW.SampleAccess = "*";
                                    PTOW.LeftSideAccess.ThreadAccess = PTOW;
                                    PTOW.RightSideAccess.ThreadAccess = PTOW;

                                    AddToTree.Tree GPRIN = new AddToTree.Tree(null, false);
                                    AddToTree.Tree GPOWERTOW = new AddToTree.Tree("^", false);

                                    GPRIN=Derivasion.DerivasionOfFX(Node.RightSideAccess);

                                    UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE); 

                                    GPRIN.SetLefTandRightCommonlySide(GPRIN.CopyNewTree(GPRIN),X);
                                    GPRIN.SampleAccess = "*";
                                    GPRIN.LeftSideAccess.ThreadAccess = GPRIN;
                                    GPRIN.RightSideAccess.ThreadAccess = GPRIN;

                                    AddToTree.Tree TOW = new AddToTree.Tree("2", false);

                                    GPOWERTOW.SetLefTandRightCommonlySide(Node.CopyNewTree(Node.RightSideAccess),TOW);
                                    GPOWERTOW.LeftSideAccess.ThreadAccess = GPOWERTOW;
                                    GPOWERTOW.RightSideAccess.ThreadAccess = GPOWERTOW;

                                    AddToTree.Tree GINTEGRAL = new AddToTree.Tree("/", false);

                                    UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE); 

                                    GINTEGRAL.SetLefTandRightCommonlySide(GPRIN,GPOWERTOW);
                                    GINTEGRAL.LeftSideAccess.ThreadAccess = GINTEGRAL;
                                    GINTEGRAL.RightSideAccess.ThreadAccess = GINTEGRAL;

                                    GINTEGRAL = Simplifier.SimplifierFx(GINTEGRAL, ref UIS);

                                    int HOLDE = UIS.progressBar2.Value;

                                    GINTEGRAL = Integral.IntegralCalculator(GINTEGRAL, ref UIS);

                                    UIS.progressBar2.Value = HOLDE;

                                    UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE); 

                                    PTOW.SetLefTandRightCommonlySide(PTOW.CopyNewTree(PTOW),GINTEGRAL);
                                    PTOW.LeftSideAccess.ThreadAccess = PTOW;                    
                                    PTOW.RightSideAccess.ThreadAccess = PTOW;
                                    PTOW.SampleAccess = "+";



                                    UIS.progressBar2.Value=UIS.progressBar2.Value+INCREASE;

                                    DummyONE.SetLefTandRightCommonlySide(PONE.CopyNewTree(PONE),PTOW.CopyNewTree(PTOW));
                                    DummyONE.LeftSideAccess.ThreadAccess = DummyONE;
                                    DummyONE.RightSideAccess.ThreadAccess = DummyONE;



                                    DummyTOW.SetLefTandRightCommonlySide(Derivasion.DerivasionOfFX(PONE),PTOW);
                                    DummyTOW.LeftSideAccess.ThreadAccess = DummyTOW;
                                    DummyTOW.RightSideAccess.ThreadAccess = DummyTOW;

                                    UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE); 

                                    DummyTOW = Simplifier.SimplifierFx(DummyTOW,ref UIS);



                                    UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE); 

                                    HOLDE = UIS.progressBar2.Value;

                                    DummyTOW = Integral.IntegralCalculator(DummyTOW,ref UIS);

                                    UIS.progressBar2.Value=HOLDE;

                                    Dummy.SampleAccess = "-";
                                    Dummy.SetLefTandRightCommonlySide(DummyONE,DummyTOW);
                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                    Dummy.RightSideAccess.ThreadAccess = Dummy;

                 */
                UIS.SetProgressValue(UIS.progressBar2, 2147483647);

                /*        AddToTree.Tree INTF    = new AddToTree.Tree(null, false);
                        AddToTree.Tree GPRIN   = new AddToTree.Tree(null, false);
                        AddToTree.Tree GONE = new AddToTree.Tree(null, false);
                        AddToTree.Tree GTOW = new AddToTree.Tree(null, false);
                        AddToTree.Tree GPOWERT = new AddToTree.Tree("^", false);
                        AddToTree.Tree NUM     = new AddToTree.Tree("2", false);
                        AddToTree.Tree INTGONE = new AddToTree.Tree(null, false);
                        AddToTree.Tree INTGTOW = new AddToTree.Tree(null, false);

                        AddToTree.Tree DONETX = new AddToTree.Tree("/", false);
                        AddToTree.Tree DTOW = new AddToTree.Tree("/", false);

                        INTF= Integral.IntegralCalculator(Node.LeftSideAccess,ref UIS);
                        GONE = Node.CopyNewTree(Node.RightSideAccess);
                        GTOW = Node.CopyNewTree(Node.RightSideAccess);

                        DONETX.SetLefTandRightCommonlySide(INTF,GONE);
                        DONETX.LeftSideAccess.ThreadAccess = DONETX;
                        DONETX.RightSideAccess.ThreadAccess = DONETX;

                        GPOWERT.SetLefTandRightCommonlySide(GTOW,NUM);
                        GPOWERT.LeftSideAccess.ThreadAccess = GPOWERT;
                        GPOWERT.RightSideAccess.ThreadAccess = GPOWERT;

                        DTOW.SetLefTandRightCommonlySide(GPRIN, GPOWERT);
                        DTOW.LeftSideAccess.ThreadAccess = DTOW;
                        DTOW.RightSideAccess.ThreadAccess = DTOW;

                        DTOW = Integral.IntegralCalculator(DTOW,ref UIS);

                        Dummy.SampleAccess = "-";
                        Dummy.SetLefTandRightCommonlySide(DONETX,DTOW);
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;

                        */


                /*AddToTreeTreeLinkList STORAGEOfIntegeralSeriece = new AddToTreeTreeLinkList();
                AddToTreeTreeLinkList STORAGEOfIntegeralSeriecePartOne = new AddToTreeTreeLinkList();
                AddToTreeTreeLinkList STORAGEOfIntegeralSeriecePartTow = new AddToTreeTreeLinkList();
                AddToTree.Tree Holder = new AddToTree.Tree(null, false);
                AddToTree.Tree HolderPartOne = new AddToTree.Tree(null, false);
                AddToTree.Tree HolderPartTow = new AddToTree.Tree(null, false);

                int i = 0;
                while (true)
                {
                     HolderPartOne = Integral.XPowerIMulFXPerGXDerI(i, Node.LeftSideAccess, Node.RightSideAccess);

                    if (HolderPartOne.SampleAccess != null)                      
                        STORAGEOfIntegeralSeriecePartOne.ADDToTree(HolderPartOne.CopyNewTree(HolderPartOne));                        

                    if (HolderPartTow.SampleAccess != null)
                    {
                        HolderPartTow = Integral.XMulDerivisionOfFx(i, Node.LeftSideAccess, Node.RightSideAccess);
                        STORAGEOfIntegeralSeriecePartTow.ADDToTree(HolderPartTow.CopyNewTree(HolderPartTow));
                    }
                    if (HolderPartOne.SampleAccess != null)
                    {if (HolderPartTow.SampleAccess != null)
                    {
                            Holder.SetLefTandRightCommonlySide(HolderPartOne.CopyNewTree(HolderPartOne), HolderPartTow.CopyNewTree(HolderPartTow));
                            Holder.SampleAccess = "+";
                            Holder.LeftSideAccess.LeftSideAccess = Holder;
                            Holder.RightSideAccess.ThreadAccess = Holder;
                    }
                        else
                            Holder = HolderPartOne;
                    }
                    else
                        if (HolderPartTow.SampleAccess != null)                        
                            Holder = HolderPartTow;

                    if (Holder.SampleAccess != null)
                        STORAGEOfIntegeralSeriece.ADDToTree(Holder.CopyNewTree(Holder));
                    else
                        break;
                    i++;
                }
                Dummy =STORAGEOfIntegeralSeriece.DELETEFromTreeFirstNode();
                if(Dummy!=null)
                do
                {
                    Holder = STORAGEOfIntegeralSeriece.DELETEFromTreeFirstNode();
                    if (Holder != null)
                    {
                        Dummy.SetLefTandRightCommonlySide(Holder.CopyNewTree(Holder), Dummy.CopyNewTree(Dummy));
                        Dummy.SampleAccess = "+";
                        Dummy.LeftSideAccess.ThreadAccess = Dummy;
                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                    }
                }while(Holder!=null);
                */
            }
            else
                    if (Node.SampleAccess == "+")
            {
                UIS.SetLableValue(UIS.label17, "Integral F(X)+G(X).");

                INCREASE = INCREASE / 2;

                FMulAtG.ADDToTree(null);
                FDeviosionByG.ADDToTree(null);

                UIS.SetProgressValue(UIS.progressBar2, 0);

                AddToTree.Tree Left = Node.LeftSideAccess;
                Left.ThreadAccess = null;
                AddToTree.Tree Right = Node.RightSideAccess;
                Right.ThreadAccess = null;

                int Holde = UIS.progressBar2.Value;

                Queficient = (float)1.0;

                Left = Integral.IntegralCalculator(Node.LeftSideAccess.CopyNewTree(Node.LeftSideAccess), ref UIS);

                UIS.SetLableValue(UIS.label17, "Integral F(X)+G(X).");

                UIS.SetProgressValue(UIS.progressBar2, Holde);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                UIS.SetProgressValue(UIS.progressBar2, Holde);

                Queficient = (float)1.0;
                Right = Integral.IntegralCalculator(Node.RightSideAccess.CopyNewTree(Node.RightSideAccess), ref UIS);

                UIS.SetLableValue(UIS.label17, "Integral F(X)+G(X).");

                UIS.SetProgressValue(UIS.progressBar2, Holde);

                if (Right == null)
                    return Left;

                Dummy.SampleAccess = "+";
                Dummy.SetLefTandRightCommonlySide(Left, Right);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;

                UIS.SetProgressValue(UIS.progressBar2, 2147483647);
                //        Dummy = Simplifier.SimplifierFx(Dummy, ref UIS);
                return Dummy;

            }
            else
                        if (Node.SampleAccess == "-")
            {
                UIS.SetLableValue(UIS.label17, "Integral F(X)-G(X).");
                FDeviosionByG.ADDToTree(null);
                FMulAtG.ADDToTree(null);

                INCREASE = INCREASE / 2;

                UIS.SetProgressValue(UIS.progressBar2, 0);

                AddToTree.Tree Left = Node.LeftSideAccess;
                Left.ThreadAccess = null;
                AddToTree.Tree Right = Node.RightSideAccess;
                Right.ThreadAccess = null;

                int Holde = UIS.progressBar2.Value;

                Queficient = (float)1.0;

                Left = Integral.IntegralCalculator(Node.LeftSideAccess.CopyNewTree(Node.LeftSideAccess), ref UIS);

                UIS.SetLableValue(UIS.label17, "Integral F(X)-G(X).");

                UIS.SetProgressValue(UIS.progressBar2, Holde);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                Holde = UIS.progressBar2.Value;

                Queficient = (float)1.0;

                Right = Integral.IntegralCalculator(Node.RightSideAccess.CopyNewTree(Node.RightSideAccess), ref UIS);

                UIS.SetLableValue(UIS.label17, "Integral F(X)-G(X).");

                UIS.SetProgressValue(UIS.progressBar2, Holde);
                if (Right == null)
                    return Left;

                Dummy.SampleAccess = "-";
                Dummy.SetLefTandRightCommonlySide(Left, Right);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
                Dummy = Simplifier.SimplifierFx(Dummy, ref UIS);

                UIS.progressBar2.Value = 2147483647;
                return Dummy;
            }
            else
                            if (Node.SampleAccess == "^")
            {
                UIS.SetLableValue(UIS.label17, "Integral F(X)^G(X).");
                INCREASE = INCREASE / 6;

                FMulAtG.ADDToTree(Node.CopyNewTree(Node));
                FDeviosionByG.ADDToTree(null);

                UIS.SetProgressValue(UIS.progressBar2, 0);

                //AddToTree.Tree FONETX = Node.CopyNewTree(Node.LeftSideAccess);
                AddToTree.Tree FONETX = Node.CopyNewTree(Node.LeftSideAccess);
                //AddToTree.Tree FTOWTX = Node.CopyNewTree(Node.LeftSideAccess);
                AddToTree.Tree FTOWTX = Node.CopyNewTree(Node.LeftSideAccess);
                //AddToTree.Tree FTHREE = Node.CopyNewTree(Node.LeftSideAccess);
                AddToTree.Tree FTHREE = Node.CopyNewTree(Node.LeftSideAccess);
                AddToTree.Tree FPRIN = Derivasion.DerivasionOfFX(Node.LeftSideAccess.CopyNewTree(Node.LeftSideAccess), ref UIS);
                //AddToTree.Tree G = Node.CopyNewTree(Node.RightSideAccess);
                AddToTree.Tree G = Node.CopyNewTree(Node.RightSideAccess);
                //AddToTree.Tree FGONE = Node.CopyNewTree(Node);
                AddToTree.Tree FGONE = Node.CopyNewTree(Node);
                //AddToTree.Tree FGTOW = Node.CopyNewTree(Node);
                AddToTree.Tree FGTOW = Node.CopyNewTree(Node);

                AddToTree.Tree INTNODEPERFONE = new AddToTree.Tree("/", false);
                AddToTree.Tree INTNODEPERTOW = new AddToTree.Tree("/", false);
                if (Node.RightSideAccess != null)
                {
                    if (IS.IsNumberNegative(Node.RightSideAccess.SampleAccess))
                    {

                        INTNODEPERFONE = new AddToTree.Tree("*", false);
                        INTNODEPERTOW = new AddToTree.Tree("*", false);


                    }
                }
                AddToTree.Tree MULONE = new AddToTree.Tree("*", false);
                AddToTree.Tree MULTOW = new AddToTree.Tree("*", false);
                AddToTree.Tree MULTHREE = new AddToTree.Tree("*", false);
                AddToTree.Tree MULFOUR = new AddToTree.Tree("*", false);
                AddToTree.Tree DIVONE = new AddToTree.Tree("/", false);
                AddToTree.Tree DIVTOW = new AddToTree.Tree("/", false);

                INTNODEPERFONE.SetLefTandRightCommonlySide(FGONE, FONETX);
                INTNODEPERFONE.LeftSideAccess.ThreadAccess = INTNODEPERFONE;
                INTNODEPERFONE.RightSideAccess.ThreadAccess = INTNODEPERFONE;
                bool FRact = false;
                if (Node.RightSideAccess != null)
                {

                    if (IS.IsNumber(Node.RightSideAccess.SampleAccess))
                    {
                        if (System.Convert.ToDouble(Node.RightSideAccess.SampleAccess) < 1 && System.Convert.ToDouble(Node.RightSideAccess.SampleAccess) > 0)
                        {
                            INTNODEPERFONE = new AddToTree.Tree("*", false);
                            INTNODEPERTOW = new AddToTree.Tree("*", false);
                            INTNODEPERFONE.SetLefTandRightCommonlySide(FGONE, FONETX);
                            INTNODEPERFONE.LeftSideAccess.ThreadAccess = INTNODEPERFONE;
                            INTNODEPERFONE.RightSideAccess.ThreadAccess = INTNODEPERFONE;
                            FRact = true;

                        }
                    }
                }
                if (Node.RightSideAccess != null)
                {
                    if (IS.IsNumber(Node.RightSideAccess.SampleAccess))
                    {
                        if (//System.Convert.ToDouble(Node.RightSideAccess.SampleAccess) > -1 && 
                            System.Convert.ToDouble(Node.RightSideAccess.SampleAccess) < 0)
                        {
                            INTNODEPERFONE = new AddToTree.Tree("*", false);
                            INTNODEPERTOW = new AddToTree.Tree("*", false);
                            INTNODEPERFONE.SetLefTandRightCommonlySide(FGONE, FONETX);
                            INTNODEPERFONE.LeftSideAccess.ThreadAccess = INTNODEPERFONE;
                            INTNODEPERFONE.RightSideAccess.ThreadAccess = INTNODEPERFONE;
                            FRact = true;

                        }
                    }
                }    //ERROR279872387  :refer to page 218.


                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                //          INTNODEPERFONE = Simplifier.SimplifierFx(INTNODEPERFONE,ref UIS);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                stk.Push(IntegralSignPositive);
                IntegralSignPositive = !IntegralSignPositive;

                //  INTNODEPERFONE = Simplifier.SimplifierFx(INTNODEPERFONE, ref UIS);

                INTNODEPERFONE = ChangeFunction.ChangeFunctionFx(INTNODEPERFONE, ref UIS);

                IntegralSignPositive = stk.Pop();

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                //ERROR3170405060 :Refer to page 225.

                int HOLDE = UIS.progressBar2.Value;

                Queficient = (float)1.0;
                //if (!IS.IsNumberNegative(Node.RightSideAccess.SampleAccess))
                if (!FRact)
                    INTNODEPERFONE = Integral.IntegralCalculator(INTNODEPERFONE.CopyNewTree(INTNODEPERFONE), ref UIS);

                UIS.SetLableValue(UIS.label17, "Integral F(X)^G(X).");

                //ERROR02323909 : The invalid error.refer to page 220.
                //LOCATION306070 :Refer top page 225.

                UIS.SetProgressValue(UIS.progressBar2, HOLDE);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                INTNODEPERFONE = Simplifier.SimplifierFx(INTNODEPERFONE, ref UIS);

                //ERRORCORECTION09119824 :The error may occured from here.
                INTNODEPERTOW = INTNODEPERFONE.CopyNewTree(INTNODEPERFONE);
                if (!FRact)
                {
                    MULONE.SetLefTandRightCommonlySide(FONETX, INTNODEPERFONE);
                    MULONE.LeftSideAccess.ThreadAccess = MULONE;
                    MULONE.RightSideAccess.ThreadAccess = MULONE;
                }
                else
                {
                    MULONE.SetLefTandRightCommonlySide(FPRIN, INTNODEPERFONE);
                    MULONE.LeftSideAccess.ThreadAccess = MULONE;
                    MULONE.RightSideAccess.ThreadAccess = MULONE;
                }

                MULTOW.SetLefTandRightCommonlySide(FPRIN, INTNODEPERTOW);
                MULTOW.LeftSideAccess.ThreadAccess = MULTOW;
                MULTOW.RightSideAccess.ThreadAccess = MULTOW;
                //ERRORCORECTION0921849823 :The number soud mul to minuse one.refer to page 221.
                /*AddToTree.Tree MIN = new AddToTree.Tree("1",false);
                MULTOW.SetLefTandRightCommonlySide(MULTOW.CopyNewTree(MULTOW),MIN);
                MULTOW.SampleAccess="-";
                MULTOW.LeftSideAccess.ThreadAccess = MULTOW;
                MULTOW.RightSideAccess.ThreadAccess = MULTOW;
                */
                //LOCATION307060 :Refer to page 227.
                //MULTOW = Simplifier.SimplifierFx(MULTOW,ref UIS);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                HOLDE = UIS.progressBar2.Value;
                //MULTOW = Simplifier.SimplifierFx(MULTOW, ref UIS);
                if (FRact || IntegralRecursiveMulatFG.IntegralRecursiveMulatFPowerGFx(Node, MULTOW, ref UIS, ref Queficient))
                {
                    if (!FRact)
                    {
                        MULTOW.SetLefTandRightCommonlySide(null, null);

                        double QDerivasionF = 0, BG = 0;
                        if (FPRIN.SampleAccess == "*")
                        {
                            if (IS.IsNumber(FPRIN.LeftSideAccess.SampleAccess))
                                QDerivasionF = System.Convert.ToDouble(FPRIN.LeftSideAccess.SampleAccess);
                            else
                                if (IS.IsNumber(FPRIN.RightSideAccess.SampleAccess))
                                QDerivasionF = System.Convert.ToDouble(FPRIN.RightSideAccess.SampleAccess);
                            else
                                QDerivasionF = 1.0;

                        }
                        else
                            if (IS.IsNumber(FPRIN.SampleAccess))
                            QDerivasionF = System.Convert.ToDouble(FPRIN.SampleAccess);
                        else
                            QDerivasionF = 1.0;

                        MULTOW.SetLefTandRightCommonlySide(null, null);

                        if (IntegralSignPositive)
                            MULTOW.SampleAccess = (1 / (1 - QDerivasionF)).ToString();
                        else
                            MULTOW.SampleAccess = (1 / (1 + QDerivasionF)).ToString();

                    }
                    else
                    {
                        MULTOW.SampleAccess = (1 / System.Convert.ToDouble(INTNODEPERFONE.RightSideAccess.SampleAccess)).ToString();
                    }
                    Dummy.SetLefTandRightCommonlySide(MULTOW, MULONE);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy.SampleAccess = "*";
                    Dummy = Simplifier.SimplifierFx(Dummy, ref UIS);
                    return Dummy;
                }
                else
                {
                    if (MULTOW != null && (!FRact))
                    {
                        MULTOW = ChangeFunction.ChangeFunctionFx(MULTOW, ref UIS);

                        //if (!IS.IsNumberNegative(MULTOW.RightSideAccess.SampleAccess))
                        MULTOW = Integral.IntegralCalculator(MULTOW.CopyNewTree(MULTOW), ref UIS);

                        UIS.SetLableValue(UIS.label17, "Integral F(X)^G(X).");

                    }
                    if (MULTOW == null)
                        return MULONE;
                    Dummy.SampleAccess = "-";
                    Dummy.SetLefTandRightCommonlySide(MULONE, MULTOW);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy = Simplifier.SimplifierFx(Dummy, ref UIS);
                    return Dummy;
                }
                UIS.SetProgressValue(UIS.progressBar2, HOLDE);

                UIS.SetProgressValue(UIS.progressBar2, 2147483647);




                /*
                //FOR determining and 
                IntegralA = false;

                                                MULTOW = FindAndIndicatingRecursiveIntegrals.FindAndIndicatingRecursiveIntegralsFx(Node, MULTOW, INTEGRALS, ANSWERS, out IntegralA, out Queficient);

                                                if (!IntegralA)
                                                {
                                                    MULTOW = Integral.IntegralCalculator(MULTOW,ref UIS);
                                                    Dummy.SampleAccess = "+";
                                                    Dummy.SetLefTandRightCommonlySide(MULONE, MULTOW);
                                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                                                }
                                                else 
                                                {
                                                    DummyEqual = MULTOW;
                                                    Dummy = MULONE;
                                                    //ERRORCORECTION918729348 :The Error is here .refer to page 218.
                                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                                                }   
                 /*
                                                                                AddToTree.Tree GLnF = new AddToTree.Tree(null, false);
                                                                               AddToTree.Tree ETX = new AddToTree.Tree("e", false);
                                                                              AddToTree.Tree EPowerX = new AddToTree.Tree(null, false);
                                                                               AddToTree.Tree POWER = new AddToTree.Tree("^", false);
                                                                               AddToTree.Tree X = new AddToTree.Tree("x", false);
                                                                               AddToTree.Tree RootArgumnet = new AddToTree.Tree(null, false);
                                                                                AddToTree.Tree LeftSideRoot = new AddToTree.Tree(null, false);
                                                                                AddToTree.Tree LeftSideFunction = new AddToTree.Tree(null, false);
                                                                                AddToTree.Tree Root = new AddToTree.Tree(null, false);
                                                                                //AddToTree.Tree FX = Node.CopyNewTree(Node.RightSideAccess);
                                                                                AddToTree.Tree FX = new AddToTree.Tree(null, false);
                                                                                AddToTree.Tree GX = Node.CopyNewTree(Node.LeftSideAccess);                                
                                                                                AddToTree.Tree Ln = new AddToTree.Tree("Ln", false);
                                                                                AddToTree.Tree NUMD = new AddToTree.Tree("2", false);
                                                                                AddToTree.Tree NUMU = new AddToTree.Tree("1", false);

                                                                                EPowerX.SetLefTandRightCommonlySide(ETX, X);
                                                                                EPowerX.SampleAccess = "^";
                                                                                EPowerX.LeftSideAccess.ThreadAccess = EPowerX;
                                                                                EPowerX.RightSideAccess.ThreadAccess = EPowerX;

                                                                                Ln.SetLefTandRightCommonlySide(Node.LeftSideAccess, null);
                                                                                Ln.LeftSideAccess.ThreadAccess = Ln;

                                                                                //ERROR19824201984  :The FX Has no Sample.
                                                                                FX.SetLefTandRightCommonlySide(Node.RightSideAccess,Ln);
                                                                                FX.LeftSideAccess.ThreadAccess = FX;
                                                                                FX.RightSideAccess.ThreadAccess = FX;
                                                                                FX.SampleAccess = "*";
                                                                                //ERRORCORECTION209874 :The above error is corected.


                                                                                GLnF =FX.CopyNewTree(FX);

                                                                                FX.SetLefTandRightCommonlySide(X, NUMD);
                                                                                FX.LeftSideAccess.ThreadAccess = FX;
                                                                                FX.RightSideAccess.ThreadAccess = FX;
                                                                                FX.SampleAccess = "^";

                                                                                RootArgumnet.SetLefTandRightCommonlySide(NUMU, FX);
                                                                                RootArgumnet.LeftSideAccess.ThreadAccess = RootArgumnet;
                                                                                RootArgumnet.RightSideAccess.ThreadAccess = RootArgumnet;
                                                                                RootArgumnet.SampleAccess = "-";

                                                                                LeftSideRoot.SetLefTandRightCommonlySide(RootArgumnet, null);
                                                                                LeftSideRoot.LeftSideAccess.ThreadAccess = LeftSideRoot;
                                                                                LeftSideRoot.SampleAccess = "Root";

                                                                                LeftSideFunction.SetLefTandRightCommonlySide(NUMU, LeftSideRoot);
                                                                                LeftSideFunction.LeftSideAccess.ThreadAccess = LeftSideFunction;
                                                                                LeftSideFunction.RightSideAccess.ThreadAccess = LeftSideFunction;
                                                                                LeftSideFunction.SampleAccess = "/";

                                                                                Dummy.SetLefTandRightCommonlySide(EPowerX, LeftSideFunction);
                                                                                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                                                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                                                                Dummy.SampleAccess = "*";

                                                                                Dummy = Integral.IntegralCalculator(Dummy);

                                                                                Dummy = Integral.ReplaceXToFX(Dummy, GLnF);
                                                                            */
            }
            else
                            if (IS.IsFunction(Node.SampleAccess))
            {
                UIS.SetLableValue(UIS.label17, "Integral Function.");

                FDeviosionByG.ADDToTree(null);
                FMulAtG.ADDToTree(null);

                INCREASE = INCREASE / 4;

                UIS.SetProgressValue(UIS.progressBar2, 0);

                Dummy = Node.CopyNewTree(Node);

                AddToTree.Tree U = Node.CopyNewTree(Node.LeftSideAccess);
                AddToTree.Tree UPRIN = Node.CopyNewTree(Node.LeftSideAccess);

                UIS.SetLableValue(UIS.label17, "Derivation Function.");

                UPRIN = Derivasion.DerivasionOfFX(UPRIN.CopyNewTree(UPRIN), ref UIS);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                UPRIN = Simplifier.SimplifierFx(UPRIN, ref UIS);

                Dummy.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                Dummy.LeftSideAccess.SampleAccess = "X";

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                if (IS.IsNumber(UPRIN.SampleAccess))
                {
                    AddToTree.Tree ONE = new AddToTree.Tree("1", false);
                    UPRIN.SetLefTandRightCommonlySide(ONE, UPRIN.CopyNewTree(UPRIN));
                    UPRIN.LeftSideAccess.ThreadAccess = UPRIN;
                    UPRIN.RightSideAccess.ThreadAccess = UPRIN;
                    UPRIN.SampleAccess = "/";

                    Dummy.SetLefTandRightCommonlySide(UPRIN, Dummy.CopyNewTree(Dummy));
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy.SampleAccess = "*";
                }
                else
                    System.Windows.Forms.MessageBox.Show(" knowldege cant not be applied.");

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                int Holde = UIS.progressBar2.Value;

                UIS.SetLableValue(UIS.label17, "Integral.");

                Dummy = Integral.IntegralOfFX(Dummy, ref UIS);

                UIS.SetLableValue(UIS.label17, "Integral Function.");

                UIS.SetProgressValue(UIS.progressBar2, Holde);

                UIS.SetProgressValue(UIS.progressBar2, UIS.progressBar2.Value + INCREASE);

                Dummy = ReplacementX.ReplacementXFx(Dummy, U, ref UIS);

                UIS.SetProgressValue(UIS.progressBar2, 2147483647);

                /*
                AddToTree.Tree U = Node.CopyNewTree(Node.LeftSideAccess);
                AddToTree.Tree X = new AddToTree.Tree("x", false);
                AddToTree.Tree NUMD = new AddToTree.Tree("2", false);
                AddToTree.Tree NUMU = new AddToTree.Tree("1", false);
                AddToTree.Tree GX = Node.CopyNewTree(Node);
                AddToTree.Tree FX = new AddToTree.Tree(null, false);
                AddToTree.Tree DFX = new AddToTree.Tree(null, false);
                AddToTree.Tree DGX = new AddToTree.Tree(null, false);                            

            GX.LeftSideAccess.LeftSideAccess = null;
            GX.LeftSideAccess.RightSideAccess = null;
            GX.LeftSideAccess.SampleAccess = "x";

            FX.SetLefTandRightCommonlySide(X, NUMD);
            FX.LeftSideAccess.ThreadAccess = FX;
            FX.RightSideAccess.ThreadAccess = FX;
            FX.SampleAccess = "^";

            FX.SetLefTandRightCommonlySide(NUMU, FX.CopyNewTree(FX));
            FX.LeftSideAccess.ThreadAccess = FX;
            FX.RightSideAccess.ThreadAccess = FX;
            FX.SampleAccess = "-";

            FX.SetLefTandRightCommonlySide(FX.CopyNewTree(FX), null);
            FX.LeftSideAccess.ThreadAccess = FX;
            FX.SampleAccess = "Root";

            FX.SetLefTandRightCommonlySide(NUMU,FX.CopyNewTree(FX));
            FX.LeftSideAccess.ThreadAccess = FX;
            FX.RightSideAccess.ThreadAccess = FX;
            FX.SampleAccess = "/";

            Dummy.SetLefTandRightCommonlySide(GX,FX.CopyNewTree(FX));
            Dummy.LeftSideAccess.ThreadAccess = Dummy;
            Dummy.LeftSideAccess.ThreadAccess = Dummy;
            Dummy.SampleAccess = "*";

            Dummy = Integral.IntegralCalculator(Dummy,ref UIS);

            Dummy = Integral.ReplaceXToFX(Dummy,U);                           
                */
            }
            //ERRORCORECTINO18726387 :The error is here .refer to page 221.

            UIS.SetLableValue(UIS.label17, "Integral End Simplifier.");
            DummyEqual = Simplifier.SimplifierFx(DummyEqual, ref UIS);
            Dummy = Simplifier.SimplifierFx(Dummy, ref UIS);

            //The location for determining and calculating Recursive Integral.
            Dummy = RecursiveIntegralAddition.RecursiveIntegralAdditionFx(Node, Dummy, DummyEqual, Queficient, INTEGRALS, ANSWERS);

            ANSWERS.ADDToTree(Dummy);
            return Dummy;

        }
        static AddToTree.Tree ConsTantFuctionIntegral(AddToTree.Tree Node)
        {
            AddToTree.Tree Dummy = new AddToTree.Tree(null, false);
            AddToTree.Tree C = new AddToTree.Tree("C", false);

            Dummy = KnownIntegralFormulla.KnownIntegralFormullaFx(Node);

            if (Dummy == null)
            {
                Dummy = new AddToTree.Tree(null, false);
                if (IS.IsNumber(Node.SampleAccess))
                {
                    AddToTree.Tree X = new AddToTree.Tree("x", false);
                    AddToTree.Tree CTX = new AddToTree.Tree(Node.SampleAccess, false);

                    Dummy.SampleAccess = "*";
                    Dummy.SetLefTandRightCommonlySide(CTX, X);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                }
                else
                    if (Node.SampleAccess.ToString().ToLower() == "x")
                {
                    AddToTree.Tree X = new AddToTree.Tree("x", false);
                    AddToTree.Tree DIV = new AddToTree.Tree("/", false);
                    AddToTree.Tree NUMONE = new AddToTree.Tree("1", false);
                    AddToTree.Tree NUMTOWONE = new AddToTree.Tree("2", false);
                    AddToTree.Tree NUMTOWTOW = new AddToTree.Tree("2", false);
                    AddToTree.Tree POWER = new AddToTree.Tree("^", false);

                    DIV.SetLefTandRightCommonlySide(NUMONE, NUMTOWONE);
                    DIV.LeftSideAccess.ThreadAccess = DIV;
                    DIV.RightSideAccess.ThreadAccess = DIV;

                    POWER.SetLefTandRightCommonlySide(X, NUMTOWTOW);
                    POWER.LeftSideAccess.ThreadAccess = POWER;
                    POWER.RightSideAccess.ThreadAccess = POWER;

                    Dummy.SampleAccess = "*";
                    Dummy.SetLefTandRightCommonlySide(DIV, POWER);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                }
                else
                        if (Node.SampleAccess.ToString().ToLower() == "cos")
                {
                    AddToTree.Tree X = new AddToTree.Tree("x", false);
                    Dummy.SampleAccess = "Sin";
                    Dummy.SetLefTandRightCommonlySide(X, null);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess = null;
                }
                else
                            if (Node.SampleAccess.ToString().ToLower() == "sin")
                {
                    AddToTree.Tree X = new AddToTree.Tree("x", false);
                    AddToTree.Tree NUM = new AddToTree.Tree("-1", false);
                    AddToTree.Tree MUL = new AddToTree.Tree("*", false);

                    Dummy.SampleAccess = "Cos";
                    Dummy.SetLefTandRightCommonlySide(X, null);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess = null;
                    //ERRORCORECTION19824334 :the New Dummy set at MUL.refer o page 240.
                    AddToTree.Tree DummyNEW = Dummy.CopyNewTree(Dummy);

                    MUL.SetLefTandRightCommonlySide(NUM, DummyNEW);
                    MUL.LeftSideAccess.ThreadAccess = MUL;
                    MUL.RightSideAccess.ThreadAccess = MUL;

                    Dummy = MUL;
                }
                else
                                if (Node.SampleAccess.ToString().ToLower() == "tan")
                {
                    AddToTree.Tree Ln = new AddToTree.Tree("Ln", false);
                    AddToTree.Tree Cos = new AddToTree.Tree("Cos", false);
                    AddToTree.Tree X = new AddToTree.Tree("x", false);
                    AddToTree.Tree CTX = new AddToTree.Tree("CTX", false);
                    AddToTree.Tree NUM = new AddToTree.Tree("-1", false);

                    Cos.SetLefTandRightCommonlySide(X, null);
                    Cos.LeftSideAccess.ThreadAccess = Cos;

                    Ln.SetLefTandRightCommonlySide(Cos, null);
                    Ln.LeftSideAccess.ThreadAccess = Ln;

                    Dummy.SetLefTandRightCommonlySide(NUM, Ln);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;

                    Dummy.SetLefTandRightCommonlySide(Dummy, CTX);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy.SampleAccess = "+";
                }
                else
                                    if (Node.SampleAccess.ToString().ToLower() == "cot")
                {
                    AddToTree.Tree Ln = new AddToTree.Tree("Ln", false);
                    AddToTree.Tree Sin = new AddToTree.Tree("Sin", false);
                    AddToTree.Tree X = new AddToTree.Tree("x", false);
                    AddToTree.Tree CTX = new AddToTree.Tree("CTX", false);

                    Sin.SetLefTandRightCommonlySide(X, null);
                    Sin.LeftSideAccess.ThreadAccess = Sin;

                    Ln.SetLefTandRightCommonlySide(Sin, null);
                    Ln.LeftSideAccess.ThreadAccess = Ln;

                    Dummy.SampleAccess = "+";
                    Dummy.SetLefTandRightCommonlySide(Ln, CTX);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                }
                else
                                        if (Node.SampleAccess.ToString().ToLower() == "ln")
                {
                    AddToTree.Tree X = new AddToTree.Tree("x", false);
                    AddToTree.Tree Ln = new AddToTree.Tree("Ln", false);
                    AddToTree.Tree CTX = new AddToTree.Tree("CTX", false);

                    Ln.SetLefTandRightCommonlySide(X, null);
                    Ln.LeftSideAccess.ThreadAccess = Ln;

                    Ln.SetLefTandRightCommonlySide(X, Ln);
                    Ln.LeftSideAccess.ThreadAccess = Ln;
                    Ln.RightSideAccess.ThreadAccess = Ln;

                    Ln.SetLefTandRightCommonlySide(Ln, X);
                    Ln.LeftSideAccess.ThreadAccess = Ln;
                    Ln.RightSideAccess.ThreadAccess = Ln;
                    Ln.SampleAccess = "-";

                    Dummy.SampleAccess = "+";
                    Dummy.SetLefTandRightCommonlySide(Ln, CTX);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                }
                else
                                            if (Node.SampleAccess.ToString().ToLower() == "log")
                {
                    AddToTree.Tree X = new AddToTree.Tree("x", false);
                    AddToTree.Tree Log = new AddToTree.Tree("Log", false);
                    AddToTree.Tree Ln = new AddToTree.Tree("Ln", false);
                    AddToTree.Tree CTX = new AddToTree.Tree("CTX", false);
                    AddToTree.Tree Ten = new AddToTree.Tree("10", false);

                    Log.SetLefTandRightCommonlySide(X, null);
                    Log.LeftSideAccess.ThreadAccess = Log;

                    Log.SetLefTandRightCommonlySide(X, Log);
                    Log.LeftSideAccess.ThreadAccess = Log;
                    Log.RightSideAccess.ThreadAccess = Log;

                    Ln.SetLefTandRightCommonlySide(Ten, null);
                    Ln.LeftSideAccess.ThreadAccess = Ln;
                    Ln.RightSideAccess.ThreadAccess = Ln;

                    X.SetLefTandRightCommonlySide(Ln, X);
                    X.LeftSideAccess.ThreadAccess = X;
                    X.RightSideAccess.ThreadAccess = X;

                    Log.SetLefTandRightCommonlySide(Log, X);
                    Log.LeftSideAccess.ThreadAccess = Log;
                    Log.RightSideAccess.ThreadAccess = Log;
                    Log.SampleAccess = "-";

                    Dummy.SampleAccess = "+";
                    Dummy.SetLefTandRightCommonlySide(Ln, CTX);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                }
                else
                                                if (Node.SampleAccess.ToString().ToLower() == "sec")
                {
                    AddToTree.Tree Sec = new AddToTree.Tree("Sec", false);
                    AddToTree.Tree Tan = new AddToTree.Tree("Tan", false);
                    AddToTree.Tree X = new AddToTree.Tree("x", false);

                    Sec.SetLefTandRightCommonlySide(X, null);
                    Sec.LeftSideAccess.ThreadAccess = Sec;
                    Sec.RightSideAccess.ThreadAccess = Sec;

                    Tan.SetLefTandRightCommonlySide(X, null);
                    Tan.LeftSideAccess.ThreadAccess = Tan;
                    Tan.RightSideAccess.ThreadAccess = Tan;

                    Dummy.SetLefTandRightCommonlySide(Sec, Tan);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy.SampleAccess = "+";

                    Dummy.SetLefTandRightCommonlySide(Dummy, null);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy.SampleAccess = "Ln";
                }
                else
                                                    if (Node.SampleAccess.ToString().ToLower() == "csc")
                {
                    AddToTree.Tree Csc = new AddToTree.Tree("Csc", false);
                    AddToTree.Tree Cot = new AddToTree.Tree("Cot", false);
                    AddToTree.Tree X = new AddToTree.Tree("x", false);

                    Csc.SetLefTandRightCommonlySide(X, null);
                    Csc.LeftSideAccess.ThreadAccess = Csc;
                    Csc.RightSideAccess.ThreadAccess = Csc;

                    Cot.SetLefTandRightCommonlySide(X, null);
                    Cot.LeftSideAccess.ThreadAccess = Cot;
                    Cot.RightSideAccess.ThreadAccess = Cot;

                    Dummy.SetLefTandRightCommonlySide(Csc, Cot);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy.SampleAccess = "-";

                    Dummy.SetLefTandRightCommonlySide(Dummy, null);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy.SampleAccess = "Ln";
                }
                else
                                                        if (Node.SampleAccess.ToString().ToLower() == "root")
                {
                    AddToTree.Tree X = new AddToTree.Tree("x", false);
                    AddToTree.Tree POWER = new AddToTree.Tree("^", false);
                    AddToTree.Tree MUL = new AddToTree.Tree("*", false);
                    AddToTree.Tree DIV = new AddToTree.Tree("/", false);
                    AddToTree.Tree DIVTOW = new AddToTree.Tree("/", false);
                    AddToTree.Tree NUMTOW = new AddToTree.Tree("2", false);
                    AddToTree.Tree NUMTHREE = new AddToTree.Tree("3", false);


                    DIVTOW.SetLefTandRightCommonlySide(NUMTOW, NUMTHREE);
                    DIVTOW.LeftSideAccess.ThreadAccess = DIVTOW;
                    DIVTOW.RightSideAccess.ThreadAccess = DIVTOW;

                    DIV.SetLefTandRightCommonlySide(NUMTHREE, NUMTOW);
                    DIV.LeftSideAccess.ThreadAccess = DIV;
                    DIV.RightSideAccess.ThreadAccess = DIV;

                    POWER.SetLefTandRightCommonlySide(X, DIV);
                    POWER.LeftSideAccess.ThreadAccess = POWER;
                    POWER.RightSideAccess.ThreadAccess = POWER;

                    Dummy.SetLefTandRightCommonlySide(DIVTOW, POWER);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    Dummy.SampleAccess = "*";
                }
            }
            /* Dummy.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy),C);
             Dummy.LeftSideAccess.ThreadAccess = Dummy;
             Dummy.RightSideAccess.ThreadAccess = Dummy;
             Dummy.SampleAccess = "+";
             */
            return Dummy;
        }
        static int Fibonatchi(int i)
        {
            if (i == 1)
                return 1;
            return i * Fibonatchi(i - 1);
        }
        static AddToTree.Tree ReplaceXToFX(AddToTree.Tree Dummy, AddToTree.Tree FX)
        {

            if (Dummy.LeftSideAccess != null)
            {
                if (Dummy.LeftSideAccess.SampleAccess == "x")
                {
                    Dummy.SetLefTandRightCommonlySide(FX, Dummy.RightSideAccess);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    return Dummy;
                }
            }
            else
                return Dummy;
            if (Dummy.RightSideAccess != null)
            {
                if (Dummy.RightSideAccess.SampleAccess == "x")
                {
                    Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, FX);
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    return Dummy;
                }
            }
            else
                return Dummy;
            Integral.ReplaceXToFX(Dummy.LeftSideAccess, FX);
            Integral.ReplaceXToFX(Dummy.RightSideAccess, FX);
            return Dummy;
        }
        static AddToTree.Tree XPowerIMulFXPerGXDerI(int i, AddToTree.Tree FX, AddToTree.Tree GX, ref UknownIntegralSolver UIS)
        {
            AddToTree.Tree Node = new AddToTree.Tree(null, false);
            AddToTree.Tree X = new AddToTree.Tree("x", false);
            AddToTree.Tree Power = new AddToTree.Tree("^", false);
            AddToTree.Tree NUM = new AddToTree.Tree(i.ToString(), false);
            AddToTree.Tree Holder = new AddToTree.Tree(null, false);
            AddToTree.Tree HolderPartOne = new AddToTree.Tree(null, false);
            AddToTree.Tree CTX = new AddToTree.Tree("CTX", false);

            AddToTree.Tree FXPERGX = null;
            if (GX != null)
                FXPERGX = Integral.FXPerGX(FX, GX);
            else
                FXPERGX = FX;

            FXPERGX = Integral.DervisionI(i, FXPERGX, ref UIS);

            FXPERGX = Simplifier.SimplifierFx(FXPERGX, ref UIS);

            if (FXPERGX.SampleAccess != null)
            {
                Power.SetLefTandRightCommonlySide(X, NUM);
                Power.LeftSideAccess.ThreadAccess = Power;
                Power.LeftSideAccess.ThreadAccess = Power;

                Node.SetLefTandRightCommonlySide(Power, FXPERGX);
                Node.LeftSideAccess.ThreadAccess = Node;
                Node.RightSideAccess.ThreadAccess = Node;
                Node.SampleAccess = "*";

                AddToTree.Tree HolderPart = Node;


                if (HolderPart.SampleAccess != null)
                {
                    if ((i % 2) != 0)
                    {
                        NUM.SampleAccess = "-1";
                        HolderPartOne.SetLefTandRightCommonlySide(NUM, HolderPart);
                        HolderPartOne.LeftSideAccess.ThreadAccess = HolderPartOne;
                        HolderPartOne.RightSideAccess.ThreadAccess = HolderPartOne;
                        HolderPartOne.SampleAccess = "*";
                    }
                    NUM.SampleAccess = (Integral.Fibonatchi(i + 1).ToString());

                    Holder.SetLefTandRightCommonlySide(HolderPartOne, NUM);
                    Holder.LeftSideAccess.ThreadAccess = Holder;
                    Holder.RightSideAccess.ThreadAccess = Holder;
                    Holder.SampleAccess = "/";
                }
                else
                    Holder = HolderPart;
            }
            else Holder = CTX;
            return Holder;

        }
        static public AddToTree.Tree DervisionI(int t, AddToTree.Tree T, ref UknownIntegralSolver UIS)
        {
            int i = 0;
            while (i < t)
            {
                T = Simplifier.SimplifierFx(T, ref UIS);
                //ERROR981724 :An Error Has Ocured in DerivasionFX.refer to page 172.it might be of null Derivasion result.
                T = Derivasion.DerivasionOfFX(T.CopyNewTree(T), ref UIS);


                i++;
                //ERRORCORECTION97918724 :Error corrected.refer to page 180.
                if (T.SampleAccess == null)
                    break;
            }
            return T;
        }
        static AddToTree.Tree FXPerGX(AddToTree.Tree FX, AddToTree.Tree GX)
        {
            AddToTree.Tree Dummy = new AddToTree.Tree(null, false);
            Dummy.SetLefTandRightCommonlySide(FX, GX);
            Dummy.SampleAccess = "/";
            Dummy.LeftSideAccess.ThreadAccess = Dummy;
            Dummy.RightSideAccess.ThreadAccess = Dummy;
            return Dummy;
        }
        static AddToTree.Tree XMulDerivisionOfFx(int i, AddToTree.Tree FX, AddToTree.Tree GX, ref UknownIntegralSolver UIS)
        {

            AddToTree.Tree FXPerGX = new AddToTree.Tree(null, false);
            AddToTree.Tree X = new AddToTree.Tree("x", false);
            AddToTree.Tree Power = new AddToTree.Tree("^", false);
            AddToTree.Tree PowerOne = new AddToTree.Tree("*", false);
            AddToTree.Tree PowerTow = new AddToTree.Tree(null, false);
            AddToTree.Tree PowerThree = new AddToTree.Tree(null, false);
            AddToTree.Tree NUM = new AddToTree.Tree(i.ToString(), false);

            FXPerGX.SetLefTandRightCommonlySide(FX, GX);

            if (GX == null)
                FXPerGX = FX;
            //ERROR307040131222  :Ther method give wrong at (Derivasion I).refre to page 182.
            FXPerGX = Integral.DervisionI(i, FXPerGX, ref UIS);
            FXPerGX = Simplifier.SimplifierFx(FXPerGX, ref UIS);
            //LOCATION9781249843 :Need to Indicating null.refer to page 180.
            //ERRORCORECTION984102934809 :The corection of error.refer to page 180.
            if (FXPerGX.SampleAccess != null)
            {
                Power.SetLefTandRightCommonlySide(X, NUM);
                Power.LeftSideAccess.ThreadAccess = Power;
                Power.RightSideAccess.ThreadAccess = Power;

                if ((i % 2) != 0)
                {
                    NUM.SampleAccess = "-1";
                    PowerOne.SetLefTandRightCommonlySide(Power, NUM);
                    PowerOne.LeftSideAccess.ThreadAccess = PowerOne;
                    PowerOne.RightSideAccess.ThreadAccess = PowerOne;
                }

                NUM.SampleAccess = Integral.Fibonatchi(i + 1).ToString();

                PowerTow.SetLefTandRightCommonlySide(PowerOne, FXPerGX);
                PowerTow.LeftSideAccess.ThreadAccess = PowerTow;
                PowerTow.RightSideAccess.ThreadAccess = PowerTow;
                PowerTow.SampleAccess = "*";

                PowerThree.SetLefTandRightCommonlySide(PowerTow, NUM);
                PowerThree.LeftSideAccess.ThreadAccess = PowerThree;
                PowerThree.RightSideAccess.ThreadAccess = PowerThree;
                PowerThree.SampleAccess = "/";
                Power = Power.CopyNewTree(PowerThree);
            }
            else
                Power = FXPerGX;
            return Power;
        }
    }
}
