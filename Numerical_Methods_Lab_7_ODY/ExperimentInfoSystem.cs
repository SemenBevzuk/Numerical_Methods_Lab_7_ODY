using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_Lab_7_ODY
{
    class ExperimentInfoSystem
    {
        public int StepsCount { get; private set; }
        public double LastX { get; private set; }
        public double MaxE { get; private set; }
        public int HPlusCount { get; private set; }
        public int HMinusCount { get; private set; }
        public double MaxH { get; private set; }
        public double XMaxH { get; private set; }
        public double MinH { get; private set; }
        public double XMinH { get; private set; }

        public ExperimentInfoSystem(List<MetodInfo> metodInfos, List<Point2D> functionValues, Func<double, double, double> func = null)
        {
            StepsCount = metodInfos.Last().Iteration;
            LastX = metodInfos.Last().X;
            HPlusCount = metodInfos.Last().CountPlusH;
            HMinusCount = metodInfos.Last().CountMinusH;

            MaxE = metodInfos.Last().e;
            MaxH = MinH = metodInfos.Last().H;
            foreach (var i in metodInfos)
            {
                if (i.e > MaxE)
                    MaxE = i.e;

                if (i.H > MaxH)
                {
                    MaxH = i.H;
                    XMaxH = i.X;
                }

                if (i.H < MinH)
                {
                    MinH = i.H;
                    XMinH = i.X;
                }
            }
        }
    }
}
