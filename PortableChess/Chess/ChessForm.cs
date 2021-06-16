//
//www.IranProject.Ir
//
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS0105 // The using directive for 'RefrigtzChessPortable' appeared previously in this namespace
#pragma warning restore CS0105 // The using directive for 'RefrigtzChessPortable' appeared previously in this namespace
namespace RefrigtzChessPortable
{
    [Serializable]
    public class RefrigtzChessPortableForm : System.Windows.Forms.Form
    {
        public bool freezCalculation = false;
        public bool ComStop = false;
        bool freezBoard = false;
        ArtificialInteligenceMove f = null;
        public bool LoadP = false;
        static readonly bool UsePenaltyRegardMechnisam = false;
        static readonly bool AStarGreedyHeuristic = false;
        int AllDrawKind = 0;
        bool NotFoundBegin = false;
        bool Deeperthandeeper = false;
        readonly String path3 = @"temp";
        String AllDrawReplacement = "";

        public static int MovmentsNumber = 0;
        public static String Root = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        public static String AllDrawKindString = "";
        public static int OrderPlate = 1;
        bool CoPermit = true;
        public int ConClick = -1;
        PictureBox[] Con = new PictureBox[4];
        bool WaitOnplay = false;
        public RefrigtzChessPortable.RefrigtzChessPortableGeneticAlgorithm R = new RefrigtzChessPortable.RefrigtzChessPortableGeneticAlgorithm(false, false, UsePenaltyRegardMechnisam, false, false, false, false, true);
        bool Person = true;
        public RefrigtzChessPortable.AllDraw Draw = new AllDraw(-1, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);
        int[,] Table = null;
        bool FOUND = false;
        #region These are the global variables and objects for RefrigtzChessPortableForm class
        private PictureBox[,] pb;
        private ListBox lb;
        Label label1;
        Label label2;
        Label label3;
        Label label4;
        Label label5;
        Label label6;
        Label label7;
        Label label8;
        Label labela;
        Label labelb;
        Label labelc;
        Label labeld;
        Label labele;
        Label labelf;
        Label labelg;
        Label labelh;
        private int cl;
        private int order;
        private int x1;
        private int y1;
        public Board brd;
        private Image img1;
        private Image img2;
        private Image img3;
        private Image img4;
        private Image img5;
        private Image img6;
        private Image img7;
        private Image img8;
        private Image img9;
        private Image img10;
        private Image img11;
        private Image img12;
        private Image img21;
        private Image img22;
        private Image img23;
        private Image img24;
        private Image img25;
        private Image img26;
        private Image img27;
        private Image img28;
        private Image img29;
        private Image img30;
        private Image img31;
        private Image img32;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripMenuItem AboutHelpToolStripMenuItem;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion
        [field: NonSerialized]
        private readonly CancellationTokenSource feedCancellationTokenSource =
            new CancellationTokenSource();
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem treeViewToolStripMenuItem;
        private ToolStripMenuItem junglesMakeTreeToolStripMenuItem;
        private OpenFileDialog openFileDialogjunglesMakeTree;
#pragma warning disable CS0169 // The field 'RefrigtzChessPortableForm.feedTask' is never used
        [field: NonSerialized] private readonly Task feedTask;
#pragma warning restore CS0169 // The field 'RefrigtzChessPortableForm.feedTask' is never used


