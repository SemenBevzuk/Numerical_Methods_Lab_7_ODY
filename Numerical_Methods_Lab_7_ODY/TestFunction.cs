using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_Lab_7_ODY
{
    class TestFunction : Function // du/dx = u
    {
        public override double FunctionValue(double x, double v)
        {
            double res = v;
            return res;
        }
    }
}
