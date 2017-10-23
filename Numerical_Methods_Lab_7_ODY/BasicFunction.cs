using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_Lab_7_ODY
{
    class BasicFunction : Function // du/dx = u^2/(1+x^4)+u-u^3*sin(10x)
    {
        public override double FunctionValue(double x, double v)
        {
            double c1 = Math.Pow(v, 2.0) / (1 + Math.Pow(x, 4.0)) + v;
            double c2 = Math.Pow(v, 3.0)*Math.Sin(10*x);
            double res = c1 - c2;
            return res;
        }
    }
}
