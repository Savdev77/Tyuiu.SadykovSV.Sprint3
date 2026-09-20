using Tyuiu.SadykovSV.Sprint3.Task2.V1.Lib;
namespace Tyuiu.SadykovSV.Sprint3.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int start = 1;
            int stop = 10;
            double expected = 0.353;
            double res = ds.GetSumSeries(start, stop);
            Assert.AreEqual(expected,res);
        }
    }
}
