//ERROR317142 :The structure is ok.refer to page 155.
//ERRORCORECTION30704012 :The error correced.refer to page 155.
//==========================================================

namespace Formulas
{
    static class Derivasion
    {
        //static SenderSample Sender = new SenderSample(new Equation());
        static public AddToTree.Tree DerivasionOfFX(AddToTree.Tree Node, ref UknownIntegralSolver UIS)
        {
            AddToTree.Tree Dummy = new AddToTree.Tree(null, false);
            Dummy = Derivasion.DerivasionCalculator(Node, Dummy, ref UIS);
            Dummy = Simplifier.SimplifierFx(Dummy, ref UIS);
            return Dummy;
        }
        static AddToTree.Tree ConsTantFuctionDerivasion(AddToTree.Tree Node)
        {
            AddToTree.Tree Dummy = new AddToTree.Tree(null, false);
            if (Node.SampleAccess.ToString().ToLower() == "sin")
            {
                AddToTree.Tree X = new AddToTree.Tree("x", false);
                Dummy.SampleAccess = "Cos";
                Dummy.SetLefTandRightCommonlySide(X, null);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
            }
            else
                if (Node.SampleAccess.ToString().ToLower() == "cos")
            {
                AddToTree.Tree X = new AddToTree.Tree("x", false);
                AddToTree.Tree NUM = new AddToTree.Tree("-1", false);
                AddToTree.Tree MUL = new AddToTree.Tree("*", false);

                Dummy.SampleAccess = "Sin";
                Dummy.SetLefTandRightCommonlySide(X, null);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;

                MUL.SetLefTandRightCommonlySide(NUM, Dummy);
                MUL.LeftSideAccess.ThreadAccess = MUL;
                MUL.RightSideAccess.ThreadAccess = MUL;

                Dummy = MUL;
            }
            else
                    if (Node.SampleAccess.ToString().ToLower() == "tan")
            {
                AddToTree.Tree TanX = new AddToTree.Tree("Tan", false);
                AddToTree.Tree Power = new AddToTree.Tree("^", false);
                AddToTree.Tree X = new AddToTree.Tree("x", false);
                AddToTree.Tree NUML = new AddToTree.Tree("1", false);
                AddToTree.Tree NUMR = new AddToTree.Tree("2", false);


                TanX.SetLefTandRightCommonlySide(X, null);
                TanX.LeftSideAccess.ThreadAccess = TanX;

                Power.SetLefTandRightCommonlySide(TanX, NUMR);
                Power.LeftSideAccess.ThreadAccess = Power;
                Power.RightSideAccess.ThreadAccess = Power;

                Dummy.SetLefTandRightCommonlySide(NUML, Power);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
            }
            else
                        if (Node.SampleAccess.ToString().ToLower() == "cot")
            {
                AddToTree.Tree ADD = new AddToTree.Tree("+", false);
                AddToTree.Tree CotX = new AddToTree.Tree("Cot", false);
                AddToTree.Tree Power = new AddToTree.Tree("^", false);
                AddToTree.Tree X = new AddToTree.Tree("x", false);
                AddToTree.Tree NUM = new AddToTree.Tree("-1", false);
                AddToTree.Tree NUML = new AddToTree.Tree("1", false);
                AddToTree.Tree NUMR = new AddToTree.Tree("2", false);
                AddToTree.Tree MUL = new AddToTree.Tree("*", false);

                CotX.SetLefTandRightCommonlySide(X, null);
                CotX.LeftSideAccess.ThreadAccess = CotX;

                Power.SetLefTandRightCommonlySide(CotX, NUMR);
                Power.LeftSideAccess.ThreadAccess = Power;
                Power.RightSideAccess.ThreadAccess = Power;

                ADD.SetLefTandRightCommonlySide(NUML, Power);
                ADD.LeftSideAccess.ThreadAccess = ADD;
                ADD.RightSideAccess.ThreadAccess = ADD;

                Dummy.SetLefTandRightCommonlySide(NUM, ADD);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
            }
            else
                            if (Node.SampleAccess.ToString().ToLower() == "ln")
            {
                AddToTree.Tree X = new AddToTree.Tree("x", false);
                AddToTree.Tree NUM = new AddToTree.Tree("1", false);

                Dummy.SampleAccess = "/";
                Dummy.SetLefTandRightCommonlySide(NUM, X);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;

            }
            else
                                if (Node.SampleAccess.ToString().ToLower() == "log")
            {
                AddToTree.Tree X = new AddToTree.Tree("x", false);
                AddToTree.Tree NUMR = new AddToTree.Tree("1", false);
                AddToTree.Tree Ln = new AddToTree.Tree("Ln", false);
                AddToTree.Tree NUML = new AddToTree.Tree("10", false);
                AddToTree.Tree DIV = new AddToTree.Tree("/", false);


                Ln.SetLefTandRightCommonlySide(NUML, null);
                Ln.LeftSideAccess.ThreadAccess = Ln;
                Ln.RightSideAccess.ThreadAccess = Ln;

                DIV.SetLefTandRightCommonlySide(NUMR, X);
                DIV.LeftSideAccess.ThreadAccess = DIV;
                DIV.RightSideAccess.ThreadAccess = DIV;

                Dummy.SampleAccess = "*";
                Dummy.SetLefTandRightCommonlySide(Ln, DIV);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
            }
            else
                                    if (Node.SampleAccess.ToString().ToLower() == "sec")
            {
                AddToTree.Tree Sin = new AddToTree.Tree("Sin", false);
                AddToTree.Tree Cos = new AddToTree.Tree("Cos", false);
                AddToTree.Tree POWER = new AddToTree.Tree("^", false);
                AddToTree.Tree X = new AddToTree.Tree("x", false);
                AddToTree.Tree MUL = new AddToTree.Tree("*", false);
                AddToTree.Tree NUMR = new AddToTree.Tree("2", false);
                AddToTree.Tree NUML = new AddToTree.Tree("-1", false);

                Sin.SetLefTandRightCommonlySide(X, null);
                Sin.LeftSideAccess.ThreadAccess = Sin;
                Sin.RightSideAccess.ThreadAccess = Sin;

                MUL.SetLefTandRightCommonlySide(NUML, Sin);
                MUL.LeftSideAccess.ThreadAccess = MUL;
                MUL.RightSideAccess.ThreadAccess = MUL;

                Cos.SetLefTandRightCommonlySide(Cos, null);
                Cos.LeftSideAccess.ThreadAccess = Cos;
                Cos.RightSideAccess.ThreadAccess = Cos;

                POWER.SetLefTandRightCommonlySide(Cos, NUMR);
                POWER.LeftSideAccess.ThreadAccess = POWER;
                POWER.RightSideAccess.ThreadAccess = POWER;

                Dummy.SetLefTandRightCommonlySide(MUL, POWER);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
            }
            else
                                        if (Node.SampleAccess.ToString().ToLower() == "csc")
            {
                AddToTree.Tree Sin = new AddToTree.Tree("Sin", false);
                AddToTree.Tree Cos = new AddToTree.Tree("Cos", false);
                AddToTree.Tree POWER = new AddToTree.Tree("^", false);
                AddToTree.Tree X = new AddToTree.Tree("x", false);
                AddToTree.Tree NUMR = new AddToTree.Tree("2", false);



                Sin.SetLefTandRightCommonlySide(X, null);
                Sin.LeftSideAccess.ThreadAccess = Sin;
                Sin.RightSideAccess.ThreadAccess = Sin;


                Cos.SetLefTandRightCommonlySide(Cos, null);
                Cos.LeftSideAccess.ThreadAccess = Cos;
                Cos.RightSideAccess.ThreadAccess = Cos;

                POWER.SetLefTandRightCommonlySide(Sin, NUMR);
                POWER.LeftSideAccess.ThreadAccess = POWER;
                POWER.RightSideAccess.ThreadAccess = POWER;

                Dummy.SetLefTandRightCommonlySide(Cos, POWER);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
            }
            else
                                            if (Node.SampleAccess.ToString().ToLower() == "root")
            {
                AddToTree.Tree Root = new AddToTree.Tree("Root", false);
                AddToTree.Tree X = new AddToTree.Tree("x", false);
                AddToTree.Tree MUL = new AddToTree.Tree("*", false);
                AddToTree.Tree NUMTOW = new AddToTree.Tree("2", false);
                AddToTree.Tree NUMONE = new AddToTree.Tree("1", false);

                Root.SetLefTandRightCommonlySide(X, null);
                Root.LeftSideAccess.ThreadAccess = Root;
                //Root.RightSideAccess.ThreadAccess = Root;

                MUL.SetLefTandRightCommonlySide(NUMTOW, MUL);
                MUL.LeftSideAccess.ThreadAccess = MUL;
                MUL.RightSideAccess.ThreadAccess = MUL;

                Dummy.SetLefTandRightCommonlySide(NUMONE, MUL);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;



            }

            return Dummy;

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
            Derivasion.ReplaceXToFX(Dummy.LeftSideAccess, FX);
            Derivasion.ReplaceXToFX(Dummy.RightSideAccess, FX);
            return Dummy;
        }

