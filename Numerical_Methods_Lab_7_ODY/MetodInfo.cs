using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_Lab_7_ODY
{
    internal class MetodInfo
    {
        public int Iteration { get; private set; }
        public double H { get; private set; }
        public double X { get; private set; }
        
        public double S { get; private set; }
        public double e { get; private set; }
        public double VResult { get; private set; }
        public int CountPlusH { get; private set; }
        public int CountMinusH { get; private set; }

        public MetodInfo(int _i, double _h, double _x, double _s,
            double _e, double _vResult, int _countMinusH, int _countPlusH)
        {
            Iteration = _i;
            H = _h;
            X = _x;
            S = _s;
            e = _e;
            VResult = _vResult;
            CountPlusH = _countPlusH;
            CountMinusH = _countMinusH;
        }
    }
}