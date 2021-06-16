namespace ContourAnalysisNS
{
    using System;
    using System.Collections.Generic;

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
            FoundTemplateDesc desc2;
            double num = 0.0;
            double angle = 0.0;
            Complex complex = new Complex();
            Template objA = null;
            using (List<Template>.Enumerator enumerator = templates.GetEnumerator())
            {
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    Template current = enumerator.Current;
                    if ((Math.Abs((int) (sample.autoCorrDescriptor1 - current.autoCorrDescriptor1)) <= this.maxACFDescriptorDeviation) && ((Math.Abs((int) (sample.autoCorrDescriptor2 - current.autoCorrDescriptor2)) <= this.maxACFDescriptorDeviation) && ((Math.Abs((int) (sample.autoCorrDescriptor3 - current.autoCorrDescriptor3)) <= this.maxACFDescriptorDeviation) && (Math.Abs((int) (sample.autoCorrDescriptor4 - current.autoCorrDescriptor4)) <= this.maxACFDescriptorDeviation))))
                    {
                        double num3 = 0.0;
                        if (!this.checkACF || (current.autoCorr.NormDot(sample.autoCorr).Norma >= this.minACF))
                        {
                            if (this.checkICF)
                            {
                                complex = current.contour.InterCorrelation(sample.contour).FindMaxNorma();
                                num3 = complex.Norma / (current.contourNorma * sample.contourNorma);
                                if (num3 < this.minICF)
                                {
                                    continue;
                                }
                                if (Math.Abs(complex.Angle) > this.maxRotateAngle)
                                {
                                    continue;
                                }
                            }
                            if ((!current.preferredAngleNoMore90 || (Math.Abs(complex.Angle) < 1.5707963267948966)) && (num3 >= num))
                            {
                                num = num3;
                                objA = current;
                                angle = complex.Angle;
                            }
                        }
                    }
                }
            }
            if ((objA != null) && (objA.name == this.antiPatternName))
            {
                objA = null;
            }
            if (ReferenceEquals(objA, null))
            {
                desc2 = null;
            }
            else
            {
                desc2 = new FoundTemplateDesc {
                    template = objA,
                    rate = num,
                    sample = sample,
                    angle = angle
                };
            }
            return desc2;
        }
    }
}

