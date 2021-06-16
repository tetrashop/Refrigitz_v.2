//ERROR30175541  :SIMPLIFIER HAS CUASED TO SOME ERRRO.refer to page 176.
//=========================================================================
//ERROR918243 :The error at splitation.refer to page 176.
//=========================================================================
//ERROR3175 :Error in data structure .refer toi page 176.
//ERRORCAUSE0981243  ;The cause ERROR3175 of  is at here.Error on copy tree.refer to page 177.
//ERRORCORECTION0918243 :refer to ERRORCORECTION091824098 ,Located at Tree.
//=========================================================================
//ERROR30174213  :The Simplified is invalid here.refer to page 180.
//=========================================================================
//ERROR312317 & ERRROR317140 :Error in simplification.refer to page 182.
//=========================================================================
//ERROR3017181920 :refer to page 188.
//=========================================================================
//ERROR981273987 :The error at derivation.refer to page 205.
//=========================================================================
//LOCATION13174253. refer to page 208.
//=========================================================================
//ERROR3070405060 :The error is here.refer to page 220.
//=========================================================================
//ERRORCORECTION6646464654643211:The Verification Return Valid result:1394/4/9
//=========================================================================
using System;
using System.Threading;
using System.Windows.Forms;

namespace Formulas
{
    public partial class UknownIntegralSolver : Form
    {
        delegate void SetProgressValueCallback(ProgressBar dat, int state);

        public void SetProgressMaxValue(ProgressBar dat, int state)
        {
            if (state > dat.Maximum || state < dat.Minimum)
                return;

            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (dat.InvokeRequired)
            {
                SetProgressValueCallback d = new SetProgressValueCallback(SetProgressMaxValue);
                dat.BeginInvoke(new MethodInvoker(() => dat.Maximum = state));
            }
            else
            {
                dat.Maximum = state;
            }
        }
        delegate void SetLableValueCallback(Label dat, String state);

        public void SetLableValue(Label dat, String state)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (dat.InvokeRequired)
            {
                SetLableValueCallback d = new SetLableValueCallback(SetLableValue);
                dat.BeginInvoke(new MethodInvoker(() => dat.Text = state));
            }
            else
            {
                dat.Text = state;
            }
        }


        public void SetProgressValue(ProgressBar dat, int state)
        {
            if (state > dat.Maximum || state < dat.Minimum)
                return;
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (dat.InvokeRequired)
            {
                SetProgressValueCallback d = new SetProgressValueCallback(SetProgressValue);
                dat.BeginInvoke(new MethodInvoker(() => dat.Value = state));
            }
            else
            {
                dat.Maximum = state;
            }
        }


        public Equation Enterface = null;

