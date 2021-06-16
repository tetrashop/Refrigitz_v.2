using System;

namespace Formulas
{
    static class RecursionAndOptimizingLinkList
    {
        static public AddToTreeTreeLinkList RecursionAndOptimizingLinkListFx(AddToTreeTreeLinkList Dummy)
        {
            if (Dummy.CurrentSizeAccess > -1)
            {
                Formulas.StackTree Stack = new StackTree((Dummy.CurrentSizeAccess) + 1);

                // System.Windows.Forms.MessageBox.Show("2.4.1-The Stsck newed.");

                AddToTree.Tree DummyTree = null;

                while (!(Dummy.ISEmpty()))
                {
                    DummyTree = new AddToTree.Tree(null, false);
                    DummyTree = Dummy.DELETEFromTreeFirstNode();
                    try
                    {
                        if (DummyTree.SampleAccess == null)
                            continue;
                        else
                            Stack.Push(DummyTree);
                    }
                    catch (NullReferenceException t) { ExceptionClass.ExceptionClassMethod(t); continue; }
                }

                // System.Windows.Forms.MessageBox.Show("2.4.2.Stack pushed.");

                while (!(Stack.IsEmpty()))
                    Dummy.ADDToTree(Stack.Pop());

                // System.Windows.Forms.MessageBox.Show("2.4.3.End Of Recursion.");
            }
            return Dummy;
        }
    }
}
