using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint2.Task5.V14.Lib;

namespace Tyuiu.MenshikovEA.Sprint2.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите день недели первого января: ");
            int dn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите номер дня в году: ");
            int kol = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindDayName(dn, kol);

            if (kol < 1 || kol > 365)
                Console.WriteLine("Недопустимое значение дня в году. Значение должно лежать в промежутке от 1 до 365.");
            else
                Console.WriteLine(kol + " день в году это " + res);
            Console.ReadKey();
        }
    }
}
