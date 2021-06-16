namespace ContourAnalysisNS
{
    using System;

    public class FoundTemplateDesc
    {
        public double rate;
        public Template template;
        public Template sample;
        public double angle;

        public double scale =>
            Math.Sqrt(this.sample.sourceArea / this.template.sourceArea);
    }
}

