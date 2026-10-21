using System;
using Tyuiu.Adzhievrsh.Sprint2.Task5.V15.Lib;

namespace Tyuiu.Adzhievrsh.Sprint2.Task5.V15
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
                "* Тема: Оператор switch                                                   *");
            Console.WriteLine(
                "* Задание #5                                                              *");
            Console.WriteLine(
                "* Вариант #15                                                             *");
            Console.WriteLine(
                "* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                      *");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine();

            Console.Write("* Введите номер дня года k (1-365): ");

            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                Console.WriteLine("Ошибка! Введите целое число.");
                Console.ReadKey();
                return;
            }

            try
            {
                string result = ds.FindDayName(k);
                Console.WriteLine("* День недели: " + result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("* Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}