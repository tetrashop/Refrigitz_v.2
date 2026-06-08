using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellipse
{
    class Params
    {
        public double ee = 0;
        public double dd = 0;
        public double pp = 0;
        public double cc = 0;
        public Params(double a, double b)
        {
            try
            {
                Parallel.Invoke(() =>
             {
                 ee = e.S(a, b);
             },
             () =>
             {
                 dd = d.S(a, b);
             }, () =>
             {
                 pp = p.S(a, b);
             }, () =>
             {
                 cc = c.S(a, b);
             });
                Console.Write("Initia Completed!");
            }
            catch (Exception t)
            {
                Console.Write("Initia Failed!");
            }
        }
    }
}
