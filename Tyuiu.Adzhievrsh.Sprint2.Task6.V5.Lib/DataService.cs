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
                6 => "шестёрка",
                7 => "семёрка",
                8 => "восьмёрка",
                9 => "девятка",
                10 => "десятка",
                11 => "валет",
                12 => "дама",
                13 => "король",
                14 => "туз",
                _ => throw new ArgumentException(
                    "Номер карты должен быть от 6 до 14.")
            };
        }
    }
}