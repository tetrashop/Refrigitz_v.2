using ContourAnalysisDemo;
//#pragma warning disable CS0246 // The type or namespace name 'ContourAnalysisNS' could not be found (are you missing a using directive or an assembly reference?)
using ContourAnalysisNS;
//#pragma warning restore CS0246 // The type or namespace name 'ContourAnalysisNS' could not be found (are you missing a using directive or an assembly reference?)
//#pragma warning disable CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//#pragma warning restore CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
//#pragma warning disable CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
//#pragma warning restore CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
//#pragma warning disable CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
//#pragma warning restore CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
//#pragma warning disable CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
//#pragma warning restore CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
namespace ImageTextDeepLearning
{
    //Constructor
    public partial class FormImageTextDeepLearning : Form
    {
        public static bool Checkonly = false;
        private readonly List<string> Verb = new List<string>();
        private readonly List<string> TextMinedIs = new List<string>();
        private readonly List< List<string>> TextMinedLogicsIs = new List<List<string>>();
        private readonly List< List<string>> TextMinedVerb = new List<List<string>>();
        private readonly List< List<List<string>>> TextMinedLogicsVerb = new List<List<List<string>>>();
        private readonly List<string> TextMinedWas = new List<string>();
        private readonly List<List<string>> TextMinedLogicsWs = new List<List<string>>();
        private bool Resum = false;
        private readonly Task tf = null;
        private bool DisablePaint = false;
        public static bool test = false;
        public static bool comeng = false;
        public static bool fontsel = false;
        public static Font selfont = null;
        private bool Recognized = false;
        //Global vars
        private DetectionOfLitteral On = null;
        //#pragma warning disable CS0108 // 'FormImageTextDeepLearning.Width' hides inherited member 'Control.Width'. Use the new keyword if hiding was intended.
        //#pragma warning disable CS0108 // 'FormImageTextDeepLearning.Height' hides inherited member 'Control.Height'. Use the new keyword if hiding was intended.
        private readonly int Width = 10, Height = 10;
        //#pragma warning restore CS0108 // 'FormImageTextDeepLearning.Height' hides inherited member 'Control.Height'. Use the new keyword if hiding was intended.
        //#pragma warning restore CS0108 // 'FormImageTextDeepLearning.Width' hides inherited member 'Control.Width'. Use the new keyword if hiding was intended.
        private readonly List<ConjunctedShape> conShapes = new List<ConjunctedShape>();
        private SmallImageing t = null;
        private MainForm d = null;
        //Main Form constructor
        public FormImageTextDeepLearning()
        {
            InitializeComponent();
        }
        //Load form
        private void FormImageTextDeepLearning_Load(object sender, EventArgs e)
        {
            //Thread of load
            Thread t = new Thread(new ThreadStart(Progress));
            t.Start();
        }
        //click on open buttonb event
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //determine file of image name
            openFileDialogImageTextDeepLearning.ShowDialog();
            //Assign content of image on main picture box
            PictureBoxImageTextDeepLearning.BackgroundImage = Image.FromFile(openFileDialogImageTextDeepLearning.FileName);
            
