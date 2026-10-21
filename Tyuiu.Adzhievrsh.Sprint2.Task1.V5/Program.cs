using System;
using Tyuiu.Adzhievrsh.Sprint2.Task1.V5.Lib;

namespace Tyuiu.Adzhievrsh.Sprint2.Task1.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Аджиев Р.Ш. | ИИП6-26-1";

            int a = 154;
            int b = 163;
            int c = 134;
            int d = 137;

            bool[] result = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Спринт #2 | Задание #1 | Вариант #5");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine();

            Console.WriteLine("Результат:");

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();
        }
    }
}