        static AddToTree.Tree DerivasionCalculator(AddToTree.Tree Node, AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            if (Node == null)
                return Dummy;
            if (Node.SampleAccess == "x")
            {
                Dummy.SampleAccess = "1";
                return Dummy;
            }
            //ERROR317142 :The structure is ok.refer to page 155.

            //ERRORCORECTION30704012 :The error correced.refer to page 155.
            if (Node.LeftSideAccess != null)
                if (Node.LeftSideAccess.LeftSideAccess == null)
                    if (Node.LeftSideAccess.RightSideAccess == null)
                        if (IS.IsFunction(Node.SampleAccess))
                        {
                            Dummy = Derivasion.ConsTantFuctionDerivasion(Node);
                            return Dummy;
                        }
                        else
                        if (IS.IsNumber(Dummy.SampleAccess))
                        {
                            Dummy = null;
                            return Dummy;
                        }
            if (Node.SampleAccess == "/")
            {
                AddToTree.Tree Minuse = new AddToTree.Tree("-", false);
                AddToTree.Tree MulL = new AddToTree.Tree("*", false);
                AddToTree.Tree MulR = new AddToTree.Tree("*", false);
                AddToTree.Tree Power = new AddToTree.Tree("^", false);
                AddToTree.Tree DFX = new AddToTree.Tree(null, false);
                AddToTree.Tree DGX = new AddToTree.Tree(null, false);
                AddToTree.Tree NRMulL = new AddToTree.Tree(null, false);
                AddToTree.Tree NRMulR = new AddToTree.Tree(null, false);
                AddToTree.Tree GX = Node.CopyNewTree(Node.RightSideAccess);
                AddToTree.Tree IND = new AddToTree.Tree("2", false);

                DFX = Derivasion.DerivasionOfFX(Node.LeftSideAccess, ref UIS);
                NRMulL = Node.RightSideAccess;

                MulL.SetLefTandRightCommonlySide(DFX, NRMulL);
                MulL.LeftSideAccess.ThreadAccess = MulL;
                MulL.RightSideAccess.ThreadAccess = MulL;

                DGX = Derivasion.DerivasionOfFX(Node.RightSideAccess, ref UIS);
                NRMulR = Node.LeftSideAccess;

                MulR.SetLefTandRightCommonlySide(DGX, NRMulR);
                MulR.LeftSideAccess.ThreadAccess = MulR;
                MulR.RightSideAccess.ThreadAccess = MulR;

                Minuse.SetLefTandRightCommonlySide(MulL, MulR);
                Minuse.LeftSideAccess.ThreadAccess = Minuse;
                Minuse.RightSideAccess.ThreadAccess = Minuse;

                Power.SetLefTandRightCommonlySide(GX, IND);
                Power.LeftSideAccess.ThreadAccess = Power;
                Power.RightSideAccess.ThreadAccess = Power;

                Dummy.SampleAccess = "/";
                Dummy.SetLefTandRightCommonlySide(Minuse, Power);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
            }
            else
                if (Node.SampleAccess == "*")
            {
                AddToTree.Tree MulL = new AddToTree.Tree("*", false);
                AddToTree.Tree MulR = new AddToTree.Tree("*", false);
                AddToTree.Tree DFX = new AddToTree.Tree(null, false);
                AddToTree.Tree DGX = new AddToTree.Tree(null, false);
                AddToTree.Tree NRMulL = new AddToTree.Tree(null, false);
                AddToTree.Tree NRMulR = new AddToTree.Tree(null, false);

                DFX = Derivasion.DerivasionOfFX(Node.LeftSideAccess, ref UIS);
                DGX = Derivasion.DerivasionOfFX(Node.RightSideAccess, ref UIS);

                NRMulL = Node.LeftSideAccess;
                NRMulR = Node.RightSideAccess;

                MulL.SetLefTandRightCommonlySide(DFX, NRMulR);
                MulL.LeftSideAccess.ThreadAccess = MulL;
                if (NRMulR.SampleAccess != null)
                    MulL.RightSideAccess.ThreadAccess = MulL;

                MulR.SetLefTandRightCommonlySide(Node.LeftSideAccess, DGX);
                MulR.LeftSideAccess.ThreadAccess = MulR;
                if (DGX.SampleAccess != null)
                    MulR.RightSideAccess.ThreadAccess = MulR;

                Dummy.SampleAccess = "+";
                Dummy.SetLefTandRightCommonlySide(MulL, MulR);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
            }
            else
                    if (Node.SampleAccess == "-")
            {
                AddToTree.Tree DFX = new AddToTree.Tree(null, false);
                AddToTree.Tree DGX = new AddToTree.Tree(null, false);

                DFX = Derivasion.DerivasionOfFX(Node.LeftSideAccess, ref UIS);
                DGX = Derivasion.DerivasionOfFX(Node.RightSideAccess, ref UIS);

                Dummy.SampleAccess = "-";
                Dummy.SetLefTandRightCommonlySide(DFX, DGX);

                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
            }
            else
                        if (Node.SampleAccess == "+")
            {
                AddToTree.Tree DFX = new AddToTree.Tree(null, false);
                AddToTree.Tree DGX = new AddToTree.Tree(null, false);

                DFX = Derivasion.DerivasionOfFX(Node.LeftSideAccess, ref UIS);
                DGX = Derivasion.DerivasionOfFX(Node.RightSideAccess, ref UIS);

                Dummy.SampleAccess = "+";
                Dummy.SetLefTandRightCommonlySide(DFX, DGX);

                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
            }
            else
                            if (Node.SampleAccess == "^")
            {
                AddToTree.Tree ADD = new AddToTree.Tree("+", false);
                AddToTree.Tree Copy = Node.CopyNewTree(Node);
                AddToTree.Tree LnFX = new AddToTree.Tree("Ln", false);
                AddToTree.Tree FXONE = Node.CopyNewTree(Node.LeftSideAccess);
                AddToTree.Tree FXTOW = Node.CopyNewTree(Node.LeftSideAccess);
                AddToTree.Tree GX = Node.CopyNewTree(Node.RightSideAccess);
                AddToTree.Tree DFX = new AddToTree.Tree(null, false);
                AddToTree.Tree DGX = new AddToTree.Tree(null, false);
                AddToTree.Tree MulLevelTowL = new AddToTree.Tree("*", false);
                AddToTree.Tree MulLevelTowR = new AddToTree.Tree("*", false);
                AddToTree.Tree DIVThree = new AddToTree.Tree("/", false);

                FXONE.ThreadAccess = null;
                DFX = Derivasion.DerivasionOfFX(FXONE, ref UIS);
                GX.ThreadAccess = null;
                DGX = Derivasion.DerivasionOfFX(GX, ref UIS);


                DIVThree.SetLefTandRightCommonlySide(DFX, FXONE);
                DIVThree.LeftSideAccess.ThreadAccess = DIVThree;
                DIVThree.RightSideAccess.ThreadAccess = DIVThree;

                MulLevelTowR.SetLefTandRightCommonlySide(GX, DIVThree);
                MulLevelTowR.LeftSideAccess.ThreadAccess = MulLevelTowR;
                MulLevelTowR.RightSideAccess.ThreadAccess = MulLevelTowR;

                LnFX.SetLefTandRightCommonlySide(FXTOW, null);
                LnFX.LeftSideAccess.ThreadAccess = LnFX;
                LnFX.RightSideAccess = null;

                MulLevelTowL.SetLefTandRightCommonlySide(DGX, LnFX);
                MulLevelTowL.LeftSideAccess.ThreadAccess = MulLevelTowL;
                MulLevelTowL.RightSideAccess.ThreadAccess = MulLevelTowL;

                ADD.SetLefTandRightCommonlySide(MulLevelTowL, MulLevelTowR);
                ADD.LeftSideAccess.ThreadAccess = ADD;
                ADD.RightSideAccess.ThreadAccess = ADD;

                Dummy.SampleAccess = "*";
                Dummy.SetLefTandRightCommonlySide(Copy, ADD);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;

            }
            else
                            if (IS.IsFunction(Node.SampleAccess))
            {
                AddToTree.Tree DFoGX = Node.CopyNewTree(Node);
                AddToTree.Tree FX = (Node);
                AddToTree.Tree GX = Node.RightSideAccess;
                AddToTree.Tree DFX = new AddToTree.Tree(null, false);
                AddToTree.Tree DGX = new AddToTree.Tree(null, false);


                FX.LeftSideAccess.SetLefTandRightCommonlySide(null, null);
                FX.LeftSideAccess.SampleAccess = "x";

                DFX = Derivasion.DerivasionOfFX(FX, ref UIS);
                DGX = Derivasion.DerivasionOfFX(Node.LeftSideAccess, ref UIS);

                /*DFoGX.SetLefTandRightCommonlySide(DFX,null);
                DFoGX.SampleAccess = DFX.SampleAccess;
                DFoGX.LeftSideAccess.ThreadAccess = DFoGX;
                if(DFoGX.RightSideAccess!=null)
                DFoGX.RightSideAccess.ThreadAccess = DFoGX;
                */
                DFoGX = Derivasion.ReplaceXToFX(DFX, Node.RightSideAccess);

                Dummy.SampleAccess = "*";
                Dummy.SetLefTandRightCommonlySide(DGX, DFoGX);
                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                Dummy.RightSideAccess.ThreadAccess = Dummy;
            }
            return Dummy;
        }
    }
}
