using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_Lab_7_ODY
{
    class FunctionG
    {
        private readonly double a;
        private readonly double b;

        public FunctionG(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double FunctionValue(Point2D point)
        {
            return -a*a*Math.Sin(point.V1) - b*Math.Sin(point.X);
        }
    }
}
