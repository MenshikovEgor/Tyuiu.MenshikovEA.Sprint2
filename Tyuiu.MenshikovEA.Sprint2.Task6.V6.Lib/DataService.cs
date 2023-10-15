using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MenshikovEA.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            if (value2 == 1)
            {
                switch (value1)
                {
                    case 6: return "Шестёрка пик";
                    case 7: return "Семёрка пик";
                    case 8: return "Восьмёрка пик";
                    case 9: return "Девятка пик";
                    case 10: return "Десятка пик";
                    case 11: return "Валет пик";
                    case 12: return "Дама пик";
                    case 13: return "Король пик";
                    case 14: return "Туз пик";
                    default: throw new ArgumentException("Нет такого значения карты");
                }
            }
            else if (value2 == 2)
            {
                switch (value1)
                {
                    case 6: return "Шестёрка треф";
                    case 7: return "Семёрка треф";
                    case 8: return "Восьмёрка треф";
                    case 9: return "Девятка треф";
                    case 10: return "Десятка треф";
                    case 11: return "Валет треф";
                    case 12: return "Дама треф";
                    case 13: return "Король треф";
                    case 14: return "Туз треф";
                    default: throw new ArgumentException("Нет такого значения карты");
                }
            }
            else if (value2 == 3)
            {
                switch (value1)
                {
                    case 6: return "Шестёрка бубен";
                    case 7: return "Семёрка бубен";
                    case 8: return "Восьмёрка бубен";
                    case 9: return "Девятка бубен";
                    case 10: return "Десятка бубен";
                    case 11: return "Валет бубен";
                    case 12: return "Дама бубен";
                    case 13: return "Король бубен";
                    case 14: return "Туз бубен";
                    default: throw new ArgumentException("Нет такого значения карты");
                }
            }
            else if (value2 == 4)
            {
                switch (value1)
                {
                    case 6: return "Шестёрка черви";
                    case 7: return "Семёрка черви";
                    case 8: return "Восьмёрка черви";
                    case 9: return "Девятка черви";
                    case 10: return "Десятка черви";
                    case 11: return "Валет черви";
                    case 12: return "Дама черви";
                    case 13: return "Король черви";
                    case 14: return "Туз черви";
                    default: throw new ArgumentException("Нет такого значения карты");
                }
            }
            else
                return "Недопустимая масть карты";
        }
    }
}
