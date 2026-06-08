/*********************************************************************************************
 * Ramin Edjlal 1398/06/11********************************************************************
 * CopyRighted 2019 Terashop.ir***************************************************************
 * Removing try catch exeption hole contained when need.**************************************
 * *******************************************************************************************/
using System;
using System.IO;
using System.Windows.Forms;

namespace TryCatchDisable
{
    public partial class FormTryCatchDisable : Form
    {
        static void Log(Exception ex)
        {
            try
            {
                Object a = new Object();
                lock (a)
                {
                    string stackTrace = ex.ToString();
                    File.AppendAllText("\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString()); // path of file where stack trace will be stored.
                }
            }
            catch (Exception t)
            {
                Log(t);
            }
        }
        //Constructor
        public FormTryCatchDisable()
        {
            InitializeComponent();
        }

        private void ButtonTryCatchDisable_Click(object sender, EventArgs e)
        {
            try
            {
                //Open file c#,c++,...
                OpenFileDialogTryCatchDisable.ShowDialog();
                //Strore file name.
                String A = OpenFileDialogTryCatchDisable.FileName;
                //Read text  computer languages.
                String Contain = System.IO.File.ReadAllText(A);
                //Found of first try
                int A1 = Contain.IndexOf("try");
                //store
                int A2 = A1;
                try
                {
                    //When end of file
                    while (A1 < Contain.Length && A1 > 0)
                    {
                        //Store current index
                        int P = A1;
                        //store  try from remain substring 
                        P = Contain.Substring(A1, Contain.Length - A1).IndexOf("try");
                        //add to current index
                        A1 = A1 + P;
                        //store 
                        A2 = A1;
                        //when is negative break
                        if (A1 < 0)
                            break;
                        //increase when end of try
                        while ((!(Contain[A2].Equals('{'))) && (A2 < Contain.Length))
                            A2++;
                        //repace try section and free code
                        Contain = Contain.Replace(Contain.Substring(A1, A2 - A1 + 1), "/*" + Contain.Substring(A1, A2 - A1 + 1) + "*/");
                        A1 = A2 + 5;
                    }
                }
                catch (Exception t) { Log(t); }
                //catch section
                try
                {
                    //index of frist catch
                    A2 = Contain.IndexOf("catch");
                    //call recursive for remaining
                    CatchReplace(ref Contain, A2, A2);
                }
                catch (Exception t) { Log(t); }
                saveDialogFileTryCatchDisable.ShowDialog();
                System.IO.File.WriteAllText(saveDialogFileTryCatchDisable.FileName, Contain);
                MessageBox.Show("Done!");

            }
            catch (Exception t)
            {
                Log(t);
            }
        }
        //Ignore of Comments Double Slash
        bool IgnoreofCommentsDoubleSlash(String Contain, int Main)
        {
            //Initiate
            int A = 0;
            int Begin = 0, End = 0;
            //do
            do
            {
                //Substring of index found
                String S = Contain.Substring(A, Contain.Length - A);
                //Index of begin comments
                Begin = S.IndexOf("//");
                //index of all
                End = S.IndexOf('\0');
                //when is condition is true
                if (Begin < Main && End > Main)
                {
                    //retun successfull
                    return true;

                }
                else
                {
                    //Index of logn comment begin
                    Begin = S.IndexOf("/*");
                    //end of comment index
                    End = S.IndexOf("*/");
                    //when is condition true
                    if (Begin < Main && End > Main)
                    {
                        //remove comment
                        Contain = Contain.Remove(Begin, End - Begin + 2);
                        //return successfull
                        return true;
                    }
                    //else
                    //return false;
                }
                //Incese
                A++;
            } while (A < Contain.Length);//while end of file
            return false;
        }
        //Found Of Proper Closed Bracetin catch
        int FoundOfProperClosedBracetincatch(String Contain, int MainOpenBracketIndex)
        {
            try
            {
                //inititate
                int IsMainClosedBraket = 0;
                do
                {
                    //store Ignore of Comments Double Slash
                    bool Ign = IgnoreofCommentsDoubleSlash(Contain, MainOpenBracketIndex);
                    //when substring contains new braket begine and Ignore of Comments Double Slash is faild 
                    if (Contain[MainOpenBracketIndex].Equals('{') && (!Ign))
                        IsMainClosedBraket++;
                    //when braket closed return gioven index
                    if (Contain[MainOpenBracketIndex].Equals('}') && IsMainClosedBraket == 1 && (!Ign))
                    {
                        return MainOpenBracketIndex;
                    }
                    else
                    //else untile contains new braket end decreamet
                    if (Contain[MainOpenBracketIndex].Equals('}') && IsMainClosedBraket >= 1 && (!Ign))
                        IsMainClosedBraket--;
                    //increase
                    MainOpenBracketIndex++;
                    //untile end of file
                } while (MainOpenBracketIndex < Contain.Length);
            }
            catch (Exception t)
            {
                Log(t);
            }
            return MainOpenBracketIndex;
        }
        //catch consideration method
        void CatchReplace(ref String Contain, int S, int A2)
        {
            try
            {


                //while end of file 
                while (A2 < Contain.Length && A2 > 0)
                {
                    //store
                    int C = A2;
                    //index of first catch in substring
                    C = Contain.Substring(A2, Contain.Length - A2).IndexOf("catch");
                    //add and store
                    A2 = A2 + C;

                    //A2 = Contain.IndexOf("catch");
                    //store
                    int P = A2;
                    try
                    {
                        //while begine of catch before decrease
                        while (!(Contain[A2].Equals('}')))
                            A2--;
                        //decrease
                        A2--;
                        //Found Of Proper Closed Bracetin catch index
                        int A1 = FoundOfProperClosedBracetincatch(Contain, P);
                        //comment founded
                        Contain = Contain.Replace(Contain.Substring(A2, A1 - A2 + 1), "/*" + Contain.Substring(A2, A1 - A2 + 1) + "*/");
                        //Add with constant 5 and store
                        A2 = A1 + 5;

                    }
                    catch (Exception t) { Log(t); }
                }
            }
            catch (Exception t) { Log(t); }
        }

        private void FormTryCatchDisable_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutBoxTryCatchDisable()).ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Open file c#,c++,...
                OpenFileDialogTryCatchDisable.ShowDialog();
                //Strore file name.
                String A = OpenFileDialogTryCatchDisable.FileName;
                //Read text  computer languages.
                String Contain = System.IO.File.ReadAllText(A);
                //Found of first try
                int A1 = Contain.IndexOf("try");
                //store
                int A2 = A1;
                try
                {
                    //When end of file
                    while (A1 < Contain.Length && A1 > 0)
                    {
                        //Store current index
                        int P = A1;
                        //store  try from remain substring 
                        P = Contain.Substring(A1, Contain.Length - A1).IndexOf("try");
                        //add to current index
                        A1 = A1 + P;
                        //store 
                        A2 = A1;
                        //when is negative break
                        if (A1 < 0)
                            break;
                        //increase when end of try
                        while ((!(Contain[A2].Equals('{'))) && (A2 < Contain.Length))
                            A2++;
                        //repace try section and free code
                        Contain = Contain.Replace(Contain.Substring(A1, A2 - A1 + 1), "/*" + Contain.Substring(A1, A2 - A1 + 1) + "*/");
                        A1 = A2 + 5;
                    }
                }
                catch (Exception t) { Log(t); }
                //catch section
                try
                {
                    //index of frist catch
                    A2 = Contain.IndexOf("catch");
                    //call recursive for remaining
                    CatchReplace(ref Contain, A2, A2);
                }
                catch (Exception t) { Log(t); }
                saveDialogFileTryCatchDisable.ShowDialog();
                System.IO.File.WriteAllText(saveDialogFileTryCatchDisable.FileName, Contain);
                MessageBox.Show("Done!");

            }
            catch (Exception t)
            {
                Log(t);
            }
        }
    }
}
