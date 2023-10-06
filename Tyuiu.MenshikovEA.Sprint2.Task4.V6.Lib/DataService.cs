using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MenshikovEA.Sprint2.Task4.V6.Lib
{
    public class DataService : ISprint2Task4V6
    {
        public double Calculate(double x, double y)
        {
            double z = (x + 20) > y * 2 ? x * Math.Pow(((y + 1) / (x + 2)), x) : y * y + 2 * x + (6 / x);
            z = Math.Round(z, 3);
            return z;
        }
    }
}
