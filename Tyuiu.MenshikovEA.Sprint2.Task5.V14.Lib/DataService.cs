using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MenshikovEA.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {

        public string FindDayName(int d, int k)
        {
            string res = "Невозможно просчитать день недели";
            string pn = "Понедельник";
            string vt = "Вторник";
            string sr = "Среда";
            string cht = "Четверг";
            string pt = "Пятница";
            string sb = "Суббота";
            string vs = "Воскресенье";
            switch (d)
            {
                case 1:
                    if (k % 7 == 0)
                        res = vs;
                    if (k % 7 == 6)
                        res = sb;
                    if (k % 7 == 5)
                        res = pt;
                    if (k % 7 == 4)
                        res = cht;
                    if (k % 7 == 3)
                        res = sr;
                    if (k % 7 == 2)
                        res = vt;
                    if (k % 7 == 1)
                        res = pn;
                    break;
                case 2:
                    if (k % 7 == 0)
                        res = pn;
                    if (k % 7 == 6)
                        res = vs;
                    if (k % 7 == 5)
                        res = sb;
                    if (k % 7 == 4)
                        res = pt;
                    if (k % 7 == 3)
                        res = cht;
                    if (k % 7 == 2)
                        res = sr;
                    if (k % 7 == 1)
                        res = vt;
                    break;
                case 3:
                    if (k % 7 == 0)
                        res = vt;
                    if (k % 7 == 6)
                        res = pn;
                    if (k % 7 == 5)
                        res = vs;
                    if (k % 7 == 4)
                        res = sb;
                    if (k % 7 == 3)
                        res = pt;
                    if (k % 7 == 2)
                        res = cht;
                    if (k % 7 == 1)
                        res = sr;
                    break;
                case 4:
                    if (k % 7 == 0)
                        res = sr;
                    if (k % 7 == 6)
                        res = vt;
                    if (k % 7 == 5)
                        res = pn;
                    if (k % 7 == 4)
                        res = vs;
                    if (k % 7 == 3)
                        res = sb;
                    if (k % 7 == 2)
                        res = pt;
                    if (k % 7 == 1)
                        res = cht;
                    break;
                case 5:
                    if (k % 7 == 0)
                        res = cht;
                    if (k % 7 == 6)
                        res = sr;
                    if (k % 7 == 5)
                        res = vt;
                    if (k % 7 == 4)
                        res = pn;
                    if (k % 7 == 3)
                        res = vs;
                    if (k % 7 == 2)
                        res = sb;
                    if (k % 7 == 1)
                        res = pt;
                    break;
                case 6:
                    if (k % 7 == 0)
                        res = pt;
                    if (k % 7 == 6)
                        res = cht;
                    if (k % 7 == 5)
                        res = sr;
                    if (k % 7 == 4)
                        res = vt;
                    if (k % 7 == 3)
                        res = pn;
                    if (k % 7 == 2)
                        res = vs;
                    if (k % 7 == 1)
                        res = sb;
                    break;
                case 7:
                    if (k % 7 == 0)
                        res = sb;
                    if (k % 7 == 6)
                        res = pt;
                    if (k % 7 == 5)
                        res = cht;
                    if (k % 7 == 4)
                        res = sr;
                    if (k % 7 == 3)
                        res = vt;
                    if (k % 7 == 2)
                        res = pn;
                    if (k % 7 == 1)
                        res = vs;
                    break;
                default:
                    res = "Недопустимый день недели";
                    break;
            }
            return res;
        }
    }
}
