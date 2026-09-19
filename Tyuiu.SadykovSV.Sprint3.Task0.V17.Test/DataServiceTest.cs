using Tyuiu.SadykovSV.Sprint3.Task0.V17.Lib;
namespace Tyuiu.SadykovSV.Sprint3.Task0.V17.Test
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
            double res = ds.GetSumSeries(start, stop);
            double expected = -0.709;
            Assert.AreEqual(expected, res);
        }
    }
}
