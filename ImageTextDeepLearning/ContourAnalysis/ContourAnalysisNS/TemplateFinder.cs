namespace ContourAnalysisNS
{
    using System;

    public class TemplateFinder
    {
        public double minACF = 0.96;
        public double minICF = 0.85;
        public bool checkICF = true;
        public bool checkACF = true;
        public double maxRotateAngle = 3.1415926535897931;
        public int maxACFDescriptorDeviation = 4;
        public string antiPatternName = "antipattern";

        public FoundTemplateDesc FindTemplate(Templates templates, Template sample)
        {
            double num = 0.0;
            double angle = 0.0;
            Complex complex = new Complex();
            Template template = null;
            foreach (Template template2 in templates)
            {
                if (((Math.Abs((int) (sample.autoCorrDescriptor1 - template2.autoCorrDescriptor1)) <= this.maxACFDescriptorDeviation) && (Math.Abs((int) (sample.autoCorrDescriptor2 - template2.autoCorrDescriptor2)) <= this.maxACFDescriptorDeviation)) && ((Math.Abs((int) (sample.autoCorrDescriptor3 - template2.autoCorrDescriptor3)) <= this.maxACFDescriptorDeviation) && (Math.Abs((int) (sample.autoCorrDescriptor4 - template2.autoCorrDescriptor4)) <= this.maxACFDescriptorDeviation)))
                {
                    double norma = 0.0;
                    if (this.checkACF)
                    {
                        norma = template2.autoCorr.NormDot(sample.autoCorr).Norma;
                        if (norma < this.minACF)
                        {
                            continue;
                        }
                    }
                    if (this.checkICF)
                    {
                        complex = template2.contour.InterCorrelation(sample.contour).FindMaxNorma();
                        norma = complex.Norma / (template2.contourNorma * sample.contourNorma);
                        if ((norma < this.minICF) || (Math.Abs(complex.Angle) > this.maxRotateAngle))
                        {
                            continue;
                        }
                    }
                    if ((!template2.preferredAngleNoMore90 || (Math.Abs(complex.Angle) < 1.5707963267948966)) && (norma >= num))
                    {
                        num = norma;
                        template = template2;
                        angle = complex.Angle;
                    }
                }
            }
            if ((template != null) && (template.name == this.antiPatternName))
            {
                template = null;
            }
            if (template != null)
            {
                return new FoundTemplateDesc { 
                    template = template,
                    rate = num,
                    sample = sample,
                    angle = angle
                };
            }
            return null;
        }
    }
}

