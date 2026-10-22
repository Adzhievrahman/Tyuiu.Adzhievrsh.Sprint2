using System;
using Tyuiu.Adzhievrsh.Sprint2.Task6.V5.Lib;

namespace Tyuiu.Adzhievrsh.Sprint2.Task6.V5
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
                "* Тема: Сокращённая форма оператора switch                                *");
            Console.WriteLine(
                "* Задание #6                                                              *");
            Console.WriteLine(
                "* Вариант #5                                                              *");
            Console.WriteLine(
                "* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                      *");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine();

            Console.Write("* Введите номер карты k (6-14): ");

            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                Console.WriteLine("Ошибка! Введите целое число.");
                Console.ReadKey();
                return;
            }

            try
            {
                string result = ds.FindCardValue(k);
                Console.WriteLine("* Достоинство карты: " + result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("* Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}