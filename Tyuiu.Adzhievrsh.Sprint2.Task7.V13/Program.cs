using System;
using Tyuiu.Adzhievrsh.Sprint2.Task7.V13.Lib;

namespace Tyuiu.Adzhievrsh.Sprint2.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title =
                "Спринт #2 | Выполнил: Аджиев Р.Ш. | ИИП6-26-1";

            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine(
                "* Спринт #2                                                               *");
            Console.WriteLine(
                "* Тема: Проверка принадлежности точки закрашенной области                 *");
            Console.WriteLine(
                "* Задание #7                                                              *");
            Console.WriteLine(
                "* Вариант #13                                                             *");
            Console.WriteLine(
                "* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                      *");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine();

            Console.Write("* Введите координату X: ");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Ошибка! Введите вещественное число.");
                Console.ReadKey();
                return;
            }

            Console.Write("* Введите координату Y: ");
            if (!double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine("Ошибка! Введите вещественное число.");
                Console.ReadKey();
                return;
            }

            bool result = ds.CheckDotInShadedArea(x, y);

            if (result)
            {
                Console.WriteLine(
                    "* Точка находится в закрашенной области.");
            }
            else
            {
                Console.WriteLine(
                    "* Точка не находится в закрашенной области.");
            }

            Console.ReadKey();
        }
    }
}