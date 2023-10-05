using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MenshikovEA.Sprint2.Task3.V6.Lib
{
    public class DataService : ISprint2Task3V6
    {
        public double Calculate(double x)
        {
            double y;
            if (x < -10)
            {
                y = x + 10 * x - 1 / x;
            }
            else if (-10 <= x && x<0)
            {
                y = Math.Pow((Math.Pow(x, 4) + 1 / Math.Pow(x, 2)), x);
            }
            else if (x == 0)
            {
                y = (x * x - Math.Cos(x * x) + 10) / (x * x - Math.Sin(x * x) + 12);
            }
            else 
            {
                double step = x - 3;
                y = x + Math.Pow(((x - 15) / (x - 10)), step);
            }
            double res = Math.Round(y, 3);
            return res;
        }
    }
}
