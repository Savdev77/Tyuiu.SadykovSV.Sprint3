using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SadykovSV.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] arr = new double[len];
            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double func;
                if (2 * x - 0.5 == 0)
                {
                    func = 0;
                }
                else
                {
                    func = 5 - 3 * x + (1 + Math.Sin(x)) / (2 * x - 0.5);
                    func = Math.Round(func, 2);
                }
                arr[index] = func;
                index++;
            }
            return arr; 
        }
    }
}