            //set scale
            PictureBoxImageTextDeepLearning.BackgroundImageLayout = ImageLayout.Stretch;
            //refresh and update to pain event occured
            PictureBoxImageTextDeepLearning.Refresh();
            PictureBoxImageTextDeepLearning.Update();
        }
        private void openFileDialogImageTextDeepLearning_FileOk(object sender, CancelEventArgs e)
        {
        }
        //splitation and conjunction of one load image deterministic
        private void buttonSplitationConjunction_Click(object sender, EventArgs e)
        {
            //when there is no image
            if (PictureBoxImageTextDeepLearning.BackgroundImage == null)
            {
                //set image to back image
                PictureBoxImageTextDeepLearning.BackgroundImage = PictureBoxImageTextDeepLearning.Image;
                PictureBoxImageTextDeepLearning.Image = null;
            }
            //wen ready to splitation
            if (buttonSplitationConjunction.Text == "Splitation")
            {
                //create constructor image
                t = new SmallImageing(PictureBoxImageTextDeepLearning.BackgroundImage);
                //Do splitation
                bool Do = t.Splitation(PictureBoxTest);
                //wen successfull
                if (Do)
                {
                    //change operation recurve
                    buttonSplitationConjunction.Text = "Conjunction";
                    MessageBox.Show("Splited!");
                }
                else
                {
                    MessageBox.Show("Unsuccessfull splitation;");
                }
            }
            else//when ready to conjunction
if (buttonSplitationConjunction.Text == "Conjunction")
            {
                //Do conjunction
                bool Do = t.Conjunction(PictureBoxTest, PictureBoxImageTextDeepLearning);
                //when successfull
                if (Do)
                {
                    //assgin conjuncted image to back image and refresh and update to pain even occured
                    PictureBoxImageTextDeepLearning.BackgroundImage = t.RootConjuction;
                    PictureBoxImageTextDeepLearning.Refresh();
                    PictureBoxImageTextDeepLearning.Update();
                    buttonSplitationConjunction.Text = "Splitation";
                    MessageBox.Show("Conjuncted!");
                }
                else
                {
                    MessageBox.Show("Unsuccessfull conjunction;");
                }
            }
        }
        private void progressBarCompleted_Click(object sender, EventArgs e)
        {
            
        }
        private void backgroundWorkerProgress_DoWork(object sender, DoWorkEventArgs e)
        {
        }
        private void Progress()
        {
            
        }
        //detect of literalson image to be text 
        private void buttonTxtDetect_Click(object sender, EventArgs e)
        {
            Recognized = false;
            textBoxImageTextDeepLearning.Text = "";
            //detection foregin unnkown app constructor
            d = new MainForm();
            d.ShowDialog();

            
            PictureBoxImageTextDeepLearning.Update();
            PictureBoxImageTextDeepLearning.Refresh();
            CreateConSha.Visible = true;
            checkBoxCheckonly.Visible = true;
        }
        //delegates on lables
        private delegate void CallRefLable();
        public void RefCallSetLablr()
        {
            if (InvokeRequired)
            {
                CallRefLable t = new CallRefLable(RefCallSetLablr);
                Invoke(new Action(() => labelMonitor.Refresh()));
            }
        }
        private delegate void CallSetLable(string Text);
        public void SetCallSetLablr(string Text)
        {
            if (InvokeRequired)
            {
                CallSetLable t = new CallSetLable(SetCallSetLablr);
                Invoke(new Action(() => labelMonitor.Text = Text));
            }
        }
        //main picture boc pain event
        private void PictureBoxImageTextDeepLearning_Paint(object sender, PaintEventArgs e)
        {
            if (!GraphS.Drawn)
            {
                if (!DisablePaint)
                {
                    bool Re = false;
                    //when foregin is ready
                    if (d != null)
                    {
                        //initiate local vars
                        Font font;
                        Brush brush;
                        Brush brush2;
                        Pen pen;
                        bool flag2;
                        //when is ready top detected unconjuncted shapes set draw parameters
                        if (!ReferenceEquals(d.frame, null))
                        {
                            font = new Font(d.Font.FontFamily, 24f);
                            e.Graphics.DrawString(d.lbFPS.Text, new Font(d.Font.FontFamily, 16f), Brushes.Yellow, new PointF(1f, 1f));
                            brush = new SolidBrush(Color.FromArgb(0xff, 0, 0, 0));
                            brush2 = new SolidBrush(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                            pen = new Pen(Color.FromArgb(150, 0, 0xff, 0));
                            flag2 = false;
                            if (!flag2)
                            {
                                using (List<Contour<Point>>.Enumerator enumerator = d.processor.contours.GetEnumerator())
                                {
                                    while (true)
                                    {
                                        flag2 = enumerator.MoveNext();
                                        if (!flag2)
                                        {
                                            break;
                                        }
                                        Contour<Point> current = enumerator.Current;
                                        if (current.Total > 1)
                                        {
                                            e.Graphics.DrawLines(Pens.Red, current.ToArray());
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                        //lock (d.processor.foundTemplates)
                        {
                            using (List<FoundTemplateDesc>.Enumerator enumerator2 = d.processor.foundTemplates.GetEnumerator())
                            {
                                while (true)
                                {
                                    flag2 = enumerator2.MoveNext();
                                    if (!flag2)
                                    {
                                        break;
                                    }
                                    FoundTemplateDesc current = enumerator2.Current;
                                    if (current.template.name.EndsWith(".png") || current.template.name.EndsWith(".jpg"))
                                    {
                                        d.DrawAugmentedReality(current, e.Graphics);
                                        continue;
                                    }
                                    Rectangle sourceBoundingRect = current.sample.contour.SourceBoundingRect;
                                    Point point = new Point((sourceBoundingRect.Left + sourceBoundingRect.Right) / 2, sourceBoundingRect.Top);
                                    string name = current.template.name;
                                    if (d.showAngle)
                                    {
                                        name = name + $"angle={((180.0 * current.angle) / 3.1415926535897931):000}°scale={current.scale:0.0}";
                                    }
                                    if (!Recognized)
                                    {
                                        textBoxImageTextDeepLearning.Text += name;
                                        textBoxImageTextDeepLearning.Refresh();
                                        textBoxImageTextDeepLearning.Update();
                                        Re = true;
                                    }
                                    e.Graphics.DrawRectangle(pen, sourceBoundingRect);
                                    e.Graphics.DrawString(name, font, brush, new PointF((point.X + 1) - (font.Height / 3), (point.Y + 1) - font.Height));
                                    e.Graphics.DrawString(name, font, brush2, new PointF(point.X - (font.Height / 3), point.Y - font.Height));
                                }
                            }
                        }
                    }
                    if (Re)
                    {
                        Recognized = true;
                    }
                    //PictureBoxImageTextDeepLearning.Update();
                    //PictureBoxImageTextDeepLearning.Refresh();
                }
            }
            else
            {
            }
        }
        public void GraphsDrawn(GraphDivergenceMatrix A, GraphDivergenceMatrix B)
        {
            Bitmap ss = new Bitmap(PictureBoxImageTextDeepLearning.Width, PictureBoxImageTextDeepLearning.Height);
            PictureBoxImageTextDeepLearning.BackgroundImage = ss;
            Graphics g = Graphics.FromImage(PictureBoxImageTextDeepLearning.BackgroundImage);
            if (A != null)
            {
                if (A.Xv != null)
                {
                    for (int i = 0; i < A.Xv.Count; i++)
                    {
                        g.DrawString("*", new Font("Tahoma", 10F), new SolidBrush(Color.Red), new PointF(A.Xv[i].X * 10, A.Xv[i].Y * 10));
                        for (int j = 0; j < A.Xv.Count; j++)
                        {
                            if (A.d(A.Xv[i], A.Xv[j]) != null)
                            {
                                g.DrawLine(new Pen(Color.Red), new Point(A.Xv[i].X * 10, A.Xv[i].Y * 10), new Point(A.Xv[j].X * 10, A.Xv[j].Y * 10));
                            }
                        }
                    }
                }
            }
            if (B != null)
            {
                if (B.Xv != null)
                {
                    for (int i = 0; i < B.Xv.Count; i++)
                    {
                        g.DrawString("*", new Font("Tahoma", 10F), new SolidBrush(Color.Blue), new PointF(B.Xv[i].X * 10, B.Xv[i].Y * 10));
                        for (int j = 0; j < B.Xv.Count; j++)
                        {
                            if (B.d(B.Xv[i], B.Xv[j]) != null)
                            {
                                g.DrawLine(new Pen(Color.Blue), new Point(B.Xv[i].X * 10, B.Xv[i].Y * 10), new Point(B.Xv[j].X * 10, B.Xv[j].Y * 10));
                            }
                        }
                    }
                }
            }
            
            g.Dispose();
            PictureBoxImageTextDeepLearning.Refresh();
            PictureBoxImageTextDeepLearning.Update();
        }
        private void PictureBoxImageTextDeepLearning_Click(object sender, EventArgs e)
        {
        }
        //disable algins paint on foregin form
        private void checkBoxDisablePaintOnAligns_CheckedChanged(object sender, EventArgs e)
        {
            if (d != null)
            {
                if (checkBoxDisablePaintOnAligns.Checked)
                {
                    d.DisablePaintOnAligns = true;
                }
                else
                {
                    d.DisablePaintOnAligns = false;
                }
            }
        }
        //main detection form
        private void CreateOneConShape()
        {
            //when cunsoming is ready
            if (!ReferenceEquals(d.frame, null))
            {
                lock (d.processor.foundTemplates)
                {
                    
                    //call detection constructor
                    FormImageTextDeepLearning This = this;
                    On = new DetectionOfLitteral(ref This, d);
                }
            }
        }
        //about
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutBoxImageTextDeepLearning()).Show();
        }
        //menue strip of open file 
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogImageTextDeepLearning.ShowDialog();
            PictureBoxImageTextDeepLearning.BackgroundImage = Image.FromFile(openFileDialogImageTextDeepLearning.FileName);
            
            PictureBoxImageTextDeepLearning.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBoxImageTextDeepLearning.Refresh();
            PictureBoxImageTextDeepLearning.Update();
        }
        //Open file and load
        private void splitationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PictureBoxImageTextDeepLearning.BackgroundImage == null)
            {
                PictureBoxImageTextDeepLearning.BackgroundImage = PictureBoxImageTextDeepLearning.Image;
                PictureBoxImageTextDeepLearning.Image = null;
            }
            if (buttonSplitationConjunction.Text == "Splitation")
            {
                t = new SmallImageing(PictureBoxImageTextDeepLearning.BackgroundImage);
                bool Do = t.Splitation(PictureBoxTest);
                if (Do)
                {
                    buttonSplitationConjunction.Text = "Conjunction";
                    MessageBox.Show("Splited!");
                }
            }
            else
if (buttonSplitationConjunction.Text == "Conjunction")
            {
                bool Do = t.Conjunction(PictureBoxTest, PictureBoxImageTextDeepLearning);
                if (Do)
                {
                    PictureBoxImageTextDeepLearning.BackgroundImage = t.RootConjuction;
                    PictureBoxImageTextDeepLearning.Refresh();
                    PictureBoxImageTextDeepLearning.Update();
                    buttonSplitationConjunction.Text = "Splitation";
                    MessageBox.Show("Conjuncted!");
                }
            }
        }
        private void Draw()
        {
            for (int i = 0; i < On.tt.AllImage.Count; i++)
            {
                object O = new object();
                lock (O)
                {
                    try
                    {
                        PictureBoxTest.BackgroundImage = On.tt.AllImage[i];
                        PictureBoxTest.BackgroundImageLayout = ImageLayout.Zoom;
                        PictureBoxTest.Refresh();
                        PictureBoxTest.Update();
                    }
                    catch (System.Exception) { }
                }
            }
        }
        //conjuncton create shapes menue strip
        private void createConjunctionShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(CreateOneConShape));
            t.Start();
            t.Join();
            t = new Thread(new ThreadStart(Draw));
            t.Start();
            t.Join();
            for (int i = 0; i < On.Detected.Count; i++)
            {
                textBoxImageTextDeepLearning.AppendText(On.Detected[i]);
            }
            
        }
        //detection form munue strip
        private void txtDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d = new MainForm();
            d.ShowDialog();
            
            
            
            PictureBoxImageTextDeepLearning.Update();
            PictureBoxImageTextDeepLearning.Refresh();
        }
        private void buttonTxtTemplates_Click(object sender, EventArgs e)
        {
        }
        private void checkBoxUndetectiveFont_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                AllKeyboardOfWorld a = new AllKeyboardOfWorld();
                a.ListAllFonts();
                comboBoxUndetectiveFont.Items.AddRange(AllKeyboardOfWorld.fonts.ToArray());
                fontsel = true;
            }
        }
        private void comboBoxUndetectiveFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllKeyboardOfWorld.fonts.Clear();
            selfont = new System.Drawing.Font(comboBoxUndetectiveFont.Text, 10);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void checkBoxUseCommonEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                comeng = true;
            }
        }
        private void PictureBoxTest_Click(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                test = true;
                checkBoxUseCommonEnglish.Enabled = false;
            }
            else
            {
                test = false;
                checkBoxUseCommonEnglish.Enabled = true;
            }
        }
        public void Set()
        {
            do
            {
                try
                {
                    do { } while (!GraphS.Drawn);
                    PictureBoxImageTextDeepLearning.Invalidate();
                    PictureBoxImageTextDeepLearning.Refresh();
                }
                catch (Exception) { }
            } while (true);
        }
        private void c()
        {
            int len = 0;
            do
            {
                if (On != null)
                {
                    if (On.Detected != null)
                    {
                        if (len != On.Detected.Count)
                        {
                            Resum = true;
                            Invoke((MethodInvoker)delegate ()
                            {
                                textBoxImageTextDeepLearning.Text = "";
                                for (int i = 0; i < On.Detected.Count; i++)
                                {
                                    textBoxImageTextDeepLearning.AppendText(On.Detected[i]);
                                    textBoxImageTextDeepLearning.Update();
                                }
                            });
                            len = On.Detected.Count;
                            Resum = false;
                        }
                    }
                }
                Thread.Sleep(1000);
            } while (true);
        }

        private int WordNumber(string s)
        {
            int no = 0;
            string c = s;
            do
            {
                if (c[0] == ' ')
                {
                    c = c.Remove(0, 1);
                }
                else
                {
                    break;
                }
            } while (true);
            int len = -1;
            do
            {
                len = c.IndexOf(" ");
                if (len > -1)
                {
                    no++;
                    c = c.Remove(0, len + 1);
                }
                else
                {
                    len = c.IndexOf(".");
                    if (len > -1)
                    {
                        no++;
                        c = c.Remove(0, len + 1);
                    }
                }
            } while (c.Length > 0);
            return no;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Con = textBoxImageTextDeepLearning.Text;
            do
            {
                string s = textBoxImageTextDeepLearning.Text.Substring(0, textBoxImageTextDeepLearning.Text.IndexOf(".") + 1);
                if (s.Contains("است.") && WordNumber(s) == 3)
                {
                    TextMinedIs.Add(s);
                }

                textBoxImageTextDeepLearning.Text = textBoxImageTextDeepLearning.Text.Remove(0, textBoxImageTextDeepLearning.Text.IndexOf(".") + 1);
            } while (textBoxImageTextDeepLearning.Text.Contains("."));
            textBoxImageTextDeepLearning.Text = "";
            Is();
            textBoxImageTextDeepLearning.Text += "\r\n========================================\r\n";
            textBoxImageTextDeepLearning.Text += "\r\n========================================\r\n";
            textBoxImageTextDeepLearning.Text += "\r\n========================================\r\n";
            string IsCon = textBoxImageTextDeepLearning.Text;
            textBoxImageTextDeepLearning.Text = Con;
            do
            {
                string s = textBoxImageTextDeepLearning.Text.Substring(0, textBoxImageTextDeepLearning.Text.IndexOf(".") + 1);
                if (s.Contains("بود.") && WordNumber(s) == 3)
                {
                    TextMinedWas.Add(s);
                }

                textBoxImageTextDeepLearning.Text = textBoxImageTextDeepLearning.Text.Remove(0, textBoxImageTextDeepLearning.Text.IndexOf(".") + 1);
            } while (textBoxImageTextDeepLearning.Text.Contains("."));
            textBoxImageTextDeepLearning.Text = "";
            Was();
            textBoxImageTextDeepLearning.Text = IsCon + textBoxImageTextDeepLearning.Text;
            IsCon = textBoxImageTextDeepLearning.Text;
            textBoxImageTextDeepLearning.Text = Con;
            Verb.Add("می داد.");
            Verb.Add("می شود.");
            Verb.Add("می کند.");
            for (int i = 0; i < Verb.Count; i++)
            {
                TextMinedVerb.Add(new List<string>());
                do
                {
                    string s = textBoxImageTextDeepLearning.Text.Substring(0, textBoxImageTextDeepLearning.Text.IndexOf(".") + 1);
                    if (s.Contains(Verb[i]) && WordNumber(s) == 3)
                    {
                        TextMinedVerb[TextMinedVerb.Count - 1].Add(s);
                    }

                    textBoxImageTextDeepLearning.Text = textBoxImageTextDeepLearning.Text.Remove(0, textBoxImageTextDeepLearning.Text.IndexOf(".") + 1);
                } while (textBoxImageTextDeepLearning.Text.Contains("."));
            }
            textBoxImageTextDeepLearning.Text = "";
            SomeVerbsAddable();
            textBoxImageTextDeepLearning.Text = IsCon + textBoxImageTextDeepLearning.Text;
        }

        private void Is()
        {
             for (int i = 0; i < TextMinedIs.Count; i++)
            {
                textBoxImageTextDeepLearning.Text += TextMinedIs[i];
            }

            textBoxImageTextDeepLearning.Refresh();
            textBoxImageTextDeepLearning.Update();
            List<string> mined = new List<string>();
            for (int i = 0; i < TextMinedIs.Count; i++)
            {
                mined.Add(TextMinedIs[i]);
            }

            for (int i = 0; i < mined.Count; i++)
            {
                TextMinedLogicsIs.Add(new List<string>());
                string s = mined[i];
                int no = 0;
                string c = s;
                do
                {
                    if (c[0] == ' ')
                    {
                        c = c.Remove(0, 1);
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                int len = -1;
                do
                {
                    len = c.IndexOf(" ");
                    if (len > -1)
                    {
                        no++;
                        TextMinedLogicsIs[TextMinedLogicsIs.Count - 1].Add(c.Substring(0, len));
                        c = c.Remove(0, len + 1);
                    }
                    else
                    {
                        len = c.IndexOf(".");
                        if (len > -1)
                        {
                            no++;
                            
                            c = c.Remove(0, len + 1);
                        }
                    }
                } while (c.Length > 0);
            }
            textBoxImageTextDeepLearning.Text += "\r\n========================================\r\n";
            ResultsOfSupposed.MindedIsVerb(TextMinedIs, TextMinedLogicsIs);
            
            for (int i = 0; i < ResultsOfSupposed.mined.Count; i++)
            {
                textBoxImageTextDeepLearning.Text += ResultsOfSupposed.mined[i];
            }

            textBoxImageTextDeepLearning.Refresh();
            textBoxImageTextDeepLearning.Update();
        }

        private void Was()
        {
            for (int i = 0; i < TextMinedWas.Count; i++)
            {
                textBoxImageTextDeepLearning.Text += TextMinedWas[i];
            }

            textBoxImageTextDeepLearning.Refresh();
            textBoxImageTextDeepLearning.Update();
            List<string> mined = new List<string>();
            for (int i = 0; i < TextMinedWas.Count; i++)
            {
                mined.Add(TextMinedWas[i]);
            }

            for (int i = 0; i < mined.Count; i++)
            {
                TextMinedLogicsWs.Add(new List<string>());
                string s = mined[i];
                int no = 0;
                string c = s;
                do
                {
                    if (c[0] == ' ')
                    {
                        c = c.Remove(0, 1);
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                int len = -1;
                do
                {
                    len = c.IndexOf(" ");
                    if (len > -1)
                    {
                        no++;
                        TextMinedLogicsWs[TextMinedLogicsWs.Count - 1].Add(c.Substring(0, len));
                        c = c.Remove(0, len + 1);
                    }
                    else
                    {
                        len = c.IndexOf(".");
                        if (len > -1)
                        {
                            no++;
                            
                            c = c.Remove(0, len + 1);
                        }
                    }
                } while (c.Length > 0);
            }
            textBoxImageTextDeepLearning.Text += "\r\n========================================\r\n";
            ResultsOfSupposed.MindedWasVerb(TextMinedWas, TextMinedLogicsWs);
            
            for (int i = 0; i < ResultsOfSupposed.mined.Count; i++)
            {
                textBoxImageTextDeepLearning.Text += ResultsOfSupposed.mined[i];
            }

            textBoxImageTextDeepLearning.Refresh();
            textBoxImageTextDeepLearning.Update();
        }

        private void SomeVerbsAddable()
        {
            bool Is = false;
            for (int k = 0; k < Verb.Count; k++)
            {
                if (TextMinedVerb.Count == 0)
                {
                    continue;
                }

                Is = true;
                try
                {
                    TextMinedLogicsVerb.Add(new List<List<string>>());
                    for (int i = 0; i < TextMinedVerb[k].Count; i++)
                    {
                        textBoxImageTextDeepLearning.Text += TextMinedVerb[k][i];
                    }

                    textBoxImageTextDeepLearning.Refresh();
                    textBoxImageTextDeepLearning.Update();
                    List<string> mined = new List<string>();
                    for (int i = 0; i < TextMinedVerb.Count; i++)
                    {
                        mined.Add(TextMinedVerb[k][i]);
                    }

                    for (int i = 0; i < mined.Count; i++)
                    {
                        TextMinedLogicsVerb[k].Add(new List<string>());
                        string s = mined[i];
                        int no = 0;
                        string c = s;
                        do
                        {
                            if (c[0] == ' ')
                            {
                                c = c.Remove(0, 1);
                            }
                            else
                            {
                                break;
                            }
                        } while (true);
                        int len = -1;
                        do
                        {
                            len = c.IndexOf(" ");
                            if (len > -1)
                            {
                                no++;
                                TextMinedLogicsVerb[k][TextMinedLogicsWs.Count - 1].Add(c.Substring(0, len));
                                c = c.Remove(0, len + 1);
                            }
                            else
                            {
                                len = c.IndexOf(".");
                                if (len > -1)
                                {
                                    no++;
                                    
                                    c = c.Remove(0, len + 1);
                                }
                            }
                        } while (c.Length > 0);
                    
                    }
                }
                catch (Exception) { }
                if (Is)
                {
                    textBoxImageTextDeepLearning.Text += "\r\n========================================\r\n";
                    ResultsOfSupposed.MindedSomeVerb(TextMinedVerb[k], TextMinedLogicsVerb[k], Verb[k]);
                    
                    for (int i = 0; i < ResultsOfSupposed.mined.Count; i++)
                    {
                        textBoxImageTextDeepLearning.Text += ResultsOfSupposed.mined[i];
                    }

                    textBoxImageTextDeepLearning.Refresh();
                    textBoxImageTextDeepLearning.Update();
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Text != "")
            {
                buttonAddVerb.Visible = true;
            }
            else
            {
                buttonAddVerb.Visible = false;
            }
        }
        private void buttonAddVerb_Click(object sender, EventArgs e)
        {
            if (!Verb.Contains(textBox1.Text))
            {
                Verb.Add(textBox1.Text);
            }

            textBox1.Text = "";
        }
        void SetTotal()
        {
            var output = Task.Factory.StartNew(() => CreateOneConShape());
            if (!ImageTextDeepLearning.FormImageTextDeepLearning.Checkonly)
            {
                do { Thread.Sleep(10); } while (DetectionOfLitteral.total == -1 || DetectionOfLitteral.current == -1);
                progressBarCompleted.Maximum = DetectionOfLitteral.total;
                var outputC = Task.Factory.StartNew(() => Current());
                output.Wait();
            }
            else
            {
                output.Wait();
                if (On != null)
                {
                    if (On.ConjunctedShapeListRequired != null)
                    {
                        if (On.ConjunctedShapeListRequired.KeyboardAllConjunctionMatrix.Count > 0)
                        {
                            if (checkBoxCheckonly.Checked)
                            {
                                ImageTextDeepLearning.FormImageTextDeepLearning.Checkonly = true;
                                buttonUpdate.Visible = true;
                                comboBoxKind.Visible = true;
                            }
                            else
                            {
                                ImageTextDeepLearning.FormImageTextDeepLearning.Checkonly = false;
                                buttonUpdate.Visible = false;
                                comboBoxKind.Visible = false;
                            }
                        }
                    }
                }
                return ;
            }

            
            DisablePaint = true;
            MessageBox.Show("Samples!");
            for (int i = 0; i < On.ConjunctedShapeListRequired.KeyboardAllImage.Count; i++)
            {
                PictureBoxTest.BackgroundImage = On.ConjunctedShapeListRequired.KeyboardAllImage[i];
                PictureBoxTest.BackgroundImageLayout = ImageLayout.Zoom;
                PictureBoxTest.Refresh();
                PictureBoxTest.Update();
                MessageBox.Show("Next!");
                PictureBoxTest.BackgroundImage.Dispose();
            }
            if (!test)
            {
                MessageBox.Show("part of References!");
            }
            else
            {
                MessageBox.Show("References!");
            }
            for (int i = 0; i < On.t.KeyboardAllImage.Count; i++)
            {
                PictureBoxTest.BackgroundImage = On.t.KeyboardAllImage[i];
                PictureBoxTest.BackgroundImageLayout = ImageLayout.Zoom;
                PictureBoxTest.Refresh();
                PictureBoxTest.Update();
                MessageBox.Show("Next!");
                PictureBoxTest.BackgroundImage.Dispose();
            }
            DisablePaint = false;

            textBoxImageTextDeepLearning.Text = "";
            for (int i = 0; i < On.Detected.Count; i++)
            {
                textBoxImageTextDeepLearning.AppendText(On.Detected[i]);
                textBoxImageTextDeepLearning.Refresh();
                textBoxImageTextDeepLearning.Update();
            }
            buttonSplitationConjunction.Visible = true;
        }

        private void progressBarCompleted_Validating(object sender, CancelEventArgs e)
        {
         }

        private void progressBarCompleted_VisibleChanged(object sender, EventArgs e)
        {
    
        }
        void Current()
        {
            int count = 0;
            do
            {
                progressBarCompleted.Value = DetectionOfLitteral.current;
                if (count < On.Detected.Count)
                {
                    textBoxImageTextDeepLearning.Text = "";
                    for (int i = 0; i < On.Detected.Count; i++)
                    {
                        textBoxImageTextDeepLearning.AppendText(On.Detected[i]);
                        textBoxImageTextDeepLearning.Refresh();
                        textBoxImageTextDeepLearning.Update();
                        count = On.Detected.Count;
                    }
                }
            } while (DetectionOfLitteral.current < DetectionOfLitteral.total);
        }

        private void checkBoxCheckonly_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheckonly.Checked)
            {
                ImageTextDeepLearning.FormImageTextDeepLearning.Checkonly = true;
            }
            else
            {
                ImageTextDeepLearning.FormImageTextDeepLearning.Checkonly = false;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKind.Text == "Sample")
            {
                if (comboBoxItem.Text != "")
                {
                    PictureBoxTest.BackgroundImage = On.ConjunctedShapeListRequired.KeyboardAllImage[System.Convert.ToInt32(comboBoxItem.Text)];
                    PictureBoxTest.BackgroundImageLayout = ImageLayout.Zoom;
                    PictureBoxTest.Refresh();
                    PictureBoxTest.Update();
                    textBoxImageTextDeepLearning.Text = "";

                    for (int i = 0; i < Width; i++)
                    {
                        for (int j = 0; j < Height; j++)
                        {
                            if (On.ConjunctedShapeListRequired.KeyboardAllConjunctionMatrix[System.Convert.ToInt32(comboBoxItem.Text)][j, i])
                            {
                                textBoxImageTextDeepLearning.AppendText("+");
                            }
                            else
                            {
                                textBoxImageTextDeepLearning.AppendText(" ");

                            }
                        }
                        textBoxImageTextDeepLearning.AppendText("\r\n");

                    }
                    DrawGraph(On.ConjunctedShapeListRequired.KeyboardAllConjunctionMatrix[System.Convert.ToInt32(comboBoxItem.Text)], Width, Height);
                }
            }
            else
            {
                if (comboBoxItem.Text != "")
                {
                    PictureBoxTest.BackgroundImage = On.t.KeyboardAllImage[System.Convert.ToInt32(comboBoxItem.Text)];
                    PictureBoxTest.BackgroundImageLayout = ImageLayout.Zoom;
                    PictureBoxTest.Refresh();
                    PictureBoxTest.Update();
                    textBoxImageTextDeepLearning.Text = "";

                    for (int i = 0; i < Width; i++)
                    {
                        for (int j = 0; j < Height; j++)
                        {
                            if (On.t.KeyboardAllConjunctionMatrix[System.Convert.ToInt32(comboBoxItem.Text)][j, i])
                            {
                                textBoxImageTextDeepLearning.AppendText("+");
                            }
                            else
                            {
                                textBoxImageTextDeepLearning.AppendText(" ");

                            }
                        }
                        textBoxImageTextDeepLearning.AppendText("\r\n");

                    }

                    DrawGraph(On.t.KeyboardAllConjunctionMatrix[System.Convert.ToInt32(comboBoxItem.Text)], Width, Height);
                }
            }
        }
        void DrawGraph(bool[,] Ab, int m, int n)
        {
            SameRikhEquvalent A = new SameRikhEquvalent(Ab, m, n);
            Graphics e = Graphics.FromImage(PictureBoxImageTextDeepLearning.Image);
            e.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, PictureBoxImageTextDeepLearning.Image.Width, PictureBoxImageTextDeepLearning.Image.Height));
            for (int i = 0; i < A.Xv.Count; i++)
            {
                for (int j = 0; j < A.Xv.Count; j++)
                {if (i == j)
                        continue;
                    Line sd = A.d(A.Xv[i], A.Xv[j]);
                    if (sd != null)
                    {
                        e.FillEllipse(new SolidBrush(Color.Red), new RectangleF(A.Xv[i].X * 20, A.Xv[i].Y * 20, 10, 10));
                        e.FillEllipse(new SolidBrush(Color.Red), new RectangleF(A.Xv[j].X * 20, A.Xv[j].Y * 20, 10, 10));
                        e.DrawLine(new Pen(new SolidBrush(Color.Blue), 6), new Point(A.Xv[i].X * 20, A.Xv[i].Y * 20), new Point(A.Xv[j].X * 20, A.Xv[j].Y * 20));
                    }
                }
            }
            PictureBoxImageTextDeepLearning.Refresh();
            panelImageTextDeepLearning.Update();
            e.Dispose();

        }
        private void comboBoxKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (On != null)
            {
                if (comboBoxKind.Text == "Sample")
                {
                    comboBoxItem.Visible = true;
                    comboBoxItem.Items.Clear();
                    for (int i = 0; i < On.ConjunctedShapeListRequired.KeyboardAllConjunctionMatrix.Count; i++)
                    {
                        comboBoxItem.Items.Add(i.ToString() + "\r\n");
                    }
                    textBoxImageTextDeepLearning.Text = "";

                }
                else
                {
                    if (comboBoxKind.Text == "Reference")
                    {
                        comboBoxItem.Items.Clear();
                        for (int i = 0; i < On.t.KeyboardAllConjunctionMatrix.Count; i++)
                        {
                            comboBoxItem.Items.Add(i.ToString() + "\r\n");
                        }
                    }
                }
            }
        }

        //create main detection button
        private void CreateConSha_Click(object sender, EventArgs e)
        {

            //var output = Task.Factory.StartNew(() => SetTotal());

            var output = Task.Factory.StartNew(() => CreateOneConShape());
            if (!ImageTextDeepLearning.FormImageTextDeepLearning.Checkonly)
            {
                do { Thread.Sleep(10); } while (DetectionOfLitteral.total == -1 || DetectionOfLitteral.current == -1);
                progressBarCompleted.Maximum = DetectionOfLitteral.total;
                var outputC = Task.Factory.StartNew(() => Current());
                output.Wait();
            }
            else
            {
                output.Wait();
                if (On != null)
                {
                    if (On.ConjunctedShapeListRequired != null)
                    {
                        if (On.ConjunctedShapeListRequired.KeyboardAllConjunctionMatrix.Count > 0)
                        {
                            if (checkBoxCheckonly.Checked)
                            {
                                ImageTextDeepLearning.FormImageTextDeepLearning.Checkonly = true;
                                buttonUpdate.Visible = true;
                                comboBoxKind.Visible = true;
                            }
                            else
                            {
                                ImageTextDeepLearning.FormImageTextDeepLearning.Checkonly = false;
                                buttonUpdate.Visible = false;
                                comboBoxKind.Visible = false;
                            }
                        }
                    }
                }
                return;
            }


            DisablePaint = true;
            MessageBox.Show("Samples!");
            for (int i = 0; i < On.ConjunctedShapeListRequired.KeyboardAllImage.Count; i++)
            {
                PictureBoxTest.BackgroundImage = On.ConjunctedShapeListRequired.KeyboardAllImage[i];
                PictureBoxTest.BackgroundImageLayout = ImageLayout.Zoom;
                PictureBoxTest.Refresh();
                PictureBoxTest.Update();
                MessageBox.Show("Next!");
                PictureBoxTest.BackgroundImage.Dispose();
            }
            if (!test)
            {
                MessageBox.Show("part of References!");
            }
            else
            {
                MessageBox.Show("References!");
            }
            for (int i = 0; i < On.t.KeyboardAllImage.Count; i++)
            {
                PictureBoxTest.BackgroundImage = On.t.KeyboardAllImage[i];
                PictureBoxTest.BackgroundImageLayout = ImageLayout.Zoom;
                PictureBoxTest.Refresh();
                PictureBoxTest.Update();
                MessageBox.Show("Next!");
                PictureBoxTest.BackgroundImage.Dispose();
            }
            DisablePaint = false;

            textBoxImageTextDeepLearning.Text = "";
            for (int i = 0; i < On.Detected.Count; i++)
            {
                textBoxImageTextDeepLearning.AppendText(On.Detected[i]);
                textBoxImageTextDeepLearning.Refresh();
                textBoxImageTextDeepLearning.Update();
            }
            buttonSplitationConjunction.Visible = true;

        }
    }
}
