using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SadykovSV.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            while (startValue <= stopValue)
            {
                res += (Math.Pow(value, startValue) + 5.0/ (startValue+4));
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}
