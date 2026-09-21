using Tyuiu.SadykovSV.Sprint3.Task4.V23.Lib;
namespace Tyuiu.SadykovSV.Sprint3.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double res = ds.Calculate(start, stop);
            double expected = 244.656;
            Assert.AreEqual(expected, res);
        }
    }
}
