namespace ContourAnalysisDemo
{
    //#pragma warning disable CS0246 // The type or namespace name 'ContourAnalysisNS' could not be found (are you missing a using directive or an assembly reference?)
    using ContourAnalysisNS;
    //#pragma warning restore CS0246 // The type or namespace name 'ContourAnalysisNS' could not be found (are you missing a using directive or an assembly reference?)
    //#pragma warning disable CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
    using Emgu.CV;
    //#pragma warning restore CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
    //#pragma warning disable CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
    using Emgu.CV.CvEnum;
    //#pragma warning restore CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
    //#pragma warning disable CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
    using Emgu.CV.Structure;
    //#pragma warning restore CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
    //#pragma warning disable CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
    using Emgu.CV.UI;
    //#pragma warning restore CS0246 // The type or namespace name 'Emgu' could not be found (are you missing a using directive or an assembly reference?)
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Windows.Forms;
    [Serializable]
    public class MainForm : Form
    {
        public bool DisablePaintOnAligns = false;
        //#pragma warning disable CS0246 // The type or namespace name 'Capture' could not be found (are you missing a using directive or an assembly reference?)
        private Capture _capture;
        //#pragma warning restore CS0246 // The type or namespace name 'Capture' could not be found (are you missing a using directive or an assembly reference?)
        //#pragma warning disable CS0308 // The non-generic type 'Image' cannot be used with type arguments
        //#pragma warning disable CS0246 // The type or namespace name 'Bgr' could not be found (are you missing a using directive or an assembly reference?)
        public Image<Bgr, byte> frame;
        //#pragma warning restore CS0246 // The type or namespace name 'Bgr' could not be found (are you missing a using directive or an assembly reference?)
        //#pragma warning restore CS0308 // The non-generic type 'Image' cannot be used with type arguments
        //#pragma warning disable CS0246 // The type or namespace name 'ImageProcessor' could not be found (are you missing a using directive or an assembly reference?)
        public ImageProcessor processor;
        //#pragma warning restore CS0246 // The type or namespace name 'ImageProcessor' could not be found (are you missing a using directive or an assembly reference?)
        private readonly Dictionary<string, Image> AugmentedRealityImages = new Dictionary<string, Image>();
        private bool captureFromCam = true;
        private int frameCount = 0;
        private int oldFrameCount = 0;
        public bool showAngle;
        private int camWidth = 640;
        private int camHeight = 480;
        private string templateFile;
        private IContainer components = null;
        //#pragma warning disable CS0246 // The type or namespace name 'ImageBox' could not be found (are you missing a using directive or an assembly reference?)
        private ImageBox ibMain;
        //#pragma warning restore CS0246 // The type or namespace name 'ImageBox' could not be found (are you missing a using directive or an assembly reference?)
        private Panel pnSettings;
        private StatusStrip ssMain;
        private Splitter splitter1;
        public ToolStripStatusLabel lbFPS;
        private ToolStripStatusLabel lbContoursCount;
        private Timer tmUpdateState;
        private ToolStripStatusLabel lbRecognized;
        private CheckBox cbShowAngle;
        private CheckBox cbAutoContrast;
        private Button btLoadImage;
        private Label label1;
        private ComboBox cbCamResolution;
        private CheckBox cbCaptureFromCam;
        private CheckBox cbAllowAngleMore45;
        private Label label3;
        private NumericUpDown nudMinContourArea;
        private Label label2;
        private NumericUpDown nudMinContourLength;
        private Label label4;
        private NumericUpDown nudMinICF;
        private Label label5;
        private NumericUpDown nudMinACF;
        private Label label6;
        private NumericUpDown nudMaxACFdesc;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private CheckBox cbBlur;
        private CheckBox cbNoiseFilter;
        private NumericUpDown nudMinDefinition;
        private NumericUpDown nudAdaptiveThBlockSize;
        private Label label7;
        private ToolStrip toolStrip1;
        private ToolStripButton btCreateTemplate;
        private ToolStripButton btNewTemplates;
        private ToolStripButton btOpenTemplates;
        private ToolStripButton btSaveTemplates;
        private ToolStripSeparator toolStripSeparator;
        private CheckBox cbShowContours;
        private ToolStripButton btTemplateEditor;
        private ToolStripButton btAutoGenerate;
        //#pragma warning disable CS0246 // The type or namespace name 'PanAndZoomPictureBox' could not be found (are you missing a using directive or an assembly reference?)
        private PanAndZoomPictureBox panAndZoomPictureBox1;
        //#pragma warning restore CS0246 // The type or namespace name 'PanAndZoomPictureBox' could not be found (are you missing a using directive or an assembly reference?)
        private ToolStripLabel toolStripLabel1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripProgressBar toolStripProgressBar1;
        private CheckBox cbShowBinarized;

