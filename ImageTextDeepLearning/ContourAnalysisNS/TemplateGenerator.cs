namespace ContourAnalysisNS
{
    using Emgu.CV;
    using System;
    using System.Drawing;

    public static class TemplateGenerator
    {
        public static void GenerateAntipatterns(ImageProcessor processor)
        {
            Bitmap image = new Bitmap(200, 200);
            Graphics graphics = Graphics.FromImage(image);
            processor.onlyFindContours = true;
            graphics.Clear(Color.White);
            graphics.FillRectangle(Brushes.Black, new Rectangle(10, 10, 80, 80));
            GenerateTemplate(processor, image, "antipattern");
            graphics.Clear(Color.White);
            graphics.FillRectangle(Brushes.Black, new Rectangle(10, 10, 50, 100));
            GenerateTemplate(processor, image, "antipattern");
            graphics.Clear(Color.White);
            graphics.FillRectangle(Brushes.Black, new Rectangle(10, 10, 20, 100));
            GenerateTemplate(processor, image, "antipattern");
            graphics.Clear(Color.White);
            graphics.FillEllipse(Brushes.Black, new Rectangle(10, 10, 100, 100));
            GenerateTemplate(processor, image, "antipattern");
            processor.onlyFindContours = false;
        }

        public static void GenerateChars(ImageProcessor processor, char[] chars, Font font)
        {
            Bitmap image = new Bitmap(200, 200);
            font = new Font(font.FontFamily, 72f, font.Style);
            Graphics graphics = Graphics.FromImage(image);
            processor.onlyFindContours = true;
            char[] chArray = chars;
            int index = 0;
            while (true)
            {
                if (index >= chArray.Length)
                {
                    processor.onlyFindContours = false;
                    return;
                }
                char ch = chArray[index];
                graphics.Clear(Color.White);
                graphics.DrawString(ch.ToString(), font, Brushes.Black, (float) 5f, (float) 5f);
                GenerateTemplate(processor, image, ch.ToString());
                index++;
            }
        }

        private static void GenerateTemplate(ImageProcessor processor, Bitmap bmp, string name)
        {
            processor.ProcessImage(new Image<Bgr, byte>(bmp));
            if (processor.samples.Count > 0)
            {
                processor.samples.Sort((t1, t2) => -t1.sourceArea.CompareTo(t2.sourceArea));
                processor.samples[0].name = name;
                processor.templates.Add(processor.samples[0]);
            }
        }
    }
}

