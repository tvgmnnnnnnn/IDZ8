using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz8_opp
{
    internal class Уравнение
    {
        public static double Уравнение1(double x, int n, int r)
        {
            double result = 0;
            double chisl = 0;
            for (int i = 1; i <= n; i++)
            {
                double znam=2;
                if (i != 1)
                {
                    znam = znam * (i + 2);
                }
                if (i % 2 == 0)
                    chisl = chisl + (i*Math.Pow(x, (i)));
                else
                    chisl = chisl - (i*Math.Pow(x, (i)));
                result += chisl / znam;
                chisl = 0;
            }
            return result;
        }

        public static double Уравнение2(int n, int r)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; i <= r; i++)
                {
                    result += ((i+1)*(i+1)) / (i*i*i+j*j*j);
                }
            }
            return result;
        }
    }
}
