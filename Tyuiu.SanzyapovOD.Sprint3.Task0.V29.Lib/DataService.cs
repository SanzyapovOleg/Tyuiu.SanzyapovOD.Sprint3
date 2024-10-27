using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SanzyapovOD.Sprint3.Task0.V29.Lib
{
    public class DataService : ISprint3Task0V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            double i;
            for (i = startValue; i <= stopValue; i++)
            {
                sum += (Math.Pow(value, 2 * i) + (1 / (i + 1))) * Math.Cos(value);
            }
            return Math.Round(sum, 3);
        }
    }
}
