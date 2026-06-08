namespace ContourAnalysisDemo
{
    using ContourAnalysisNS;
    using Emgu.CV;
    using Emgu.CV.CvEnum;
    using Emgu.CV.UI;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Windows.Forms;

    public class MainForm : Form
    {
        private Capture _capture;
        private Image<Bgr, byte> frame;
        private ImageProcessor processor;
        private Dictionary<string, Image> AugmentedRealityImages = new Dictionary<string, Image>();
        private bool captureFromCam = true;
        private int frameCount = 0;
        private int oldFrameCount = 0;
        private bool showAngle;
        private int camWidth = 640;
        private int camHeight = 480;
        private string templateFile;
        private IContainer components = null;
        private ImageBox ibMain;
        private Panel pnSettings;
        private StatusStrip ssMain;
        private Splitter splitter1;
        private ToolStripStatusLabel lbFPS;
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
        private CheckBox cbShowBinarized;

        public MainForm()
        {
            this.InitializeComponent();
            this.processor = new ImageProcessor();
            this.templateFile = AppDomain.CurrentDomain.BaseDirectory + @"\Tahoma.bin";
            this.LoadTemplates(this.templateFile);
            this.StartCapture();
            this.ApplySettings();
            Application.Idle += new EventHandler(this.Application_Idle);
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            this.ProcessFrame();
        }

        private void ApplyCamSettings()
        {
            try
            {
                this._capture.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, (double) this.camWidth);
                this._capture.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, (double) this.camHeight);
                this.cbCamResolution.Text = this.camWidth + "x" + this.camHeight;
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
                this.processor.equalizeHist = this.cbAutoContrast.Checked;
                this.showAngle = this.cbShowAngle.Checked;
                this.captureFromCam = this.cbCaptureFromCam.Checked;
                this.btLoadImage.Enabled = !this.captureFromCam;
                this.cbCamResolution.Enabled = this.captureFromCam;
                this.processor.finder.maxRotateAngle = this.cbAllowAngleMore45.Checked ? 3.1415926535897931 : 0.78539816339744828;
                this.processor.minContourArea = (int) this.nudMinContourArea.Value;
                this.processor.minContourLength = (int) this.nudMinContourLength.Value;
                this.processor.finder.maxACFDescriptorDeviation = (int) this.nudMaxACFdesc.Value;
                this.processor.finder.minACF = (double) this.nudMinACF.Value;
                this.processor.finder.minICF = (double) this.nudMinICF.Value;
                this.processor.blur = this.cbBlur.Checked;
                this.processor.noiseFilter = this.cbNoiseFilter.Checked;
                this.processor.cannyThreshold = (int) this.nudMinDefinition.Value;
                this.nudMinDefinition.Enabled = this.processor.noiseFilter;
                this.processor.adaptiveThresholdBlockSize = (int) this.nudAdaptiveThBlockSize.Value;
                string[] strArray = this.cbCamResolution.Text.ToLower().Split(new char[] { 'x' });
                if (strArray.Length == 2)
                {
                    int num = int.Parse(strArray[0]);
                    int num2 = int.Parse(strArray[1]);
                    if ((this.camHeight != num2) || (this.camWidth != num))
                    {
                        this.camWidth = num;
                        this.camHeight = num2;
                        this.ApplyCamSettings();
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
            new AutoGenerateForm(this.processor).ShowDialog();
        }

        private void btCreateTemplate_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(this.frame, null))
            {
                new ShowContoursForm(this.processor.templates, this.processor.samples, this.frame).ShowDialog();
            }
        }

        private void btLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    this.frame = new Image<Bgr, byte>((Bitmap) Image.FromFile(dialog.FileName));
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
                this.processor.templates.Clear();
            }
        }

        private void btOpenTemplates_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = "Templates(*.bin)|*.bin"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this.templateFile = dialog.FileName;
                this.LoadTemplates(this.templateFile);
            }
        }

        private void btSaveTemplates_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog {
                Filter = "Templates(*.bin)|*.bin"
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this.templateFile = dialog.FileName;
                this.SaveTemplates(this.templateFile);
            }
        }

        private void btTemplateEditor_Click(object sender, EventArgs e)
        {
            new TemplateEditor(this.processor.templates).Show();
        }

        private void cbAutoContrast_CheckedChanged(object sender, EventArgs e)
        {
            this.ApplySettings();
        }

        protected override void Dispose(bool disposing)
        {
            if (!(!disposing || ReferenceEquals(this.components, null)))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void DrawAugmentedReality(FoundTemplateDesc found, Graphics gr)
        {
            string key = Path.GetDirectoryName(this.templateFile) + @"\" + found.template.name;
            if (!this.AugmentedRealityImages.ContainsKey(key))
            {
                if (File.Exists(key))
                {
                    this.AugmentedRealityImages[key] = Image.FromFile(key);
                }
                else
                {
                    return;
                }
            }
            Image image = this.AugmentedRealityImages[key];
            Point point = found.sample.contour.SourceBoundingRect.Center();
            GraphicsState gstate = gr.Save();
            gr.TranslateTransform((float) point.X, (float) point.Y);
            gr.RotateTransform((float) ((180.0 * found.angle) / 3.1415926535897931));
            gr.ScaleTransform((float) found.scale, (float) found.scale);
            gr.DrawImage(image, new Point(-image.Width / 2, -image.Height / 2));
            gr.Restore(gstate);
        }

        private void ibMain_Paint(object sender, PaintEventArgs e)
        {
            Font font;
            Brush brush;
            Brush brush2;
            Pen pen;
            bool flag2;
            if (!ReferenceEquals(this.frame, null))
            {
                font = new Font(this.Font.FontFamily, 24f);
                e.Graphics.DrawString(this.lbFPS.Text, new Font(this.Font.FontFamily, 16f), Brushes.Yellow, new PointF(1f, 1f));
                brush = new SolidBrush(Color.FromArgb(0xff, 0, 0, 0));
                brush2 = new SolidBrush(Color.FromArgb(0xff, 0xff, 0xff, 0xff));
                pen = new Pen(Color.FromArgb(150, 0, 0xff, 0));
                flag2 = !this.cbShowContours.Checked;
                if (!flag2)
                {
                    using (List<Contour<Point>>.Enumerator enumerator = this.processor.contours.GetEnumerator())
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
            lock (this.processor.foundTemplates)
            {
                using (List<FoundTemplateDesc>.Enumerator enumerator2 = this.processor.foundTemplates.GetEnumerator())
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
                            this.DrawAugmentedReality(current, e.Graphics);
                            continue;
                        }
                        Rectangle sourceBoundingRect = current.sample.contour.SourceBoundingRect;
                        Point point = new Point((sourceBoundingRect.Left + sourceBoundingRect.Right) / 2, sourceBoundingRect.Top);
                        string name = current.template.name;
                        if (this.showAngle)
                        {
                            name = name + $"
angle={((180.0 * current.angle) / 3.1415926535897931):000}°
scale={current.scale:0.0}";
                        }
                        e.Graphics.DrawRectangle(pen, sourceBoundingRect);
                        e.Graphics.DrawString(name, font, brush, new PointF((float) ((point.X + 1) - (font.Height / 3)), (float) ((point.Y + 1) - font.Height)));
                        e.Graphics.DrawString(name, font, brush2, new PointF((float) (point.X - (font.Height / 3)), (float) (point.Y - font.Height)));
                    }
                }
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(MainForm));
            this.ibMain = new ImageBox();
            this.pnSettings = new Panel();
            this.cbShowBinarized = new CheckBox();
            this.cbShowContours = new CheckBox();
            this.groupBox3 = new GroupBox();
            this.nudMaxACFdesc = new NumericUpDown();
            this.nudMinACF = new NumericUpDown();
            this.label5 = new Label();
            this.cbAllowAngleMore45 = new CheckBox();
            this.label6 = new Label();
            this.nudMinICF = new NumericUpDown();
            this.label4 = new Label();
            this.groupBox2 = new GroupBox();
            this.nudMinDefinition = new NumericUpDown();
            this.cbNoiseFilter = new CheckBox();
            this.label2 = new Label();
            this.nudMinContourLength = new NumericUpDown();
            this.nudMinContourArea = new NumericUpDown();
            this.label3 = new Label();
            this.groupBox1 = new GroupBox();
            this.nudAdaptiveThBlockSize = new NumericUpDown();
            this.label7 = new Label();
            this.cbBlur = new CheckBox();
            this.label1 = new Label();
            this.cbCaptureFromCam = new CheckBox();
            this.cbCamResolution = new ComboBox();
            this.btLoadImage = new Button();
            this.cbAutoContrast = new CheckBox();
            this.cbShowAngle = new CheckBox();
            this.ssMain = new StatusStrip();
            this.lbFPS = new ToolStripStatusLabel();
            this.lbContoursCount = new ToolStripStatusLabel();
            this.lbRecognized = new ToolStripStatusLabel();
            this.splitter1 = new Splitter();
            this.tmUpdateState = new Timer(this.components);
            this.toolStrip1 = new ToolStrip();
            this.btNewTemplates = new ToolStripButton();
            this.btOpenTemplates = new ToolStripButton();
            this.btSaveTemplates = new ToolStripButton();
            this.toolStripSeparator = new ToolStripSeparator();
            this.btCreateTemplate = new ToolStripButton();
            this.btAutoGenerate = new ToolStripButton();
            this.btTemplateEditor = new ToolStripButton();
            ((ISupportInitialize) this.ibMain).BeginInit();
            this.pnSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.nudMaxACFdesc.BeginInit();
            this.nudMinACF.BeginInit();
            this.nudMinICF.BeginInit();
            this.groupBox2.SuspendLayout();
            this.nudMinDefinition.BeginInit();
            this.nudMinContourLength.BeginInit();
            this.nudMinContourArea.BeginInit();
            this.groupBox1.SuspendLayout();
            this.nudAdaptiveThBlockSize.BeginInit();
            this.ssMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            base.SuspendLayout();
            this.ibMain.Dock = DockStyle.Fill;
            this.ibMain.Location = new Point(0, 0x19);
            this.ibMain.Name = "ibMain";
            this.ibMain.Size = new Size(0x1f3, 0x195);
            this.ibMain.TabIndex = 2;
            this.ibMain.TabStop = false;
            this.ibMain.Paint += new PaintEventHandler(this.ibMain_Paint);
            this.pnSettings.AutoScroll = true;
            this.pnSettings.Controls.Add(this.cbShowBinarized);
            this.pnSettings.Controls.Add(this.cbShowContours);
            this.pnSettings.Controls.Add(this.groupBox3);
            this.pnSettings.Controls.Add(this.groupBox2);
            this.pnSettings.Controls.Add(this.groupBox1);
            this.pnSettings.Controls.Add(this.cbShowAngle);
            this.pnSettings.Dock = DockStyle.Right;
            this.pnSettings.Location = new Point(0x1f8, 0x19);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new Size(0xd1, 0x195);
            this.pnSettings.TabIndex = 3;
            this.cbShowBinarized.AutoSize = true;
            this.cbShowBinarized.Location = new Point(6, 0xb2);
            this.cbShowBinarized.Name = "cbShowBinarized";
            this.cbShowBinarized.Size = new Size(0x65, 0x11);
            this.cbShowBinarized.TabIndex = 0x15;
            this.cbShowBinarized.Text = "Show binarized ";
            this.cbShowBinarized.UseVisualStyleBackColor = true;
            this.cbShowContours.AutoSize = true;
            this.cbShowContours.Location = new Point(0x5f, 0x9b);
            this.cbShowContours.Name = "cbShowContours";
            this.cbShowContours.Size = new Size(0x61, 0x11);
            this.cbShowContours.TabIndex = 20;
            this.cbShowContours.Text = "Show contours";
            this.cbShowContours.UseVisualStyleBackColor = true;
            this.groupBox3.Controls.Add(this.nudMaxACFdesc);
            this.groupBox3.Controls.Add(this.nudMinACF);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbAllowAngleMore45);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.nudMinICF);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new Point(6, 0x13d);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0xb6, 0x80);
            this.groupBox3.TabIndex = 0x13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recognition parameters";
            this.nudMaxACFdesc.Location = new Point(6, 0x24);
            this.nudMaxACFdesc.Maximum = new decimal(new int[] { 50 });
            this.nudMaxACFdesc.Name = "nudMaxACFdesc";
            this.nudMaxACFdesc.Size = new Size(0x4e, 20);
            this.nudMaxACFdesc.TabIndex = 15;
            this.nudMaxACFdesc.Value = new decimal(new int[] { 4 });
            this.nudMaxACFdesc.ValueChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.nudMinACF.DecimalPlaces = 2;
            int[] bits = new int[] { 1 };
            bits[3] = 0x20000;
            this.nudMinACF.Increment = new decimal(bits);
            this.nudMinACF.Location = new Point(6, 0x4b);
            this.nudMinACF.Maximum = new decimal(new int[] { 1 });
            bits = new int[] { 2 };
            bits[3] = 0x10000;
            this.nudMinACF.Minimum = new decimal(bits);
            this.nudMinACF.Name = "nudMinACF";
            this.nudMinACF.Size = new Size(0x4e, 20);
            this.nudMinACF.TabIndex = 11;
            bits = new int[] { 0x60 };
            bits[3] = 0x20000;
            this.nudMinACF.Value = new decimal(bits);
            this.nudMinACF.ValueChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.label5.AutoSize = true;
            this.label5.Location = new Point(3, 0x3b);
            this.label5.Name = "label5";
            this.label5.Size = new Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Min. ACF";
            this.cbAllowAngleMore45.AutoSize = true;
            this.cbAllowAngleMore45.Location = new Point(7, 0x69);
            this.cbAllowAngleMore45.Name = "cbAllowAngleMore45";
            this.cbAllowAngleMore45.Size = new Size(0x6d, 0x11);
            this.cbAllowAngleMore45.TabIndex = 6;
            this.cbAllowAngleMore45.Text = "Allow angles > 45";
            this.cbAllowAngleMore45.UseVisualStyleBackColor = true;
            this.cbAllowAngleMore45.CheckedChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.label6.AutoSize = true;
            this.label6.Location = new Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x94, 13);
            this.label6.TabIndex = 0x10;
            this.label6.Text = "Max. ACF descriptor deviation";
            this.nudMinICF.DecimalPlaces = 2;
            bits = new int[] { 1 };
            bits[3] = 0x20000;
            this.nudMinICF.Increment = new decimal(bits);
            this.nudMinICF.Location = new Point(0x65, 0x4b);
            this.nudMinICF.Maximum = new decimal(new int[] { 1 });
            bits = new int[] { 2 };
            bits[3] = 0x10000;
            this.nudMinICF.Minimum = new decimal(bits);
            this.nudMinICF.Name = "nudMinICF";
            this.nudMinICF.Size = new Size(0x4e, 20);
            this.nudMinICF.TabIndex = 13;
            bits = new int[] { 0x55 };
            bits[3] = 0x20000;
            this.nudMinICF.Value = new decimal(bits);
            this.nudMinICF.ValueChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.label4.AutoSize = true;
            this.label4.Location = new Point(100, 0x3b);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x2e, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Min. ICF";
            this.groupBox2.Controls.Add(this.nudMinDefinition);
            this.groupBox2.Controls.Add(this.cbNoiseFilter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudMinContourLength);
            this.groupBox2.Controls.Add(this.nudMinContourArea);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new Point(3, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0xb6, 0x5b);
            this.groupBox2.TabIndex = 0x12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contour filtration";
            this.nudMinDefinition.Enabled = false;
            this.nudMinDefinition.Location = new Point(100, 0x3f);
            this.nudMinDefinition.Maximum = new decimal(new int[] { 0xff });
            this.nudMinDefinition.Name = "nudMinDefinition";
            this.nudMinDefinition.Size = new Size(0x4e, 20);
            this.nudMinDefinition.TabIndex = 12;
            this.nudMinDefinition.Value = new decimal(new int[] { 50 });
            this.nudMinDefinition.ValueChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.cbNoiseFilter.AutoSize = true;
            this.cbNoiseFilter.Location = new Point(6, 0x40);
            this.cbNoiseFilter.Name = "cbNoiseFilter";
            this.cbNoiseFilter.Size = new Size(0x4b, 0x11);
            this.cbNoiseFilter.TabIndex = 11;
            this.cbNoiseFilter.Text = "Noise filter";
            this.cbNoiseFilter.UseVisualStyleBackColor = true;
            this.cbNoiseFilter.CheckedChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new Point(1, 0x12);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Min. contour length";
            this.nudMinContourLength.Location = new Point(5, 0x22);
            this.nudMinContourLength.Maximum = new decimal(new int[] { 400 });
            this.nudMinContourLength.Name = "nudMinContourLength";
            this.nudMinContourLength.Size = new Size(0x4e, 20);
            this.nudMinContourLength.TabIndex = 7;
            this.nudMinContourLength.Value = new decimal(new int[] { 15 });
            this.nudMinContourLength.ValueChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.nudMinContourArea.Location = new Point(100, 0x22);
            this.nudMinContourArea.Maximum = new decimal(new int[] { 400 });
            this.nudMinContourArea.Name = "nudMinContourArea";
            this.nudMinContourArea.Size = new Size(0x4e, 20);
            this.nudMinContourArea.TabIndex = 9;
            this.nudMinContourArea.Value = new decimal(new int[] { 10 });
            this.nudMinContourArea.ValueChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.label3.AutoSize = true;
            this.label3.Location = new Point(0x61, 0x12);
            this.label3.Name = "label3";
            this.label3.Size = new Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Min. contour area";
            this.groupBox1.Controls.Add(this.nudAdaptiveThBlockSize);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbBlur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbCaptureFromCam);
            this.groupBox1.Controls.Add(this.cbCamResolution);
            this.groupBox1.Controls.Add(this.btLoadImage);
            this.groupBox1.Controls.Add(this.cbAutoContrast);
            this.groupBox1.Location = new Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0xb1, 0x92);
            this.groupBox1.TabIndex = 0x11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            this.nudAdaptiveThBlockSize.Location = new Point(11, 0x7a);
            this.nudAdaptiveThBlockSize.Maximum = new decimal(new int[] { 400 });
            this.nudAdaptiveThBlockSize.Minimum = new decimal(new int[] { 1 });
            this.nudAdaptiveThBlockSize.Name = "nudAdaptiveThBlockSize";
            this.nudAdaptiveThBlockSize.Size = new Size(0x4e, 20);
            this.nudAdaptiveThBlockSize.TabIndex = 11;
            this.nudAdaptiveThBlockSize.Value = new decimal(new int[] { 4 });
            this.nudAdaptiveThBlockSize.ValueChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.label7.AutoSize = true;
            this.label7.Location = new Point(8, 0x6a);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x91, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adaptive threshold block size";
            this.cbBlur.AutoSize = true;
            this.cbBlur.Checked = true;
            this.cbBlur.CheckState = CheckState.Checked;
            this.cbBlur.Location = new Point(0x6a, 0x54);
            this.cbBlur.Name = "cbBlur";
            this.cbBlur.Size = new Size(0x2c, 0x11);
            this.cbBlur.TabIndex = 6;
            this.cbBlur.Text = "Blur";
            this.cbBlur.UseVisualStyleBackColor = true;
            this.cbBlur.CheckedChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(13, 0x25);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x4c, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cam resolution";
            this.cbCaptureFromCam.AutoSize = true;
            this.cbCaptureFromCam.Checked = true;
            this.cbCaptureFromCam.CheckState = CheckState.Checked;
            this.cbCaptureFromCam.Location = new Point(11, 0x10);
            this.cbCaptureFromCam.Name = "cbCaptureFromCam";
            this.cbCaptureFromCam.Size = new Size(0x7c, 0x11);
            this.cbCaptureFromCam.TabIndex = 2;
            this.cbCaptureFromCam.Text = "Capture from camera";
            this.cbCaptureFromCam.UseVisualStyleBackColor = true;
            this.cbCaptureFromCam.CheckedChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.cbCamResolution.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbCamResolution.FormattingEnabled = true;
            object[] items = new object[] { "800x600", "640x480", "320x240" };
            this.cbCamResolution.Items.AddRange(items);
            this.cbCamResolution.Location = new Point(11, 0x33);
            this.cbCamResolution.Name = "cbCamResolution";
            this.cbCamResolution.Size = new Size(0x59, 0x15);
            this.cbCamResolution.TabIndex = 3;
            this.cbCamResolution.TextChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.btLoadImage.Enabled = false;
            this.btLoadImage.Location = new Point(0x69, 0x26);
            this.btLoadImage.Name = "btLoadImage";
            this.btLoadImage.Size = new Size(0x44, 0x23);
            this.btLoadImage.TabIndex = 5;
            this.btLoadImage.Text = "Recognize image ...";
            this.btLoadImage.UseVisualStyleBackColor = true;
            this.btLoadImage.Click += new EventHandler(this.btLoadImage_Click);
            this.cbAutoContrast.AutoSize = true;
            this.cbAutoContrast.Location = new Point(11, 0x54);
            this.cbAutoContrast.Name = "cbAutoContrast";
            this.cbAutoContrast.Size = new Size(0x59, 0x11);
            this.cbAutoContrast.TabIndex = 1;
            this.cbAutoContrast.Text = "Auto contrast";
            this.cbAutoContrast.UseVisualStyleBackColor = true;
            this.cbAutoContrast.CheckedChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            this.cbShowAngle.AutoSize = true;
            this.cbShowAngle.Location = new Point(6, 0x9b);
            this.cbShowAngle.Name = "cbShowAngle";
            this.cbShowAngle.Size = new Size(0x57, 0x11);
            this.cbShowAngle.TabIndex = 0;
            this.cbShowAngle.Text = "Show angles";
            this.cbShowAngle.UseVisualStyleBackColor = true;
            this.cbShowAngle.CheckedChanged += new EventHandler(this.cbAutoContrast_CheckedChanged);
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.lbFPS, this.lbContoursCount, this.lbRecognized };
            this.ssMain.Items.AddRange(toolStripItems);
            this.ssMain.Location = new Point(0, 430);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new Size(0x2c9, 0x16);
            this.ssMain.TabIndex = 4;
            this.ssMain.Text = "statusStrip1";
            this.lbFPS.AutoSize = false;
            this.lbFPS.BorderSides = ToolStripStatusLabelBorderSides.All;
            this.lbFPS.BorderStyle = Border3DStyle.SunkenOuter;
            this.lbFPS.Name = "lbFPS";
            this.lbFPS.Size = new Size(0x34, 0x11);
            this.lbFPS.Text = "0 fps";
            this.lbContoursCount.AutoSize = false;
            this.lbContoursCount.BorderSides = ToolStripStatusLabelBorderSides.All;
            this.lbContoursCount.BorderStyle = Border3DStyle.SunkenOuter;
            this.lbContoursCount.Name = "lbContoursCount";
            this.lbContoursCount.Size = new Size(120, 0x11);
            this.lbContoursCount.Text = "Total Contours: ";
            this.lbContoursCount.TextAlign = ContentAlignment.MiddleLeft;
            this.lbRecognized.AutoSize = false;
            this.lbRecognized.BorderSides = ToolStripStatusLabelBorderSides.All;
            this.lbRecognized.BorderStyle = Border3DStyle.SunkenOuter;
            this.lbRecognized.Name = "lbRecognized";
            this.lbRecognized.Size = new Size(150, 0x11);
            this.lbRecognized.Text = "Recognized Contours: ";
            this.lbRecognized.TextAlign = ContentAlignment.MiddleLeft;
            this.splitter1.Dock = DockStyle.Right;
            this.splitter1.Location = new Point(0x1f3, 0x19);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new Size(5, 0x195);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            this.tmUpdateState.Enabled = true;
            this.tmUpdateState.Interval = 0x3e8;
            this.tmUpdateState.Tick += new EventHandler(this.tmUpdateState_Tick);
            toolStripItems = new ToolStripItem[] { this.btNewTemplates, this.btOpenTemplates, this.btSaveTemplates, this.toolStripSeparator, this.btCreateTemplate, this.btAutoGenerate, this.btTemplateEditor };
            this.toolStrip1.Items.AddRange(toolStripItems);
            this.toolStrip1.Location = new Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(0x2c9, 0x19);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            this.btNewTemplates.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btNewTemplates.Image = (Image) manager.GetObject("btNewTemplates.Image");
            this.btNewTemplates.ImageTransparentColor = Color.Magenta;
            this.btNewTemplates.Name = "btNewTemplates";
            this.btNewTemplates.Size = new Size(0x17, 0x16);
            this.btNewTemplates.Text = "New templates";
            this.btNewTemplates.Click += new EventHandler(this.btNewTemplates_Click);
            this.btOpenTemplates.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btOpenTemplates.Image = (Image) manager.GetObject("btOpenTemplates.Image");
            this.btOpenTemplates.ImageTransparentColor = Color.Magenta;
            this.btOpenTemplates.Name = "btOpenTemplates";
            this.btOpenTemplates.Size = new Size(0x17, 0x16);
            this.btOpenTemplates.Text = "Open templates";
            this.btOpenTemplates.Click += new EventHandler(this.btOpenTemplates_Click);
            this.btSaveTemplates.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btSaveTemplates.Image = (Image) manager.GetObject("btSaveTemplates.Image");
            this.btSaveTemplates.ImageTransparentColor = Color.Magenta;
            this.btSaveTemplates.Name = "btSaveTemplates";
            this.btSaveTemplates.Size = new Size(0x17, 0x16);
            this.btSaveTemplates.Text = "Save templates";
            this.btSaveTemplates.Click += new EventHandler(this.btSaveTemplates_Click);
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new Size(6, 0x19);
            this.btCreateTemplate.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btCreateTemplate.Image = (Image) manager.GetObject("btCreateTemplate.Image");
            this.btCreateTemplate.ImageTransparentColor = Color.Magenta;
            this.btCreateTemplate.Name = "btCreateTemplate";
            this.btCreateTemplate.Size = new Size(0x17, 0x16);
            this.btCreateTemplate.Text = "Create template";
            this.btCreateTemplate.Click += new EventHandler(this.btCreateTemplate_Click);
            this.btAutoGenerate.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btAutoGenerate.Image = (Image) manager.GetObject("btAutoGenerate.Image");
            this.btAutoGenerate.ImageTransparentColor = Color.Magenta;
            this.btAutoGenerate.Name = "btAutoGenerate";
            this.btAutoGenerate.Size = new Size(0x17, 0x16);
            this.btAutoGenerate.Text = "Auto generate templates";
            this.btAutoGenerate.Click += new EventHandler(this.btAutoGenerate_Click);
            this.btTemplateEditor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btTemplateEditor.Image = (Image) manager.GetObject("btTemplateEditor.Image");
            this.btTemplateEditor.ImageTransparentColor = Color.Magenta;
            this.btTemplateEditor.Name = "btTemplateEditor";
            this.btTemplateEditor.Size = new Size(0x17, 0x16);
            this.btTemplateEditor.Text = "Template viewer";
            this.btTemplateEditor.Click += new EventHandler(this.btTemplateEditor_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x2c9, 0x1c4);
            base.Controls.Add(this.ibMain);
            base.Controls.Add(this.splitter1);
            base.Controls.Add(this.pnSettings);
            base.Controls.Add(this.ssMain);
            base.Controls.Add(this.toolStrip1);
            base.Name = "MainForm";
            this.Text = "Contour Analysis Demo";
            ((ISupportInitialize) this.ibMain).EndInit();
            this.pnSettings.ResumeLayout(false);
            this.pnSettings.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.nudMaxACFdesc.EndInit();
            this.nudMinACF.EndInit();
            this.nudMinICF.EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.nudMinDefinition.EndInit();
            this.nudMinContourLength.EndInit();
            this.nudMinContourArea.EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.nudAdaptiveThBlockSize.EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void LoadTemplates(string fileName)
        {
            try
            {
                FileStream serializationStream = new FileStream(fileName, FileMode.Open);
                try
                {
                    this.processor.templates = (Templates) new BinaryFormatter().Deserialize(serializationStream);
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
                if (this.captureFromCam)
                {
                    this.frame = this._capture.QueryFrame();
                }
                this.frameCount++;
                this.processor.ProcessImage(this.frame);
                this.ibMain.Image = !this.cbShowBinarized.Checked ? ((IImage) this.frame) : ((IImage) this.processor.binarizedFrame);
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
                    new BinaryFormatter().Serialize(serializationStream, this.processor.templates);
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
                this._capture = new Capture();
                this.ApplyCamSettings();
            }
            catch (NullReferenceException exception1)
            {
                MessageBox.Show(exception1.Message);
            }
        }

        private void tmUpdateState_Tick(object sender, EventArgs e)
        {
            this.lbFPS.Text = (this.frameCount - this.oldFrameCount) + " fps";
            this.oldFrameCount = this.frameCount;
            if (!ReferenceEquals(this.processor.contours, null))
            {
                this.lbContoursCount.Text = "Contours: " + this.processor.contours.Count;
            }
            if (!ReferenceEquals(this.processor.foundTemplates, null))
            {
                this.lbRecognized.Text = "Recognized contours: " + this.processor.foundTemplates.Count;
            }
        }
    }
}

