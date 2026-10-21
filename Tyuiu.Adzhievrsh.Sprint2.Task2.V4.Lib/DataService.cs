using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Adzhievrsh.Sprint2.Task2.V4.Lib
{
    public class DataService : ISprint2Task2V4
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            switch (y)
            {
                case 3:
                    return (x >= 3 && x <= 5) || x == 9 || x == 12;

                case 4:
                    return (x >= 3 && x <= 5) || x == 12;

                case 5:
                    return (x >= 5 && x <= 9) || x == 12;

                case 6:
                    return (x >= 5 && x <= 9) || (x >= 12 && x <= 13);

                case 7:
                    return x >= 3 && x <= 13;

                case 8:
                    return x == 4 || (x >= 8 && x <= 13);

                case 9:
                case 10:
                    return x == 4 || (x >= 8 && x <= 10);

                case 11:
                    return (x >= 3 && x <= 4) ||
                           (x >= 8 && x <= 12);

                case 12:
                    return x == 4 || (x >= 8 && x <= 10);

                case 13:
                    return x == 4;

                case 14:
                    return x == 5 || x == 6;

                default:
                    return false;
            }
        }
    }
}