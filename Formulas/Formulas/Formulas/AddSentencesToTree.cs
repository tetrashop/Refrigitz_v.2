//ERRORCORECTION1897246872 :goto added.
//ERRORCORECTION786543679086 : if let side is empty do this else do else.
//refer to page 85 and e Formulas namespace
//========================================================================================
//ERRORCORECTION760947638 : The condition added.refer to page 96 at ERROR456790358754
//========================================================================================
//ERRORCORECTION1872498 :The ERROR31725 (of Equation Class) Error Correction.refer to page 102.
//========================================================================================
//ERROR9823748 :The Structure is not valid.In x^2+x-2.refer to page 103.error occured when next condition is taken also.
//ERRORCORECTION1897246872 :goto added.
//========================================================================================
//ERROR239874897 :The Structre is incoreced.
//ERRORCORECTION238748 :The Structure is Constructed.
//========================================================================================
//ERRORCUASE273275  :The strucure is constructed incorrectly.
//========================================================================================
//ERRORCORECTION9807 :The set sample is done.refer to page 105.
//========================================================================================
//ERROR31712342 :The graphically drawn is incorrect.refer top page 105.
//========================================================================================
//ERROR41721641 :The draw structure is not valid.
//========================================================================================
//ERRORCORECTION981274 :The Structure is corected.refer to page 109.
//========================================================================================
//ERRORCAUSE3172 :refer top page 117.
//========================================================================================
//ERRORCORECTION281319238 :refer top page 120.
//========================================================================================
//ERRORCAUSE3178324 :refer to page 120.
//========================================================================================
//ERROR31078472 :The condistion is not valid.
//========================================================================================
//ERROR3070403258 :refer to page 121.
//========================================================================================
//PROPOSAL3040704030.refer to page 121.
//========================================================================================
//ERRORCORECTION862134 :The condition added.refer top apge 121.
//========================================================================================
//ERRORCUASE2381274 :The Base Node is Not Set Correctly.refer to page 139.
//========================================================================================
//ERRORCORECTION091824098.refer to page 177.
//========================================================================================
//CASED13171507 :Refer to oage 336.
//========================================================================================
using System;

namespace AddToTree
{
    public class Tree
    {
        private Tree LeftSide = null;
        private Tree RightSide = null;

        private Tree Thread = null;

        private bool Splitable = true;

