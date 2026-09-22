using Tyuiu.SadykovSV.Sprint3.Task6.V11.Lib;

namespace Tyuiu.SadykovSV.Sprint3.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 19;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int expected = 9;

            Assert.AreEqual(expected, res);
        }
    }
}
