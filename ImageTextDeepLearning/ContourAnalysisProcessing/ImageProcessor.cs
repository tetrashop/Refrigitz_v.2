namespace ContourAnalysisNS
{
    using Emgu.CV;
    using Emgu.CV.CvEnum;
    using Emgu.CV.Structure;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Threading.Tasks;

    public class ImageProcessor
    {
        public bool equalizeHist = false;
        public bool noiseFilter = false;
        public int cannyThreshold = 50;
        public bool blur = true;
        public int adaptiveThresholdBlockSize = 4;
        public bool addCanny = true;
        public bool filterContoursBySize = true;
        public bool onlyFindContours = false;
        public int minContourLength = 15;
        public int minContourArea = 10;
        public List<Contour<Point>> contours;
        public Templates templates = new Templates();
        public Templates samples = new Templates();
        public List<FoundTemplateDesc> foundTemplates = new List<FoundTemplateDesc>();
        public TemplateFinder finder = new TemplateFinder();
        public Image<Gray, byte> binarizedFrame;

        private static void FilterByIntersection(ref List<FoundTemplateDesc> templates)
        {
            int num;
            templates.Sort((t1, t2) => -t1.sample.contour.SourceBoundingRect.Area().CompareTo(t2.sample.contour.SourceBoundingRect.Area()));
            HashSet<int> set = new HashSet<int>();
            for (num = 0; num < templates.Count; num++)
            {
                if (!set.Contains(num))
                {
                    Rectangle sourceBoundingRect = templates[num].sample.contour.SourceBoundingRect;
                    int num2 = templates[num].sample.contour.SourceBoundingRect.Area();
                    sourceBoundingRect.Inflate(4, 4);
                    for (int i = num + 1; i < templates.Count; i++)
                    {
                        if (sourceBoundingRect.Contains(templates[i].sample.contour.SourceBoundingRect))
                        {
                            double num4 = templates[i].sample.contour.SourceBoundingRect.Area();
                            if ((num4 / ((double)num2)) > 0.9)
                            {
                                if (templates[num].rate > templates[i].rate)
                                {
                                    set.Add(i);
                                }
                                else
                                {
                                    set.Add(num);
                                }
                            }
                            else
                            {
                                set.Add(i);
                            }
                        }
                    }
                }
            }
            List<FoundTemplateDesc> list = new List<FoundTemplateDesc>();
            for (num = 0; num < templates.Count; num++)
            {
                if (!set.Contains(num))
                {
                    list.Add(templates[num]);
                }
            }
            templates = list;
        }

        private List<Contour<Point>> FilterContours(Contour<Point> contours, Image<Gray, byte> cannyFrame, int frameWidth, int frameHeight)
        {
            int num = (frameWidth * frameHeight) / 5;
            Contour<Point> item = contours;
            List<Contour<Point>> list = new List<Contour<Point>>();
            while (item != null)
            {
                if (!this.filterContoursBySize || ((((item.Total >= this.minContourLength) && (item.Area >= this.minContourArea)) && (item.Area <= num)) && ((item.Area / ((double)item.Total)) > 1.5)))
                {
                    if (this.noiseFilter)
                    {
                        Point point = item[0];
                        Point point2 = item[(item.Total / 2) % item.Total];
                        Gray gray = cannyFrame[point];
                        if ((gray.Intensity <= double.Epsilon) && ((gray = cannyFrame[point2]).Intensity <= double.Epsilon))
                        {
                            goto Label_00EA;
                        }
                    }
                    list.Add(item);
                }
                Label_00EA:
                item = item.HNext;
            }
            return list;
        }

        public void ProcessImage(Image<Bgr, byte> frame)
        {
            this.ProcessImage(frame.Convert<Gray, byte>());
        }

        public void ProcessImage(Image<Gray, byte> grayFrame)
        {
            Action<Contour<Point>> body = null;
            if (this.equalizeHist)
            {
                grayFrame._EqualizeHist();
            }
            Image<Gray, byte> image = grayFrame.PyrDown().PyrUp();
            Image<Gray, byte> image2 = null;
            if (this.noiseFilter)
            {
                image2 = image.Canny(new Gray((double)this.cannyThreshold), new Gray((double)this.cannyThreshold));
            }
            if (this.blur)
            {
                grayFrame = image;
            }
            CvInvoke.cvAdaptiveThreshold((IntPtr)grayFrame, (IntPtr)grayFrame, 255.0, ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C, THRESH.CV_THRESH_BINARY, (this.adaptiveThresholdBlockSize + (this.adaptiveThresholdBlockSize % 2)) + 1, 1.0);
            grayFrame._Not();
            if (this.addCanny && (image2 != null))
            {
                grayFrame._Or(image2);
            }
            this.binarizedFrame = grayFrame;
            if (image2 != null)
            {
                image2 = image2.Dilate(3);
            }
            Contour<Point> contours = grayFrame.FindContours(CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_NONE, RETR_TYPE.CV_RETR_LIST);
            this.contours = this.FilterContours(contours, image2, grayFrame.Width, grayFrame.Height);
            lock (this.foundTemplates)
            {
                this.foundTemplates.Clear();
            }
            this.samples.Clear();
            lock (this.templates)
            {
                if (body == null)
                {
                    body = delegate (Contour<Point> contour)
                    {
                        Template item = new Template(contour.ToArray(), contour.Area, this.samples.templateSize);
                        lock (this.samples)
                        {
                            this.samples.Add(item);
                        }
                        if (!this.onlyFindContours)
                        {
                            FoundTemplateDesc desc = this.finder.FindTemplate(this.templates, item);
                            if (desc != null)
                            {
                                lock (this.foundTemplates)
                                {
                                    this.foundTemplates.Add(desc);
                                }
                            }
                        }
                    };
                }
                Parallel.ForEach<Contour<Point>>(this.contours, body);
            }
            FilterByIntersection(ref this.foundTemplates);
        }
    }
}

