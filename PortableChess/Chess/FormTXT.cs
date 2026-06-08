using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace Refrigtz
{
    [Serializable]
    public partial class FormTXT : Form
    {
        //#pragma warning disable CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        RefrigtzChessPortable.AllDraw D = null;
        //#pragma warning restore CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        Thread t = null;
        //#pragma warning disable CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        public FormTXT(RefrigtzChessPortable.AllDraw TG)
        //#pragma warning restore CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        {
            InitializeComponent();
            Object O = new Object();
            lock (O)
            {
                D = TG;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormTXT_Load(object sender, EventArgs e)
        {
            /*TextBoxTXT.Text = "";
            if (FormRefrigtz.ErrorTrueMonitorFalse)
            {
                // TextBoxTXT.Text = File.ReadAllText(FormRefrigtz.Root + "\\ErrorProgramRun.txt");
            }
            else
            {
                TextBoxTXT.Text = File.ReadAllText(FormRefrigtz.Root + "\\Database\\Monitor.html");
            }*/
            //backgroundWorkertreeView.RunWorkerAsync();
            Object O = new Object();
            lock (O)
            {
                CreateTree(D);
                treeViewRefregitzDraw.Update();
            }
        }

        private void treeViewRefregitzDraw_BindingContextChanged(object sender, EventArgs e)
        {
            //CreateTree(D);
            //treeViewRefregitzDraw.Update();

        }

        private void treeViewRefregitzDraw_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeViewRefregitzDraw_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }
        //#pragma warning disable CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        public void CreateTree(RefrigtzChessPortable.AllDraw Draw)
        //#pragma warning restore CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        {
            Object O = new Object();
            lock (O)
            {
                while (Draw.AStarGreedyString != null)
                    Draw = Draw.AStarGreedyString;
                Invoke((MethodInvoker)delegate ()
                {
                    treeViewRefregitzDraw.BeginUpdate();
                });
                PopulateTreeViewS(0, null, Draw);
                PopulateTreeViewE(0, null, Draw);
                PopulateTreeViewH(0, null, Draw);
                PopulateTreeViewC(0, null, Draw);
                PopulateTreeViewM(0, null, Draw);
                PopulateTreeViewK(0, null, Draw);
                PopulateTreeViewA(0, null, Draw);
                Invoke((MethodInvoker)delegate ()
                {
                    treeViewRefregitzDraw.EndUpdate();
                    treeViewRefregitzDraw.ExpandAll();
                });
            }

        }
        String Alphabet(int RowRealesed)
        {
            //long Time = TimeElapced.TimeNow();Spaces++;
            Object O = new Object();
            lock (O)
            {
                String A = "";
                if (RowRealesed == 0)
                    A = "a";
                else
                    if (RowRealesed == 1)
                    A = "b";
                else
                        if (RowRealesed == 2)
                    A = "c";
                else
                            if (RowRealesed == 3)
                    A = "d";
                else
                                if (RowRealesed == 4)
                    A = "e";
                else
                                    if (RowRealesed == 5)
                    A = "f";
                else
                                        if (RowRealesed == 6)
                    A = "g";
                else
                                            if (RowRealesed == 7)
                    A = "h";
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Alphabet:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;

                return A;
            }
        }
        String Number(int ColumnRealeased)
        {
            //long Time = TimeElapced.TimeNow();Spaces++;
            Object O = new Object();
            lock (O)
            {

                String A = "";
                if (ColumnRealeased == 7)
                    A = "0";
                else
                    if (ColumnRealeased == 6)
                    A = "1";
                else
                        if (ColumnRealeased == 5)
                    A = "2";
                else
                            if (ColumnRealeased == 4)
                    A = "3";
                else
                                if (ColumnRealeased == 3)
                    A = "4";
                else
                                    if (ColumnRealeased == 2)
                    A = "5";
                else
                                        if (ColumnRealeased == 1)
                    A = "6";
                else
                                            if (ColumnRealeased == 0)
                    A = "7";
                ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("Number:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
                return A;
            }
        }
        String CheM(int A)
        {
            //long Time = TimeElapced.TimeNow();Spaces++;
            String AA = "";
            if (A <= -1 && A < 0)
                AA = "+SelfChecked ";

            if (A >= 1 && A > 0)
                AA = "+EnemeyChecked ";

            if (A <= -2 && A < 0)
                AA = "++SelfMate ";

            if (A >= 2 && A > 0)
                AA = "++EnemeyMate ";

            if (A <= -3 && A < 0)
                AA = "++SelfFinished ";

            if (A >= 3 && A > 0)
                AA = "++EnemeyFinsished ";
            ////{ //AllDraw.OutPut.Append("\r\n");for (int l = 0; l < Spaces; l++) //AllDraw.OutPut.Append(Space);  //AllDraw.OutPut.Append("CheM:" + (TimeElapced.TimeNow() - Time).ToString());}Spaces--;
            return AA;
        }
        //#pragma warning disable CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        string MoveS(RefrigtzChessPortable.ThinkingRefrigtzChessPortable t, int kind, int j)
        //#pragma warning restore CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        {
            Object O = new Object();
            lock (O)
            {
                int RowDestination = -1, ColumnDestination = -1;
                if (kind == 1)
                {
                    RowDestination = t.RowColumnSoldier[j][0];
                    ColumnDestination = t.RowColumnSoldier[j][1];
                }
                else if (kind == 2)
                {
                    RowDestination = t.RowColumnElefant[j][0];
                    ColumnDestination = t.RowColumnElefant[j][1];
                }
                else
          if (kind == 3)
                {
                    RowDestination = t.RowColumnHourse[j][0];
                    ColumnDestination = t.RowColumnHourse[j][1];
                }
                else
          if (kind == 4)
                {
                    RowDestination = t.RowColumnCastle[j][0];
                    ColumnDestination = t.RowColumnCastle[j][1];
                }
                else
          if (kind == 5)
                {
                    RowDestination = t.RowColumnMinister[j][0];
                    ColumnDestination = t.RowColumnMinister[j][1];
                }
                else
          if (kind == 6)
                {
                    RowDestination = t.RowColumnKing[j][0];
                    ColumnDestination = t.RowColumnKing[j][1];
                }
                else
          if (kind == 7 || kind == -7)
                {
                    RowDestination = t.RowColumnCastling[j][0];
                    ColumnDestination = t.RowColumnCastling[j][1];
                }
                string move = Alphabet(t.Row) + Number(t.Column) + Alphabet(RowDestination) + Number(ColumnDestination);
                if (t.IsThereMateOfSelf[j] || t.IsThereMateOfEnemy[j])
                    move += "++";
                else
                if (t.KishSelf[j] || t.KishEnemy[j])
                    move += "+";

                return move;
            }
        }
        //#pragma warning disable CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        private void PopulateTreeViewS(int parentId, TreeNode parentNode, RefrigtzChessPortable.AllDraw Draw)
        //#pragma warning restore CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        {
            Object O = new Object();
            lock (O)
            {
                bool Call = true;

                if (Draw == null)
                    return;
                TreeNode childNode = new TreeNode();
                for (int i = 0; i < Draw.SodierHigh; i++)
                {
                    if (Draw.SolderesOnTable == null)
                    {
                        Call = false;
                        TreeNode t = new TreeNode();
                        t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Tag = parentId;
                        if (parentNode == null)
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                treeViewRefregitzDraw.Nodes.Add(t);
                            }); childNode = t;
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                parentNode.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        break;
                    }
                    else
                    {

                        if (Draw.SolderesOnTable[i] == null)
                        {
                            Call = false;
                            TreeNode t = new TreeNode();
                            t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;
                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                }); childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });
                                childNode = t;
                            }

                            PopulateTreeViewS(i, childNode, null);
                        }
                        else
                        {
                            TreeNode t = new TreeNode();
                            t.Text = "SoldierOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "SoldierOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;

                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                }); childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            TreeNode HeuristicSoldier = new TreeNode();
                            for (int j = 0; Draw.SolderesOnTable[i].SoldierThinking != null && Draw.SolderesOnTable[i].SoldierThinking[0] != null && Draw.SolderesOnTable[i].SoldierThinking[0].HeuristicListSolder != null && j < Draw.SolderesOnTable[i].SoldierThinking[0].HeuristicListSolder.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                tt.Text = "HeuristicSoldier" + j.ToString() + "_CountHurSo:" + ReturnbCal(Draw.SolderesOnTable[i].SoldierThinking[0], 1, j).ToString() + "_MoveString:" + MoveS(Draw.SolderesOnTable[i].SoldierThinking[0], 1, j).ToString();
                                tt.Name = "HeuristicSoldier" + j.ToString() + "_CountHurSo:" + ReturnbCal(Draw.SolderesOnTable[i].SoldierThinking[0], 1, j).ToString() + "_MoveString:" + MoveS(Draw.SolderesOnTable[i].SoldierThinking[0], 1, j).ToString();
                                tt.Tag = j;
                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    HeuristicSoldier = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    HeuristicSoldier = tt;
                                }
                            }
                            TreeNode AstarGreedy = new TreeNode();
                            for (int j = 0; Draw.SolderesOnTable[i].SoldierThinking != null && Draw.SolderesOnTable[i].SoldierThinking[0] != null && Draw.SolderesOnTable[i].SoldierThinking[0].AStarGreedy != null && j < Draw.SolderesOnTable[i].SoldierThinking[0].AStarGreedy.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                if (Draw.SolderesOnTable[i].LoseOcuuredatChiled[0] < 0)
                                    tt.BackColor = Color.RosyBrown;
                                else
                                if (Draw.SolderesOnTable[i].SoldierThinking[0].LoseChiled.Count == Draw.SolderesOnTable[i].SoldierThinking[0].HeuristicListSolder.Count)
                                {
                                    if (Draw.SolderesOnTable[i].SoldierThinking[0].LoseChiled[j] < 0)
                                        tt.BackColor = Color.Cyan;
                                }
                                else
                                if (Draw.IsCurrentDraw)
                                    tt.BackColor = Color.Orange;
                                else
                       if (Draw.SolderesOnTable[i].SoldierThinking[0].IsThereMateOfSelf[j])
                                    tt.BackColor = Color.Red;
                                else
                     if (Draw.SolderesOnTable[i].SoldierThinking[0].IsThereMateOfEnemy[j])
                                    tt.BackColor = Color.Green;

                                if (Draw.SolderesOnTable[i].SoldierThinking[0].KishEnemy[j])
                                    tt.BackColor = Color.Blue;
                                else
                          if (Draw.SolderesOnTable[i].SoldierThinking[0].KishSelf[j])
                                    tt.BackColor = Color.Yellow;
                                else
                                if (Draw.HaveKilled > 0)
                                    tt.BackColor = Color.Gray;
                                else if (Draw.HaveKilled < 0)
                                    tt.BackColor = Color.Brown;
                                tt.Text = "AstarGreedy" + j.ToString() + "_Order:" + Draw.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Name = "AstarGreedy" + j.ToString() + "_Order:" + Draw.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Tag = j;
                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                if (Call)
                                {
                                    PopulateTreeViewS(j, AstarGreedy, Draw.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewE(j, AstarGreedy, Draw.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewH(j, AstarGreedy, Draw.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewC(j, AstarGreedy, Draw.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewM(j, AstarGreedy, Draw.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewK(j, AstarGreedy, Draw.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewA(j, AstarGreedy, Draw.SolderesOnTable[i].SoldierThinking[0].AStarGreedy[j]);
                                }

                            }
                        }
                    }
                }
            }
        }
        //#pragma warning disable CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        private void PopulateTreeViewE(int parentId, TreeNode parentNode, RefrigtzChessPortable.AllDraw Draw)
        //#pragma warning restore CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        {
            Object O = new Object();
            lock (O)
            {
                bool Call = true;

                if (Draw == null)
                    return;

                TreeNode childNode = new TreeNode();
                for (int i = 0; i < Draw.ElefantHigh; i++)
                {
                    if (Draw.SolderesOnTable == null)
                    {
                        Call = false;
                        TreeNode t = new TreeNode();
                        t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Tag = parentId;
                        if (parentNode == null)
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                treeViewRefregitzDraw.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                parentNode.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        break;
                    }
                    else
                    {
                        if (Draw.ElephantOnTable[i] == null)
                        {
                            Call = false;
                            TreeNode t = new TreeNode();
                            t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;
                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });
                                childNode = t;
                            }

                            PopulateTreeViewE(i, childNode, null);
                        }
                        else
                        {
                            TreeNode t = new TreeNode();
                            t.Text = "ElephantOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "ElephantOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;
                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            TreeNode HeuristicElephant = new TreeNode();
                            for (int j = 0; Draw.ElephantOnTable[i].ElefantThinking != null && Draw.ElephantOnTable[i].ElefantThinking[0] != null && Draw.ElephantOnTable[i].ElefantThinking[0].HeuristicListElefant != null && j < Draw.ElephantOnTable[i].ElefantThinking[0].HeuristicListElefant.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                if (Draw.ElephantOnTable[i].LoseOcuuredatChiled[0] < 0)
                                    tt.BackColor = Color.RosyBrown;
                                else
                                 if (Draw.ElephantOnTable[i].ElefantThinking[0].LoseChiled.Count == Draw.ElephantOnTable[i].ElefantThinking[0].HeuristicListElefant.Count)
                                {
                                    if (Draw.ElephantOnTable[i].ElefantThinking[0].LoseChiled[j] < 0)
                                        tt.BackColor = Color.Cyan;
                                }
                                else
                               if (Draw.IsCurrentDraw)
                                    tt.BackColor = Color.Orange;
                                else
                           if (Draw.ElephantOnTable[i].ElefantThinking[0].IsThereMateOfSelf[j])
                                    tt.BackColor = Color.Red;
                                else
                         if (Draw.ElephantOnTable[i].ElefantThinking[0].IsThereMateOfEnemy[j])
                                    tt.BackColor = Color.Green;

                                if (Draw.ElephantOnTable[i].ElefantThinking[0].KishEnemy[j])
                                    tt.BackColor = Color.Blue;
                                else
                          if (Draw.ElephantOnTable[i].ElefantThinking[0].KishSelf[j])
                                    tt.BackColor = Color.Yellow;
                                else
                                if (Draw.HaveKilled > 0)
                                    tt.BackColor = Color.Gray;
                                else if (Draw.HaveKilled < 0)
                                    tt.BackColor = Color.Brown;
                                tt.Text = "HeuristicElephant" + j.ToString() + "_CountHurEl:" + ReturnbCal(Draw.ElephantOnTable[i].ElefantThinking[0], 2, j).ToString() + "_MoveString:" + MoveS(Draw.ElephantOnTable[i].ElefantThinking[0], 2, j).ToString();
                                tt.Name = "HeuristicElephant" + j.ToString() + "_CountHurEl:" + ReturnbCal(Draw.ElephantOnTable[i].ElefantThinking[0], 2, j).ToString() + "_MoveString:" + MoveS(Draw.ElephantOnTable[i].ElefantThinking[0], 2, j).ToString();
                                tt.Tag = j;
                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    HeuristicElephant = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    HeuristicElephant = tt;
                                }
                            }
                            TreeNode AstarGreedy = new TreeNode();
                            for (int j = 0; Draw.ElephantOnTable[i].ElefantThinking != null && Draw.ElephantOnTable[i].ElefantThinking[0] != null && Draw.ElephantOnTable[i].ElefantThinking[0].AStarGreedy != null && j < Draw.ElephantOnTable[i].ElefantThinking[0].AStarGreedy.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                tt.Text = "AstarGreedy" + j.ToString() + "_Order:" + Draw.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Name = "AstarGreedy" + j.ToString() + "_Order:" + Draw.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Tag = j;

                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                if (Call)
                                {
                                    PopulateTreeViewS(j, AstarGreedy, Draw.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewE(j, AstarGreedy, Draw.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewH(j, AstarGreedy, Draw.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewC(j, AstarGreedy, Draw.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewM(j, AstarGreedy, Draw.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewK(j, AstarGreedy, Draw.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewA(j, AstarGreedy, Draw.ElephantOnTable[i].ElefantThinking[0].AStarGreedy[j]);
                                }
                            }

                        }
                    }
                }
            }
        }
        //#pragma warning disable CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        private void PopulateTreeViewH(int parentId, TreeNode parentNode, RefrigtzChessPortable.AllDraw Draw)
        //#pragma warning restore CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        {
            Object O = new Object();
            lock (O)
            {
                bool Call = true;

                if (Draw == null)
                    return;

                TreeNode childNode = new TreeNode();
                for (int i = 0; i < Draw.HourseHight; i++)
                {
                    if (Draw.HoursesOnTable == null)
                    {
                        Call = false;
                        TreeNode t = new TreeNode();
                        t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Tag = parentId;
                        if (parentNode == null)
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                treeViewRefregitzDraw.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                parentNode.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        break;
                    }
                    else
                    {
                        if (Draw.HoursesOnTable[i] == null)
                        {
                            Call = false;
                            TreeNode t = new TreeNode();
                            t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;
                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });
                                childNode = t;
                            }


                        }
                        else
                        {
                            TreeNode t = new TreeNode();
                            t.Text = "HoursesOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "HoursesOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;
                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            TreeNode HeuristicHourse = new TreeNode();
                            for (int j = 0; Draw.HoursesOnTable[i].HourseThinking != null && Draw.HoursesOnTable[i].HourseThinking[0] != null && Draw.HoursesOnTable[i].HourseThinking[0].HeuristicListHourse != null && j < Draw.HoursesOnTable[i].HourseThinking[0].HeuristicListHourse.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                if (Draw.HoursesOnTable[i].LoseOcuuredatChiled[0] < 0)
                                    tt.BackColor = Color.RosyBrown;
                                else
                             if (Draw.HoursesOnTable[i].HourseThinking[0].LoseChiled.Count == Draw.HoursesOnTable[i].HourseThinking[0].HeuristicListHourse.Count)
                                {
                                    if (Draw.HoursesOnTable[i].HourseThinking[0].LoseChiled[j] < 0)
                                        tt.BackColor = Color.Cyan;
                                }
                                else
                                if (Draw.IsCurrentDraw)
                                    tt.BackColor = Color.Orange;
                                else
                         if (Draw.HoursesOnTable[i].HourseThinking[0].IsThereMateOfSelf[j])
                                    tt.BackColor = Color.Red;
                                else
                       if (Draw.HoursesOnTable[i].HourseThinking[0].IsThereMateOfEnemy[j])
                                    tt.BackColor = Color.Green;

                                if (Draw.HoursesOnTable[i].HourseThinking[0].KishEnemy[j])
                                    tt.BackColor = Color.Blue;
                                else
                          if (Draw.HoursesOnTable[i].HourseThinking[0].KishSelf[j])
                                    tt.BackColor = Color.Yellow;
                                else
                                if (Draw.HaveKilled > 0)
                                    tt.BackColor = Color.Gray;
                                else if (Draw.HaveKilled < 0)
                                    tt.BackColor = Color.Brown;
                                tt.Text = "HeuristicHourse" + j.ToString() + "_CountHurHo:" + ReturnbCal(Draw.HoursesOnTable[i].HourseThinking[0], 3, j).ToString() + "_MoveString:" + MoveS(Draw.HoursesOnTable[i].HourseThinking[0], 3, j).ToString();
                                tt.Name = "HeuristicHourse" + j.ToString() + "_CountHurHo:" + ReturnbCal(Draw.HoursesOnTable[i].HourseThinking[0], 3, j).ToString() + "_MoveString:" + MoveS(Draw.HoursesOnTable[i].HourseThinking[0], 3, j).ToString();
                                tt.Tag = j;

                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    HeuristicHourse = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    HeuristicHourse = tt;
                                }
                            }
                            TreeNode AstarGreedy = new TreeNode();
                            for (int j = 0; Draw.HoursesOnTable[i].HourseThinking != null && Draw.HoursesOnTable[i].HourseThinking[0] != null && Draw.HoursesOnTable[i].HourseThinking[0].AStarGreedy != null && j < Draw.HoursesOnTable[i].HourseThinking[0].AStarGreedy.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                tt.Text = "AstarGreedy" + j.ToString() + "_Order:" + Draw.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Name = "AstarGreedy" + j.ToString() + "_Order:" + Draw.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Tag = j;

                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }

                                if (Call)
                                {
                                    PopulateTreeViewS(j, AstarGreedy, Draw.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewE(j, AstarGreedy, Draw.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewH(j, AstarGreedy, Draw.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewC(j, AstarGreedy, Draw.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewM(j, AstarGreedy, Draw.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewK(j, AstarGreedy, Draw.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewA(j, AstarGreedy, Draw.HoursesOnTable[i].HourseThinking[0].AStarGreedy[j]);
                                }
                            }
                        }
                    }
                }
            }
        }
        //#pragma warning disable CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        private void PopulateTreeViewC(int parentId, TreeNode parentNode, RefrigtzChessPortable.AllDraw Draw)
        //#pragma warning restore CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        {
            Object O = new Object();
            lock (O)
            {
                bool Call = true;
                if (Draw == null)
                    return;

                TreeNode childNode = new TreeNode();
                for (int i = 0; i < Draw.CastleHigh; i++)
                {
                    if (Draw.CastlesOnTable == null)
                    {
                        Call = false;
                        TreeNode t = new TreeNode();
                        t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Tag = parentId;
                        if (parentNode == null)
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                treeViewRefregitzDraw.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                parentNode.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        break;
                    }
                    else
                    {
                        if (Draw.CastlesOnTable[i] == null)
                        {
                            Call = false;
                            TreeNode t = new TreeNode();
                            t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;
                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });
                                childNode = t;
                            }

                        }
                        else
                        {
                            TreeNode t = new TreeNode();
                            t.Text = "CastlesOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "CastlesOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;

                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            TreeNode HeuristicCastle = new TreeNode();
                            for (int j = 0; Draw.CastlesOnTable[i].CastleThinking != null && Draw.CastlesOnTable[i].CastleThinking[0] != null && Draw.CastlesOnTable[i].CastleThinking[0].HeuristicListCastle != null && j < Draw.CastlesOnTable[i].CastleThinking[0].HeuristicListCastle.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                if (Draw.CastlesOnTable[i].LoseOcuuredatChiled[0] < 0)
                                    tt.BackColor = Color.RosyBrown;
                                else
                                 if (Draw.CastlesOnTable[i].CastleThinking[0].LoseChiled[j] < 0)
                                {
                                    if (Draw.CastlesOnTable[i].CastleThinking[0].LoseChiled.Count == Draw.CastlesOnTable[i].CastleThinking[0].HeuristicListCastle.Count)
                                        tt.BackColor = Color.Cyan;
                                }
                                else
                              if (Draw.IsCurrentDraw)

                                    tt.BackColor = Color.Orange;
                                else
                      if (Draw.CastlesOnTable[i].CastleThinking[0].IsThereMateOfSelf[j])
                                    tt.BackColor = Color.Red;
                                else
                    if (Draw.CastlesOnTable[i].CastleThinking[0].IsThereMateOfEnemy[j])
                                    tt.BackColor = Color.Green;

                                if (Draw.CastlesOnTable[i].CastleThinking[0].KishEnemy[j])
                                    tt.BackColor = Color.Blue;
                                else
                          if (Draw.CastlesOnTable[i].CastleThinking[0].KishSelf[j])
                                    tt.BackColor = Color.Yellow;
                                else
                                if (Draw.HaveKilled > 0)
                                    tt.BackColor = Color.Gray;
                                else if (Draw.HaveKilled < 0)
                                    tt.BackColor = Color.Brown;
                                tt.Text = "HeuristicCastle" + j.ToString() + "_CountHurCa:" + ReturnbCal(Draw.CastlesOnTable[i].CastleThinking[0], 4, j).ToString() + "_MoveString:" + MoveS(Draw.CastlesOnTable[i].CastleThinking[0], 4, j).ToString();
                                tt.Name = "HeuristicCastle" + j.ToString() + "_CountHurCa:" + ReturnbCal(Draw.CastlesOnTable[i].CastleThinking[0], 4, j).ToString() + "_MoveString:" + MoveS(Draw.CastlesOnTable[i].CastleThinking[0], 4, j).ToString();
                                tt.Tag = j;

                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    HeuristicCastle = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    HeuristicCastle = tt;
                                }
                            }
                            TreeNode AstarGreedy = new TreeNode();
                            for (int j = 0; Draw.CastlesOnTable[i].CastleThinking != null && Draw.CastlesOnTable[i].CastleThinking[0] != null && Draw.CastlesOnTable[i].CastleThinking[0].AStarGreedy != null && j < Draw.CastlesOnTable[i].CastleThinking[0].AStarGreedy.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                tt.Text = "AstarGreedy" + j.ToString() + "_Order:" + Draw.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Name = "AstarGreedy" + j.ToString() + "_Order:" + Draw.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Tag = j;

                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                if (Call)
                                {
                                    PopulateTreeViewS(j, AstarGreedy, Draw.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewE(j, AstarGreedy, Draw.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewH(j, AstarGreedy, Draw.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewC(j, AstarGreedy, Draw.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewM(j, AstarGreedy, Draw.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewK(j, AstarGreedy, Draw.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewA(j, AstarGreedy, Draw.CastlesOnTable[i].CastleThinking[0].AStarGreedy[j]);
                                }
                            }
                        }
                    }

                }
            }
        }
        //#pragma warning disable CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        int ReturnbCal(RefrigtzChessPortable.ThinkingRefrigtzChessPortable t, int Kind, int j)
        //#pragma warning restore CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        {
            Object O = new Object();
            lock (O)
            {
                if (Kind == 1)
                {
                    return
                                    t.HeuristicListSolder[j][0] +
                                        t.HeuristicListSolder[j][1] +
                                        t.HeuristicListSolder[j][2] +
                                        t.HeuristicListSolder[j][3] +
                                        t.HeuristicListSolder[j][4] +
                                        t.HeuristicListSolder[j][5] +
                                        t.HeuristicListSolder[j][6] +
                                    t.HeuristicListSolder[j][7] +
                                    t.HeuristicListSolder[j][8] +
                                    t.HeuristicListSolder[j][9];
                }

                else
                if (Kind == 2)
                {
                    return t.HeuristicListElefant[j][0] +
                    t.HeuristicListElefant[j][1] +
                    t.HeuristicListElefant[j][2] +
                    t.HeuristicListElefant[j][3] +
                    t.HeuristicListElefant[j][4] +
                    t.HeuristicListElefant[j][5] +
                    t.HeuristicListElefant[j][6] +
                    t.HeuristicListElefant[j][7] +
                    t.HeuristicListElefant[j][8] +
                    t.HeuristicListElefant[j][9];
                }
                else if (Kind == 3)
                {
                    return t.HeuristicListHourse[j][0] +
                                   t.HeuristicListHourse[j][1] +
                                   t.HeuristicListHourse[j][2] +
                                   t.HeuristicListHourse[j][3] +
                                   t.HeuristicListHourse[j][4] +
                                   t.HeuristicListHourse[j][5] +
                                   t.HeuristicListHourse[j][6] +
                                   t.HeuristicListHourse[j][7] +
                                   t.HeuristicListHourse[j][8] +
                                   t.HeuristicListHourse[j][9];
                }
                else if (Kind == 4)
                {
                    return t.HeuristicListCastle[j][0] +
          t.HeuristicListCastle[j][1] +
          t.HeuristicListCastle[j][2] +
          t.HeuristicListCastle[j][3] +
          t.HeuristicListCastle[j][4] +
          t.HeuristicListCastle[j][5] +
          t.HeuristicListCastle[j][6] +
          t.HeuristicListCastle[j][7] +
          t.HeuristicListCastle[j][8] +
          t.HeuristicListCastle[j][9];
                }
                else if (Kind == 5)
                {
                    return t.HeuristicListMinister[j][0] +
       t.HeuristicListMinister[j][1] +
       t.HeuristicListMinister[j][2] +
       t.HeuristicListMinister[j][3] +
       t.HeuristicListMinister[j][4] +
       t.HeuristicListMinister[j][5] +
       t.HeuristicListMinister[j][6] +
       t.HeuristicListMinister[j][7] +
       t.HeuristicListMinister[j][8] +
       t.HeuristicListMinister[j][9];
                }
                else
                    if (Kind == 6)
                {
                    return t.HeuristicListKing[j][0] +
        t.HeuristicListKing[j][1] +
        t.HeuristicListKing[j][2] +
        t.HeuristicListKing[j][3] +
        t.HeuristicListKing[j][4] +
        t.HeuristicListKing[j][5] +
        t.HeuristicListKing[j][6] +
        t.HeuristicListKing[j][7] +
        t.HeuristicListKing[j][8] +
        t.HeuristicListKing[j][9];
                }
                else
                    if (Kind == 7 || Kind == -7)
                {
                    return t.HeuristicListCastling[j][0] +
        t.HeuristicListCastling[j][1] +
        t.HeuristicListCastling[j][2] +
        t.HeuristicListCastling[j][3] +
        t.HeuristicListCastling[j][4] +
        t.HeuristicListCastling[j][5] +
        t.HeuristicListCastling[j][6] +
        t.HeuristicListCastling[j][7] +
        t.HeuristicListCastling[j][8] +
        t.HeuristicListCastling[j][9];
                }
                return int.MinValue;
            }
        }
        //#pragma warning disable CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        private void PopulateTreeViewM(int parentId, TreeNode parentNode, RefrigtzChessPortable.AllDraw Draw)
        //#pragma warning restore CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        {
            Object O = new Object();
            lock (O)
            {
                bool Call = true;

                if (Draw == null)
                    return;

                TreeNode childNode = new TreeNode();
                for (int i = 0; i < Draw.MinisterHigh; i++)
                {
                    if (Draw.MinisterOnTable == null)
                    {
                        Call = false;
                        TreeNode t = new TreeNode();
                        t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Tag = parentId;
                        if (parentNode == null)
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                treeViewRefregitzDraw.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                parentNode.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        break;
                    }
                    else
                    {
                        if (Draw.MinisterOnTable[i] == null)
                        {
                            Call = false;
                            TreeNode t = new TreeNode();
                            t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;
                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });
                                childNode = t;
                            }


                        }
                        else
                        {
                            TreeNode t = new TreeNode();
                            t.Text = "MinisterOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "MinisterOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;
                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            TreeNode HeuristicMinister = new TreeNode();
                            for (int j = 0; Draw.MinisterOnTable[i].MinisterThinking != null && Draw.MinisterOnTable[i].MinisterThinking[0] != null && Draw.MinisterOnTable[i].MinisterThinking[0].HeuristicListMinister != null && j < Draw.MinisterOnTable[i].MinisterThinking[0].HeuristicListMinister.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                if (Draw.MinisterOnTable[i].LoseOcuuredatChiled[0] < 0)
                                    tt.BackColor = Color.RosyBrown;
                                else
                                if (Draw.MinisterOnTable[i].MinisterThinking[0].LoseChiled.Count == Draw.MinisterOnTable[i].MinisterThinking[0].HeuristicListMinister.Count)
                                {
                                    if (Draw.MinisterOnTable[i].MinisterThinking[0].LoseChiled[j] < 0)
                                        tt.BackColor = Color.Cyan;
                                }
                                else
                               if (Draw.IsCurrentDraw)
                                    tt.BackColor = Color.Orange;
                                else
                         if (Draw.MinisterOnTable[i].MinisterThinking[0].IsThereMateOfSelf[j])
                                    tt.BackColor = Color.Red;
                                else
                       if (Draw.MinisterOnTable[i].MinisterThinking[0].IsThereMateOfEnemy[j])
                                    tt.BackColor = Color.Green;

                                if (Draw.MinisterOnTable[i].MinisterThinking[0].KishEnemy[j])
                                    tt.BackColor = Color.Blue;
                                else
                          if (Draw.MinisterOnTable[i].MinisterThinking[0].KishSelf[j])
                                    tt.BackColor = Color.Yellow;
                                else
                                if (Draw.HaveKilled > 0)
                                    tt.BackColor = Color.Gray;
                                else if (Draw.HaveKilled < 0)
                                    tt.BackColor = Color.Brown;
                                tt.Text = "HeuristicMinister" + j.ToString() + "_CountHurMi:" + ReturnbCal(Draw.MinisterOnTable[i].MinisterThinking[0], 5, j).ToString() + "_MoveString:" + MoveS(Draw.MinisterOnTable[i].MinisterThinking[0], 5, j).ToString();
                                tt.Name = "HeuristicMinister" + j.ToString() + "_CountHurMi:" + ReturnbCal(Draw.MinisterOnTable[i].MinisterThinking[0], 5, j).ToString() + "_MoveString:" + MoveS(Draw.MinisterOnTable[i].MinisterThinking[0], 5, j).ToString();
                                tt.Tag = j;

                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    HeuristicMinister = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    HeuristicMinister = tt;
                                }
                            }
                            TreeNode AstarGreedy = new TreeNode();
                            for (int j = 0; Draw.MinisterOnTable[i].MinisterThinking != null && Draw.MinisterOnTable[i].MinisterThinking[0] != null && Draw.MinisterOnTable[i].MinisterThinking[0].AStarGreedy != null && j < Draw.MinisterOnTable[i].MinisterThinking[0].AStarGreedy.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                tt.Text = "AstarGreedy" + j.ToString() + "_Order:" + Draw.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Name = "AstarGreedy" + j.ToString() + "_Order:" + Draw.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Tag = j;

                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                if (Call)
                                {
                                    PopulateTreeViewS(j, AstarGreedy, Draw.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewE(j, AstarGreedy, Draw.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewH(j, AstarGreedy, Draw.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewC(j, AstarGreedy, Draw.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewM(j, AstarGreedy, Draw.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewK(j, AstarGreedy, Draw.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewA(j, AstarGreedy, Draw.MinisterOnTable[i].MinisterThinking[0].AStarGreedy[j]);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void PopulateTreeViewK(int parentId, TreeNode parentNode, RefrigtzChessPortable.AllDraw Draw)
        //#pragma warning restore CS0246 // The type or namespace name 'RefrigtzDLL' could not be found (are you missing a using directive or an assembly reference?)
        {
            Object O = new Object();
            lock (O)
            {
                bool Call = true;


                if (Draw == null)
                    return;

                TreeNode childNode = new TreeNode();
                for (int i = 0; i < Draw.KingHigh; i++)
                {
                    if (Draw.KingOnTable == null)
                    {
                        Call = false;
                        TreeNode t = new TreeNode();
                        t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Tag = parentId;
                        if (parentNode == null)
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                treeViewRefregitzDraw.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                parentNode.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        break;
                    }
                    else
                    {
                        if (Draw.KingOnTable[i] == null)
                        {
                            Call = false;

                            TreeNode t = new TreeNode();
                            t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;
                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });
                                childNode = t;
                            }

                        }
                        else
                        {
                            TreeNode t = new TreeNode();
                            t.Text = "KingOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "KingOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;
                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });

                                childNode = t;
                            }
                            TreeNode HeuristicKing = new TreeNode();
                            for (int j = 0; Draw.KingOnTable[i].KingThinking != null && Draw.KingOnTable[i].KingThinking[0] != null && Draw.KingOnTable[i].KingThinking[0].HeuristicListKing != null && j < Draw.KingOnTable[i].KingThinking[0].HeuristicListKing.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                if (Draw.KingOnTable[i].LoseOcuuredatChiled[0] < 0)
                                    tt.BackColor = Color.RosyBrown;
                                else
                                   if (Draw.KingOnTable[i].KingThinking[0].LoseChiled.Count == Draw.KingOnTable[i].KingThinking[0].HeuristicListKing.Count)
                                {
                                    if (Draw.KingOnTable[i].KingThinking[0].LoseChiled[j] < 0)
                                        tt.BackColor = Color.Cyan;
                                }
                                else
                             if (Draw.IsCurrentDraw)
                                    tt.BackColor = Color.Orange;
                                else
                        if (Draw.KingOnTable[i].KingThinking[0].IsThereMateOfSelf[j])
                                    tt.BackColor = Color.Red;
                                else
                      if (Draw.KingOnTable[i].KingThinking[0].IsThereMateOfEnemy[j])
                                    tt.BackColor = Color.Green;

                                if (Draw.KingOnTable[i].KingThinking[0].KishEnemy[j])
                                    tt.BackColor = Color.Blue;
                                else
                          if (Draw.KingOnTable[i].KingThinking[0].KishSelf[j])
                                    tt.BackColor = Color.Yellow;
                                else
                                if (Draw.HaveKilled > 0)
                                    tt.BackColor = Color.Gray;
                                else if (Draw.HaveKilled < 0)
                                    tt.BackColor = Color.Brown;
                                tt.Text = "HeuristicKing" + j.ToString() + "_CountHurKi:" + ReturnbCal(Draw.KingOnTable[i].KingThinking[0], 6, j).ToString() + "_MoveString:" + MoveS(Draw.KingOnTable[i].KingThinking[0], 6, j).ToString();
                                tt.Name = "HeuristicKing" + j.ToString() + "_CountHurKi:" + ReturnbCal(Draw.KingOnTable[i].KingThinking[0], 6, j).ToString() + "_MoveString:" + MoveS(Draw.KingOnTable[i].KingThinking[0], 6, j).ToString();
                                tt.Tag = j;


                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    HeuristicKing = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    HeuristicKing = tt;
                                }
                            }
                            TreeNode AstarGreedy = new TreeNode();
                            for (int j = 0; Draw.KingOnTable[i].KingThinking != null && Draw.KingOnTable[i].KingThinking[0] != null && Draw.KingOnTable[i].KingThinking[0].AStarGreedy != null && j < Draw.KingOnTable[i].KingThinking[0].AStarGreedy.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                tt.Text = "AstarGreedy" + j.ToString() + "_Order:" + Draw.KingOnTable[i].KingThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Name = "AstarGreedy" + j.ToString() + "_Order:" + Draw.KingOnTable[i].KingThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Tag = j;

                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                if (Call)
                                {
                                    PopulateTreeViewS(j, AstarGreedy, Draw.KingOnTable[i].KingThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewE(j, AstarGreedy, Draw.KingOnTable[i].KingThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewH(j, AstarGreedy, Draw.KingOnTable[i].KingThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewC(j, AstarGreedy, Draw.KingOnTable[i].KingThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewM(j, AstarGreedy, Draw.KingOnTable[i].KingThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewK(j, AstarGreedy, Draw.KingOnTable[i].KingThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewA(j, AstarGreedy, Draw.KingOnTable[i].KingThinking[0].AStarGreedy[j]);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void PopulateTreeViewA(int parentId, TreeNode parentNode, RefrigtzChessPortable.AllDraw Draw)
        //#pragma warning restore CS0246 // The type or namespace name 'RefrigtzChessPortable' could not be found (are you missing a using directive or an assembly reference?)
        {
            Object O = new Object();
            lock (O)
            {
                bool Call = true;


                if (Draw == null)
                    return;

                TreeNode childNode = new TreeNode();
                for (int i = 0; i < 1; i++)
                {
                    if (Draw.CastlingOnTable == null)
                    {
                        Call = false;
                        TreeNode t = new TreeNode();
                        t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                        t.Tag = parentId;
                        if (parentNode == null)
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                treeViewRefregitzDraw.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate ()
                            {
                                parentNode.Nodes.Add(t);
                            });
                            childNode = t;
                        }
                        break;
                    }
                    else
                    {
                        if (Draw.CastlingOnTable[i] == null)
                        {
                            Call = false;

                            TreeNode t = new TreeNode();
                            t.Text = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "NULL" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;
                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });
                                childNode = t;
                            }

                        }
                        else
                        {
                            TreeNode t = new TreeNode();
                            t.Text = "CastlingOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Name = "CastlingOnTable" + i.ToString() + ":Order=" + Draw.OrderP.ToString();
                            t.Tag = parentId;
                            if (parentNode == null)
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    treeViewRefregitzDraw.Nodes.Add(t);
                                });
                                childNode = t;
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate ()
                                {
                                    parentNode.Nodes.Add(t);
                                });

                                childNode = t;
                            }
                            TreeNode HeuristicCastling = new TreeNode();
                            for (int j = 0; Draw.CastlingOnTable[i].CastlingThinking != null && Draw.CastlingOnTable[i].CastlingThinking[0] != null && Draw.CastlingOnTable[i].CastlingThinking[0].HeuristicListCastling != null && j < Draw.CastlingOnTable[i].CastlingThinking[0].HeuristicListCastling.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                if (Draw.CastlingOnTable[i].LoseOcuuredatChiled[0] < 0)
                                    tt.BackColor = Color.RosyBrown;
                                else
                                   if (Draw.CastlingOnTable[i].CastlingThinking[0].LoseChiled.Count == Draw.CastlingOnTable[i].CastlingThinking[0].HeuristicListCastling.Count)
                                {
                                    if (Draw.CastlingOnTable[i].CastlingThinking[0].LoseChiled[j] < 0)
                                        tt.BackColor = Color.Cyan;
                                }
                                else
                             if (Draw.IsCurrentDraw)
                                    tt.BackColor = Color.Orange;
                                else
                        if (Draw.CastlingOnTable[i].CastlingThinking[0].IsThereMateOfSelf[j])
                                    tt.BackColor = Color.Red;
                                else
                      if (Draw.CastlingOnTable[i].CastlingThinking[0].IsThereMateOfEnemy[j])
                                    tt.BackColor = Color.Green;

                                if (Draw.CastlingOnTable[i].CastlingThinking[0].KishEnemy[j])
                                    tt.BackColor = Color.Blue;
                                else
                          if (Draw.CastlingOnTable[i].CastlingThinking[0].KishSelf[j])
                                    tt.BackColor = Color.Yellow;
                                else
                                if (Draw.HaveKilled > 0)
                                    tt.BackColor = Color.Gray;
                                else if (Draw.HaveKilled < 0)
                                    tt.BackColor = Color.Brown;
                                tt.Text = "HeuristicCastling" + j.ToString() + "_CountHurKi:" + ReturnbCal(Draw.CastlingOnTable[i].CastlingThinking[0], 7, j).ToString() + "_MoveString:" + MoveS(Draw.CastlingOnTable[i].CastlingThinking[0], 7, j).ToString();
                                tt.Name = "HeuristicCastling" + j.ToString() + "_CountHurKi:" + ReturnbCal(Draw.CastlingOnTable[i].CastlingThinking[0], 7, j).ToString() + "_MoveString:" + MoveS(Draw.CastlingOnTable[i].CastlingThinking[0], 7, j).ToString();
                                tt.Tag = j;


                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    HeuristicCastling = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    HeuristicCastling = tt;
                                }
                            }
                            TreeNode AstarGreedy = new TreeNode();
                            for (int j = 0; Draw.CastlingOnTable[i].CastlingThinking != null && Draw.CastlingOnTable[i].CastlingThinking[0] != null && Draw.CastlingOnTable[i].CastlingThinking[0].AStarGreedy != null && j < Draw.CastlingOnTable[i].CastlingThinking[0].AStarGreedy.Count; j++)
                            {
                                TreeNode tt = new TreeNode();
                                tt.Text = "AstarGreedy" + j.ToString() + "_Order:" + Draw.CastlingOnTable[i].CastlingThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Name = "AstarGreedy" + j.ToString() + "_Order:" + Draw.CastlingOnTable[i].CastlingThinking[0].AStarGreedy[j].OrderP.ToString();
                                tt.Tag = j;

                                if (childNode == null)
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        treeViewRefregitzDraw.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate ()
                                    {
                                        childNode.Nodes.Add(tt);
                                    });
                                    AstarGreedy = tt;
                                }
                                if (Call)
                                {
                                    PopulateTreeViewS(j, AstarGreedy, Draw.CastlingOnTable[i].CastlingThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewE(j, AstarGreedy, Draw.CastlingOnTable[i].CastlingThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewH(j, AstarGreedy, Draw.CastlingOnTable[i].CastlingThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewC(j, AstarGreedy, Draw.CastlingOnTable[i].CastlingThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewM(j, AstarGreedy, Draw.CastlingOnTable[i].CastlingThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewK(j, AstarGreedy, Draw.CastlingOnTable[i].CastlingThinking[0].AStarGreedy[j]);
                                    PopulateTreeViewA(j, AstarGreedy, Draw.CastlingOnTable[i].CastlingThinking[0].AStarGreedy[j]);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void backgroundWorkertreeView_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                Object O = new Object();
                lock (O)
                {
                    treeViewRefregitzDraw.Nodes.Clear();
                    CreateTree(D);
                    treeViewRefregitzDraw.Update();

                }
            } while (true);
        }

        private void treeViewRefregitzDraw_ControlAdded(object sender, ControlEventArgs e)
        {

        }
        void Create()
        {
            Object O = new Object();
            lock (O)
            {
                Invoke((MethodInvoker)delegate ()
            {
                treeViewRefregitzDraw.Nodes.Clear();
            });

                CreateTree(D);
            }
        }
        private void treeViewRefregitzDraw_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void FormTXT_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
