using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Adzhievrsh.Sprint2.Task4.V27.Lib
{
    public class DataService : ISprint2Task4V27
    {
        public double Calculate(double x, double y)
        {
            bool condition = x - 10 > y + 2;

            if (condition && x == 1)
            {
                throw new ArgumentException(
                    "Знаменатель x - 1 не должен быть равен нулю.");
            }

            if (!condition && x == 0)
            {
                throw new ArgumentException(
                    "Деление на ноль невозможно.");
            }

            double z = condition
                ? x * Math.Pow((y + 2) / (x - 1), x)
                : Math.Pow(y, 2) - 2 / x;

            return Math.Round(z, 3);
        }
    }
}