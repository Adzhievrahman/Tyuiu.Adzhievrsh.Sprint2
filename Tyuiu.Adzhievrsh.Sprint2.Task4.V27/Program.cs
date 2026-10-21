using System;
using Tyuiu.Adzhievrsh.Sprint2.Task4.V27.Lib;

namespace Tyuiu.Adzhievrsh.Sprint2.Task4.V27
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
                "* Тема: Тернарный оператор                                                *");
            Console.WriteLine(
                "* Задание #4                                                              *");
            Console.WriteLine(
                "* Вариант #27                                                             *");
            Console.WriteLine(
                "* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                      *");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine();

            Console.Write("* Введите x: ");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Ошибка! Введите число.");
                Console.ReadKey();
                return;
            }

            Console.Write("* Введите y: ");
            if (!double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine("Ошибка! Введите число.");
                Console.ReadKey();
                return;
            }

            try
            {
                double result = ds.Calculate(x, y);
                Console.WriteLine("* Результат z = " + result.ToString("F3"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("* Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}