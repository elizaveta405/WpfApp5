using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class Class1
    {
        public static void Class1(
            double a, double b, double c,
            out double d, out double x1, out double x2,
            out string message)
        {
            
            d = x1 = x2 = double.NaN;

            if (a == 0)
            {
                Class(b, c, out x1, out message);
                x2 = double.NaN;
            }
            else
            {
                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    message = " Дискрименант больше нуля, 2 корня";
                }
                else if (d == 0)
                {
                    x1 = -b / 2 / a;
                    x2 = double.NaN;
                    message = "Дискрименант равен нулю, 1 корень";
                }
                else
                {
                    x1 = double.NaN;
                    x2 = double.NaN;
                }
            }
        }

        public static void Class(double k, double b,
            out double x, out string message)
        {
            if (k == 0)
            {
                x = double.NaN;
                if (b == 0) message = "Прямая совпадает с осью, ответ R";
                else message = "Нет решений";
            }
        }
    }
}