        public UknownIntegralSolver()
        {
            InitializeComponent();
        }
        public Equation EquationAccess
        {
            get { return Enterface; }
            set { Enterface = value; }
        }
        private void UknownIntegralSolver_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enterface = null;
            Enterface = new Equation();
            Enterface.Show();
            button1.Enabled = false;

        }
        int A = 0;
        void Verifing()
        {
            while (true)
            {
                if (A == 0)
                {
                    SetLableValue(label17, "Integral Calculation Finished.Verifing");
                    A++;

                }
                if (A == 1)
                {
                    SetLableValue(label17, "Integral Calculation Finished.Verifing.");
                    A++;

                }
                if (A == 2)
                {
                    SetLableValue(label17, "Integral Calculation Finished.Verifing..");
                    A++;

                }
                if (A == 3)
                {
                    SetLableValue(label17, "Integral Calculation Finished.Verifing...");
                    A = 0;

                }
            }
        }
        private AddToTree.Tree Solver()
        {
            UknownIntegralSolver UNKNOWN = this;
            this.SetProgressValue(progressBar1, 0);

            int INCREASE = 2147483647 / 10;

            this.SetProgressValue(progressBar1, this.progressBar1.Value + INCREASE);


            //ERRORCUASE1715 :ERRROR cause of ERROR317142.the copy operation is not valid.
            //ERROR3175 :Error in data structure .
            //ERRORCAUSE0981243  ;The cause ERROR3175 of  is at here.Error on copy tree.refer to page 177.
            if (Enterface.SenderAccess.AutoSenderAccess.NodeAccess.SampleAccess == null && Enterface.SenderAccess.AutoSenderAccess != null)
                Enterface.SenderAccess.AutoSenderAccess.NodeAccess = new AddToTree.Tree(Enterface.SenderAccess.AutoSenderAccess.CurrentStirngAccess, false);
            AddToTree.Tree Copy = Enterface.SenderAccess.AutoSenderAccess.NodeAccess.CopyNewTree(Enterface.SenderAccess.AutoSenderAccess.NodeAccess);
            //Copy = TransmisionToDeleteingMinusPluse.TrasmisionToDeleteingMinusPluseFx(Copy);
            //ERROR918243 :The error at splitation.refer to page 176.
            //Copy = TransmisionToDeleteingMinusPluse.TrasmisionToDeleteingMinusPluseFx(Copy);

            AddToTree.Tree CopyNode = null;
            CopyNode = Copy.CopyNewTree(Copy);
            this.SetProgressValue(progressBar1, this.progressBar1.Value + INCREASE);

            Copy = DeleteingMinusPluseTree.DeleteingMinusPluseFx(Copy);

            this.SetProgressValue(progressBar1, this.progressBar1.Value + INCREASE);

            Copy = Spliter.SpliterFx(Copy, ref UNKNOWN);

            this.SetProgressValue(progressBar1, this.progressBar1.Value + INCREASE);

            Copy = Simplifier.ArrangmentForSpliter(Copy);
            //ERROR30175541  :SIMPLIFIER HAS CUASED TO SOME ERRRO.refer to page 176.
            //ERROR312317 & ERRROR317140 :Error in simplification.refer to page 182.

            this.SetProgressValue(progressBar1, this.progressBar1.Value + INCREASE);

            //Copy = Simplifier.SimplifierFx(Copy,ref UNKNOWN);
            //ERROR30174213  :The Simplified is invalid here.refer to page 180.            
            //Copy = Derivasion.DerivasionOfFX(Copy);

            this.SetProgressValue(progressBar1, this.progressBar1.Value + INCREASE);

            Copy = Integral.IntegralOfFX(Copy, ref UNKNOWN);
            /*int i = 0;
            while (true)new AddToTree.Tree(null, false);
            {
                //Copy = Integral.DervisionI(i, Copy);
                //ERROR981273987 :The error at derivation.refer to page 205.
                 Copy = Derivasion.DerivasionOfFX(Copy);
                //ERROR3017181920 :refer to page 188.
                
                Copy=Simplifier.SimplifierFx(Copy);
                i++;
            }
             */

            //LOCATION13174253. refer to page 208.
            //ERROR3070405060 :The error is here.refer to page 220.
            //int NUM1 = Integral.NumberOfElements(Copy);
            this.SetProgressValue(progressBar1, this.progressBar1.Value + INCREASE);

            int NUM1 = Integral.NumberOfElements(Copy);

            this.SetProgressValue(progressBar1, this.progressBar1.Value + INCREASE);

            Copy = Simplifier.SimplifierFx(Copy, ref UNKNOWN);

            this.SetProgressValue(progressBar1, this.progressBar1.Value + INCREASE);

            int NUM2 = Integral.NumberOfElements(Copy);

            this.SetProgressValue(progressBar1, this.progressBar1.Value + INCREASE);

            //Copy = RoundTree.RoundTreeMethod(Copy,0);

            Copy.ThreadAccess = null;
            Thread t = new Thread(new ThreadStart(Verifing));
            t.Start();
            //ERRORCORECTION6646464654643211:The Verification Return Valid result:1394/4/9
            if (EqualToObject.IsEqualWithOutThreadConsiderationCommonly(Simplifier.SimplifierFx(RoundTree.RoundTreeMethod(ChangeFunction.ChangeFunctionFx(Derivasion.DerivasionOfFX(Copy.CopyNewTree(Copy), ref UNKNOWN), ref UNKNOWN), RoundTree.MaxFractionalDesimal(CopyNode)), ref UNKNOWN), CopyNode))
            {
                t.Abort();
                SetLableValue(label17, "Verifing finished.Integral Answer Calculated is :");
                MessageBox.Show("Verify OK");
            }
            else
            {
                t.Abort();
                SetLableValue(label17, "Verifing finished.Integral Answer Calculated is :");
                MessageBox.Show("Verify Failed.");
            }

            return Copy;

            //this.SetProgressValue(progressBar1, this.progressBar1.Value + INCREASE);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Enterface.Hide();
            //Thread SolverThread = new Thread(new ThreadStart(Solver));
            //SolverThread.Start();            
            Thread Tr = new Thread(new ThreadStart(SolverThread));
            Tr.Start();

        }
        void SolverThread()
        {
            this.DrawIntegralAnswer(this.Solver());

        }
        private void DrawIntegralAnswer(AddToTree.Tree DummyAnswer)
        {
            //   System.Windows.Forms.MessageBox.Show("1-The answer is ready");              
            IntegralAnswerGraphicallyWitten.IntegralAnswerGraphicallyWittenFx(DummyAnswer, this);

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void UknownIntegralSolver_Load_1(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            (new AboutBox1()).Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }

}