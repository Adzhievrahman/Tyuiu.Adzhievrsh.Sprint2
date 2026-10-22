using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.Adzhievrsh.Sprint2.Task6.V5.Lib
{
    public class DataService : ISprint2Task6V5
    {
      

        public string FindCardValue(int k)
        {
            return k switch
            {
                6 => "Шестёрка",
                7 => "Семёрка",
                8 => "Восьмёрка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                14 => "Туз",
                _ => throw new ArgumentException(
                    "Номер карты должен быть от 6 до 14.")
            };
        }
    }
}