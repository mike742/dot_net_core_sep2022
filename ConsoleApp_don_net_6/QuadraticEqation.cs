using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_don_net_6
{
    public class QuadraticEqation
    {
        public static string Calculate(int a, int b, int c)
        {
            if (a < -99 || a > 99 || b < -99 || b > 99 || c < -99 || c > 99)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (a == 0)
            {
                throw new ArgumentException();
            }

            if (b * b < 4 * a * c)
            {
                return "x's roots are imaginary";
            }

            if (b * b == 4 * a * c)
            {
                double res = -b / (2 * a);

                return $"x = {res.ToString("0.000")}";
            }

            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

            return $"x = {x1.ToString("0.000")}, x = {x2.ToString("0.000")}";
        }

    }
}
