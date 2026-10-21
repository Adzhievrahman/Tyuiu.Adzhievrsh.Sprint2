using System;
using Tyuiu.Adzhievrsh.Sprint2.Task2.V4.Lib;

namespace Tyuiu.Adzhievrsh.Sprint2.Task2.V4
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
                "* Проверка принадлежности точки закрашенной области                       *");
            Console.WriteLine(
                "* Задание #2                                                              *");
            Console.WriteLine(
                "* Вариант #4                                                              *");
            Console.WriteLine(
                "* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                      *");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine();

            Console.Write("* Введите координату X: ");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Ошибка! Введите целое число.");
                Console.ReadKey();
                return;
            }

            Console.Write("* Введите координату Y: ");
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("Ошибка! Введите целое число.");
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