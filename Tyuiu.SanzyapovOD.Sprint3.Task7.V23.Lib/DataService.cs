﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SanzyapovOD.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 1)
                {
                    valueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round(4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2), 2);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