        public MainForm()
        {
            InitializeComponent();
            processor = new ImageProcessor();
            templateFile = AppDomain.CurrentDomain.BaseDirectory + @"\Tahoma.bin";
            LoadTemplates(templateFile);
            StartCapture();
            ApplySettings();
            Application.Idle += new EventHandler(Application_Idle);
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            ProcessFrame();
        }

        private void ApplyCamSettings()
        {
            try
            {
                _capture.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, camWidth);
                _capture.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, camHeight);
                cbCamResolution.Text = camWidth + "x" + camHeight;
            }
            catch (NullReferenceException exception1)
            {
                MessageBox.Show(exception1.Message);
            }
        }

        private void ApplySettings()
        {
            try
            {
                processor.equalizeHist = cbAutoContrast.Checked;
                showAngle = cbShowAngle.Checked;
                captureFromCam = cbCaptureFromCam.Checked;
                btLoadImage.Enabled = !captureFromCam;
                cbCamResolution.Enabled = captureFromCam;
                processor.finder.maxRotateAngle = cbAllowAngleMore45.Checked ? 3.1415926535897931 : 0.78539816339744828;
                processor.minContourArea = (int)nudMinContourArea.Value;
                processor.minContourLength = (int)nudMinContourLength.Value;
                processor.finder.maxACFDescriptorDeviation = (int)nudMaxACFdesc.Value;
                processor.finder.minACF = (double)nudMinACF.Value;
                processor.finder.minICF = (double)nudMinICF.Value;
                processor.blur = cbBlur.Checked;
                processor.noiseFilter = cbNoiseFilter.Checked;
                processor.cannyThreshold = (int)nudMinDefinition.Value;
                nudMinDefinition.Enabled = processor.noiseFilter;
                processor.adaptiveThresholdBlockSize = (int)nudAdaptiveThBlockSize.Value;
                string[] strArray = cbCamResolution.Text.ToLower().Split(new char[] { 'x' });
                if (strArray.Length == 2)
                {
                    int num = int.Parse(strArray[0]);
                    int num2 = int.Parse(strArray[1]);
                    if ((camHeight != num2) || (camWidth != num))
                    {
                        camWidth = num;
                        camHeight = num2;
                        ApplyCamSettings();
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message);
            }
        }

        private void btAutoGenerate_Click(object sender, EventArgs e)
        {
            new AutoGenerateForm(processor).ShowDialog();
        }

        private void btCreateTemplate_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(frame, null))
            {
                new ShowContoursForm(processor.templates, processor.samples, frame.Bitmap).ShowDialog();
            }
        }

        private void btLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    frame = new Image<Bgr, byte>((Bitmap)Image.FromFile(dialog.FileName));
                }
                catch (Exception exception1)
                {
                    MessageBox.Show(exception1.Message);
                }
            }
        }

        private void btNewTemplates_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to create new template database?", "Create new template database", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                processor.templates.Clear();
            }
        }

        private void btOpenTemplates_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Templates(*.bin)|*.bin"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                templateFile = dialog.FileName;
                LoadTemplates(templateFile);
            }
        }

        private void btSaveTemplates_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Templates(*.bin)|*.bin"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                templateFile = dialog.FileName;
                SaveTemplates(templateFile);
            }
        }

        private void btTemplateEditor_Click(object sender, EventArgs e)
        {
            new TemplateEditor(processor.templates).Show();
        }

        private void cbAutoContrast_CheckedChanged(object sender, EventArgs e)
        {
            ApplySettings();
        }

        protected override void Dispose(bool disposing)
        {
            if (!(!disposing || ReferenceEquals(components, null)))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //#pragma warning disable CS0246 // The type or namespace name 'FoundTemplateDesc' could not be found (are you missing a using directive or an assembly reference?)
        public void DrawAugmentedReality(FoundTemplateDesc found, Graphics gr)
        //#pragma warning restore CS0246 // The type or namespace name 'FoundTemplateDesc' could not be found (are you missing a using directive or an assembly reference?)
        {
            string key = Path.GetDirectoryName(templateFile) + @"\" + found.template.name;
            if (!AugmentedRealityImages.ContainsKey(key))
            {
                if (File.Exists(key))
                {
                    AugmentedRealityImages[key] = Image.FromFile(key);
                }
                else
                {
                    return;
                }
            }
            Image image = AugmentedRealityImages[key];
            Point point = found.sample.contour.SourceBoundingRect.Center();
            GraphicsState gstate = gr.Save();
            gr.TranslateTransform(point.X, point.Y);
            gr.RotateTransform((float)((180.0 * found.angle) / 3.1415926535897931));
            gr.ScaleTransform((float)found.scale, (float)found.scale);
            gr.DrawImage(image, new Point(-image.Width / 2, -image.Height / 2));
            gr.Restore(gstate);
        }

        private void ibMain_Paint(object sender, PaintEventArgs e)
        {
            if (!DisablePaintOnAligns)
            {
                Font font;
                Brush brush;
                Brush brush2;
                Pen pen;
                bool flag2;
                if (!ReferenceEquals(frame, null))
                {
                    font = new Font(Font.FontFamily, 24f);
                    e.Graphics.DrawString(lbFPS.Text, new Font(Font.FontFamily, 16f), Brushes.Yellow, new PointF(1f, 1f));
                    brush = new SolidBrush(Color.FromArgb(0xff, 0, 0, 0));
                    brush2 = new SolidBrush(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                    pen = new Pen(Color.FromArgb(150, 0, 0xff, 0));
                    flag2 = !cbShowContours.Checked;
                    if (!flag2)
                    {
                        using (List<Contour<Point>>.Enumerator enumerator = processor.contours.GetEnumerator())
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
                //lock (this.processor.foundTemplates)
                {
                    using (List<FoundTemplateDesc>.Enumerator enumerator2 = processor.foundTemplates.GetEnumerator())
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
                                DrawAugmentedReality(current, e.Graphics);
                                continue;
                            }
                            Rectangle sourceBoundingRect = current.sample.contour.SourceBoundingRect;
                            Point point = new Point((sourceBoundingRect.Left + sourceBoundingRect.Right) / 2, sourceBoundingRect.Top);
                            string name = current.template.name;
                            if (showAngle)
                            {
                                name = name + $"angle={((180.0 * current.angle) / 3.1415926535897931):000}°scale={current.scale:0.0}";

                            }

                            e.Graphics.DrawRectangle(pen, sourceBoundingRect);
                            e.Graphics.DrawString(name, font, brush, new PointF((point.X + 1) - (font.Height / 3), (point.Y + 1) - font.Height));
                            e.Graphics.DrawString(name, font, brush2, new PointF(point.X - (font.Height / 3), point.Y - font.Height));
                        }
                    }
                }
            }
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ibMain = new Emgu.CV.UI.ImageBox();
            pnSettings = new System.Windows.Forms.Panel();
            panAndZoomPictureBox1 = new Emgu.CV.UI.PanAndZoomPictureBox();
            cbShowBinarized = new System.Windows.Forms.CheckBox();
            cbShowContours = new System.Windows.Forms.CheckBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            nudMaxACFdesc = new System.Windows.Forms.NumericUpDown();
            nudMinACF = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            cbAllowAngleMore45 = new System.Windows.Forms.CheckBox();
            label6 = new System.Windows.Forms.Label();
            nudMinICF = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            nudMinDefinition = new System.Windows.Forms.NumericUpDown();
            cbNoiseFilter = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            nudMinContourLength = new System.Windows.Forms.NumericUpDown();
            nudMinContourArea = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            nudAdaptiveThBlockSize = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            cbBlur = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            cbCaptureFromCam = new System.Windows.Forms.CheckBox();
            cbCamResolution = new System.Windows.Forms.ComboBox();
            btLoadImage = new System.Windows.Forms.Button();
            cbAutoContrast = new System.Windows.Forms.CheckBox();
            cbShowAngle = new System.Windows.Forms.CheckBox();
            ssMain = new System.Windows.Forms.StatusStrip();
            lbFPS = new System.Windows.Forms.ToolStripStatusLabel();
            lbContoursCount = new System.Windows.Forms.ToolStripStatusLabel();
            lbRecognized = new System.Windows.Forms.ToolStripStatusLabel();
            btNewTemplates = new System.Windows.Forms.ToolStripButton();
            btOpenTemplates = new System.Windows.Forms.ToolStripButton();
            btSaveTemplates = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            btCreateTemplate = new System.Windows.Forms.ToolStripButton();
            btAutoGenerate = new System.Windows.Forms.ToolStripButton();
            btTemplateEditor = new System.Windows.Forms.ToolStripButton();
            splitter1 = new System.Windows.Forms.Splitter();
            tmUpdateState = new System.Windows.Forms.Timer(components);
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(ibMain)).BeginInit();
            pnSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panAndZoomPictureBox1)).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(nudMaxACFdesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(nudMinACF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(nudMinICF)).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(nudMinDefinition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(nudMinContourLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(nudMinContourArea)).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(nudAdaptiveThBlockSize)).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ibMain
            // 
            ibMain.Dock = System.Windows.Forms.DockStyle.Fill;
            ibMain.Location = new System.Drawing.Point(0, 25);
            ibMain.Name = "ibMain";
            ibMain.Size = new System.Drawing.Size(499, 405);
            ibMain.TabIndex = 2;
            ibMain.TabStop = false;
            ibMain.Paint += new System.Windows.Forms.PaintEventHandler(ibMain_Paint);
            // 
            // pnSettings
            // 
            pnSettings.AutoScroll = true;
            pnSettings.Controls.Add(panAndZoomPictureBox1);
            pnSettings.Controls.Add(cbShowBinarized);
            pnSettings.Controls.Add(cbShowContours);
            pnSettings.Controls.Add(groupBox3);
            pnSettings.Controls.Add(groupBox2);
            pnSettings.Controls.Add(groupBox1);
            pnSettings.Controls.Add(cbShowAngle);
            pnSettings.Dock = System.Windows.Forms.DockStyle.Right;
            pnSettings.Location = new System.Drawing.Point(504, 25);
            pnSettings.Name = "pnSettings";
            pnSettings.Size = new System.Drawing.Size(209, 405);
            pnSettings.TabIndex = 3;
            pnSettings.Paint += new System.Windows.Forms.PaintEventHandler(pnSettings_Paint);
            // 
            // panAndZoomPictureBox1
            // 
            panAndZoomPictureBox1.Location = new System.Drawing.Point(145, 190);
            panAndZoomPictureBox1.Name = "panAndZoomPictureBox1";
            panAndZoomPictureBox1.Size = new System.Drawing.Size(8, 8);
            panAndZoomPictureBox1.TabIndex = 22;
            panAndZoomPictureBox1.TabStop = false;
            // 
            // cbShowBinarized
            // 
            cbShowBinarized.AutoSize = true;
            cbShowBinarized.Location = new System.Drawing.Point(6, 178);
            cbShowBinarized.Name = "cbShowBinarized";
            cbShowBinarized.Size = new System.Drawing.Size(101, 17);
            cbShowBinarized.TabIndex = 21;
            cbShowBinarized.Text = "Show binarized ";
            cbShowBinarized.UseVisualStyleBackColor = true;
            // 
            // cbShowContours
            // 
            cbShowContours.AutoSize = true;
            cbShowContours.Location = new System.Drawing.Point(95, 155);
            cbShowContours.Name = "cbShowContours";
            cbShowContours.Size = new System.Drawing.Size(97, 17);
            cbShowContours.TabIndex = 20;
            cbShowContours.Text = "Show contours";
            cbShowContours.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nudMaxACFdesc);
            groupBox3.Controls.Add(nudMinACF);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(cbAllowAngleMore45);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(nudMinICF);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new System.Drawing.Point(6, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(182, 128);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Recognition parameters";
            // 
            // nudMaxACFdesc
            // 
            nudMaxACFdesc.Location = new System.Drawing.Point(6, 36);
            nudMaxACFdesc.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            nudMaxACFdesc.Name = "nudMaxACFdesc";
            nudMaxACFdesc.Size = new System.Drawing.Size(78, 20);
            nudMaxACFdesc.TabIndex = 15;
            nudMaxACFdesc.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            nudMaxACFdesc.ValueChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // nudMinACF
            // 
            nudMinACF.DecimalPlaces = 2;
            nudMinACF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            nudMinACF.Location = new System.Drawing.Point(6, 75);
            nudMinACF.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nudMinACF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            nudMinACF.Name = "nudMinACF";
            nudMinACF.Size = new System.Drawing.Size(78, 20);
            nudMinACF.TabIndex = 11;
            nudMinACF.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            nudMinACF.ValueChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 59);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 13);
            label5.TabIndex = 12;
            label5.Text = "Min. ACF";
            // 
            // cbAllowAngleMore45
            // 
            cbAllowAngleMore45.AutoSize = true;
            cbAllowAngleMore45.Location = new System.Drawing.Point(7, 105);
            cbAllowAngleMore45.Name = "cbAllowAngleMore45";
            cbAllowAngleMore45.Size = new System.Drawing.Size(109, 17);
            cbAllowAngleMore45.TabIndex = 6;
            cbAllowAngleMore45.Text = "Allow angles > 45";
            cbAllowAngleMore45.UseVisualStyleBackColor = true;
            cbAllowAngleMore45.CheckedChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 20);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(148, 13);
            label6.TabIndex = 16;
            label6.Text = "Max. ACF descriptor deviation";
            // 
            // nudMinICF
            // 
            nudMinICF.DecimalPlaces = 2;
            nudMinICF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            nudMinICF.Location = new System.Drawing.Point(101, 75);
            nudMinICF.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nudMinICF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            nudMinICF.Name = "nudMinICF";
            nudMinICF.Size = new System.Drawing.Size(78, 20);
            nudMinICF.TabIndex = 13;
            nudMinICF.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            nudMinICF.ValueChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(100, 59);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 13);
            label4.TabIndex = 14;
            label4.Text = "Min. ICF";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nudMinDefinition);
            groupBox2.Controls.Add(cbNoiseFilter);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(nudMinContourLength);
            groupBox2.Controls.Add(nudMinContourArea);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new System.Drawing.Point(3, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(182, 91);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contour filtration";
            // 
            // nudMinDefinition
            // 
            nudMinDefinition.Enabled = false;
            nudMinDefinition.Location = new System.Drawing.Point(100, 63);
            nudMinDefinition.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            nudMinDefinition.Name = "nudMinDefinition";
            nudMinDefinition.Size = new System.Drawing.Size(78, 20);
            nudMinDefinition.TabIndex = 12;
            nudMinDefinition.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            nudMinDefinition.ValueChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // cbNoiseFilter
            // 
            cbNoiseFilter.AutoSize = true;
            cbNoiseFilter.Location = new System.Drawing.Point(6, 64);
            cbNoiseFilter.Name = "cbNoiseFilter";
            cbNoiseFilter.Size = new System.Drawing.Size(75, 17);
            cbNoiseFilter.TabIndex = 11;
            cbNoiseFilter.Text = "Noise filter";
            cbNoiseFilter.UseVisualStyleBackColor = true;
            cbNoiseFilter.CheckedChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 13);
            label2.TabIndex = 8;
            label2.Text = "Min. contour length";
            // 
            // nudMinContourLength
            // 
            nudMinContourLength.Location = new System.Drawing.Point(5, 34);
            nudMinContourLength.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            nudMinContourLength.Name = "nudMinContourLength";
            nudMinContourLength.Size = new System.Drawing.Size(78, 20);
            nudMinContourLength.TabIndex = 7;
            nudMinContourLength.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            nudMinContourLength.ValueChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // nudMinContourArea
            // 
            nudMinContourArea.Location = new System.Drawing.Point(100, 34);
            nudMinContourArea.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            nudMinContourArea.Name = "nudMinContourArea";
            nudMinContourArea.Size = new System.Drawing.Size(78, 20);
            nudMinContourArea.TabIndex = 9;
            nudMinContourArea.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            nudMinContourArea.ValueChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(97, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 13);
            label3.TabIndex = 10;
            label3.Text = "Min. contour area";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudAdaptiveThBlockSize);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbBlur);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbCaptureFromCam);
            groupBox1.Controls.Add(cbCamResolution);
            groupBox1.Controls.Add(btLoadImage);
            groupBox1.Controls.Add(cbAutoContrast);
            groupBox1.Location = new System.Drawing.Point(5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(177, 146);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Source";
            groupBox1.Enter += new System.EventHandler(groupBox1_Enter);
            // 
            // nudAdaptiveThBlockSize
            // 
            nudAdaptiveThBlockSize.Location = new System.Drawing.Point(11, 122);
            nudAdaptiveThBlockSize.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            nudAdaptiveThBlockSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nudAdaptiveThBlockSize.Name = "nudAdaptiveThBlockSize";
            nudAdaptiveThBlockSize.Size = new System.Drawing.Size(78, 20);
            nudAdaptiveThBlockSize.TabIndex = 11;
            nudAdaptiveThBlockSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            nudAdaptiveThBlockSize.ValueChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(8, 106);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(145, 13);
            label7.TabIndex = 12;
            label7.Text = "Adaptive threshold block size";
            // 
            // cbBlur
            // 
            cbBlur.AutoSize = true;
            cbBlur.Checked = true;
            cbBlur.CheckState = System.Windows.Forms.CheckState.Checked;
            cbBlur.Location = new System.Drawing.Point(106, 84);
            cbBlur.Name = "cbBlur";
            cbBlur.Size = new System.Drawing.Size(44, 17);
            cbBlur.TabIndex = 6;
            cbBlur.Text = "Blur";
            cbBlur.UseVisualStyleBackColor = true;
            cbBlur.CheckedChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 13);
            label1.TabIndex = 4;
            label1.Text = "Cam resolution";
            // 
            // cbCaptureFromCam
            // 
            cbCaptureFromCam.AutoSize = true;
            cbCaptureFromCam.Checked = true;
            cbCaptureFromCam.CheckState = System.Windows.Forms.CheckState.Checked;
            cbCaptureFromCam.Location = new System.Drawing.Point(11, 16);
            cbCaptureFromCam.Name = "cbCaptureFromCam";
            cbCaptureFromCam.Size = new System.Drawing.Size(124, 17);
            cbCaptureFromCam.TabIndex = 2;
            cbCaptureFromCam.Text = "Capture from camera";
            cbCaptureFromCam.UseVisualStyleBackColor = true;
            cbCaptureFromCam.CheckedChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // cbCamResolution
            // 
            cbCamResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCamResolution.FormattingEnabled = true;
            cbCamResolution.Items.AddRange(new object[] {
            "800x600",
            "640x480",
            "320x240"});
            cbCamResolution.Location = new System.Drawing.Point(11, 51);
            cbCamResolution.Name = "cbCamResolution";
            cbCamResolution.Size = new System.Drawing.Size(89, 21);
            cbCamResolution.TabIndex = 3;
            cbCamResolution.TextChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // btLoadImage
            // 
            btLoadImage.Enabled = false;
            btLoadImage.Location = new System.Drawing.Point(105, 38);
            btLoadImage.Name = "btLoadImage";
            btLoadImage.Size = new System.Drawing.Size(68, 35);
            btLoadImage.TabIndex = 5;
            btLoadImage.Text = "Recognize image ...";
            btLoadImage.UseVisualStyleBackColor = true;
            btLoadImage.Click += new System.EventHandler(btLoadImage_Click);
            // 
            // cbAutoContrast
            // 
            cbAutoContrast.AutoSize = true;
            cbAutoContrast.Location = new System.Drawing.Point(11, 84);
            cbAutoContrast.Name = "cbAutoContrast";
            cbAutoContrast.Size = new System.Drawing.Size(89, 17);
            cbAutoContrast.TabIndex = 1;
            cbAutoContrast.Text = "Auto contrast";
            cbAutoContrast.UseVisualStyleBackColor = true;
            cbAutoContrast.CheckedChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // cbShowAngle
            // 
            cbShowAngle.AutoSize = true;
            cbShowAngle.Location = new System.Drawing.Point(6, 155);
            cbShowAngle.Name = "cbShowAngle";
            cbShowAngle.Size = new System.Drawing.Size(87, 17);
            cbShowAngle.TabIndex = 0;
            cbShowAngle.Text = "Show angles";
            cbShowAngle.UseVisualStyleBackColor = true;
            cbShowAngle.CheckedChanged += new System.EventHandler(cbAutoContrast_CheckedChanged);
            // 
            // ssMain
            // 
            ssMain.Location = new System.Drawing.Point(0, 430);
            ssMain.Name = "ssMain";
            ssMain.Size = new System.Drawing.Size(713, 22);
            ssMain.TabIndex = 4;
            ssMain.Text = "statusStrip1";
            ssMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(ssMain_ItemClicked);
            // 
            // lbFPS
            // 
            lbFPS.AutoSize = false;
            lbFPS.BorderSides = (((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
            lbFPS.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            lbFPS.Name = "lbFPS";
            lbFPS.Size = new System.Drawing.Size(52, 17);
            lbFPS.Text = "0 fps";
            // 
            // lbContoursCount
            // 
            lbContoursCount.AutoSize = false;
            lbContoursCount.BorderSides = (((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
            lbContoursCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            lbContoursCount.Name = "lbContoursCount";
            lbContoursCount.Size = new System.Drawing.Size(120, 17);
            lbContoursCount.Text = "Total Contours: ";
            lbContoursCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbContoursCount.Click += new System.EventHandler(lbContoursCount_Click);
            // 
            // lbRecognized
            // 
            lbRecognized.AutoSize = false;
            lbRecognized.BorderSides = (((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
            lbRecognized.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            lbRecognized.Name = "lbRecognized";
            lbRecognized.Size = new System.Drawing.Size(150, 17);
            lbRecognized.Text = "Recognized Contours: ";
            lbRecognized.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbRecognized.Click += new System.EventHandler(btAutoGenerate_Click);
            // 
            // btNewTemplates
            // 
            btNewTemplates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btNewTemplates.ImageTransparentColor = System.Drawing.Color.Magenta;
            btNewTemplates.Name = "btNewTemplates";
            btNewTemplates.Size = new System.Drawing.Size(23, 22);
            btNewTemplates.Text = "New templates";
            btNewTemplates.Click += new System.EventHandler(btNewTemplates_Click);
            // 
            // btOpenTemplates
            // 
            btOpenTemplates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btOpenTemplates.ImageTransparentColor = System.Drawing.Color.Magenta;
            btOpenTemplates.Name = "btOpenTemplates";
            btOpenTemplates.Size = new System.Drawing.Size(23, 22);
            btOpenTemplates.Text = "Open templates";
            btOpenTemplates.Click += new System.EventHandler(btOpenTemplates_Click);
            // 
            // btSaveTemplates
            // 
            btSaveTemplates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btSaveTemplates.ImageTransparentColor = System.Drawing.Color.Magenta;
            btSaveTemplates.Name = "btSaveTemplates";
            btSaveTemplates.Size = new System.Drawing.Size(23, 22);
            btSaveTemplates.Text = "Save templates";
            btSaveTemplates.Click += new System.EventHandler(btSaveTemplates_Click);
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btCreateTemplate
            // 
            btCreateTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btCreateTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            btCreateTemplate.Name = "btCreateTemplate";
            btCreateTemplate.Size = new System.Drawing.Size(23, 22);
            btCreateTemplate.Text = "Create template";
            btCreateTemplate.Click += new System.EventHandler(btCreateTemplate_Click);
            // 
            // btAutoGenerate
            // 
            btAutoGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btAutoGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            btAutoGenerate.Name = "btAutoGenerate";
            btAutoGenerate.Size = new System.Drawing.Size(23, 22);
            btAutoGenerate.Text = "Auto generate templates";
            btAutoGenerate.Click += new System.EventHandler(btAutoGenerate_Click);
            // 
            // btTemplateEditor
            // 
            btTemplateEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btTemplateEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            btTemplateEditor.Name = "btTemplateEditor";
            btTemplateEditor.Size = new System.Drawing.Size(23, 22);
            btTemplateEditor.Text = "Template viewer";
            btTemplateEditor.Click += new System.EventHandler(btTemplateEditor_Click);
            // 
            // splitter1
            // 
            splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            splitter1.Location = new System.Drawing.Point(499, 25);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(5, 405);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // tmUpdateState
            // 
            tmUpdateState.Enabled = true;
            tmUpdateState.Interval = 1000;
            tmUpdateState.Tick += new System.EventHandler(tmUpdateState_Tick);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lbFPS,
            lbContoursCount,
            lbRecognized,
            toolStripLabel1,
            toolStripDropDownButton1,
            toolStripComboBox1,
            toolStripTextBox1,
            toolStripProgressBar1});
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(713, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            toolStripLabel1.Text = "toolStripLabel1";
            toolStripLabel1.Click += new System.EventHandler(toolStripLabel1_Click);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new System.Drawing.Size(100, 15);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(713, 452);
            Controls.Add(ibMain);
            Controls.Add(splitter1);
            Controls.Add(pnSettings);
            Controls.Add(ssMain);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            Text = "Contour Analysis Demo";
            Load += new System.EventHandler(MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(ibMain)).EndInit();
            pnSettings.ResumeLayout(false);
            pnSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(panAndZoomPictureBox1)).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(nudMaxACFdesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(nudMinACF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(nudMinICF)).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(nudMinDefinition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(nudMinContourLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(nudMinContourArea)).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(nudAdaptiveThBlockSize)).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private void LoadTemplates(string fileName)
        {
            try
            {
                FileStream serializationStream = new FileStream(fileName, FileMode.Open);
                try
                {
                    processor.templates = (Templates)new BinaryFormatter().Deserialize(serializationStream);
                }
                finally
                {
                    if (!ReferenceEquals(serializationStream, null))
                    {
                        serializationStream.Dispose();
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message);
            }
        }

        private void ProcessFrame()
        {
            try
            {
                if (captureFromCam)
                {
                    frame = _capture.QueryFrame();
                }
                frameCount++;
                processor.ProcessImage(frame);
                ibMain.Image = !cbShowBinarized.Checked ? frame : ((IImage)processor.binarizedFrame);
            }
            catch (Exception exception1)
            {
                Console.WriteLine(exception1.Message);
            }
        }

        private void SaveTemplates(string fileName)
        {
            try
            {
                FileStream serializationStream = new FileStream(fileName, FileMode.Create);
                try
                {
                    new BinaryFormatter().Serialize(serializationStream, processor.templates);
                }
                finally
                {
                    if (!ReferenceEquals(serializationStream, null))
                    {
                        serializationStream.Dispose();
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message);
            }
        }

        private void StartCapture()
        {
            try
            {
                _capture = new Capture();
                ApplyCamSettings();
            }
            catch (NullReferenceException exception1)
            {
                MessageBox.Show(exception1.Message);
            }
        }

        private void tmUpdateState_Tick(object sender, EventArgs e)
        {
            lbFPS.Text = (frameCount - oldFrameCount) + " fps";
            oldFrameCount = frameCount;
            if (!ReferenceEquals(processor.contours, null))
            {
                lbContoursCount.Text = "Contours: " + processor.contours.Count;
            }
            if (!ReferenceEquals(processor.foundTemplates, null))
            {
                lbRecognized.Text = "Recognized contours: " + processor.foundTemplates.Count;
            }
        }

        private void ssMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lbContoursCount_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pnSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

