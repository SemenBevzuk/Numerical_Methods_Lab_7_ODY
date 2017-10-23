using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace Numerical_Methods_Lab_7_ODY
{
    class TrueSolution // u = u0*e^x
    {
        private double u0; // начальная точка
        private double x0;

        private readonly List<Point> listOfPoints = new List<Point>(); // список точек для графика

        public TrueSolution(double _x0, double _u0)
        {
            u0 = _u0;
            x0 = _x0;
        }

        public double FunctionValue(double x, double v)
        {
            double res = u0*Math.Exp(x);
            return res;
        }

        public void FindPoints(double rightBoarder)
        {
            listOfPoints.Clear();

            int N = 300;
            double h = (rightBoarder - x0)/N;
            double u = u0;
            double x = x0;
            listOfPoints.Add(new Point(x,u));
            int i = 1;
            while (i < N)
            {
                x = x + h;
                u = FunctionValue(x, 0);
                listOfPoints.Add(new Point(x,u));
                i++;
            }
        }
        public List<Point> GetPoints()
        {
            return listOfPoints;
        } 
    }
}
