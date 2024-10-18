﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TimoninIA.Sprint2.Task4.V10.Lib
{
    public class DataService : ISprint2Task4V10
    {
        public double Calculate(double x, double y)
        {
            var res = x * 2 < y / 3 ? Math.Pow((1 + 3 / y * y), x) : y + 10 * x - (5 / x);
            return Math.Round(res, 3);
        }
    }
}