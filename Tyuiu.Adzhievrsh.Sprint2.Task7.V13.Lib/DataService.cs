using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Adzhievrsh.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool insideCircle =
                x >= 0 &&
                x * x + y * y <= 1 &&
                y >= x - 1;

            bool insideTriangle =
                x >= 1 &&
                y <= 1 &&
                y >= x - 1;

            return insideCircle || insideTriangle;
        }
    }
}