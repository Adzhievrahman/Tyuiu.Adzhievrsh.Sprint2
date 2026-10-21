using System;
using Tyuiu.Adzhievrsh.Sprint2.Task3.V17.Lib;

namespace Tyuiu.Adzhievrsh.Sprint2.Task3.V17
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
                "* Тема: Вычисление функции с использованием if-else                       *");
            Console.WriteLine(
                "* Задание #3                                                              *");
            Console.WriteLine(
                "* Вариант #17                                                             *");
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

            try
            {
                double result = ds.Calculate(x);
                Console.WriteLine("* Результат y = " + result.ToString("F3"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("* Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}