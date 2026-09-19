using Tyuiu.SadykovSV.Sprint3.Task1.V30.Lib;

namespace Tyuiu.SadykovSV.Sprint3.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double t = 0.5;
            int start = 1;
            int stop = 12;
            double res = ds.GetSumSeries(t,start,stop);
            double expected = 7.487;
            Assert.AreEqual(expected, res);
        }
    }
}
