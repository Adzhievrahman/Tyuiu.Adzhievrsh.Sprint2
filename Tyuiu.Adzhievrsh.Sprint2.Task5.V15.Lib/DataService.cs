using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Adzhievrsh.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {

        public string FindDayName(int k)
        {
            if (k < 1 || k > 365)
            {
                throw new ArgumentException(
                    "Число k должно быть от 1 до 365.");
            }

            int day = (k - 1) % 7 + 1;

            switch (day)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 7:
                    return "Воскресенье";
                default:
                    return "";
            }
        }
    }
}