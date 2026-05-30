//ERRORCORECTION1245678:The Font Scale became smaller:1394/3/28

namespace Formulas
{
    static class IntegralAnswerGraphicallyWitten
    {
        static Editors.Editor Written = new Editors.Editor();
        static public void IntegralAnswerGraphicallyWittenFx(AddToTree.Tree Dummy, UknownIntegralSolver UIS)
        {

            IntegralAnswerAdding.IntegralAnswerAddingFx(Dummy);
            //System.Windows.Forms.MessageBox.Show("2-The answer Added");
            IntegralAnswerGraphicallyWitten.IntegralAnswerGraphicallyWittenActionFx(UIS);
            Written.ShowDialog();

        }
        static void IntegralAnswerGraphicallyWittenActionFx(UknownIntegralSolver UIS)
        {
            AddToTreeTreeLinkList DummyLinkList = IntegralAnswerAdding.AnswerAccess.CopyLinkList();

            //  System.Windows.Forms.MessageBox.Show("2.1-The answer Copied.");

            AddToTree.Tree Dummy = new AddToTree.Tree(null, false);

            // System.Windows.Forms.MessageBox.Show("2.2-The Dummy tree newed.");

            ArrtificialItelligenceForGraphicallyDrawing ArrtificialItelligenceForGraphicallyDrawingFx = UIS.EquationAccess.SenderSampleAccess.AutoSenderAccess.DrawingAccess.ArrtificialItelligenceForGraphicallyDrawingAccess;

            //   System.Windows.Forms.MessageBox.Show("2.3-The Artificial class loaded.");

            Set DummySet = new Set();
            int BigestX = 0, SmallestX = 1000000;

            //   System.Windows.Forms.MessageBox.Show("2.4-The Varibles newed and assigened.");

            //DummyLinkList = RecursionAndOptimizingLinkList.RecursionAndOptimizingLinkListFx(DummyLinkList);


            //   System.Windows.Forms.MessageBox.Show("3-The answer is recurved.");

            while (!(DummyLinkList.ISEmpty()))
            {
                Dummy = DummyLinkList.DELETEFromTreeFirstNode();

                // System.Windows.Forms.MessageBox.Show("4-The answer is Loaded from link list.");

                if (Dummy != null)
                {
                    //  System.Windows.Forms.MessageBox.Show("5-The answer of link list is not null.");
                    //DummySet = ArrtificialItelligenceForGraphicallyDrawingFx.CreateGraphicallyNodes(Dummy);

                    ArrtificialItelligenceForGraphicallyDrawingFx.InizializingWhenNeedeForAnswerDrawn(Dummy, 40 + BigestX, 40);

                    //  System.Windows.Forms.MessageBox.Show("6-The answer is Converted to set and inzizialized.");

                    //ArrtificialItelligenceForGraphicallyDrawingFx.CalculatingXAndYAndWhithAndHeight(DummySet, 40 + BigestX, 40, 15, 15,true);


                    //System.Windows.Forms.MessageBox.Show("5-The answer is calculated.");              

                    UIS.EquationAccess.SenderAccess.AutoSenderAccess.DrawingAccess.DrawEachNodeOfArrtificialItelligenceForGraphicallyDrawing(ArrtificialItelligenceForGraphicallyDrawingFx, UIS.EquationAccess, UIS.EquationAccess.SenderAccess.AutoSenderAccess);

                    //System.Windows.Forms.MessageBox.Show("7-The answer is drawned.");

                    ArrtificialItelligenceForGraphicallyDrawingFx.TheBigestValueNodeXForcalculationMethode(DummySet, ref BigestX);
                    ArrtificialItelligenceForGraphicallyDrawingFx.TheSmallestValue(DummySet, ref SmallestX);
                    if (Dummy.Equals("+"))//ERRORCORECTION1245678:The Font Scale became smaller:1394/3/28
                        Written.FiveBasicOprators(0);
                    else if (Dummy.Equals("-"))
                        Written.FiveBasicOprators(1);
                    else if (Dummy.Equals("*"))
                        Written.FiveBasicOprators(2);
                    else if (Dummy.Equals("/"))
                        Written.FiveBasicOprators(3);
                    else if (Dummy.Equals("^"))
                        Written.FiveBasicOprators(4);
                    else
                        Written.DrawNumberAndVaribale(Dummy.SampleAccess);

                }


            }

        }
    }
}
