using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Adzhievrsh.Sprint2.Task0.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        public double ConvertMToKm(int value)
        {
            return value / 1000.0;
        }

        public bool[] GetBoolArray(int x, int y)
        {
            bool[] result = new bool[]
            {
                x + y == 861,
                x != y,
                x < y,
                x > y,
                x <= y,
                x >= y
            };

            return result;
        }

        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[]
            {
                x + y == 861,
                x != y,
                x < y,
                x > y,
                x <= y,
                x >= y
            };

            return result;
        }
    }
}