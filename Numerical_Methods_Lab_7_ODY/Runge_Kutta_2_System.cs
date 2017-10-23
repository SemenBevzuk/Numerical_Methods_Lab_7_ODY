using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerical_Methods_Lab_7_ODY
{
    class Runge_Kutta_2_System
    {
        private Func<Point2D, double> f1; // первая функция системы
        private Func<Point2D, double> f2; // вторая функция системы
        private double h; // шаг
        private double eps; // контроль шага
        protected double borderRight; // правая граница
        protected double borderAccuracy; // точность выхода на границу
        private Point2D currentPoint; // текущая точка 

        private bool flagStepControl; // включить или отключить контроль шага
        private int maxSteps;         // ограничение по числу шагов
        private readonly List<Point2D> Points = new List<Point2D>(); // список точек для графика
        private readonly List<MetodInfo> MetodInformation = new List<MetodInfo>(); // список для таблиц
        private int countPlusH = 0; // счётчик увеличения шага
        private int countMinusH = 0; // счётчик уменьшения шага
        private int steps = 0; // число шагов в данный момент
        public Runge_Kutta_2_System(double _x0, double _u_0_1, double _u_0_2, double _h, double _eps,
            double _rightBoarder, double _borderAccuracy,int _maxSteps, bool _flagIsHControl, 
            Func<Point2D, double> _u1, Func<Point2D, double> _u2)
        {
            currentPoint = new Point2D(_x0, _u_0_1, _u_0_2);
            h = _h;
            eps = _eps;
            borderRight = _rightBoarder;
            borderAccuracy = _borderAccuracy;
            maxSteps = _maxSteps;
            flagStepControl = _flagIsHControl;
            f1 = _u1;
            f2 = _u2;
            Points.Add(currentPoint);
            MetodInformation.Add(new MetodInfo(steps, _h, _x0, 0, 0, 0, 0, 0));
        }

        public void Run()
        {
            while (!NeedStop())
            {
                var oldH = h;

                var newPoint = MakeStep(currentPoint, h);

                var halfPoint = GetHalfPoint(currentPoint, h);

                var s = Math.Abs(GetS(halfPoint, newPoint));

                var e = Math.Abs(Math.Pow(2.0, 2.0) * s);

                if (flagStepControl)
                {
                    if (s > eps || ((currentPoint.X + h) > borderRight))
                    {
                        h = h/2.0;
                        countMinusH++;
                        continue;
                    }

                    if (s < eps/(Math.Pow(2.0, 3.0)))
                    {
                        h = h*2;
                        countPlusH++;
                    }
                }
                currentPoint = newPoint;
                Points.Add(newPoint);
                steps++;
                MetodInformation.Add(new MetodInfo(steps, oldH, currentPoint.X, s, e, currentPoint.V1, countMinusH, countPlusH));
            }
        }
        private double GetS(Point2D _halfPoint, Point2D _newPoint)
        {
            Point2D a = (_halfPoint - _newPoint) / (Math.Pow(2.0, 2.0) - 1.0);
            double res = Math.Max(a.V1, a.V2);
            return res;
        }
        private Point2D GetHalfPoint(Point2D _currentPoint, double h)
        {
            var p1 = MakeStep(_currentPoint, h / 2.0);
            return MakeStep(p1, h / 2.0);
        }

        private Point2D MakeStep(Point2D curPoint, double h)
        {
            var x = GetNextX(curPoint.X, h);
            Point2D v = GetNextV(curPoint, h);
            return new Point2D(x, v.V1, v.V2);
        }
        private double GetNextX(double x, double h)
        {
            return x + h;
        }

        private Point2D GetNextV(Point2D point, double h)
        {
            double c1 = f1(point);
            double c2 = f2(point);
            double a1 = (h)*f1(new Point2D(point.X + h/2.0, point.V1 + (h/(2.0))*c1, point.V2 + (h/(2.0))*c2));
            double a2 = (h)*f2(new Point2D(point.X + h/2.0, point.V1 + (h/(2.0))*c1, point.V2 + (h/(2.0))*c2));
            Point2D res = new Point2D(0, point.V1+a1, point.V2+a2);
            return res;
        }

        private bool NeedStop()
        {
            if (steps > maxSteps)
            {
                return true;
            }
            if ((borderRight - currentPoint.X) <= borderAccuracy)
            {
                return true;
            }
            return false;
        }

        public List<MetodInfo> GetMetodInfos()
        {
            return MetodInformation;
        }
        public List<Point2D> GetPoints()
        {
            return Points;
        }
    }
}
