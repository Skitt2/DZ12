using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ12
{
    static class circle
    {
        static public double GetLenght(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI * r * r;
        }

        static public double GetPoint(double r, double x, double y) // Значение 1 точка в круге, значение 0 точка вне круга
        {
            double c = Math.Sqrt(x * x + y * y);

            if (c>r)
                return 0;
            return 1;
        }
    }
}
