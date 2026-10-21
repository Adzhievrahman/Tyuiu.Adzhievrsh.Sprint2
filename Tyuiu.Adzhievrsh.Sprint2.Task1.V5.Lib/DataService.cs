using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Adzhievrsh.Sprint2.Task1.V5.Lib
{
    public class DataService : ISprint2Task1V5
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[]
            {
                (a + b == 317) | (c + d == 271),
                (a < b) & (c > d),
                (a == b) || (c == d),
                (a > b) && (c < d),
                !(a > b) ^ (c >= d),
                (a != b) ^ (c != d)
            };

            return result;
        }
    }
}