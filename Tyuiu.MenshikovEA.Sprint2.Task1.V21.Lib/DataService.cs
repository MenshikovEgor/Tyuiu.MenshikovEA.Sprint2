using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

//a = 696, b = 987, c = 696, d = 155
//==, !=, <, >, <=, >=, |, &, ||, &&, !, ^

namespace Tyuiu.MenshikovEA.Sprint2.Task1.V21.Lib
{
    public class DataService : ISprint2Task1V21
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (d == c);
            res[1] = (a < b) & (c < d);
            res[2] = (a > b) || (d > c);
            res[3] = (a != c) && (b != d);
            res[4] = !(b <= d);
            res[5] = (a >= b) ^ (d >= c);

            return res;
        }
    }
}
