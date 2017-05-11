using System;
using System.Collections.Generic;

namespace Physical_Body_Movement__TUTS_Lab1_.Models
{
    public static class Physics
    {
        public static ChartData Calculate(double a1, double a2, double time, double x0, double x1)
        {
            var x = new List<double>();
            var y = new List<double>();

            var absComponent = Math.Abs(a1 / a2);
            var intermediateX = (absComponent * x1 + x0) / (1 + absComponent);

            var xx = x0;
            var v = .0;
            var t = .0;
            while (xx < intermediateX)
            {
                x.Add(xx);
                y.Add(v);

                v += a1 * t;
                xx += v * t + a1 * t * t / 2;

                t += time;
            }

            while (0 < v)
            {
                x.Add(xx);
                y.Add(v);

                v -= a2 * t;
                xx += v * t - a2 * t * t / 2;

                t += time;
            }

            var smth = Math.Sqrt((x1 - x0) / (a1 / 2 - a1 * a1 / 2 / -a2));
            return new ChartData { X = x, Y = y, TotalTime = -a1 * smth / -a2 + smth, IsValid = true };
        }
    }
}