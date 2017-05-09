using System.Collections.Generic;

namespace Physical_Body_Movement__TUTS_Lab1_.Models
{
    public static class Physics
    {
        public static ChartData Calculate(double a1, double a2, double time, double x0, double x1)
        {
            var x = new List<double>();
            var y = new List<double>();

            var xx = x0;
            var v = .0;
            var t = .0;
            while (xx < x1)
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

            return new ChartData { X = x, Y = y, TotalTime = t, IsValid = true };
        }
    }
}