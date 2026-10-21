using System;
using Tyuiu.Adzhievrsh.Sprint2.Task0.V6.Lib;

namespace Tyuiu.Adzhievrsh.Sprint2.Task0.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title =
                "Спринт #1 | Выполнил: Аджиев Р.Ш. | ИИП6-26-1";

            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine(
                "* Спринт #2                                                               *");
            Console.WriteLine(
                "* Тема: Операции сравнения                                                *");
            Console.WriteLine(
                "* Задание #0                                                              *");
            Console.WriteLine(
                "* Вариант #6                                                              *");
            Console.WriteLine(
                "* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                      *");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine();

            int x = 107;
            int y = 754;

            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine();
            Console.WriteLine("Результат:");

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);

                if (i < result.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}