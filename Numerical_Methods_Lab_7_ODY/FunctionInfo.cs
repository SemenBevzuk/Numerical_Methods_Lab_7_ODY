using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Numerical_Methods_Lab_7_ODY
{
    class FunctionInfo
    {
        private Func<double, double, double> f;
        private readonly List<Point> points; // список точек для графика

        public FunctionInfo(Func<double, double, double> f)
        {
            this.f = f;
            this.points = new List<Point>();
        }

        public List<Point> GetPoints()
        {
            return points;
        }

        public double Value(double x, double u)
        {
            return f(x, u);
        }

        public void AddPoint(Point point)
        {
            points.Add(point);
        }
    }
}
