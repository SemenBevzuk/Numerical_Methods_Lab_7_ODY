using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_Lab_7_ODY
{
    class Point2D
    {
        public double X { get; private set; }
        public double V1 { get; private set; }
        public double V2 { get; private set; }

        public Point2D(double x, double v1, double v2)
        {
            X = x;
            V1 = v1;
            V2 = v2;
        }

        public static Point2D operator + (Point2D obj1, Point2D obj2)
        {
            Point2D res = new Point2D(
                0,
                obj1.V1 + obj2.V1,
                obj1.V2 + obj2.V2
                );
            return res;
        }

        public static Point2D operator + (Point2D obj1, double obj2)
        {
            Point2D res = new Point2D(
                obj1.X,
                obj1.V1 + obj2,
                obj1.V2 + obj2
                );
            return res;
        }
        public static Point2D operator - (Point2D obj1, Point2D obj2)
        {
            Point2D res = new Point2D(
                0,
                obj1.V1 - obj2.V1,
                obj1.V2 - obj2.V2
                );
            return res;
        }
        public static Point2D operator * (Point2D obj1, Point2D obj2)
        {
            Point2D res = new Point2D(
                0,
                obj1.V1 * obj2.V1,
                obj1.V2 * obj2.V2
                );
            return res;
        }
        public static Point2D operator * (double obj1, Point2D obj2)
        {
            Point2D res = new Point2D(
                obj2.X,
                obj1 * obj2.V1,
                obj1 * obj2.V2
                );
            return res;
        }

        public static Point2D operator / (double obj1, Point2D obj2)
        {
            Point2D res = new Point2D(
                obj2.X,
                obj2.V1/obj1,
                obj2.V2/obj1
                );
            return res;
        }
        public static Point2D operator / (Point2D obj2, double obj1)
        {
            Point2D res = new Point2D(
                obj2.X,
                obj2.V1/obj1,
                obj2.V2/obj1
                );
            return res;
        }

        public static Point2D operator -(Point2D obj1)
        {
            Point2D res = new Point2D(
                obj1.X,
                obj1.V1 * (-1.0),
                obj1.V2 * (-1.0)
                );
            return res;
        }
    }
}
