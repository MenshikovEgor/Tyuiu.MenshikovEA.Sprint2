using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint2.Task6.V6.Lib;

namespace Tyuiu.MenshikovEA.Sprint2.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите силу карты от 6 до 14: ");
            int power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите масть карты от 1 до 4: ");
            int type = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindCardNameAndValue(power, type);

            if (res == "Нет такого значения карты" || res == "Недопустимая масть карты")
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Ваша карта - " + res);
            }
            Console.ReadKey();
        }
    }
}
