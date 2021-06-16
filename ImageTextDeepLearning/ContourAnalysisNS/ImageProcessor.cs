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
            templates.Sort((t1, t2) => -t1.sample.contour.SourceBoundingRect.Area().CompareTo(t2.sample.contour.SourceBoundingRect.Area()));
            HashSet<int> set = new HashSet<int>();
            int item = 0;
            while (true)
            {
                bool flag = item < templates.Count;
                if (!flag)
                {
                    List<FoundTemplateDesc> list = new List<FoundTemplateDesc>();
                    item = 0;
                    while (true)
                    {
                        flag = item < templates.Count;
                        if (!flag)
                        {
                            templates = list;
                            return;
                        }
                        if (!set.Contains(item))
                        {
                            list.Add(templates[item]);
                        }
                        item++;
                    }
                }
                if (!set.Contains(item))
                {
                    Rectangle sourceBoundingRect = templates[item].sample.contour.SourceBoundingRect;
                    int num2 = templates[item].sample.contour.SourceBoundingRect.Area();
                    sourceBoundingRect.Inflate(4, 4);
                    int num3 = item + 1;
                    while (true)
                    {
                        flag = num3 < templates.Count;
                        if (!flag)
                        {
                            break;
                        }
                        if (sourceBoundingRect.Contains(templates[num3].sample.contour.SourceBoundingRect))
                        {
                            if ((((double) templates[num3].sample.contour.SourceBoundingRect.Area()) / ((double) num2)) <= 0.9)
                            {
                                set.Add(num3);
                            }
                            else if (templates[item].rate > templates[num3].rate)
                            {
                                set.Add(num3);
                            }
                            else
                            {
                                set.Add(item);
                            }
                        }
                        num3++;
                    }
                }
                item++;
            }
        }

        private List<Contour<Point>> FilterContours(Contour<Point> contours, Image<Gray, byte> cannyFrame, int frameWidth, int frameHeight)
        {
            int num = (frameWidth * frameHeight) / 5;
            Contour<Point> objA = contours;
            List<Contour<Point>> list = new List<Contour<Point>>();
            while (true)
            {
                while (true)
                {
                    if (ReferenceEquals(objA, null))
                    {
                        return list;
                    }
                    if (!this.filterContoursBySize || (((objA.Total >= this.minContourLength) && ((objA.Area >= this.minContourArea) && (objA.Area <= num))) && ((objA.Area / ((double) objA.Total)) > 1.5)))
                    {
                        if (this.noiseFilter)
                        {
                            Point point = objA[0];
                            Point point2 = objA[(objA.Total / 2) % objA.Total];
                            if ((cannyFrame[point].Intensity <= double.Epsilon) && (cannyFrame[point2].Intensity <= double.Epsilon))
                            {
                                break;
                            }
                        }
                        list.Add(objA);
                    }
                    break;
                }
                objA = objA.HNext;
            }
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
            Image<Gray, byte> objA = null;
            if (this.noiseFilter)
            {
                objA = image.Canny(new Gray((double) this.cannyThreshold), new Gray((double) this.cannyThreshold));
            }
            if (this.blur)
            {
                grayFrame = image;
            }
            CvInvoke.cvAdaptiveThreshold((IntPtr) grayFrame, (IntPtr) grayFrame, 255.0, ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C, THRESH.CV_THRESH_BINARY, (this.adaptiveThresholdBlockSize + (this.adaptiveThresholdBlockSize % 2)) + 1, 1.0);
            grayFrame._Not();
            if (this.addCanny && !ReferenceEquals(objA, null))
            {
                grayFrame._Or(objA);
            }
            this.binarizedFrame = grayFrame;
            if (!ReferenceEquals(objA, null))
            {
                objA = objA.Dilate(3);
            }
            Contour<Point> contours = grayFrame.FindContours(CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_NONE, RETR_TYPE.CV_RETR_LIST);
            this.contours = this.FilterContours(contours, objA, grayFrame.Width, grayFrame.Height);
            lock (this.foundTemplates)
            {
                this.foundTemplates.Clear();
            }
            this.samples.Clear();
            lock (this.templates)
            {
                if (body == null)
                {
                    body = delegate (Contour<Point> contour) {
                        Template item = new Template(contour.ToArray(), contour.Area, this.samples.templateSize);
                        lock (this.samples)
                        {
                            this.samples.Add(item);
                        }
                        if (!this.onlyFindContours)
                        {
                            FoundTemplateDesc desc = this.finder.FindTemplate(this.templates, item);
                            if (!ReferenceEquals(desc, null))
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

