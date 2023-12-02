using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint1.Review.V18.Lib;
namespace Tyuiu.IvanovSI.Sprint1.Review.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Иванов С. И. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Review                                                            *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Иванов С. И. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            

            DataService Res = new DataService();

            Console.Write("Введите х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(Res.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