        String Sample;
        private bool Integration = true;
        AddToTree.Tree DummyFind = null;
        //int NodeNumber = 0;
        //static int NumberOfNode = 0;
        public Tree(String SD0, bool INT)
        {
            Sample = SD0;
            Integration = INT;
            //  this.NodeNumber = NumberOfNode + 1;
            //NumberOfNode++;
        }
        public Tree FINDTreeWithThreadConsideration(AddToTree.Tree Base, AddToTree.Tree Holder)
        {
            DummyFind = null;
            DummyFind = this.FINDTreeWithThreadConsiderationAction(Base, Holder);
            return DummyFind;
        }
        private Tree FINDTreeWithThreadConsiderationAction(AddToTree.Tree Base, AddToTree.Tree Holder)
        {

            if (Base == null)
                return DummyFind;
            this.FINDTreeWithThreadConsiderationAction(Base.LeftSideAccess, Holder);
            this.FINDTreeWithThreadConsiderationAction(Base.RightSideAccess, Holder);
            if (Formulas.EqualToObject.IsEqualWithThreadConsiderationCommonly(Base, Holder))
                DummyFind = Base;
            return DummyFind;
        }
        public Tree FINDTreeWithOutThreadConsideration(AddToTree.Tree Base, AddToTree.Tree Holder)
        {
            DummyFind = null;
            DummyFind = this.FINDTreeWithOutThreadConsiderationAction(Base, Holder);
            return DummyFind;
        }
        private Tree FINDTreeWithOutThreadConsiderationAction(AddToTree.Tree Base, AddToTree.Tree Holder)
        {

            if (Base == null)
                return DummyFind;
            this.FINDTreeWithOutThreadConsiderationAction(Base.LeftSideAccess, Holder);
            this.FINDTreeWithOutThreadConsiderationAction(Base.RightSideAccess, Holder);
            if (Formulas.EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Base, Holder))
                DummyFind = Base;
            return DummyFind;
        }
        public Tree FINDTreeWithOutThreadConsiderationWithMoreeficiency(AddToTree.Tree Base, AddToTree.Tree Holder)
        {
            DummyFind = null;
            Formulas.UknownIntegralSolver UIS = new Formulas.UknownIntegralSolver();
            UIS.Hide();
            DummyFind = this.FINDTreeWithOutThreadConsiderationActionWithMoreeficiency(Base, Holder, ref UIS);
            return DummyFind;
        }
        private Tree FINDTreeWithOutThreadConsiderationActionWithMoreeficiency(AddToTree.Tree Base, AddToTree.Tree Holder, ref Formulas.UknownIntegralSolver UIS)
        {

            if (Base == null)
                return DummyFind;
            this.FINDTreeWithOutThreadConsiderationActionWithMoreeficiency(Base.LeftSideAccess, Holder, ref UIS);
            this.FINDTreeWithOutThreadConsiderationActionWithMoreeficiency(Base.RightSideAccess, Holder, ref UIS);
            if (Formulas.EqualToObject.IsEqualWithOutThreadConsiderationByDivision(Base, Holder, ref UIS))
                DummyFind = Base;
            return DummyFind;
        }
        public Tree CopyNewTree(AddToTree.Tree Exsit)
        {
            if (Exsit != null)
            {
                AddToTree.Tree Current = new AddToTree.Tree(null, false);
                Current = Exsit.CopyNewTreeAction(Exsit);
                //CASED13171507 :Refer to oage 336.
                //Current.ThreadAccess = Exsit.CopyNewTree(Exsit.ThreadAccess);                

                Current.ThreadAccess = Exsit.ThreadAccess;
                return Current;
            }
            else
                return null;
        }
        public Tree CopyNewTreeAction(AddToTree.Tree Exsit)
        {
            if (Exsit == null)
                return null;
            AddToTree.Tree Current = new AddToTree.Tree(null, false);
            try
            {
                Current.SampleAccess = Exsit.SampleAccess;
                Current.SetLefTandRightCommonlySide(Exsit.CopyNewTreeAction(Exsit.LeftSideAccess), Exsit.CopyNewTreeAction(Exsit.RightSideAccess));
                //ERRORCORECTION091824098.refer to page 177.
                //ERRORCORECTION9812738 :Refet  top age 190.
                Current.LeftSideAccess.ThreadAccess = Current;
                Current.RightSideAccess.ThreadAccess = Current;
            }
            catch (NullReferenceException t)
            { Formulas.ExceptionClass.ExceptionClassMethod(t); }
            return Current;

        }
        public Tree CopyReferenclyTree(AddToTree.Tree Exsit)
        {
            if (Exsit == null)
                return null;
            AddToTree.Tree Current = new AddToTree.Tree(null, false);
            try
            {
                Current.SampleAccess = Exsit.SampleAccess;
                Current.SetLefTandRightReferencelySide(Exsit.LeftSideAccess, Exsit.RightSideAccess);
                //ERRORCORECTION091824098.refer to page 177.
                //ERRORCORECTION9812738 :Refet  top age 190.
                Current.LeftSideAccess.ThreadAccess = Current;
                Current.RightSideAccess.ThreadAccess = Current;
                //Current.NodeNumber = Exsit.NodeNumber;                              
            }
            catch (NullReferenceException t)
            { Formulas.ExceptionClass.ExceptionClassMethod(t); }
            return Current;

        }
        static public Tree DeleteTree(AddToTree.Tree Exsit, AddToTree.Tree Deleted)
        {
            if (Exsit == null)
                return null;
            if (Deleted == null)
                return null;
            AddToTree.Tree Current = new AddToTree.Tree(null, false);
            if (!Formulas.EqualToObject.IsEqualWithThreadConsiderationCommonly(Exsit, Deleted))
            {

                try
                {

                    Current.SampleAccess = Exsit.SampleAccess;
                    Current.SetLefTandRightCommonlySide(AddToTree.Tree.DeleteTree(Exsit.LeftSideAccess, Deleted), AddToTree.Tree.DeleteTree(Exsit.RightSideAccess, Deleted));
                    //ERRORCORECTION091824098.refer to page 177.
                    Current.LeftSideAccess.ThreadAccess = Exsit.LeftSideAccess.ThreadAccess;
                    Current.RightSideAccess.ThreadAccess = Exsit.RightSideAccess.ThreadAccess;
                }
                catch (NullReferenceException t)
                { Formulas.ExceptionClass.ExceptionClassMethod(t); }
            }
            else
            {
                Tree.DeleteTree(Exsit.LeftSideAccess, Deleted.LeftSideAccess);
                Tree.DeleteTree(Exsit.RightSideAccess, Deleted.RightSideAccess);
            }
            return Current;

        }
        public String GetSample()
        {
            return this.Sample;
        }
        /*public void SetSample(String SD)
        { 
         Sample=SD;
        }
         */
        public String SampleAccess
        {
            get { return Sample; }
            set { Sample = value; }
        }
        public void SetLefTandRightCommonlySide(Tree L, Tree R)
        {
            LeftSide = L;
            RightSide = R;
        }
        public void SetLefTandRightReferencelySide(Tree L, Tree R)
        {
            LeftSide = L;
            RightSide = R;
        }
        public Tree LeftSideAccess
        {
            get { return LeftSide; }
            set { LeftSide = value; }
        }
        public bool SplitableAccess
        {
            get { return Splitable; }
            set { Splitable = value; }
        }
        public Tree RightSideAccess
        {
            get { return RightSide; }
            set { RightSide = value; }
        }
        /*public int NodeNumberAccess
        {
            get { return NodeNumber; }
            set { NodeNumber = value; }
        }
         */
        /*public void SetThread(Tree t)
        {
            Thread = t;
        }
         */
        public Tree ThreadAccess
        {
            get { return Thread; }
            set { Thread = value; }

        }
    }
    public class reciverContractionTree
    {
        static private TreeConstruction TreeConstructionVariable = null;
        public reciverContractionTree()
        {
            TreeConstructionVariable = new TreeConstruction();
        }
        public bool ResivedTaskFunction(String Oprator, String LeftSide, String RightSide, int Stage, AddToTree.Tree Dummy, ref bool ACT)
        {
            bool ResivedTaskvariable = false;
            ResivedTaskvariable = TreeConstructionVariable.ConstructionTree(Oprator, LeftSide, RightSide, Stage, Dummy, ref ACT);
            return ResivedTaskvariable;
        }
        public bool GetIsLastRightNumberOrIndependenceVariale()
        {
            return TreeConstructionVariable.GetIsLastRightNumberOrIndependenceVariale();
        }
        public Tree NodeAccess
        {
            get { return TreeConstructionVariable.NodeAccess; }
            set { TreeConstructionVariable.NodeAccess = value; }
        }
        /*public void SetNode(AddToTree.Tree t)
        {
            TreeConstructionVariable.NodeAccess=t;
        }
         */
        /*public Tree NodeAccess
        {
            get { return TreeConstructionVariable.NodeAccess; }
            set { TreeConstructionVariable.NodeAccess=value; }
        }
         */
        public Tree GetRightSideOfLastStage()
        {
            return TreeConstructionVariable.RightSideOfLastStageAccess;
        }
        public Tree GetRightSideOfLastStageByParantez()
        {
            return TreeConstructionVariable.GetRightSideOfLastStageByParantez();
        }
    }
    class TreeConstruction
    {
        //To do just Addition oprations
        private AddOpration AddOprationVariable = null;
        //Contained Tree Constructed
        private Tree Node = null;
        private Tree Current = new Tree(null, true);
        //for decision how to work
        public TreeConstruction()
        {
            AddOprationVariable = new AddOpration();
        }
        /*public Tree NodeAccess
        {
            return AddOprationVariable.NodeReturnAndAccess;
        }
         */
        public Tree NodeAccess
        {
            get { return AddOprationVariable.NodeReturnAndAccess; }
            set { AddOprationVariable.NodeReturnAndAccess = value; }
        }
        public bool GetIsLastRightNumberOrIndependenceVariale()
        {
            return AddOprationVariable.IsLastRightNumberOrIndependenceVariale();
        }
        public Tree NodeReturnAndAccess
        {
            get { return AddOprationVariable.NodeReturnAndAccess; }
            set { AddOprationVariable.NodeReturnAndAccess = value; }
        }
        public bool ConstructionTree(String Oprator, String LeftSide, String RightSide, int Stage, AddToTree.Tree Dummy, ref bool ACT)
        {
            bool Construction = false;
            if (Node == null)
                Node = Current;
            if (Oprator.ToString() == "/")
                AddOprationVariable.AddOprations("/", LeftSide, RightSide, false, Dummy, ref ACT);
            //Construction=this.ConstructionTreeDivisionOprator(LeftSide, RightSide);
            else
                if (Oprator.ToString() == "*")
                AddOprationVariable.AddOprations("*", LeftSide, RightSide, false, Dummy, ref ACT);
            //Construction=this.ConstructionTreeMultiplicationOprator(LeftSide, RightSide);
            else
                    if (Oprator.ToString() == "+")
                AddOprationVariable.AddOprations("+", LeftSide, RightSide, false, Dummy, ref ACT);
            //Construction=this.ConstructionTreeAdditionOprator(LeftSide, RightSide);
            else
                        if (Oprator.ToString() == "-")
                AddOprationVariable.AddOprations("-", LeftSide, RightSide, false, Dummy, ref ACT);
            //Construction=this.ConstructionTreeSubtractionOprator(LeftSide, RightSide);
            else
                            if (Oprator.ToString() == "^")
                AddOprationVariable.AddOprations("^", LeftSide, RightSide, false, Dummy, ref ACT);
            //Construction=this.ConstructionTreePowerOprator(LeftSide, RightSide);
            else
                                if (Oprator.ToString().ToLower() == "sin")
                AddOprationVariable.AddOprations("Sin", LeftSide, null, false, Dummy, ref ACT);
            //Construction=this.ConstructionTreeSinOprator(LeftSide,null);
            else
                                    if (Oprator.ToString().ToLower() == "cos")
                AddOprationVariable.AddOprations("Cos", LeftSide, null, false, Dummy, ref ACT);
            //    Construction=this.ConstructionTreeCosOprator(LeftSide, null);
            else
                                        if (Oprator.ToString().ToLower() == "tan")
                AddOprationVariable.AddOprations("Tan", LeftSide, null, false, Dummy, ref ACT);
            //  Construction=this.ConstructionTreeTanOprator(LeftSide, null);
            else
                                            if (Oprator.ToString().ToLower() == "cot")
                AddOprationVariable.AddOprations("Cot", LeftSide, null, false, Dummy, ref ACT);
            //Construction=this.ConstructionTreeCotOprator(LeftSide, null);
            else
                                                if (Oprator.ToString().ToLower() == "sec")
                AddOprationVariable.AddOprations("Sec", LeftSide, null, false, Dummy, ref ACT);
            // Construction = this.ConstructionTreeSecOprator(LeftSide, null);
            else
                                                    if (Oprator.ToString().ToLower() == "csc")
                AddOprationVariable.AddOprations("Csc", LeftSide, null, false, Dummy, ref ACT);
            // Construction = this.ConstructionTreeCscOprator(LeftSide, null);
            else
                                                        if (Oprator.ToString().ToLower() == "ln")
                AddOprationVariable.AddOprations("Ln", LeftSide, null, false, Dummy, ref ACT);
            else
                                                            if (Oprator.ToString().ToLower() == "=")
                AddOprationVariable.AddOprations("=", null, RightSide, false, Dummy, ref ACT);
            else
                                                            if (LeftSide == null)
                if (RightSide == null)
                    AddOprationVariable.AddOprations(null, null, Oprator, false, Dummy, ref ACT);

            // Construction = this.ConstructionTreeLnOprator(LeftSide, null);            
            if (Current != null)
                Current = Current.RightSideAccess;
            return Construction;
        }
        /*public Tree GetRightSideOfLastStage()
        {
            return AddOprationVariable.GetRightSideOfLastStage();
        }
         */
        public Tree RightSideOfLastStageAccess
        {
            get { return AddOprationVariable.GetRightSideOfLastStage(); }
        }
        public Tree GetRightSideOfLastStageByParantez()
        {
            return AddOprationVariable.GetRightSideOfLastStageByParantez();
        }
    }
    //for just addition
    class AddOpration
    {
        private Tree Node = null;

        public AddOpration()
        {
            Node = new Tree(null, false);
        }
        public AddToTree.Tree NodeAcess
        {
            get { return Node; }
            set { Node = value; }
        }
        public bool AddOprations(String Sample, String LeftSentence, String RightSentecne, bool INT, AddToTree.Tree DummyTree, ref bool ACT)
        {
            Tree Dummy = new Tree(null, false);
            Tree DummyRightSide = new Tree(null, false);
            Tree DummyLeftSide = new Tree(null, false);
            Dummy = Node;

            //For parantez condition.
            if (DummyTree == null)
            {
                if (Dummy != null)
                {
                    while (Dummy.RightSideAccess != null)
                        Dummy = Dummy.RightSideAccess;
                }
            }
            else
                Dummy = DummyTree;
            Tree LeftDummy = new Tree(null, INT);
            Tree RightDummy = new Tree(null, INT);

            if (Dummy.GetSample() != null)
            {
                if (Sample == null)
                    if (LeftSentence == null)
                    {//tL
                        RightDummy.SampleAccess = RightSentecne;
                        Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, RightDummy);
                        //test
                        Dummy.RightSideAccess.ThreadAccess = Dummy;
                        ACT = true;
                    }

                if ((this.IsOperator(Sample)) && (this.IsNumber(RightSentecne)))
                {
                    //txj
                    RightDummy.SampleAccess = Sample;
                    LeftDummy.SampleAccess = RightSentecne;
                    RightDummy.SetLefTandRightCommonlySide(LeftDummy, null);
                    Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, RightDummy);
                    //test
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    ACT = true;
                }
                if ((this.IsFunction(Sample)) && (this.IsNumber(RightSentecne)))
                {
                    //txi
                    RightDummy.SampleAccess = Sample;
                    LeftDummy.SampleAccess = RightSentecne;
                    RightDummy.SetLefTandRightCommonlySide(LeftDummy, null);
                    Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, RightDummy);
                    //test
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    ACT = true;
                }
                //ERORRCORECTION890758746789 :The Last Sample of Parantez Closeed. refer to page 93.
                if (this.IsFunction(Sample) || this.ISindependenceVaribale(Sample) || this.IsNumber(Sample))
                    if (RightSentecne == null)
                        if (LeftSentence == null)
                        {
                            //tw
                            //ERRORCORECTION786543679086 : if let side is empty do this else do else
                            if (Dummy.LeftSideAccess == null)
                            {
                                //ERRORCORECTION760947638 : The condition added.
                                if (!this.IsFunction(Dummy.GetSample()))
                                {
                                    LeftDummy.SampleAccess = Sample;
                                    Dummy.SetLefTandRightCommonlySide(LeftDummy, null);
                                    //test
                                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                    ACT = true;
                                }
                                else
                                {

                                    RightDummy.SampleAccess = Sample;
                                    Dummy.SetLefTandRightCommonlySide(null, RightDummy);
                                    //test
                                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                                    ACT = true;
                                }
                            }
                            else
                            {

                                RightDummy.SampleAccess = Sample;
                                Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, RightDummy);
                                //test
                                Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                ACT = true;
                            }
                        }
                if ((this.IsOperator(Sample)) && (this.ISindependenceVaribale(LeftSentence)))
                {   //tziep
                    RightDummy.SampleAccess = Sample;
                    LeftDummy.SampleAccess = LeftSentence;
                    RightDummy.SetLefTandRightCommonlySide(LeftDummy, null);
                    Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, RightDummy);
                    //test
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    ACT = true;
                }
                if (this.IsParantez(Sample))
                {   //y
                    RightDummy.SampleAccess = RightSentecne;
                    Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, RightDummy);
                    //test
                    Dummy.RightSideAccess.ThreadAccess = Dummy;
                    ACT = true;
                }
                //ERRORCORECTION981274 :The Structure is corected.refer to page 108.
                if (this.IsEqualWithThreadConsiderationCommonly(Sample))
                {
                    DummyRightSide.SampleAccess = RightSentecne;
                    Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, DummyRightSide);
                    //ERRORCORECTION281319238 :refer top page 120.
                    DummyRightSide.ThreadAccess = Dummy;
                    ACT = true;
                }
            }
            else//
            {
                if ((this.ISindependenceVaribale(Sample)) && (this.IsOperator(RightSentecne)))
                {
                    //t
                    LeftDummy.SampleAccess = RightSentecne;
                    Dummy.SampleAccess = Sample;
                    Dummy.SetLefTandRightCommonlySide(LeftDummy, null);
                    //test
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    ACT = true;
                }
                //ERROR9823748 :The Structure is not valid.In x^2+x-2.refer to page 103.error occured when next condition is taken also.
                //ERRORCORECTION1897246872 :goto added.
                if (this.IsOperator(Sample))
                {
                    //t
                    Dummy.SampleAccess = Sample;
                    //RightDummy.SetSample(RightSentecne);
                    LeftDummy.SampleAccess = LeftSentence;
                    Dummy.SetLefTandRightCommonlySide(LeftDummy, null);
                    //test
                    Dummy.LeftSideAccess.ThreadAccess = Dummy;
                    ACT = true;
                    goto End;
                }
            }
            if (this.IsOperator(Sample) && ((this.ISindependenceVaribale(LeftSentence) || (this.IsNumber(LeftSentence)))))
            {
                if (Dummy.RightSideAccess == null)
                {
                    //ERROR31078472 :The condistion is not valid(below)
                    //if ((RightSentecne != null) && (LeftSentence != null) & (Sample != null))

                    {

                        if (Dummy.ThreadAccess != null)
                        {

                            //Dummy.SetSample(Sample);
                            //RightDummy.SetSample(RightSentecne);
                            //LeftDummy.SetSample(LeftSentence);
                            //Dummy.SetLefTandRightCommonlySide(LeftDummy, null);
                            //test
                            //Dummy.LeftSideAccess.SetThread(Dummy);
                            //ERRORCORECTION1872498 :The ERROR31725 (of Equation Class) Error Correction.refer to page 102.
                            //ERRORCUASE273275  :The strucure is constructed incorrectly.
                            AddToTree.Tree ChangerLocation = new AddToTree.Tree(null, false);
                            //LeftDummy.SetSample(Sample);
                            //ERRORCUASE273275  :The strucure is constructed incorrectly. ChangerLocation.SetSample(LeftSentence);                    
                            //ERRORCORECTION9807 :The set sample is done.
                            //ERRORCAUSE3172 :refer top page 117.
                            //ERRORCAUSE3178324 :refer top page 120.
                            RightDummy.SampleAccess = LeftSentence;
                            Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, RightDummy);
                            ChangerLocation.SetLefTandRightCommonlySide(Dummy, ChangerLocation.RightSideAccess);
                            ChangerLocation.SampleAccess = Sample;
                            ChangerLocation.ThreadAccess = Dummy.ThreadAccess;
                            //ERROR3070403258 :refer to page 121.
                            Dummy.ThreadAccess.SetLefTandRightCommonlySide(Dummy.ThreadAccess.LeftSideAccess, ChangerLocation);
                            //ERROR239874897 :The Structre is incoreced.
                            //ERRORCORECTION238748 :The Structure is Constructed.
                            /*while (Dummy.ThreadAccess != null)
                                Dummy = Dummy.ThreadAccess;
                            Node = Dummy;
                             */
                            ACT = true;
                        }
                        else
                        {
                            //ERRORCORECTION862134 :The condition added.refer top apge 121.and else.
                            AddToTree.Tree ChangerLocation = new AddToTree.Tree(null, false);
                            RightDummy.SampleAccess = LeftSentence;
                            Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, RightDummy);
                            RightDummy.ThreadAccess = Dummy;
                            ChangerLocation.SampleAccess = Sample;
                            ChangerLocation.SetLefTandRightCommonlySide(Dummy, ChangerLocation.RightSideAccess);
                            Dummy.ThreadAccess = ChangerLocation;
                            while (Dummy.ThreadAccess != null)
                                Dummy = Dummy.ThreadAccess;
                            this.NodeAcess = Dummy;
                            ACT = true;
                            //Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, RightDummy);
                        }
                    }
                    //ERRORCORECTION8917238973 :The condition added.refr t
                    /*ERROR31078472 :refer to page 120.
                    else
                    if((Sample!=null)&&(LeftSentence!=null)&&(RightSentecne==null))
                    {

                        AddToTree.Tree ChangerLocation = new AddToTree.Tree(null, false);
                        RightDummy.SetSample(LeftSentence);
                        ChangerLocation.SetSample(Sample);
                        Dummy.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, RightDummy);
                        RightDummy.SetLefTandRightCommonlySide(ChangerLocation, RightDummy.RightSideAccess);
                        ChangerLocation.SetThread(RightDummy);
                        RightDummy.SetThread(Dummy);
                    }          
                     */
                }
            }
            End:
            return true;
        }
        private bool IsEqualWithThreadConsiderationCommonly(String Sample)
        {
            bool Is = false;
            if (Sample == "=")
                Is = true;
            else
                Is = false;
            return Is;
        }
        public bool IsNumber(String Sample)
        {
            bool IsNumber = false;
            if (Sample != null)
            {
                if ((!this.IsFunction(Sample)) && (!this.IsOperator(Sample)) && (!this.ISindependenceVaribale(Sample)))
                    IsNumber = true;
            }
            return IsNumber;
        }
        public bool IsOperator(String Sample)
        {
            bool IsOperator = false;
            if (Sample != null)
            {
                if (Sample.ToString() == "+")
                    IsOperator = true;
                else
                    if (Sample.ToString() == "-")
                    IsOperator = true;
                else
                        if (Sample.ToString() == "*")
                    IsOperator = true;
                else
                            if (Sample.ToString() == "/")
                    IsOperator = true;
                else
                                if (Sample.ToString().ToLower() == "pow")
                    IsOperator = true;
                else
                                    if (Sample.ToString().ToLower() == "^")
                    IsOperator = true;
            }
            return IsOperator;
        }
        public bool IsParantez(String Sample)
        {
            bool IsPrantez = false;
            if (Sample != null)
                if (Sample.ToString() == "()")
                    IsPrantez = true;

            return IsPrantez;
        }
        public bool IsFunction(String Sample)
        {
            bool IsFunction = false;
            if (Sample != null)
            {
                if (Sample.ToString().ToLower() == "sin")
                    IsFunction = true;
                else
                    if (Sample.ToString().ToLower() == "cos")
                    IsFunction = true;
                else
                        if (Sample.ToString().ToLower() == "tan")
                    IsFunction = true;
                else
                            if (Sample.ToString().ToLower() == "cot")
                    IsFunction = true;
                else
                                if (Sample.ToString().ToLower() == "sec")
                    IsFunction = true;
                else
                                    if (Sample.ToString().ToLower() == "csc")
                    IsFunction = true;
                else
                                        if (Sample.ToString().ToLower() == "log")
                    IsFunction = true;
                else
                                            if (Sample.ToString().ToLower() == "ln")
                    IsFunction = true;
                if (Sample.ToString().ToLower() == "root")
                    IsFunction = true;
            }
            return IsFunction;
        }
        public bool ISindependenceVaribale(String Sample)
        {
            bool ISindePendenceVariable = false;
            if (Sample != null)
            {
                if (Sample.ToString().ToLower() == "x")
                    ISindePendenceVariable = true;
                else
                    ISindePendenceVariable = false;
            }
            return ISindePendenceVariable;
        }
        public void Optimizer(Tree L, Tree R)
        {
            if ((L == null) || (R == null))
                return;

            this.Optimizer(L.LeftSideAccess, R.LeftSideAccess);

            if (L.LeftSideAccess != null)
                if (L.LeftSideAccess.GetSample() == null)
                    L.SetLefTandRightCommonlySide(null, L.RightSideAccess);

            if (R.LeftSideAccess != null)
                if (R.LeftSideAccess.GetSample() == null)
                    R.SetLefTandRightCommonlySide(null, R.RightSideAccess);


            this.Optimizer(L.RightSideAccess, R.RightSideAccess);

            if (L.RightSideAccess != null)
                if (L.RightSideAccess.GetSample() == null)
                    L.SetLefTandRightCommonlySide(L.LeftSideAccess, null);

            if (R.RightSideAccess != null)
                if (R.RightSideAccess.GetSample() == null)
                    R.SetLefTandRightCommonlySide(R.LeftSideAccess, null);

            this.Optimizer(L.LeftSideAccess, R.RightSideAccess);

            if (L.LeftSideAccess != null)
                if (L.LeftSideAccess.GetSample() == null)
                    L.SetLefTandRightCommonlySide(null, L.RightSideAccess);

            if (R.RightSideAccess != null)
                if (R.RightSideAccess.GetSample() == null)
                    R.SetLefTandRightCommonlySide(R.LeftSideAccess, null);

            this.Optimizer(L.RightSideAccess, R.LeftSideAccess); ;

            if (L.RightSideAccess != null)
                if (L.RightSideAccess.GetSample() == null)
                    L.SetLefTandRightCommonlySide(L.LeftSideAccess, null);

            if (R.LeftSideAccess != null)
                if (R.LeftSideAccess.GetSample() == null)
                    R.SetLefTandRightCommonlySide(null, L.RightSideAccess);

            /*if (L != null)
            {
                if (L.LeftSideAccess != null)
                {
                    Optimizer(L.LeftSideAccess, R);
                    if (L.LeftSideAccess.GetSample() == null)
                        L.SetLefTandRightCommonlySide(null, L.RightSideAccess);
                }

            }
            if (R != null)
            {
                if (R.LeftSideAccess != null)
                {
                    Optimizer(L, R.LeftSideAccess);

                    if (R.LeftSideAccess.GetSample() == null)
                        R.SetLefTandRightCommonlySide(null, R.RightSideAccess);
                }

            }
            if (L != null)
            {
                if (L.RightSideAccess != null)
                {
                    Optimizer(L.RightSideAccess, R);

                    if (L.RightSideAccess.GetSample() == null)
                        L.SetLefTandRightCommonlySide(null, L.LeftSideAccess);
                }
            }
            if (R != null)
            {
                if (R.RightSideAccess != null)
                {
                    Optimizer(L, R.RightSideAccess);

                    if (R.RightSideAccess.GetSample() == null)
                        R.SetLefTandRightCommonlySide(null, R.LeftSideAccess);
                }
            }
             */
        }
        public bool IsLastRightNumberOrIndependenceVariale()
        {
            bool IsLastRightNumberOrIndependenceVarial = false;
            this.Optimizer(Node.LeftSideAccess, Node.RightSideAccess);
            Tree Dummy = new Tree(null, false);

            Dummy = /*Node;      
            if(Dummy!=null)
               while (Dummy.RightSideAccess != null)
                   Dummy = Dummy.RightSideAccess;
            */
                Dummy = this.GetRightSideOfLastStage();

            if (this.IsNumber(Dummy.GetSample()) ||
                    this.ISindependenceVaribale(Dummy.GetSample()))
                IsLastRightNumberOrIndependenceVarial = true;
            return IsLastRightNumberOrIndependenceVarial;
        }
        public Tree GetRightSideOfLastStage()
        {
            Tree Dummy = new Tree(null, false);
            Tree Holder = new Tree(null, false);
            //ERRORCUASE2381274 :The Base Node is Not Set Correctly.refer to page 139.
            Dummy = Node;
            Holder = Dummy;
            /*if(Dummy!=null)
                if(Dummy.RightSideAccess!=null)
                while (Dummy.RightSideAccess.RightSideAccess != null)
                {

                    if (this.IsFunction(Dummy.GetSample()) ||                        
                        this.IsOperator(Dummy.GetSample())
                        )
                        Holder = Dummy;
                    Dummy = Dummy.RightSideAccess;
               }
             */
            if (Dummy != null)
                while (Dummy.RightSideAccess != null)
                    Dummy = Dummy.RightSideAccess;

            return Dummy;
        }
        public Tree GetRightSideOfLastStageByParantez()
        {
            Tree Dummy = new Tree(null, false);
            Tree Holder = new Tree(null, false);
            Dummy = Node;
            Holder = Dummy;
            while (Dummy != null && (!this.IsFunction(Dummy.GetSample())))
                Dummy = Dummy.RightSideAccess;
            if (Dummy != null)
            {
                Dummy = Dummy.LeftSideAccess;
                if (Dummy != null)
                    while (Dummy.RightSideAccess != null)
                        Dummy = Dummy.RightSideAccess;
            }
            return Dummy;
        }
        public Tree NodeReturnAndAccess
        {
            get { return Node; }
            set { Node = value; }
        }
    }
}