        public RefrigtzChessPortableForm()
        {

            Init();
            Init2();
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            GC.SuppressFinalize(this);
            base.Dispose(disposing);
        }//tetrashop.ir
        void Initiate(Color a, int Order)
        {
            Object O = new Object();
            lock (O)
            {
                int LeafAStarGrteedy = 0;
                AllDraw THIS = Draw.AStarGreedyString;
                Table = Draw.Initiate(1, 4, a, CloneATable(brd.GetTable()), Order, false, FOUND, LeafAStarGrteedy);
                Draw.AStarGreedyString = THIS;
            }
        }
        //tetrashop.ir
        void AliceAction(int Order)
        {



            Object O = new Object();
            lock (O)
            {
                bool B = AllDraw.Blitz;
                AllDraw.Blitz = false;
                RefrigtzChessPortable.ThinkingRefrigtzChessPortable.ThinkingRun = false;
                //#pragma warning disable CS0164 // This label has not been referenced
#pragma warning disable CS0164 // This label has not been referenced
                Begin4:
#pragma warning restore CS0164 // This label has not been referenced
                //#pragma warning restore CS0164 // This label has not been referenced
                AllDraw Th = Draw.AStarGreedyString;
                if (Draw.IsAtLeastAllObjectIsNull())
                {
                    Draw.TableList.Clear();
                    Draw.TableList.Add(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]));
                    Draw.SetRowColumn(0);
                    Draw.IsCurrentDraw = true;
                }
                Draw.AStarGreedyString = Th;
                Initiate(Color.Brown, -1);
                AllDraw.Blitz = B;

            }



        }
        //tetrashop.ir
        void DisposeConv()
        {
            for (int i = 0; i < 4; i++)
                Con[i].Dispose();
        }
        //tetrashop.ir
        void InitConv(int j)
        {
            for (int i = j; i < 4 + j; i++)
            {
                Con[i - j] = new PictureBox();
                if (i % 2 == 0)
                    Con[i - j].BackColor = System.Drawing.Color.White;
                else
                    Con[i - j].BackColor = System.Drawing.Color.Silver;
                Con[i - j].Location = new System.Drawing.Point(30 + i * 60, 10 + 1 * 60);
                Con[i - j].Name = "con";
                Con[i - j].Size = new System.Drawing.Size(60, 60);
                Con[i - j].TabIndex = i;
                Con[i - j].TabStop = false;
                pb[i, j].Controls.AddRange(new System.Windows.Forms.Control[] { Con[i - j] });
                if (i % 2 == 0)
                {
                    if (i == j)
                        Con[i - j].Image = img7;
                    if (i == j + 1)
                        Con[i - j].Image = img1;
                    if (i == j + 2)
                        Con[i - j].Image = img3;
                    if (i == j + 3)
                        Con[i - j].Image = img5;
                }
                else
                {
                    if (i == j)
                        Con[i - j].Image = img8;
                    if (i == j + 1)
                        Con[i - j].Image = img2;
                    if (i == j + 2)
                        Con[i - j].Image = img4;
                    if (i == j + 3)
                        Con[i - j].Image = img6;
                }
            }
            Con[0].Click += new System.EventHandler(Con1_Click1);
            Con[1].Click += new System.EventHandler(Con2_Click1);
            Con[2].Click += new System.EventHandler(Con3_Click1);
            Con[3].Click += new System.EventHandler(Con4_Click1);
        }
        public void Init()
        {
            InitializeComponent();
            pb = new PictureBox[8, 8];
            brd = new Board();
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    pb[i, j] = new PictureBox();
                    if (brd.getbcolor(i, j) == 2)
                        this.pb[i, j].BackColor = System.Drawing.Color.White;
                    else
                        this.pb[i, j].BackColor = System.Drawing.Color.Silver;
                    this.pb[i, j].Location = new System.Drawing.Point(30 + i * 60, 10 + j * 60);
                    this.pb[i, j].Name = "pb1";
                    this.pb[i, j].Size = new System.Drawing.Size(60, 60);
                    this.pb[i, j].TabIndex = i;
                    this.pb[i, j].TabStop = false;
                    this.Controls.AddRange(new System.Windows.Forms.Control[] { this.pb[i, j] });
                }
            lb = new ListBox();
            this.lb.Location = new System.Drawing.Point(530, 10);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(150, 500);
            this.lb.TabIndex = 64;
            this.lb.TabStop = false;
            this.Controls.AddRange(new Control[] { this.lb });
            label1 = new Label();
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 65;
            this.label1.TabStop = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            label1.Text = "1";
            this.Controls.AddRange(new Control[] { this.label1 });
            label2 = new Label();
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 65;
            this.label2.TabStop = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            label2.Text = "2";
            this.Controls.AddRange(new Control[] { this.label2 });
            label3 = new Label();
            this.label3.Location = new System.Drawing.Point(10, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 65;
            this.label3.TabStop = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            label3.Text = "3";
            this.Controls.AddRange(new Control[] { this.label3 });
            label4 = new Label();
            this.label4.Location = new System.Drawing.Point(10, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 65;
            this.label4.TabStop = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            label4.Text = "4";
            this.Controls.AddRange(new Control[] { this.label4 });
            label5 = new Label();
            this.label5.Location = new System.Drawing.Point(10, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 65;
            this.label5.TabStop = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            label5.Text = "5";
            this.Controls.AddRange(new Control[] { this.label5 });
            label6 = new Label();
            this.label6.Location = new System.Drawing.Point(10, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 65;
            this.label6.TabStop = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            label6.Text = "6";
            this.Controls.AddRange(new Control[] { this.label6 });
            label7 = new Label();
            this.label7.Location = new System.Drawing.Point(10, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 65;
            this.label7.TabStop = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            label7.Text = "7";
            this.Controls.AddRange(new Control[] { this.label7 });
            label8 = new Label();
            this.label8.Location = new System.Drawing.Point(10, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 20);
            this.label8.TabIndex = 65;
            this.label8.TabStop = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            label8.Text = "8";
            this.Controls.AddRange(new Control[] { this.label8 });
            labelh = new Label();
            this.labelh.Location = new System.Drawing.Point(50, 490);
            this.labelh.Name = "labelh";
            this.labelh.Size = new System.Drawing.Size(20, 20);
            this.labelh.TabIndex = 65;
            this.labelh.TabStop = false;
            this.labelh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            labelh.Text = "h";
            this.Controls.AddRange(new Control[] { this.labelh });
            labelg = new Label();
            this.labelg.Location = new System.Drawing.Point(110, 490);
            this.labelg.Name = "labelg";
            this.labelg.Size = new System.Drawing.Size(20, 30);
            this.labelg.TabIndex = 65;
            this.labelg.TabStop = false;
            this.labelg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            labelg.Text = "g";
            this.Controls.AddRange(new Control[] { this.labelg });
            labelf = new Label();
            this.labelf.Location = new System.Drawing.Point(175, 490);
            this.labelf.Name = "labelf";
            this.labelf.Size = new System.Drawing.Size(20, 20);
            this.labelf.TabIndex = 65;
            this.labelf.TabStop = false;
            this.labelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            labelf.Text = "f";
            this.Controls.AddRange(new Control[] { this.labelf });
            labele = new Label();
            this.labele.Location = new System.Drawing.Point(230, 490);
            this.labele.Name = "labele";
            this.labele.Size = new System.Drawing.Size(20, 20);
            this.labele.TabIndex = 65;
            this.labele.TabStop = false;
            this.labele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            labele.Text = "e";
            this.Controls.AddRange(new Control[] { this.labele });
            labeld = new Label();
            this.labeld.Location = new System.Drawing.Point(290, 490);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(20, 20);
            this.labeld.TabIndex = 65;
            this.labeld.TabStop = false;
            this.labeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            labeld.Text = "d";
            this.Controls.AddRange(new Control[] { this.labeld });
            labelc = new Label();
            this.labelc.Location = new System.Drawing.Point(350, 490);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(20, 20);
            this.labelc.TabIndex = 65;
            this.labelc.TabStop = false;
            this.labelc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            labelc.Text = "c";
            this.Controls.AddRange(new Control[] { this.labelc });
            labelb = new Label();
            this.labelb.Location = new System.Drawing.Point(410, 490);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(20, 20);
            this.labelb.TabIndex = 65;
            this.labelb.TabStop = false;
            this.labelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            labelb.Text = "b";
            this.Controls.AddRange(new Control[] { this.labelb });
            labela = new Label();
            this.labela.Location = new System.Drawing.Point(470, 490);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(20, 20);
            this.labela.TabIndex = 65;
            this.labela.TabStop = false;
            this.labela.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
            labela.Text = "a";
            this.Controls.AddRange(new Control[] { this.labela });
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Name = "RefrigtzChessPortableForm";
            this.Text = "برنامه شطرنج";
            this.pb[0, 0].Click += new System.EventHandler(Pb_Click1);
            this.pb[1, 0].Click += new System.EventHandler(Pb_Click2);
            this.pb[2, 0].Click += new System.EventHandler(Pb_Click3);
            this.pb[3, 0].Click += new System.EventHandler(Pb_Click4);
            this.pb[4, 0].Click += new System.EventHandler(Pb_Click5);
            this.pb[5, 0].Click += new System.EventHandler(Pb_Click6);
            this.pb[6, 0].Click += new System.EventHandler(Pb_Click7);
            this.pb[7, 0].Click += new System.EventHandler(Pb_Click8);
            this.pb[0, 1].Click += new System.EventHandler(Pb_Click9);
            this.pb[1, 1].Click += new System.EventHandler(Pb_Click10);
            this.pb[2, 1].Click += new System.EventHandler(Pb_Click11);
            this.pb[3, 1].Click += new System.EventHandler(Pb_Click12);
            this.pb[4, 1].Click += new System.EventHandler(Pb_Click13);
            this.pb[5, 1].Click += new System.EventHandler(Pb_Click14);
            this.pb[6, 1].Click += new System.EventHandler(Pb_Click15);
            this.pb[7, 1].Click += new System.EventHandler(Pb_Click16);
            this.pb[0, 2].Click += new System.EventHandler(Pb_Click17);
            this.pb[1, 2].Click += new System.EventHandler(Pb_Click18);
            this.pb[2, 2].Click += new System.EventHandler(Pb_Click19);
            this.pb[3, 2].Click += new System.EventHandler(Pb_Click20);
            this.pb[4, 2].Click += new System.EventHandler(Pb_Click21);
            this.pb[5, 2].Click += new System.EventHandler(Pb_Click22);
            this.pb[6, 2].Click += new System.EventHandler(Pb_Click23);
            this.pb[7, 2].Click += new System.EventHandler(Pb_Click24);
            this.pb[0, 3].Click += new System.EventHandler(Pb_Click25);
            this.pb[1, 3].Click += new System.EventHandler(Pb_Click26);
            this.pb[2, 3].Click += new System.EventHandler(Pb_Click27);
            this.pb[3, 3].Click += new System.EventHandler(Pb_Click28);
            this.pb[4, 3].Click += new System.EventHandler(Pb_Click29);
            this.pb[5, 3].Click += new System.EventHandler(Pb_Click30);
            this.pb[6, 3].Click += new System.EventHandler(Pb_Click31);
            this.pb[7, 3].Click += new System.EventHandler(Pb_Click32);
            this.pb[0, 4].Click += new System.EventHandler(Pb_Click33);
            this.pb[1, 4].Click += new System.EventHandler(Pb_Click34);
            this.pb[2, 4].Click += new System.EventHandler(Pb_Click35);
            this.pb[3, 4].Click += new System.EventHandler(Pb_Click36);
            this.pb[4, 4].Click += new System.EventHandler(Pb_Click37);
            this.pb[5, 4].Click += new System.EventHandler(Pb_Click38);
            this.pb[6, 4].Click += new System.EventHandler(Pb_Click39);
            this.pb[7, 4].Click += new System.EventHandler(Pb_Click40);
            this.pb[0, 5].Click += new System.EventHandler(Pb_Click41);
            this.pb[1, 5].Click += new System.EventHandler(Pb_Click42);
            this.pb[2, 5].Click += new System.EventHandler(Pb_Click43);
            this.pb[3, 5].Click += new System.EventHandler(Pb_Click44);
            this.pb[4, 5].Click += new System.EventHandler(Pb_Click45);
            this.pb[5, 5].Click += new System.EventHandler(Pb_Click46);
            this.pb[6, 5].Click += new System.EventHandler(Pb_Click47);
            this.pb[7, 5].Click += new System.EventHandler(Pb_Click48);
            this.pb[0, 6].Click += new System.EventHandler(Pb_Click49);
            this.pb[1, 6].Click += new System.EventHandler(Pb_Click50);
            this.pb[2, 6].Click += new System.EventHandler(Pb_Click51);
            this.pb[3, 6].Click += new System.EventHandler(Pb_Click52);
            this.pb[4, 6].Click += new System.EventHandler(Pb_Click53);
            this.pb[5, 6].Click += new System.EventHandler(Pb_Click54);
            this.pb[6, 6].Click += new System.EventHandler(Pb_Click55);
            this.pb[7, 6].Click += new System.EventHandler(Pb_Click56);
            this.pb[0, 7].Click += new System.EventHandler(Pb_Click57);
            this.pb[1, 7].Click += new System.EventHandler(Pb_Click58);
            this.pb[2, 7].Click += new System.EventHandler(Pb_Click59);
            this.pb[3, 7].Click += new System.EventHandler(Pb_Click60);
            this.pb[4, 7].Click += new System.EventHandler(Pb_Click61);
            this.pb[5, 7].Click += new System.EventHandler(Pb_Click62);
            this.pb[6, 7].Click += new System.EventHandler(Pb_Click63);
            this.pb[7, 7].Click += new System.EventHandler(Pb_Click64);
        }
        private void Init2()
        {
            cl = 0;
            order = 2;
            x1 = 1;
            y1 = 1;
            img1 = Image.FromFile("pic/siyahkale1.jpg");
            img2 = Image.FromFile("pic/siyahkale2.jpg");
            img3 = Image.FromFile("pic/siyahat1.jpg");
            img4 = Image.FromFile("pic/siyahat2.jpg");
            img5 = Image.FromFile("pic/siyahfil1.jpg");
            img6 = Image.FromFile("pic/siyahfil2.jpg");
            img7 = Image.FromFile("pic/siyahvezir1.jpg");
            img8 = Image.FromFile("pic/siyahvezir2.jpg");
            img9 = Image.FromFile("pic/siyahsah1.jpg");
            img10 = Image.FromFile("pic/siyahsah2.jpg");
            img11 = Image.FromFile("pic/siyahpiyon1.jpg");
            img12 = Image.FromFile("pic/siyahpiyon2.jpg");
            img21 = Image.FromFile("pic/beyazkale1.jpg");
            img22 = Image.FromFile("pic/beyazkale2.jpg");
            img23 = Image.FromFile("pic/beyazat1.jpg");
            img24 = Image.FromFile("pic/beyazat2.jpg");
            img25 = Image.FromFile("pic/beyazfil1.jpg");
            img26 = Image.FromFile("pic/beyazfil2.jpg");
            img27 = Image.FromFile("pic/beyazvezir1.jpg");
            img28 = Image.FromFile("pic/beyazvezir2.jpg");
            img29 = Image.FromFile("pic/beyazsah1.jpg");
            img30 = Image.FromFile("pic/beyazsah2.jpg");
            img31 = Image.FromFile("pic/beyazpiyon1.jpg");
            img32 = Image.FromFile("pic/beyazpiyon2.jpg");
            pb[0, 0].Image = img1;
            pb[1, 0].Image = img4;
            pb[2, 0].Image = img5;
            pb[3, 0].Image = img8;
            pb[4, 0].Image = img9;
            pb[5, 0].Image = img6;
            pb[6, 0].Image = img3;
            pb[7, 0].Image = img2;
            pb[0, 7].Image = img22;
            pb[1, 7].Image = img23;
            pb[2, 7].Image = img26;
            pb[3, 7].Image = img27;
            pb[4, 7].Image = img30;
            pb[5, 7].Image = img25;
            pb[6, 7].Image = img24;
            pb[7, 7].Image = img21;
            pb[0, 1].Image = img12;
            pb[1, 1].Image = img11;
            pb[2, 1].Image = img12;
            pb[3, 1].Image = img11;
            pb[4, 1].Image = img12;
            pb[5, 1].Image = img11;
            pb[6, 1].Image = img12;
            pb[7, 1].Image = img11;
            pb[0, 6].Image = img31;
            pb[1, 6].Image = img32;
            pb[2, 6].Image = img31;
            pb[3, 6].Image = img32;
            pb[4, 6].Image = img31;
            pb[5, 6].Image = img32;
            pb[6, 6].Image = img31;
            pb[7, 6].Image = img32;
        }
        //tetrashop.ir
        void ClearTableInitiationPreventionOfMultipleMove()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] == 0)
                    {
                        if (RefrigtzChessPortable.ThinkingRefrigtzChessPortable.TableInitiationPreventionOfMultipleMove[i, j] != 0)
                            RefrigtzChessPortable.ThinkingRefrigtzChessPortable.TableInitiationPreventionOfMultipleMove[i, j] = RefrigtzChessPortable.ThinkingRefrigtzChessPortable.NoOfMovableAllObjectMove - 1;
                    }
                }
            }

        }
        public void Form1_Load(object sender, System.EventArgs e)
        {
            //tetrashop.ir
            Object O = new Object();
            lock (O)
            {
                if (!LoadP)
                {
                    freezBoard = false;
                    MessageBox.Show("Wait...");
                    //var parallelOptions = new ParallelOptions();
                    //parallelOptions.MaxDegreeOfParallelism = System.Threading.PlatformHelper.ProcessorCount;
                    RefrigtzChessPortable.AllDraw.OrderPlateDraw = -1;
                    RefrigtzChessPortable.AllDraw.TableListAction.Add(CloneATable(brd.GetTable()));
                    Table = CloneATable(brd.GetTable());
                    RefrigtzChessPortable.ThinkingRefrigtzChessPortable.TableInitiation = CloneATable(brd.GetTable());
                    //Load AllDraw.asd
                    bool LoadTree = true;
                    TakeRoot y = new TakeRoot();
                    bool DrawDrawen = y.Load(FOUND, false, this, ref LoadTree, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);
                    if (DrawDrawen)
                    {
                        if (DrawManagement())
                        {
                            //Load AllDraw.asd
                            LoadTree = true;
                            y = new TakeRoot();
                            FOUND = false;
                            DrawDrawen = y.Load(FOUND, false, this, ref LoadTree, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);
                            if (!DrawDrawen)
                            {
                                Draw = new RefrigtzChessPortable.AllDraw(OrderPlate, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);
                                Draw.TableList.Clear();
                                Draw.TableList.Add(CloneATable(Table));
                                Draw.SetRowColumn(0);
                                RefrigtzChessPortable.AllDraw.DepthIterative = 0;

                                bool Store = Deeperthandeeper;
                                Deeperthandeeper = false;

                                OrderPlate = 1;
                                AllDraw.OrderPlate = OrderPlate;

                                int Ord = OrderPlate;
                                Color aa = Color.Gray;
                                if (Ord == -1)
                                    aa = Color.Brown;
                                bool B = AllDraw.Blitz;
                                AllDraw.Blitz = false;
                                //RefrigtzChessPortable.AllDraw.MaxAStarGreedy = 0; // PlatformHelper.ProcessorCount; //PlatformHelper.ProcessorCount;

                                if (Draw.IsAtLeastAllObjectIsNull())
                                {
                                    Draw.TableList.Clear();
                                    Draw.TableList.Add(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 2]));
                                    Draw.SetRowColumn(0);
                                    Draw.IsCurrentDraw = true;
                                }

                                object n = new object();
                                lock (n)
                                {
                                    AllDraw.ChangedInTreeOccured = false;

                                }

                                Draw.InitiateAStarGreedyt(PlatformHelper.ProcessorCount + AllDraw.StoreInitMaxAStarGreedy - AllDraw.MaxAStarGreedy, 0, 0, aa, CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]), Ord, false, FOUND, 0);

                                AllDraw.Blitz = B;
                                Deeperthandeeper = Store;

                            }
                            else
                            {
                                FOUND = false;
                                Draw = y.t;
                                Draw.HarasAlphaBeta(0, 0, -1);
                                Thread arr = new Thread(new ThreadStart(SetDrawFound));
                                arr.Start();
                                arr.Join();
                            }
                        }
                    }
                    else
                    {
                        Object OO = new Object();
                        lock (OO)
                        {
                            SetAllDrawKind();
                            //Set Configuration To True for some unknown reason!.

                            SetAllDrawKindString();
                            bool Found = false;
                            String P = Path.GetFullPath(path3);
                            AllDrawReplacement = Path.Combine(P, AllDrawKindString);


                            if (File.Exists(AllDrawReplacement))
                            {
                                if (((new System.IO.FileInfo(AllDrawKindString).Length) < (new System.IO.FileInfo(AllDrawReplacement)).Length))
                                {
                                    File.Delete(AllDrawKindString);
                                    File.Copy(AllDrawReplacement, AllDrawKindString);
                                    Found = true;
                                }
                            }
                            else
                            {

                                File.Delete(AllDrawKindString);
                            }


                        }
                        if (DrawManagement())
                        {
                            //Load AllDraw.asd
                            LoadTree = true;
                            y = new TakeRoot();
                            DrawDrawen = y.Load(FOUND, false, this, ref LoadTree, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);
                            if (!DrawDrawen)
                            {
                                Draw = new RefrigtzChessPortable.AllDraw(OrderPlate, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);
                                Draw.TableList.Clear();
                                Draw.TableList.Add(CloneATable(Table));
                                Draw.SetRowColumn(0);
                                RefrigtzChessPortable.AllDraw.DepthIterative = 0;

                                bool Store = Deeperthandeeper;
                                Deeperthandeeper = false;

                                OrderPlate = 1;
                                AllDraw.OrderPlate = OrderPlate;

                                int Ord = OrderPlate;
                                Color aa = Color.Gray;
                                if (Ord == -1)
                                    aa = Color.Brown;
                                bool B = AllDraw.Blitz;
                                AllDraw.Blitz = false;
                                //RefrigtzChessPortable.AllDraw.MaxAStarGreedy = 0; // PlatformHelper.ProcessorCount; //PlatformHelper.ProcessorCount;

                                if (Draw.IsAtLeastAllObjectIsNull())
                                {
                                    Draw.TableList.Clear();
                                    Draw.TableList.Add(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 2]));
                                    Draw.SetRowColumn(0);
                                    Draw.IsCurrentDraw = true;
                                }

                                object n = new object();
                                lock (n)
                                {
                                    AllDraw.ChangedInTreeOccured = false;

                                }

                                Draw.InitiateAStarGreedyt(PlatformHelper.ProcessorCount + AllDraw.StoreInitMaxAStarGreedy - AllDraw.MaxAStarGreedy, 0, 0, aa, CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]), Ord, false, FOUND, 0);

                                AllDraw.Blitz = B;
                                Deeperthandeeper = Store;


                            }
                            else
                            {
                                FOUND = false;
                                Draw = y.t;
                                Draw.HarasAlphaBeta(0, 0, -1);
                                Thread arr = new Thread(new ThreadStart(SetDrawFound));
                                arr.Start();
                                arr.Join();
                            }
                        }
                        else
                        {

                            Draw = new RefrigtzChessPortable.AllDraw(OrderPlate, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);
                            Draw.TableList.Clear();
                            Draw.TableList.Add(CloneATable(Table));
                            Draw.SetRowColumn(0);
                            RefrigtzChessPortable.AllDraw.DepthIterative = 0;

                            bool Store = Deeperthandeeper;
                            Deeperthandeeper = false;

                            OrderPlate = 1;
                            AllDraw.OrderPlate = OrderPlate;

                            int Ord = OrderPlate;
                            Color aa = Color.Gray;
                            if (Ord == -1)
                                aa = Color.Brown;
                            bool B = AllDraw.Blitz;
                            AllDraw.Blitz = false;
                            //RefrigtzChessPortable.AllDraw.MaxAStarGreedy = 0; // PlatformHelper.ProcessorCount; //PlatformHelper.ProcessorCount;

                            if (Draw.IsAtLeastAllObjectIsNull())
                            {
                                Draw.TableList.Clear();
                                Draw.TableList.Add(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 2]));
                                Draw.SetRowColumn(0);
                                Draw.IsCurrentDraw = true;
                            }

                            object n = new object();
                            lock (n)
                            {
                                AllDraw.ChangedInTreeOccured = false;

                            }

                            Draw.InitiateAStarGreedyt(PlatformHelper.ProcessorCount + AllDraw.StoreInitMaxAStarGreedy - AllDraw.MaxAStarGreedy, 0, 0, aa, CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]), Ord, false, FOUND, 0);

                            AllDraw.Blitz = B;
                            Deeperthandeeper = Store;



                        }
                    }
                }

                MessageBox.Show("Ready...");
                LoadP = true;

                f = new ArtificialInteligenceMove(this);
            }
        }
        //tetrashop.ir
        void ClickedSimAtClOne(int i, int j)
        {
            Object o = new Object();
            lock (o)
            {
                int ii = new int();
                int jj = new int();
                if (R.CromosomRowFirst == -1 || R.CromosomColumnFirst == -1 || R.CromosomRow == -1 || R.CromosomColumn == -1)
                {
                    ii = 7 - AllDraw.NextRow;
                    jj = AllDraw.NextColumn;
                }
                else
                {
                    ii = R.CromosomRow;
                    jj = R.CromosomColumn;
                }


                freezBoard = false;


                Play(ii, jj);

                AllDraw.NextRow = -1;
                AllDraw.NextColumn = -1;
                AllDraw.LastRow = -1;
                AllDraw.LastColumn = -1;
                cl = 0;
                Person = true;
            }
        }
        //tetrashop.ir
        static void Log(Exception ex)
        {

            Object a = new Object();
            lock (a)
            {
                string stackTrace = ex.ToString();
                Helper.WaitOnUsed(AllDraw.Root + "\\ErrorProgramRun.txt"); File.AppendAllText(AllDraw.Root + "\\ErrorProgramRun.txt", stackTrace + ": On" + DateTime.Now.ToString());
            }

        }
        //tetrashop.ir
        int[,] CloneATable(int[,] Tab)
        {
            Object O = new Object();
            lock (O)
            {
                int[,] Tabl = new int[8, 8];
                for (var i = 0; i < 8; i++)
                    for (var j = 0; j < 8; j++)
                        Tabl[i, j] = Tab[i, j];

                return Tabl;
            }
        }
        //tetrashop.ir
        void WaitCon()
        {
            do { } while (ConClick == -1);
        }
        //tetrashop.ir
        void WaitOnly()
        {
            do { } while (WaitOnplay);
        }
        public int Play(int i, int j)
        {
            Object o = new Object();
            lock (o)
            {



                try
                {
                    //tetrashop.ir
                    object f = new object();
                    lock (f)
                    {
                        if (freezBoard)
                            return 0;

                        if (AllDraw.CalIdle == 0)
                        {
                            ArtificialInteligenceMove.UpdateIsRunning = true;
                            RefrigtzChessPortable.AllDraw.CalIdle = 2;
                            return 0;
                        }
                        if (ArtificialInteligenceMove.UpdateIsRunning)
                        {
                            if (AllDraw.CalIdle == 2)
                            {
                                AllDraw.CalIdle = 1;
                                return 0;
                            }
                        }
                        else
                            if (!freezBoard)
                            return 0;

                    }
                    bool Com = false;
                    int k = 0;
                    int played = 0;

                    if (i == -1 && j == -1)
                    {
                        AllDraw.AllowedSupTrue = false;

                        Again:
                        AllDraw.NextRow = -1;
                        AllDraw.NextColumn = -1;
                        AllDraw.LastRow = -1;
                        AllDraw.LastColumn = -1;
                        CoPermit = false;
                        Person = false;

                        AllDraw.Blitz = true;





                        Table = brd.GetTable();




                        freezBoard = true;
                        var newTask = Task.Factory.StartNew(() => AliceAction(-1));
                        newTask.Wait();
                        newTask.Dispose();
                        if (Draw.TableZero(Table))
                        {
                            MessageBox.Show("Board is invalid;");
                            if (Draw.IsAtLeastAllObjectIsNull())
                            {
                                Draw.TableList.Clear();
                                Draw.TableList.Add(CloneATable(AllDraw.TableListAction[AllDraw.TableListAction.Count - 1]));
                                Draw.SetRowColumn(0);
                            }
                            Draw.IsCurrentDraw = true;
                            ThinkingRefrigtzChessPortable.NoOfMovableAllObjectMove++;

                            AllDraw.AStarGreedyiLevelMax = Draw.CurrentMaxLevel;
                            AllDraw.AllowedSupTrue = true;

                            if (ArtificialInteligenceMove.UpdateIsRunning)
                            {
                                if (AllDraw.CalIdle == 0)
                                    return 0;
                                if (AllDraw.CalIdle == 2)
                                {
                                    AllDraw.CalIdle = 1;
                                    return 0;
                                }
                            }
                            else
                            if (!freezBoard)
                                return 0;
                            //AllDraw.indexStep--;//no to axelirity speed

                            goto Again;
                        }
                        AllDraw.AllowedSupTrue = false;

                        if (ArtificialInteligenceMove.UpdateIsRunning)
                        {
                            if (AllDraw.CalIdle == 0)
                                return 0;
                            if (AllDraw.CalIdle == 2)
                            {
                                AllDraw.CalIdle = 1;
                                return 0;
                            }
                        }
                        else
                            if (!freezBoard)
                            return 0;


                        AllDraw.TableListAction.Add(CloneATable(Table));
                        R = new RefrigtzChessPortableGeneticAlgorithm(false, false, false, false, false, false, false, true);
                        if (R.FindGenToModified(AllDraw.TableListAction[AllDraw.TableListAction.Count - 2], AllDraw.TableListAction[AllDraw.TableListAction.Count - 1], AllDraw.TableListAction, 0, -1, true))
                        {

                            int ii = new int();
                            int jj = new int();
                            if (R.CromosomRowFirst == -1 || R.CromosomColumnFirst == -1 || R.CromosomRow == -1 || R.CromosomColumn == -1)
                            {
                                if (AllDraw.LastRow != -1 && AllDraw.LastColumn != -1 && AllDraw.NextRow != -1 && AllDraw.NextColumn != -1)
                                {
                                    R.CromosomRowFirst = AllDraw.LastRow;
                                    R.CromosomColumnFirst = AllDraw.LastColumn;
                                    R.CromosomRow = AllDraw.NextRow;
                                    R.CromosomColumn = AllDraw.NextColumn;

                                }
                                else
                                {
                                    MessageBox.Show("One or more cromosoms is invalid;");
                                    AllDraw.TableListAction.RemoveAt(AllDraw.TableListAction.Count - 1);
                                    if (Draw.IsAtLeastAllObjectIsNull())
                                    {
                                        Draw.TableList.Clear();
                                        Draw.TableList.Add(CloneATable(AllDraw.TableListAction[AllDraw.TableListAction.Count - 1]));
                                        Draw.SetRowColumn(0);
                                        Draw.IsCurrentDraw = true;
                                    }
                                    goto Again;
                                }
                            }

                            ii = R.CromosomRowFirst;
                            jj = R.CromosomColumnFirst;
                            i = ii;
                            j = jj;

                            k = brd.getInfo(i, j);
                            //if (k == 0)

                            cl = 0;
                            if (AllDraw.OrderPlateDraw == 1)
                                ThinkingRefrigtzChessPortable.NoOfBoardMovedGray++;
                            else
                                ThinkingRefrigtzChessPortable.NoOfBoardMovedBrown++;
                        }
                        else
                        {


                            {
                                MessageBox.Show("One or more DNA is invalid;");



                                AllDraw.TableListAction.RemoveAt(AllDraw.TableListAction.Count - 1);
                                Table = brd.GetTable();





                                goto Again;
                            }
                        }


                    }
                    else
                    {
                        CoPermit = true;
                        k = brd.getInfo(i, j);
                        //if (k == 0)

                    }
                    string lstr = " ";
                    if (k > 6)
                    {
                        played = 2;
                    }
                    else if (k < 7 && k != 0)
                    {
                        played = 1;
                    }
                    //tetrashop.ir
                    if (cl == 0 && k != 0 && played == order)
                    {
                        freezCalculation = true;

                        x1 = i;
                        y1 = j;
                        this.pb[i, j].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        cl = 1;
                        Object oo = new Object();
                        lock (oo)
                        {
                            if ((!Person) && i != -1 && j != -1)
                                ClickedSimAtClOne(i, j);
                        }
                        return 0;
                    }
                    if (cl == 1)
                    {
                        Board b = new Board();
                        int m = brd.getInfo(x1, y1);
                        King king2 = new King(order, x1, y1);
                        int y, z;
                        for (y = 0; y < 8; y++)
                            for (z = 0; z < 8; z++)
                                b.setSquare(brd.getInfo(y, z), y, z);
                        switch (m)
                        {
                            case 1:
                                Castle cs2 = new Castle(1, x1, y1);
                                if (cs2.move(brd, i, j) == 1)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(1, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "R";
                                    pb[x1, y1].Image = null;
                                    brd.setSquare(0, x1, y1);
                                    brd.setSquare(1, i, j);
                                    order++;
                                    if (brd.getbcolor(i, j) == 2)
                                    {
                                        pb[i, j].Image = img1;
                                    }
                                    else if (brd.getbcolor(i, j) == 1)
                                    {
                                        pb[i, j].Image = img2;
                                    }
                                    Com = true;
                                }
                                else
                                {
                                    cl = 0;
                                    pb[x1, y1].BorderStyle = 0;
                                    return 0;
                                }
                                break;
                            case 2:
                                Knight kn = new Knight(1, x1, y1);
                                if (kn.move(brd, i, j) == 1)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(2, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "N";
                                    pb[x1, y1].Image = null;
                                    brd.setSquare(0, x1, y1);
                                    brd.setSquare(2, i, j);
                                    order++;
                                    if (brd.getbcolor(i, j) == 2)
                                    {
                                        pb[i, j].Image = img3;
                                    }
                                    else if (brd.getbcolor(i, j) == 1)
                                    {
                                        pb[i, j].Image = img4;
                                    }
                                    Com = true;
                                }
                                else
                                {
                                    cl = 0;
                                    pb[x1, y1].BorderStyle = 0;
                                    return 0;
                                }
                                break;
                            case 3:
                                Bishop bsp = new Bishop(1, x1, y1);
                                if (bsp.move(brd, i, j) == 1)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(3, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "B";
                                    pb[x1, y1].Image = null;
                                    brd.setSquare(0, x1, y1);
                                    brd.setSquare(3, i, j);
                                    order++;
                                    if (brd.getbcolor(i, j) == 2)
                                    {
                                        pb[i, j].Image = img5;
                                    }
                                    else if (brd.getbcolor(i, j) == 1)
                                    {
                                        pb[i, j].Image = img6;
                                    }
                                    Com = true;
                                }
                                else
                                {
                                    cl = 0;
                                    pb[x1, y1].BorderStyle = 0;
                                    return 0;
                                }
                                break;
                            case 4:
                                Queen qn2 = new Queen(1, x1, y1);
                                if (qn2.move(brd, i, j) == 1)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(4, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "Q";
                                    pb[x1, y1].Image = null;
                                    brd.setSquare(0, x1, y1);
                                    brd.setSquare(4, i, j);
                                    order++;
                                    if (brd.getbcolor(i, j) == 2)
                                    {
                                        pb[i, j].Image = img7;
                                    }
                                    else if (brd.getbcolor(i, j) == 1)
                                    {
                                        pb[i, j].Image = img8;
                                    }
                                    Com = true;
                                }
                                else
                                {
                                    cl = 0;
                                    pb[x1, y1].BorderStyle = 0;
                                    return 0;
                                }
                                break;
                            case 5:
                                King kg2 = new King(1, x1, y1);
                                if (kg2.move(brd, i, j) == 1)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(5, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    pb[x1, y1].Image = null;
                                    brd.setSquare(0, x1, y1);
                                    brd.setSquare(5, i, j);
                                    order++;
                                    if (brd.getbcolor(i, j) == 2)
                                    {
                                        pb[i, j].Image = img9;
                                    }
                                    else if (brd.getbcolor(i, j) == 1)
                                    {
                                        pb[i, j].Image = img10;
                                    }
                                    Com = true;
                                }
                                else if (kg2.move(brd, i, j) == 2)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(5, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "0-0";
                                    pb[x1, y1].Image = null;
                                    pb[0, 0].Image = null;
                                    pb[2, 0].Image = img9;
                                    pb[3, 0].Image = img2;
                                    brd.setSquare(0, 0, 0);
                                    brd.setSquare(0, 4, 0);
                                    brd.setSquare(5, 2, 0);
                                    brd.setSquare(1, 3, 0);
                                    order++;
                                    Com = true;
                                }
                                else if (kg2.move(brd, i, j) == 3)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(5, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "0-0";
                                    pb[x1, y1].Image = null;
                                    pb[7, 0].Image = null;
                                    pb[5, 0].Image = img2;
                                    pb[6, 0].Image = img9;
                                    brd.setSquare(0, 4, 0);
                                    brd.setSquare(0, 7, 0);
                                    brd.setSquare(1, 5, 0);
                                    brd.setSquare(5, 6, 0);
                                    order++;
                                    Com = true;
                                }
                                else
                                {
                                    cl = 0;
                                    pb[x1, y1].BorderStyle = 0;
                                    return 0;
                                }
                                break;
                            case 6:
                                Pawn p = new Pawn(1, x1, y1);
                                if (p.move(brd, i, j) == 1)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(6, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "P";
                                    //tetrashop.ir
                                    if (j == 7 && CoPermit)
                                    {
                                        if (!ComStop)
                                        {
                                            InitConv(y1);
                                            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(WaitCon));
                                            t.Start();
                                            t.Join();
                                        }
                                        if (ConClick == 1)
                                        {
                                            brd.setSquare(0, x1, y1);
                                            brd.setSquare(4, i, j);
                                        }
                                        else
                                         if (ConClick == 2)
                                        {
                                            brd.setSquare(0, x1, y1);
                                            brd.setSquare(1, i, j);
                                        }
                                        else
                                        if (ConClick == 3)
                                        {
                                            brd.setSquare(0, x1, y1);
                                            brd.setSquare(2, i, j);
                                        }
                                        else
                                        if (ConClick == 4)
                                        {
                                            brd.setSquare(0, x1, y1);
                                            brd.setSquare(3, i, j);
                                        }

                                    }
                                    else
                                    {
                                        pb[x1, y1].Image = null;
                                        brd.setSquare(0, x1, y1);
                                        brd.setSquare(6, i, j);
                                    }
                                    order++;
                                    //tetrashop.ir
                                    if (ConClick != -1)
                                    {
                                        if (ConClick == 1)
                                        {
                                            if (brd.getbcolor(i, j) == 2)
                                            {
                                                pb[i, j].Image = img7;
                                            }
                                            else if (brd.getbcolor(i, j) == 1)
                                            {
                                                pb[i, j].Image = img8;
                                            }
                                        }
                                        else
                                               if (ConClick == 2)
                                        {
                                            if (brd.getbcolor(i, j) == 2)
                                            {
                                                pb[i, j].Image = img1;
                                            }
                                            else if (brd.getbcolor(i, j) == 1)
                                            {
                                                pb[i, j].Image = img2;
                                            }
                                        }
                                        else
                                        if (ConClick == 3)
                                        {
                                            if (brd.getbcolor(i, j) == 2)
                                            {
                                                pb[i, j].Image = img3;
                                            }
                                            else if (brd.getbcolor(i, j) == 1)
                                            {
                                                pb[i, j].Image = img4;
                                            }
                                        }
                                        else
                                        if (ConClick == 4)
                                        {
                                            if (brd.getbcolor(i, j) == 2)
                                            {
                                                pb[i, j].Image = img5;
                                            }
                                            else if (brd.getbcolor(i, j) == 1)
                                            {
                                                pb[i, j].Image = img6;
                                            }
                                        }
                                        ConClick = -1;
                                        DisposeConv();
                                    }
                                    else
                                    {
                                        if (brd.getbcolor(i, j) == 2)
                                        {
                                            pb[i, j].Image = img11;
                                        }
                                        else if (brd.getbcolor(i, j) == 1)
                                        {
                                            pb[i, j].Image = img12;
                                        }
                                    }
                                    Com = true;
                                }
                                else
                                {
                                    cl = 0;
                                    pb[x1, y1].BorderStyle = 0;
                                    return 0;
                                }
                                break;
                            case 7:
                                Castle cs = new Castle(2, x1, y1);
                                if (cs.move(brd, i, j) == 1)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(7, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "R";
                                    pb[x1, y1].Image = null;
                                    brd.setSquare(0, x1, y1);
                                    brd.setSquare(7, i, j);
                                    order--;
                                    if (brd.getbcolor(i, j) == 2)
                                    {
                                        pb[i, j].Image = img21;
                                    }
                                    else if (brd.getbcolor(i, j) == 1)
                                    {
                                        pb[i, j].Image = img22;
                                    }
                                    Com = true;
                                }
                                else
                                {
                                    cl = 0;
                                    pb[x1, y1].BorderStyle = 0;
                                    return 0;
                                }
                                break;
                            case 8:
                                Knight kn2 = new Knight(2, x1, y1);
                                if (kn2.move(brd, i, j) == 1)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(8, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "N";
                                    pb[x1, y1].Image = null;
                                    brd.setSquare(0, x1, y1);
                                    brd.setSquare(8, i, j);
                                    order--;
                                    if (brd.getbcolor(i, j) == 2)
                                    {
                                        pb[i, j].Image = img23;
                                    }
                                    else if (brd.getbcolor(i, j) == 1)
                                    {
                                        pb[i, j].Image = img24;
                                    }
                                    Com = true;
                                }
                                else
                                {
                                    cl = 0;
                                    pb[x1, y1].BorderStyle = 0;
                                    return 0;
                                }
                                break;
                            case 9:
                                Bishop bsp2 = new Bishop(2, x1, y1);
                                if (bsp2.move(brd, i, j) == 1)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(9, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "B";
                                    pb[x1, y1].Image = null;
                                    brd.setSquare(0, x1, y1);
                                    brd.setSquare(9, i, j);
                                    order--;
                                    if (brd.getbcolor(i, j) == 2)
                                    {
                                        pb[i, j].Image = img25;
                                    }
                                    else if (brd.getbcolor(i, j) == 1)
                                    {
                                        pb[i, j].Image = img26;
                                    }
                                    Com = true;
                                }
                                else
                                {
                                    cl = 0;
                                    pb[x1, y1].BorderStyle = 0;
                                    return 0;
                                }
                                break;
                            case 10:
                                Queen qn = new Queen(2, x1, y1);
                                if (qn.move(brd, i, j) == 1)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(10, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "Q";
                                    pb[x1, y1].Image = null;
                                    brd.setSquare(0, x1, y1);
                                    brd.setSquare(10, i, j);
                                    order--;
                                    if (brd.getbcolor(i, j) == 2)
                                    {
                                        pb[i, j].Image = img27;
                                    }
                                    else if (brd.getbcolor(i, j) == 1)
                                    {
                                        pb[i, j].Image = img28;
                                    }
                                    Com = true;
                                }
                                else
                                {
                                    cl = 0;
                                    pb[x1, y1].BorderStyle = 0;
                                    return 0;
                                }
                                break;
                            case 11:
                                King kg = new King(2, x1, y1);
                                if (kg.move(brd, i, j) == 1)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(11, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "K";
                                    pb[x1, y1].Image = null;
                                    brd.setSquare(0, x1, y1);
                                    brd.setSquare(11, i, j);
                                    order--;
                                    if (brd.getbcolor(i, j) == 2)
                                    {
                                        pb[i, j].Image = img29;
                                    }
                                    else if (brd.getbcolor(i, j) == 1)
                                    {
                                        pb[i, j].Image = img30;
                                    }
                                    Com = true;
                                }
                                else if (kg.move(brd, i, j) == 2)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(11, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "0-0";
                                    pb[x1, y1].Image = null;
                                    pb[0, 7].Image = null;
                                    pb[2, 7].Image = img30;
                                    pb[3, 7].Image = img21;
                                    brd.setSquare(0, 0, 7);
                                    brd.setSquare(0, 4, 7);
                                    brd.setSquare(11, 2, 7);
                                    brd.setSquare(5, 3, 7);
                                    order--;
                                    Com = true;
                                }
                                else if (kg.move(brd, i, j) == 3)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(11, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        this.pb[x1, y1].BorderStyle = 0;
                                        cl = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "0-0";
                                    pb[x1, y1].Image = null;
                                    pb[7, 7].Image = null;
                                    pb[5, 7].Image = img21;
                                    pb[6, 7].Image = img30;
                                    brd.setSquare(0, 4, 7);
                                    brd.setSquare(0, 7, 7);
                                    brd.setSquare(7, 5, 7);
                                    brd.setSquare(11, 6, 7);
                                    order--;
                                    Com = true;
                                }
                                else
                                {
                                    cl = 0;
                                    pb[x1, y1].BorderStyle = 0;
                                    return 0;
                                }
                                break;
                            case 12:
                                Pawn p2 = new Pawn(2, x1, y1);
                                if (p2.move(brd, i, j) == 1)
                                {
                                    b.setSquare(0, x1, y1);
                                    b.setSquare(12, i, j);
                                    if (king2.isChecked(b) == 1)
                                    {
                                        cl = 0;
                                        this.pb[x1, y1].BorderStyle = 0;
                                        MessageBox.Show("شما نمی توانید این حرکت را انجام دهید");
                                        return 0;
                                    }
                                    lstr = "P";
                                    //tetrashop.ir
                                    if (j == 0 && CoPermit)
                                    {
                                        if (!ComStop)
                                        {
                                            InitConv(y1);
                                            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(WaitCon));
                                            t.Start();
                                            t.Join();
                                        }
                                        if (ConClick == 1)
                                        {
                                            brd.setSquare(0, x1, y1);
                                            brd.setSquare(10, i, j);
                                        }
                                        else
                                         if (ConClick == 2)
                                        {
                                            brd.setSquare(0, x1, y1);
                                            brd.setSquare(8, i, j);
                                        }
                                        else
                                        if (ConClick == 3)
                                        {
                                            brd.setSquare(0, x1, y1);
                                            brd.setSquare(9, i, j);
                                        }
                                        else
                                        if (ConClick == 4)
                                        {
                                            brd.setSquare(0, x1, y1);
                                            brd.setSquare(10, i, j);
                                        }

                                    }
                                    else
                                    {
                                        pb[x1, y1].Image = null;
                                        brd.setSquare(0, x1, y1);
                                        brd.setSquare(12, i, j);
                                    }
                                    order--;
                                    //tetrashop.ir
                                    if (ConClick != -1)
                                    {
                                        if (ConClick == 1)
                                        {
                                            if (brd.getbcolor(i, j) == 2)
                                            {
                                                pb[i, j].Image = img27;
                                            }
                                            else if (brd.getbcolor(i, j) == 1)
                                            {
                                                pb[i, j].Image = img28;
                                            }
                                        }
                                        else
                                               if (ConClick == 2)
                                        {
                                            if (brd.getbcolor(i, j) == 2)
                                            {
                                                pb[i, j].Image = img21;
                                            }
                                            else if (brd.getbcolor(i, j) == 1)
                                            {
                                                pb[i, j].Image = img22;
                                            }
                                        }
                                        else
                                        if (ConClick == 3)
                                        {
                                            if (brd.getbcolor(i, j) == 2)
                                            {
                                                pb[i, j].Image = img23;
                                            }
                                            else if (brd.getbcolor(i, j) == 1)
                                            {
                                                pb[i, j].Image = img24;
                                            }
                                        }
                                        else
                                        if (ConClick == 4)
                                        {
                                            if (brd.getbcolor(i, j) == 2)
                                            {
                                                pb[i, j].Image = img25;
                                            }
                                            else if (brd.getbcolor(i, j) == 1)
                                            {
                                                pb[i, j].Image = img26;
                                            }
                                        }
                                        ConClick = -1;
                                        DisposeConv();
                                    }
                                    else
                                    {
                                        if (brd.getbcolor(i, j) == 2)
                                        {
                                            pb[i, j].Image = img31;
                                        }
                                        else if (brd.getbcolor(i, j) == 1)
                                        {
                                            pb[i, j].Image = img32;
                                        }
                                    }
                                    Com = true;
                                }
                                else
                                {
                                    cl = 0;
                                    pb[x1, y1].BorderStyle = 0;
                                    return 0;
                                }
                                break;
                        }
                        //tetrashop.ir
                        RefrigtzChessPortable.ThinkingRefrigtzChessPortable.TableInitiationPreventionOfMultipleMove[x1, y1]++;
                        RefrigtzChessPortable.ThinkingRefrigtzChessPortable.TableInitiationPreventionOfMultipleMove[i, j]++;

                        this.pb[x1, y1].BorderStyle = 0;
                        cl = 0;
                        string str, str2;
                        King king = new King(order, x1, y1);
                        if (order == 1)
                        {
                            str = "سیاه";
                            str2 = "سفید";
                        }
                        else
                        {
                            str = "سفید";
                            str2 = "سیاه";
                        }
                        string lstr2 = " ", lstr3 = " ";
                        switch (i)
                        {
                            case 0:
                                lstr2 = "h";
                                break;
                            case 1:
                                lstr2 = "g";
                                break;
                            case 2:
                                lstr2 = "f";
                                break;
                            case 3:
                                lstr2 = "e";
                                break;
                            case 4:
                                lstr2 = "d";
                                break;
                            case 5:
                                lstr2 = "c";
                                break;
                            case 6:
                                lstr2 = "b";
                                break;
                            case 7:
                                lstr2 = "a";
                                break;
                        }
                        switch (x1)
                        {
                            case 0:
                                lstr3 = "h";
                                break;
                            case 1:
                                lstr3 = "g";
                                break;
                            case 2:
                                lstr3 = "f";
                                break;
                            case 3:
                                lstr3 = "e";
                                break;
                            case 4:
                                lstr3 = "d";
                                break;
                            case 5:
                                lstr3 = "c";
                                break;
                            case 6:
                                lstr3 = "b";
                                break;
                            case 7:
                                lstr3 = "a";
                                break;
                        }
                        if (king.isChecked(brd) == 1)
                        {
                            if (brd.isMated(order) == 1)
                            {
                                this.lb.Items.AddRange(new object[] { lstr });
                                lstr = str2 + " " + lstr + " " + lstr3 + (y1 + 1).ToString() + " To " + lstr2 + (j + 1).ToString() + " Hu:" + AllDraw.Less.ToString();
                                MessageBox.Show(str + " " + "مات شد");
                                Application.Exit();
                            }
                            else
                            {
                                lstr = str2 + " کیش  " + lstr + " " + lstr3 + (y1 + 1).ToString() + " To " + lstr2 + (j + 1).ToString() + " Hu:" + AllDraw.Less.ToString();
                                this.lb.Items.AddRange(new object[] { lstr });
                                MessageBox.Show(" کیش توسط" + " " + str2);
                                //tetrashop.ir
                                Object oo = new Object();
                                lock (oo)
                                {
                                    if (Com && (order == 1))
                                    {

                                        MovmentsNumber++;
                                        AllDraw.MaxAStarGreedy = 0;


                                        Table = brd.GetTable();
                                        ClearTableInitiationPreventionOfMultipleMove();
                                        RefrigtzChessPortable.AllDraw.TableListAction.Add(CloneATable(brd.GetTable()));

                                        AllDraw.OrderPlate = OrderPlate;
                                        int Ord = OrderPlate;
                                        Color aa = Color.Gray;
                                        if (Ord == -1)
                                            aa = Color.Brown;
                                        bool B = AllDraw.Blitz;
                                        AllDraw.Blitz = false;
                                        //RefrigtzChessPortable.AllDraw.MaxAStarGreedy = 0; // PlatformHelper.ProcessorCount; //PlatformHelper.ProcessorCount;

                                        AllDraw thiB = Draw.AStarGreedyString;
                                        if (Draw.IsAtLeastAllObjectIsNull())
                                        {
                                            Draw.TableList.Clear();
                                            Draw.TableList.Add(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]));
                                            Draw.SetRowColumn(0);
                                            Draw.IsCurrentDraw = true;
                                        }
                                        Draw.AStarGreedyString = thiB;
                                        object n = new object();
                                        lock (n)
                                        {
                                            AllDraw.ChangedInTreeOccured = false;

                                        }
                                        AllDraw.StoreInitMaxAStarGreedy = Draw.CurrentMaxLevel; AllDraw.MaxAStarGreedy = 0;
                                        Draw.InitiateAStarGreedyt(PlatformHelper.ProcessorCount + AllDraw.StoreInitMaxAStarGreedy - AllDraw.MaxAStarGreedy, 0, 0, aa, CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]), Ord, false, FOUND, 0);

                                        AllDraw.Blitz = B;

                                        System.Threading.Thread tt = new System.Threading.Thread(new System.Threading.ThreadStart(SetDrawFound));
                                        tt.Start();
                                        tt.Join();
                                        tt.Abort();

                                        AllDraw.OrderPlate = -1; OrderPlate = -1;
                                        if (!ComStop)
                                        {
                                            Play(-1, -1);

                                            ArtificialInteligenceMove.UpdateIsRunning = false;
                                            RefrigtzChessPortable.AllDraw.CalIdle = 0;
                                        }

                                        freezCalculation = false;
                                    }
                                    else
                              if (Com && (order == 2))
                                    {
                                        if (ComStop && (!freezBoard))
                                            AllDraw.TableListAction.Add(CloneATable(brd.GetTable()));

                                        freezBoard = false;

                                        MovmentsNumber++;
                                        Table = brd.GetTable();
                                        ClearTableInitiationPreventionOfMultipleMove();

                                        System.Threading.Thread tt = new System.Threading.Thread(new System.Threading.ThreadStart(SetDrawFound));
                                        tt.Start();
                                        tt.Join();
                                        tt.Abort();
                                        AllDraw.OrderPlate = 1; OrderPlate = 1;

                                        ArtificialInteligenceMove.UpdateIsRunning = true;
                                        RefrigtzChessPortable.AllDraw.CalIdle = 1;

                                        freezCalculation = false;

                                    }
                                }
                            }
                        }
                        else
                        {
                            lstr = str2 + " " + lstr + " " + lstr3 + (y1 + 1).ToString() + " To " + lstr2 + (j + 1).ToString() + " Hu:" + AllDraw.Less.ToString();
                            this.lb.Items.AddRange(new object[] { lstr });
                        }
                        //tetrashop.ir
                        Object oi = new Object();
                        lock (oi)
                        {
                            if (Com && (order == 1))
                            {
                                MovmentsNumber++;


                                Table = brd.GetTable();
                                ClearTableInitiationPreventionOfMultipleMove();
                                RefrigtzChessPortable.AllDraw.TableListAction.Add(CloneATable(brd.GetTable()));


                                AllDraw.OrderPlate = OrderPlate;
                                int Ord = OrderPlate;
                                Color aa = Color.Gray;
                                if (Ord == -1)
                                    aa = Color.Brown;
                                bool B = AllDraw.Blitz;
                                AllDraw.Blitz = false;
                                //RefrigtzChessPortable.AllDraw.MaxAStarGreedy = 0; // PlatformHelper.ProcessorCount; //PlatformHelper.ProcessorCount;

                                AllDraw thiB = Draw.AStarGreedyString;
                                if (Draw.IsAtLeastAllObjectIsNull())
                                {
                                    Draw.TableList.Clear();
                                    Draw.TableList.Add(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]));
                                    Draw.SetRowColumn(0);
                                    Draw.IsCurrentDraw = true;
                                }
                                Draw.AStarGreedyString = thiB;

                                object n = new object();
                                lock (n)
                                {
                                    AllDraw.ChangedInTreeOccured = false;

                                }
                                AllDraw.StoreInitMaxAStarGreedy = Draw.CurrentMaxLevel;
                                Draw.InitiateAStarGreedyt(PlatformHelper.ProcessorCount + AllDraw.StoreInitMaxAStarGreedy - AllDraw.MaxAStarGreedy, 0, 0, aa, CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]), Ord, false, FOUND, 0);



                                AllDraw.Blitz = B;

                                System.Threading.Thread tt = new System.Threading.Thread(new System.Threading.ThreadStart(SetDrawFound));
                                tt.Start();
                                tt.Join();
                                tt.Abort();

                                AllDraw.OrderPlate = -1; OrderPlate = -1;


                                if (!ComStop)
                                {
                                    Play(-1, -1);

                                    ArtificialInteligenceMove.UpdateIsRunning = false;
                                    RefrigtzChessPortable.AllDraw.CalIdle = 0;
                                }
                                freezCalculation = false;
                            }
                            else
                              if (Com && (order == 2))
                            {


                                if (ComStop && (!freezBoard))
                                    AllDraw.TableListAction.Add(CloneATable(brd.GetTable()));
                                freezBoard = false;
                                Table = brd.GetTable();
                                MovmentsNumber++;
                                ClearTableInitiationPreventionOfMultipleMove();

                                System.Threading.Thread tt = new System.Threading.Thread(new System.Threading.ThreadStart(SetDrawFound));
                                tt.Start();
                                tt.Join();
                                tt.Abort();
                                AllDraw.OrderPlate = 1; OrderPlate = 1;
                                ArtificialInteligenceMove.UpdateIsRunning = true;
                                RefrigtzChessPortable.AllDraw.CalIdle = 1;
                                freezCalculation = false;
                            }
                        }
                        return 0;
                    }
                }
                catch (Exception t) { Log(t); return -1; }
                return 0;
            }
        }
        //tetrashop.ir
        void Wait()
        {
            Object O = new Object();
            lock (O)
            {
                PerformanceCounter myAppCpu =
                    new PerformanceCounter(
                        "Process", "% Processor Time", Process.GetCurrentProcess().ProcessName, true);

                do { WaitOnplay = true; } while (myAppCpu.NextValue() != 0);
                WaitOnplay = false;
            }
        }

        #region These are the Click events for Picture Boxes in the form
        private void Con1_Click1(object sender, System.EventArgs e)
        {
            ConClick = 1;
        }
        private void Con2_Click1(object sender, System.EventArgs e)
        {
            ConClick = 2;
        }
        private void Con3_Click1(object sender, System.EventArgs e)
        {
            ConClick = 3;
        }
        private void Con4_Click1(object sender, System.EventArgs e)
        {
            ConClick = 4;
        }
        private void Pb_Click1(object sender, System.EventArgs e)
        {
            Play(0, 0);
        }
        private void Pb_Click2(object sender, System.EventArgs e)
        {
            Play(1, 0);
        }
        private void Pb_Click3(object sender, System.EventArgs e)
        {
            Play(2, 0);
        }
        private void Pb_Click4(object sender, System.EventArgs e)
        {
            Play(3, 0);
        }
        private void Pb_Click5(object sender, System.EventArgs e)
        {
            Play(4, 0);
        }
        private void Pb_Click6(object sender, System.EventArgs e)
        {
            Play(5, 0);
        }
        private void Pb_Click7(object sender, System.EventArgs e)
        {
            Play(6, 0);
        }
        private void Pb_Click8(object sender, System.EventArgs e)
        {
            Play(7, 0);
        }
        private void Pb_Click9(object sender, System.EventArgs e)
        {
            Play(0, 1);
        }
        private void Pb_Click10(object sender, System.EventArgs e)
        {
            Play(1, 1);
        }
        private void Pb_Click11(object sender, System.EventArgs e)
        {
            Play(2, 1);
        }
        private void Pb_Click12(object sender, System.EventArgs e)
        {
            Play(3, 1);
        }
        private void Pb_Click13(object sender, System.EventArgs e)
        {
            Play(4, 1);
        }
        private void Pb_Click14(object sender, System.EventArgs e)
        {
            Play(5, 1);
        }
        private void Pb_Click15(object sender, System.EventArgs e)
        {
            Play(6, 1);
        }
        private void Pb_Click16(object sender, System.EventArgs e)
        {
            Play(7, 1);
        }
        private void Pb_Click17(object sender, System.EventArgs e)
        {
            Play(0, 2);
        }
        private void Pb_Click18(object sender, System.EventArgs e)
        {
            Play(1, 2);
        }
        private void Pb_Click19(object sender, System.EventArgs e)
        {
            Play(2, 2);
        }
        private void Pb_Click20(object sender, System.EventArgs e)
        {
            Play(3, 2);
        }
        private void Pb_Click21(object sender, System.EventArgs e)
        {
            Play(4, 2);
        }

        private void Pb_Click22(object sender, System.EventArgs e)
        {
            Play(5, 2);
        }
        private void Pb_Click23(object sender, System.EventArgs e)
        {
            Play(6, 2);
        }
        private void Pb_Click24(object sender, System.EventArgs e)
        {
            Play(7, 2);
        }
        private void Pb_Click25(object sender, System.EventArgs e)
        {
            Play(0, 3);
        }
        private void Pb_Click26(object sender, System.EventArgs e)
        {
            Play(1, 3);
        }
        private void Pb_Click27(object sender, System.EventArgs e)
        {
            Play(2, 3);
        }
        private void Pb_Click28(object sender, System.EventArgs e)
        {
            Play(3, 3);
        }
        private void Pb_Click29(object sender, System.EventArgs e)
        {
            Play(4, 3);
        }

        private void Pb_Click30(object sender, System.EventArgs e)
        {
            Play(5, 3);
        }
        private void Pb_Click31(object sender, System.EventArgs e)
        {
            Play(6, 3);
        }
        private void Pb_Click32(object sender, System.EventArgs e)
        {
            Play(7, 3);
        }
        private void Pb_Click33(object sender, System.EventArgs e)
        {
            Play(0, 4);
        }
        private void Pb_Click34(object sender, System.EventArgs e)
        {
            Play(1, 4);
        }
        private void Pb_Click35(object sender, System.EventArgs e)
        {
            Play(2, 4);
        }
        private void Pb_Click36(object sender, System.EventArgs e)
        {
            Play(3, 4);
        }
        private void Pb_Click37(object sender, System.EventArgs e)
        {
            Play(4, 4);
        }

        private void Pb_Click38(object sender, System.EventArgs e)
        {
            Play(5, 4);
        }
        private void Pb_Click39(object sender, System.EventArgs e)
        {
            Play(6, 4);
        }
        private void Pb_Click40(object sender, System.EventArgs e)
        {
            Play(7, 4);
        }
        private void Pb_Click41(object sender, System.EventArgs e)
        {
            Play(0, 5);
        }
        private void Pb_Click42(object sender, System.EventArgs e)
        {
            Play(1, 5);
        }
        private void Pb_Click43(object sender, System.EventArgs e)
        {
            Play(2, 5);
        }
        private void Pb_Click44(object sender, System.EventArgs e)
        {
            Play(3, 5);
        }
        private void Pb_Click45(object sender, System.EventArgs e)
        {
            Play(4, 5);
        }

        private void Pb_Click46(object sender, System.EventArgs e)
        {
            Play(5, 5);
        }
        private void Pb_Click47(object sender, System.EventArgs e)
        {
            Play(6, 5);
        }
        private void Pb_Click48(object sender, System.EventArgs e)
        {
            Play(7, 5);
        }
        private void Pb_Click49(object sender, System.EventArgs e)
        {
            Play(0, 6);
        }
        private void Pb_Click50(object sender, System.EventArgs e)
        {
            Play(1, 6);
        }
        private void Pb_Click51(object sender, System.EventArgs e)
        {
            Play(2, 6);
        }
        private void Pb_Click52(object sender, System.EventArgs e)
        {
            Play(3, 6);
        }
        private void Pb_Click53(object sender, System.EventArgs e)
        {
            Play(4, 6);
        }

        private void Pb_Click54(object sender, System.EventArgs e)
        {
            Play(5, 6);
        }
        private void Pb_Click55(object sender, System.EventArgs e)
        {
            Play(6, 6);
        }
        private void Pb_Click56(object sender, System.EventArgs e)
        {
            Play(7, 6);
        }
        private void Pb_Click57(object sender, System.EventArgs e)
        {
            Play(0, 7);
        }
        private void Pb_Click58(object sender, System.EventArgs e)
        {
            Play(1, 7);
        }
        private void Pb_Click59(object sender, System.EventArgs e)
        {
            Play(2, 7);
        }
        private void Pb_Click60(object sender, System.EventArgs e)
        {
            Play(3, 7);
        }
        private void Pb_Click61(object sender, System.EventArgs e)
        {
            Play(4, 7);
        }
        private void Pb_Click62(object sender, System.EventArgs e)
        {
            Play(5, 7);
        }
        private void Pb_Click63(object sender, System.EventArgs e)
        {
            Play(6, 7);
        }
        private void Pb_Click64(object sender, System.EventArgs e)
        {
            Play(7, 7);
        }
        #endregion
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefrigtzChessPortableForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.junglesMakeTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogjunglesMakeTree = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //tetrashop.ir
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //tetrashop.ir
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treeViewToolStripMenuItem,
            this.junglesMakeTreeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "View";
            //tetrashop.ir
            // 
            // treeViewToolStripMenuItem
            // 
            this.treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            this.treeViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.treeViewToolStripMenuItem.Text = "Tree View";
            this.treeViewToolStripMenuItem.Click += new System.EventHandler(this.treeViewToolStripMenuItem_Click);
            //tetrashop.ir
            // 
            // junglesMakeTreeToolStripMenuItem
            // 
            this.junglesMakeTreeToolStripMenuItem.Name = "junglesMakeTreeToolStripMenuItem";
            this.junglesMakeTreeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.junglesMakeTreeToolStripMenuItem.Text = "Jungles make Tree";
            this.junglesMakeTreeToolStripMenuItem.Click += new System.EventHandler(this.junglesMakeTreeToolStripMenuItem_Click);
            //tetrashop.ir
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.AboutHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.helpToolStripMenuItem.Text = "راهنما";
            //tetrashop.ir
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.AboutToolStripMenuItem.Text = "درباره";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            //tetrashop.ir
            // 
            // AboutHelpToolStripMenuItem
            // 
            this.AboutHelpToolStripMenuItem.Name = "AboutHelpToolStripMenuItem";
            this.AboutHelpToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.AboutHelpToolStripMenuItem.Text = "درباره یاری ";
            this.AboutHelpToolStripMenuItem.Click += new System.EventHandler(this.AboutHelpToolStripMenuItem_Click);
            //tetrashop.ir
            // 
            // openFileDialogjunglesMakeTree
            // 
            this.openFileDialogjunglesMakeTree.Filter = "asd|*asd";
            // 
            // RefrigtzChessPortableForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RefrigtzChessPortableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //tetrashop.ir
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutBoxRefrigtzChessPortableRefrigitz()).ShowDialog();
        }
        //tetrashop.ir
        private void AboutHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutBoxFaraDars()).ShowDialog();
        }
        //tetrashop.ir
        public RefrigtzChessPortable.AllDraw RootFound()
        {
            Object O = new Object();
            lock (O)
            {
                try
                {
                    if (Draw != null)
                    {
                        while (Draw.AStarGreedyString != null)
                        {
                            Draw = Draw.AStarGreedyString;
                        }
                    }
                }
                catch (Exception t) { Log(t); }
                return Draw;
            }
        }
        //tetrashop.ir
        public void SetDrawFounding(ref bool FOUNDI, ref RefrigtzChessPortable.AllDraw THISI, bool FirstI)
        {
            /*    Object OO = new Object();
                lock (OO)
                {
                    if (Draw == null)
                        return;
                    int Dummy = OrderPlate;

                    RefrigtzChessPortable.AllDraw THISB = Draw.AStarGreedyString;
                    RefrigtzChessPortable.AllDraw THISStore = Draw;
                    //while (Draw.AStarGreedyString != null)
                    bool FOUND = false;
                    RefrigtzChessPortable.AllDraw THIS = null;
                    bool First = false;



                    Object O = new Object();
                    lock (O)
                    {
                        FOUND = false;
                        THIS = null;
                        Color a = Color.Brown;
                        //if (First)

                        //else
                        int Ord = OrderPlate;
                        AllDraw.OrderPlate = Ord;
                        var output = Task.Factory.StartNew(() => Draw.FoundOfCurrentTableNode(CloneATable(Table), Ord, ref THIS, ref FOUND));
                        output.Wait();
                        output.Dispose();
                        if (FOUND)
                        {
                            Draw = THIS;



                            bool LoadTree = true;
                            Ord = OrderPlate;
                            //if (MovmentsNumber > 1)
                            (new TakeRoot()).Save(FOUND, false, this, ref LoadTree, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);

                            Draw.IsCurrentDraw = true;


                        }
                        else
                        {
                            FOUND = false;

                            a = Color.Brown;
                            while (Draw.AStarGreedyString != null)
                                Draw = Draw.AStarGreedyString;

                            bool FirstS = false;
                            if ((RefrigtzChessPortable.AllDraw.TableListAction.Count > 2))
                            {
                                Ord = OrderPlate * -1;
                                AllDraw.OrderPlate = Ord;
                                OrderPlate = Ord;

                                Color aa = Color.Gray;
                                if (Ord == -1)
                                    aa = Color.Brown;
                                output = Task.Factory.StartNew(() => Draw.FoundOfCurrentTableNode(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 2]), Ord, ref THIS, ref FOUND));
                                output.Wait();
                                output.Dispose();
                            }
                            else
                            if ((RefrigtzChessPortable.AllDraw.TableListAction.Count >= 1))
                            {
                                output = Task.Factory.StartNew(() => Draw.FoundOfCurrentTableNode(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]), Ord, ref THIS, ref FOUND));
                                output.Wait();
                                output.Dispose();
                                FirstS = true;
                            }


                            if (FOUND)
                            {
                                Draw = THIS;

                                Draw.IsCurrentDraw = true;




                                bool Store = Deeperthandeeper;
                                Deeperthandeeper = false;


                                Color aa = Color.Gray;
                                if (Ord == -1)
                                    aa = Color.Brown;
                                bool B = AllDraw.Blitz;
                                AllDraw.Blitz = false;
                                //RefrigtzChessPortable.AllDraw.MaxAStarGreedy = 0; // PlatformHelper.ProcessorCount; //PlatformHelper.ProcessorCount;

                                if (!FirstS)
                                {

                                    AllDraw thiB = Draw.AStarGreedyString;
                                    if (Draw.IsAtLeastAllObjectIsNull())
                                    {
                                        Draw.TableList.Clear();
                                        Draw.TableList.Add(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 2]));
                                        Draw.SetRowColumn(0);
                                        Draw.IsCurrentDraw = true;
                                    }
                                    Draw.AStarGreedyString = thiB;


                                    output = Task.Factory.StartNew(() => Draw.InitiateAStarGreedyt(PlatformHelper.ProcessorCount+AllDraw.StoreInitMaxAStarGreedy-AllDraw.MaxAStarGreedy, 0, 0, aa, CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 2]), Ord, false, FOUND, 0));
                                    output.Wait();
                                    output.Dispose();
                                }
                                else
                                {
                                    FOUND = false;

                                    AllDraw thiB = Draw.AStarGreedyString;
                                    if (Draw.IsAtLeastAllObjectIsNull())
                                    {
                                        Draw.TableList.Clear();
                                        Draw.TableList.Add(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]));
                                        Draw.SetRowColumn(0);
                                        Draw.IsCurrentDraw = true;
                                    }
                                    Draw.AStarGreedyString = thiB;


                                    output = Task.Factory.StartNew(() => Draw.InitiateAStarGreedyt(PlatformHelper.ProcessorCount+AllDraw.StoreInitMaxAStarGreedy-AllDraw.MaxAStarGreedy, 0, 0, aa, CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]), Ord, false, FOUND, 0));
                                    output.Wait();
                                    output.Dispose();
                                }
                                AllDraw.Blitz = B;
                                Deeperthandeeper = Store;
                                //while (Draw.AStarGreedyString != null)

                                FOUND = false;
                                if (!First && (RefrigtzChessPortable.AllDraw.TableListAction.Count > 2))
                                {
                                    Ord = OrderPlate * -1;
                                    AllDraw.OrderPlate = Ord;
                                    OrderPlate = Ord;
                                }
                                output = Task.Factory.StartNew(() => Draw.FoundOfCurrentTableNode(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]), Ord, ref THIS, ref FOUND));
                                output.Wait();
                                output.Dispose();

                                if (FOUND)
                                {
                                    Draw = THIS;





                                    bool LoadTree = true;
                                    (new TakeRoot()).Save(FOUND, false, this, ref LoadTree, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);
                                    AllDraw.OrderPlate = Ord;



                                }
                                else
                                {
                                    Draw = THISStore;
                                    if (MovmentsNumber == 1)
                                        NotFoundBegin = true;

                                    bool LoadTree = true;


                                    Draw.TableList.Clear();
                                    Draw.TableList.Add(CloneATable(Table));
                                    Draw.SetRowColumn(0);
                                    Draw.IsCurrentDraw = true;
                                    Draw.AStarGreedyString = THISB;
                                    RefrigtzChessPortable.ChessRules.CurrentOrder = OrderPlate;
                                    RefrigtzChessPortable.AllDraw.DepthIterative = 0;
                                    (new TakeRoot()).Save(FOUND, false, this, ref LoadTree, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);


                                }
                            }
                            else
                            {
                                Draw = THISStore;
                                if (MovmentsNumber == 1)
                                    NotFoundBegin = true;
                                OrderPlate = Dummy;

                                bool LoadTree = true;


                                Draw.TableList.Clear();
                                Draw.TableList.Add(CloneATable(Table));
                                Draw.SetRowColumn(0);
                                Draw.IsCurrentDraw = true;
                                Draw.AStarGreedyString = THISB;
                                RefrigtzChessPortable.ChessRules.CurrentOrder = OrderPlate;
                                RefrigtzChessPortable.AllDraw.DepthIterative = 0;
                                (new TakeRoot()).Save(FOUND, false, this, ref LoadTree, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);


                            }
                        }
                    }

                    if (RefrigtzChessPortable.AllDraw.FirstTraversalTree)
                        FOUND = false;
                    FOUNDI = FOUND;
                    THISI = THIS;
                    FirstI = First;
                    DrawManagement();
                }
    */

            Object OO = new Object();
            lock (OO)
            {
                if (Draw == null)
                    return;
                int Dummy = OrderPlate;

                RefrigtzChessPortable.AllDraw.StoreInitMaxAStarGreedy = Draw.CurrentMaxLevel; AllDraw.MaxAStarGreedy = 0;

                RefrigtzChessPortable.AllDraw THISB = Draw.AStarGreedyString;
                RefrigtzChessPortable.AllDraw THISStore = Draw;
                //while (Draw.AStarGreedyString != null)
                bool FOUND = false;
                RefrigtzChessPortable.AllDraw THIS = null;
                bool First = false;



                Object O = new Object();
                lock (O)
                {
                    FOUND = false;
                    THIS = null;
                    Color a = Color.Brown;
                    //if (First)

                    //else
                    int Ord = OrderPlate;
                    AllDraw.OrderPlate = Ord;
                    var output = Task.Factory.StartNew(() => Draw.FoundOfCurrentTableNode(CloneATable(Table), Ord, ref THIS, ref FOUND));
                    output.Wait();
                    output.Dispose();
                    if (FOUND)
                    {
                        Draw = THIS;



                        bool LoadTree = true;
                        Ord = OrderPlate;
                        //if (MovmentsNumber > 1)
                        (new TakeRoot()).Save(FOUND, false, this, ref LoadTree, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);

                        Draw.IsCurrentDraw = true;


                    }
                    else
                    {
                        bool Store = Deeperthandeeper;
                        Deeperthandeeper = false;


                        Color aa = Color.Gray;
                        if (Ord == -1)
                            aa = Color.Brown;
                        bool B = AllDraw.Blitz;
                        AllDraw.Blitz = false;
                        //RefrigtzChessPortable.AllDraw.MaxAStarGreedy = PlatformHelper.ProcessorCount * 2;

                        FOUND = false;

                        AllDraw thiB = Draw.AStarGreedyString;
                        if (Draw.IsAtLeastAllObjectIsNull())
                        {
                            Draw.TableList.Clear();
                            Draw.TableList.Add(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]));
                            Draw.SetRowColumn(0);
                            Draw.IsCurrentDraw = true;
                        }
                        Draw.AStarGreedyString = thiB;

                        object n = new object();
                        lock (n)
                        {
                            AllDraw.ChangedInTreeOccured = false;

                        }
                        AllDraw.StoreInitMaxAStarGreedy = Draw.CurrentMaxLevel; AllDraw.MaxAStarGreedy = 0;

                        output = Task.Factory.StartNew(() => Draw.InitiateAStarGreedyt(PlatformHelper.ProcessorCount + AllDraw.StoreInitMaxAStarGreedy - AllDraw.MaxAStarGreedy, 0, 0, aa, CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]), Ord, false, FOUND, 0));
                        output.Wait();
                        output.Dispose();
                        AllDraw.Blitz = B;
                        Deeperthandeeper = Store;
                        //while (Draw.AStarGreedyString != null)

                        FOUND = false;


                        output = Task.Factory.StartNew(() => Draw.FoundOfCurrentTableNode(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]), Ord, ref THIS, ref FOUND));
                        output.Wait();
                        output.Dispose();

                        if (FOUND)
                        {
                            Draw = THIS;





                            bool LoadTree = true;
                            (new TakeRoot()).Save(FOUND, false, this, ref LoadTree, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);
                            AllDraw.OrderPlate = Ord;



                        }
                        else
                        {
                            Draw = THISStore;
                            if (MovmentsNumber == 1)
                                NotFoundBegin = true;

                            bool LoadTree = true;


                            THISB = Draw.AStarGreedyString;
                            if (Draw.IsAtLeastAllObjectIsNull())
                            {
                                Draw.TableList.Clear();
                                Draw.TableList.Add(CloneATable(RefrigtzChessPortable.AllDraw.TableListAction[RefrigtzChessPortable.AllDraw.TableListAction.Count - 1]));
                                Draw.SetRowColumn(0);
                                Draw.IsCurrentDraw = true;
                            }
                            Draw.AStarGreedyString = THISB;
                            RefrigtzChessPortable.ChessRules.CurrentOrder = OrderPlate;
                            RefrigtzChessPortable.AllDraw.DepthIterative = 0;
                            (new TakeRoot()).Save(FOUND, false, this, ref LoadTree, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);


                        }

                    }
                }

                if (RefrigtzChessPortable.AllDraw.FirstTraversalTree)
                    FOUND = false;
                FOUNDI = FOUND;
                THISI = THIS;
                FirstI = First;
                DrawManagement();
            }

        }
        //tetrashop.ir
        bool DrawManagement()
        {
            Object OO = new Object();
            lock (OO)
            {
                SetAllDrawKind();
                //Set Configuration To True for some unknown reason!.

                SetAllDrawKindString();
                bool Found = false;
                String P = Path.GetFullPath(path3);
                AllDrawReplacement = Path.Combine(P, AllDrawKindString);
                Logger y = new Logger(AllDrawReplacement);

                y = new Logger(AllDrawKindString);

                if (File.Exists(AllDrawReplacement))
                {
                    if (AllDraw.HarasAct)
                        File.Delete(AllDrawReplacement);
                }
                if (File.Exists(AllDrawKindString))
                {
                    if (AllDraw.HarasAct)
                        File.Delete(AllDrawKindString);

                }
                AllDraw.HarasAct = false;

                if (File.Exists(AllDrawKindString))
                {
                    if (AllDraw.HarasAct)
                    {
                        AllDraw.HarasAct = false;
                        File.Delete(AllDrawReplacement);
                    }
                }
                if (!NotFoundBegin)
                {
                    if (File.Exists(AllDrawKindString))
                    {
                        if (File.Exists(AllDrawReplacement))
                        {
                            if (((new System.IO.FileInfo(AllDrawKindString).Length) < (new System.IO.FileInfo(AllDrawReplacement)).Length))
                            {
                                File.Delete(AllDrawKindString);
                                File.Copy(AllDrawReplacement, AllDrawKindString);
                                Found = true;
                            }
                            else if (((new System.IO.FileInfo(AllDrawKindString).Length) > (new System.IO.FileInfo(AllDrawReplacement)).Length))
                            {
                                if (File.Exists(AllDrawReplacement))
                                    File.Delete(AllDrawReplacement);
                                File.Copy(AllDrawKindString, AllDrawReplacement);
                                Found = true;
                            }
                        }
                        else
                        {
                            if (!Directory.Exists(Path.GetFullPath(path3)))
                                Directory.CreateDirectory(Path.GetFullPath(path3));
                            File.Copy(AllDrawKindString, AllDrawReplacement);
                            Found = true;
                        }
                        Found = true;
                    }
                    else if (File.Exists(AllDrawReplacement))
                    {
                        File.Copy(AllDrawReplacement, AllDrawKindString);
                        Found = true;
                    }
                }
                else
                {
                    if (File.Exists(AllDrawKindString))
                        File.Delete(AllDrawKindString);
                    if (File.Exists(AllDrawReplacement))
                        File.Delete(AllDrawReplacement);
                    NotFoundBegin = false;
                }
                return Found;
            }
        }
        //tetrashop.ir
        void SetAllDrawKindString()
        {
            Object O = new Object();
            lock (O)
            {
                if (AllDrawKind == 4)
                    AllDrawKindString = "S_AllDrawBT.asd";
                else
                if (AllDrawKind == 3)
                    AllDrawKindString = "S_AllDrawFFST.asd";
                else
                if (AllDrawKind == 2)
                    AllDrawKindString = "S_AllDrawFTSF.asd";
                else
                if (AllDrawKind == 1)
                    AllDrawKindString = "S_AllDrawFFSF.asd";

            }
        }
        //tetrashop.ir
        void SetAllDrawKind()
        {
            Object O = new Object();
            lock (O)
            {
                if (UsePenaltyRegardMechnisam && AStarGreedyHeuristic)
                    AllDrawKind = 4;
                else
          if ((!UsePenaltyRegardMechnisam) && AStarGreedyHeuristic)
                    AllDrawKind = 3;
                if (UsePenaltyRegardMechnisam && (!AStarGreedyHeuristic))
                    AllDrawKind = 2;
                if ((!UsePenaltyRegardMechnisam) && (!AStarGreedyHeuristic))
                    AllDrawKind = 1;
            }
        }
        //tetrashop.ir
        void SetDrawFound()
        {
            Object O = new Object();
            lock (O)
            {
                FOUND = false;
                RefrigtzChessPortable.AllDraw THIS = null;
                SetDrawFounding(ref FOUND, ref THIS, false);
            }
        }
        //tetrashop.ir
        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Object O = new Object();
            lock (O)
            {
                try
                {
                    Refrigtz.FormTXT t = new Refrigtz.FormTXT(Draw);
                    t.Show();
                }
                catch (Exception t) { Log(t); }
            }
        }
        //tetrashop.ir
        private void junglesMakeTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            freezBoard = true;
            openFileDialogjunglesMakeTree.ShowDialog();
            TakeRoot y = new TakeRoot();
            bool LoadTree = false;
            RefrigtzChessPortableForm sss = new RefrigtzChessPortableForm();
            bool DrawDrawen = y.LoadJungle(openFileDialogjunglesMakeTree.FileName, FOUND, false, sss, ref LoadTree, false, false, UsePenaltyRegardMechnisam, false, false, false, AStarGreedyHeuristic, true);
            if (DrawDrawen)
            {
                bool makes = Draw.MergeJungleTree(y.t);
                if (makes)
                {
                    MessageBox.Show("ایجاد درخت از جنگلها موفقیت آمیز بود.");
                    object i = new object();

                    lock (i)
                    {
                        LoadTree = false;
                        //Draw = sss.Draw;
                        (new TakeRoot()).SaveJungle(false, false, this, ref LoadTree, false, false, false, false, false, false, false, true);
                    }
                    Application.Exit();
                }
                else
                    MessageBox.Show("هیچ تغییری ایجاد نشد.");
            }
        }
    }
}
