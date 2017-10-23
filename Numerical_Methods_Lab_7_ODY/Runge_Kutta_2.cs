using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_Lab_7_ODY
{
    class Runge_Kutta_2
    {
        protected FunctionInfo f; // функция и список точек для графика
        protected double h; // шаг
        protected double eps; // контроль шага
        protected Point fCurrentPoint; // текущая точка 
        protected double borderRight; // правая граница
        protected double borderAccuracy; // точность выхода на границу

        protected bool flagStepControl; // включить или отключить контроль шага
        protected int maxSteps;         // ограничение по числу шагов
        protected readonly List<MetodInfo> MetodInfos = new List<MetodInfo>(); // список для таблиц про параметры метода
        protected readonly List<FunctionValue> FValues = new List<FunctionValue>(); // список для таблиц про параметры функции
        protected int countPlusH = 0; // счётчик увеличения шага
        protected int countMinusH = 0; // счётчик уменьшения шага
        protected int steps = 0; // число шагов в данный момент
        public Runge_Kutta_2(double _x0, double _u0, double _h, double _eps, double _rightBoarder,
            double _borderAccuracy, int _maxSteps, Func<double, double, double> _f, bool _flagIsHControl)
        {
            fCurrentPoint = new Point(_x0, _u0);
            h = _h;
            eps = _eps;
            borderRight = _rightBoarder;
            borderAccuracy = _borderAccuracy;
            maxSteps = _maxSteps;
            f = new FunctionInfo(_f);
            flagStepControl = _flagIsHControl;
            f.AddPoint(fCurrentPoint);
            MetodInfos.Add(new MetodInfo(steps, _h, _x0, 0, 0, 0, 0, 0));
            FValues.Add(new FunctionValue(_u0, 0));
        }

        public virtual void Run()
        {
            while (!NeedStop())
            {
                var oldH = h;

                var newPoint = MakeStep(fCurrentPoint, h, f.Value);

                var halfPoint = GetHalfPoint(fCurrentPoint, h, f.Value);

                var s = Math.Abs(GetS(halfPoint, newPoint));

                var e = Math.Abs(Math.Pow(2.0, 2.0) * s);


                if (flagStepControl)
                {
                    if (s > eps || (fCurrentPoint.X + h) > borderRight) // ограничивает выход за границу при слишком большом шаге
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

                fCurrentPoint = newPoint;
                f.AddPoint(newPoint);
                steps++;
                MetodInfos.Add(new MetodInfo(steps, oldH, fCurrentPoint.X, s, e, fCurrentPoint.V, countMinusH, countPlusH));
                FValues.Add(new FunctionValue(fCurrentPoint.V, halfPoint.V));
            }
        }

        protected double GetS(Point _halfPoint, Point _newPoint)
        {
            return (_halfPoint.V - _newPoint.V) / (2.0 * 2.0 - 1.0);
        }
        protected Point GetHalfPoint(Point point, double h, Func<double, double, double> func)
        {
            var p1 = MakeStep(point, h / 2.0, func);
            return MakeStep(p1, h / 2.0, func);
        }

        protected Point MakeStep(Point point, double h, Func<double, double, double> func)
        {
            var x1 = GetNextX(point.X, h);
            var u1 = GetNextV(point, h, func);
            return new Point(x1, u1);
        }

        protected double GetNextX(double x, double h)
        {
            return x + h;
        }

        protected virtual double GetNextV(Point point, double h, Func<double, double, double> func)
        {
            var a = func(point.X + h / 2.0, point.V + (h / 2.0) * func(point.X, point.V));
            return point.V + h * a;
        }
        protected bool NeedStop()
        {
            if (steps > maxSteps)
            {
                return true;
            }
            if ((borderRight - fCurrentPoint.X) <= borderAccuracy)
            {
                return true;
            }
            return false;
        }

        public List<MetodInfo> GetMetodInfos()
        {
            return MetodInfos;
        }

        public List<FunctionValue> GetFunctionValues()
        {
            return FValues;
        }
        public List<Point> GetPoints()
        {
            return f.GetPoints();
        }
    }
}
