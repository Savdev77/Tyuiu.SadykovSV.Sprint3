using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SadykovSV.Sprint3.Task6.V11.Lib
{
    public class DataService : ISprint3Task6V11
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 11; d<=stopValue; d++)
                {
                    if (x % d == 0)
                    {
                        res++;
                    }
                }
            }
            return res;
        }
    }
}
