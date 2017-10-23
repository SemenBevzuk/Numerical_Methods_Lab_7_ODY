using System;
using System.Collections.Generic;
using System.Linq;

namespace Numerical_Methods_Lab_7_ODY
{
    class ExperimentInfo
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
        public double MaxDeltaUV { get; private set; }
        public double XMaxDeltaUV { get; private set; }

        public ExperimentInfo(List<MetodInfo> metodInfos, List<FunctionValue> functionValues, Func<double, double, double> func = null)
        {
            StepsCount = metodInfos.Last().Iteration;
            LastX = metodInfos.Last().X;
            HPlusCount = metodInfos.Last().CountPlusH;
            HMinusCount = metodInfos.Last().CountMinusH;

            MaxE = metodInfos.Last().e;
            MaxH = MinH = metodInfos.Last().H;
            XMaxDeltaUV = XMaxH = XMinH = metodInfos.Last().X;
            MaxDeltaUV = 0;
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
            for (int index = 0; index < functionValues.Count; index++)
            {
                var f = functionValues[index];
                var metod = metodInfos[index];
                if (func != null && Math.Abs(f.V - func(metod.X, f.V)) > MaxDeltaUV)
                {
                    MaxDeltaUV = Math.Abs(f.V - func(metod.X, f.V));
                    XMaxDeltaUV = metod.X;
                }
            }
        }
    }
}
