using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_Lab_7_ODY
{
    class Point
    {
        public double X { get; private set; }
        public double V { get; private set; }

        public Point(double x, double v)
        {
            X = x;
            V = v;
        }
    }
}
