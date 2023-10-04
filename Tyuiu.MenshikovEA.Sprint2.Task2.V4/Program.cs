using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint2.Task2.V4.Lib;

namespace Tyuiu.MenshikovEA.Sprint2.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x;
            int y;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите значение переменной х: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите значение переменной y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res == true)
                Console.WriteLine("Точка с данными координатами является заштрихованной");
            else
                Console.WriteLine("Точка с данными координатами не является заштрихованной");
            Console.ReadKey();
        }
    }
}
