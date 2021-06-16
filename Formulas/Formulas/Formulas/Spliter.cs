//ERROR1092874 :The Error is located here .the inproper division detected.refer to page 174.
//=============================================================================================
//ERROR091409214 :The some needed spliation dose not acts.
//ERRORCORECTION98242184 :Corrected as indicated.
//=============================================================================================
//ERRORCORECTION981278 :Correction of ERRORCAUSE713040 .refer to page 182.
//=============================================================================================
//ERROR30405031v :Refer to page 207.
//=============================================================================================
//ERROR37492387 :Refe to page 261.
//=============================================================================================
//ERROR234721646 :The error is at here.refre to page 287.
//=============================================================================================
//ADDDED73562150 :The added is here :Refer to page 331.
//=============================================================================================
//ERRORCORECTION198234871648 :The condition of splitation added.refer to page 339.
//=============================================================================================

using System;

namespace Formulas
{
    static class Spliter
    {
        //static SenderSample Sender = new SenderSample(new Equation());
        static AddToTreeTreeLinkList SPLITED = new AddToTreeTreeLinkList();
        static public AddToTree.Tree SpliterFx(AddToTree.Tree Dummy, ref UknownIntegralSolver UIS)
        {
            try
            {
                Dummy.ThreadAccess = null;
                Dummy = Simplifier.ArrangmentForSpliter(Dummy);

                Dummy = Simplifier.SimplifierFxSimpler(Dummy, ref UIS);

                //ERRORCORECTION198234871648 :The condition of splitation added.refer to page 339.
                Dummy = SplitationAllowed.SplitationAllowedFx(Dummy, ref UIS);

                bool CONTINUSE = false;
                do
                {
                    CONTINUSE = false;
                    if (Spliter.ISAtLeastOneDivisionAtNode(Dummy))
                        Dummy = Spliter.SpliterCalculator(Dummy, ref CONTINUSE, ref UIS);
                }
                while (CONTINUSE);
            }
            catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); }
            return Dummy;
        }
        static AddToTree.Tree TheRightSideOperandOfDivision(AddToTree.Tree Current)
        {
            if (Current == null)
                return Current;
            while (Current.SampleAccess != "/")
                Current = Current.ThreadAccess;
            return Current.RightSideAccess;
        }
        static bool ISAtLeastOneDivisionAtNode(AddToTree.Tree Node)
        {
            bool Is = false;
            if (Node == null)
                return Is;
            if (Node.SampleAccess == "/")
                Is = true;
            Is = Is || ISAtLeastOneDivisionAtNode(Node.LeftSideAccess);
            Is = Is || ISAtLeastOneDivisionAtNode(Node.RightSideAccess);
            return Is;
        }
        static AddToTree.Tree SpliterCalculator(AddToTree.Tree Dummy, ref bool Again, ref UknownIntegralSolver UIS)
        {
            if (Dummy == null)
                return Dummy;
            Dummy.LeftSideAccess = Spliter.SpliterCalculator(Dummy.LeftSideAccess, ref Again, ref UIS);
            try
            {
                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess.ThreadAccess, Dummy.ThreadAccess))
                    Dummy = Dummy.LeftSideAccess;
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            Dummy.RightSideAccess = Spliter.SpliterCalculator(Dummy.RightSideAccess, ref Again, ref UIS);
            try
            {
                if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy.LeftSideAccess.ThreadAccess, Dummy.ThreadAccess))
                    Dummy = Dummy.LeftSideAccess;
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }

            //ERROR091409214 :The some needed spliation dose not acts.
            //if (Dummy.SampleAccess == "/")
            //ERRORCORECTION98242184 :Corrected as below.
            int INCREASE = 2147483647 / 4;
            UIS.SetProgressValue(UIS.progressBar11, 0);
            try
            {
                if (Dummy.SampleAccess == "/")
                {
                    if (((Dummy.LeftSideAccess.SampleAccess == "+") || (Dummy.LeftSideAccess.SampleAccess == "-")) && (AllowToMulMinusePluse.AllowToMulMinusePluseFx(Dummy, ref UIS)) && (Dummy.SplitableAccess))
                    {
                        UIS.SetProgressValue(UIS.progressBar11, INCREASE + UIS.progressBar11.Value);
                        Again = true;
                        AddToTree.Tree Div1 = Dummy.CopyNewTree(Dummy.RightSideAccess);
                        AddToTree.Tree Div2 = Dummy.CopyNewTree(Dummy.RightSideAccess);

                        UIS.SetProgressValue(UIS.progressBar11, INCREASE + UIS.progressBar11.Value);

                        //Dummy = Dummy.LeftSideAccess;

                        AddToTree.Tree DummyLeft = new AddToTree.Tree("/", false);

                        DummyLeft.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess.LeftSideAccess), Div1);
                        DummyLeft.LeftSideAccess.ThreadAccess = DummyLeft;
                        DummyLeft.RightSideAccess.ThreadAccess = DummyLeft;

                        UIS.SetProgressValue(UIS.progressBar11, INCREASE + UIS.progressBar11.Value);

                        Dummy.LeftSideAccess.LeftSideAccess = DummyLeft;
                        Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;

                        AddToTree.Tree DummyRight = new AddToTree.Tree("/", false);
                        //ERROR37492387 :Refe to page 261.
                        DummyRight.SetLefTandRightCommonlySide(Dummy.CopyNewTree(Dummy.LeftSideAccess.RightSideAccess), Div2);
                        DummyRight.LeftSideAccess.ThreadAccess = DummyRight;
                        DummyRight.RightSideAccess.ThreadAccess = DummyRight;

                        UIS.SetProgressValue(UIS.progressBar11, INCREASE + UIS.progressBar11.Value);

                        Dummy.LeftSideAccess.RightSideAccess = DummyRight;
                        Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;


                        Dummy.LeftSideAccess.ThreadAccess = Dummy.ThreadAccess;
                        Dummy = Dummy.LeftSideAccess;
                        UIS.SetProgressValue(UIS.progressBar11, 2147483647);
                    }
                    //  :The error is at here.refre to page 287.
                    //ADDDED73562150 :The added is here :Refer to page 331.
                    /*if ((Dummy.RightSideAccess.SampleAccess == "+") || (Dummy.RightSideAccess.SampleAccess == "-"))
                    {
                        Again = true;
                        AddToTree.Tree Div1 = Dummy.CopyNewTree(Dummy.LeftSideAccess);
                        AddToTree.Tree Div2 = Dummy.CopyNewTree(Dummy.LeftSideAccess);

                        Dummy = Dummy.RightSideAccess;

                        AddToTree.Tree DummyRight=new AddToTree.Tree("/",false);

                        DummyRight.SetLefTandRightCommonlySide(Div1,Dummy.CopyNewTree(Dummy.RightSideAccess));
                        DummyRight.LeftSideAccess.ThreadAccess = DummyRight;
                        DummyRight.RightSideAccess.ThreadAccess = DummyRight;

                        DummyRight.RightSideAccess=DummyRight;
                        Dummy.RightSideAccess.ThreadAccess=Dummy;

                        AddToTree.Tree DummyLeft=new AddToTree.Tree("/",false);

                        DummyLeft.SetLefTandRightCommonlySide(Div2, Dummy.CopyNewTree(Dummy.RightSideAccess));
                        DummyLeft.LeftSideAccess.ThreadAccess = DummyLeft;
                        DummyLeft.RightSideAccess.ThreadAccess = DummyLeft;

                        DummyLeft.RightSideAccess=DummyLeft;
                        Dummy.LeftSideAccess.ThreadAccess=Dummy;

                        Dummy=Dummy.ThreadAccess;

                        Dummy.RightSideAccess.ThreadAccess=Dummy.ThreadAccess;
                        Dummy=Dummy.RightSideAccess;                           

                    }
                    */
                    /*if (IS.IsOperator(Dummy.SampleAccess))
                        if (!IS.IsPower(Dummy.SampleAccess))
                            if (!IS.IsFunction(Dummy.SampleAccess))
                            {
                                AddToTree.Tree Div= Spliter.TheRightSideOperandOfDivision(Dummy)
                                if (!SPLITED.FINDTreeWithThreadConsideration(Dummy.LeftSideAccess))
                                {
                                    Dummy.LeftSideAccess = Spliter.DivisionSpliter(Dummy.LeftSideAccess,Div, 0);
                                    Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                    Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
                                }
                                if (!SPLITED.FINDTreeWithThreadConsideration(Dummy.RightSideAccess))
                                {
                                    Dummy.RightSideAccess = Spliter.DivisionSpliter(Dummy.RightSideAccess,Div, 0);
                                    Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
                                    Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;                                   
                                }

                                SPLITED.ADDToTree(Dummy);
                                //Dummy.LeftSideAccess.ThreadAccess = Dummy;
                                //if (Dummy.ThreadAccess == null)
                                //  Dummy.LeftSideAccess.ThreadAccess = null;
                                //Dummy = Dummy.LeftSideAccess;


                            }
                    */
                }
                else
                {   //ERRORCORECTION981278 :Correction of ERRORCAUSE713040 .refer to page 182.
                    //ERROR30405031v :Refer to page 207.
                    /*if (!SPLITED.ISEmpty())
                    {
                        if (Dummy.ThreadAccess == null)
                            Dummy.LeftSideAccess.ThreadAccess = null;
                        Dummy = Dummy.LeftSideAccess;
                    }
                     */
                }
            }
            catch (NullReferenceException t)
            { ExceptionClass.ExceptionClassMethod(t); }
            /*
                if (Again)
                {
                    Again = false;
                    Spliter.SpliterCalculator(Dummy);                 

                }*/
            return Dummy;
        }
        static AddToTree.Tree DivisionSpliter(AddToTree.Tree Dummy, AddToTree.Tree DummyDown, int level)
        {

            if (Dummy == null)
                return Dummy;
            AddToTree.Tree Holder = new AddToTree.Tree("/", false);
            Holder.SetLefTandRightCommonlySide(Dummy, DummyDown);
            Holder.LeftSideAccess.ThreadAccess = Holder;
            Holder.RightSideAccess.ThreadAccess = Holder;
            //Holder.ThreadAccess = Dummy.ThreadAccess;
            Dummy = Holder;
            Dummy.LeftSideAccess.ThreadAccess = Dummy;
            Dummy.RightSideAccess.ThreadAccess = Dummy;
            //Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
            //Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;

            /*if(Dummy!=null)
      if (IS.IsOperator(Dummy.SampleAccess)
          || IS.IsFunction(Dummy.SampleAccess)
              || IS.ISindependenceVaribaleOrNumber(Dummy.SampleAccess))
          if (Dummy.LeftSideAccess != null)
          {
              AddToTree.Tree Holder = new AddToTree.Tree("/", false);
              Holder.SetLefTandRightCommonlySide(Dummy.LeftSideAccess, DummyDown);
              Holder.LeftSideAccess.ThreadAccess = Holder;
              Holder.RightSideAccess.ThreadAccess = Holder;
              Dummy.LeftSideAccess = Holder;
              Dummy.LeftSideAccess.ThreadAccess = Dummy;
              Dummy.RightSideAccess.ThreadAccess = Dummy;
              Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
              Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
              //Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
              //Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;
              SPLITED.ADDToTree(Holder);
          }
          else
          {
              AddToTree.Tree Holder = new AddToTree.Tree("/", false);
              Holder.SetLefTandRightCommonlySide(Dummy, DummyDown);
              Holder.LeftSideAccess.ThreadAccess = Holder;
              Holder.RightSideAccess.ThreadAccess = Holder;
              Dummy = Holder;
              SPLITED.ADDToTree(Holder);
          }
while((Dummy.SampleAccess != "/")&(Dummy!=null))
{
  if (!(IS.IsOperator(Dummy.SampleAccess)
      || IS.IsFunction(Dummy.SampleAccess)
          || IS.ISindependenceVaribaleOrNumber(Dummy.SampleAccess)))
  {
      if (Dummy.LeftSideAccess != null)
          if (IS.IsOperator(Dummy.LeftSideAccess.SampleAccess)
              || IS.IsFunction(Dummy.LeftSideAccess.SampleAccess)
                  || IS.ISindependenceVaribaleOrNumber(Dummy.LeftSideAccess.SampleAccess))
          {
              Dummy.LeftSideAccess = Spliter.DivisionSpliter(Dummy.LeftSideAccess, DummyDown,level++);
              Dummy.LeftSideAccess.LeftSideAccess.ThreadAccess = Dummy.LeftSideAccess;
              Dummy.LeftSideAccess.RightSideAccess.ThreadAccess = Dummy.LeftSideAccess;
              SPLITED.ADDToTree(Dummy.LeftSideAccess);
          }
  }
  else
  {
      Dummy.RightSideAccess = Spliter.DivisionSpliter(Dummy.RightSideAccess, DummyDown,level++);
      Dummy.RightSideAccess.ThreadAccess = Dummy;
      Dummy.RightSideAccess.LeftSideAccess.ThreadAccess = Dummy.RightSideAccess;
      Dummy.RightSideAccess.RightSideAccess.ThreadAccess = Dummy.RightSideAccess;
      SPLITED.ADDToTree(Dummy.RightSideAccess);
  }
  //ERROR1092874 :The Error is located here .the inproper division detected.refer to page 174.
  if (!SPLITED.FINDTreeWithThreadConsideration(Dummy.LeftSideAccess))
      Dummy = Dummy.LeftSideAccess;
  else
      break;
}
//Spliter.DivisionSpliter(Dummy.LeftSideAccess, DummyDown);
//Spliter.DivisionSpliter(Dummy.RightSideAccess, DummyDown);                                        
  //if(level==0)
//while (Dummy.ThreadAccess != null)
//{
//  Dummy = Dummy.ThreadAccess;
  //if (EqualToObject.IsEqualWithThreadConsiderationCommonly(Dummy, Dummy.ThreadAccess))
  //  Dummy.ThreadAccess = null;
//}                
      */
            return Dummy;
        }
    }
}
