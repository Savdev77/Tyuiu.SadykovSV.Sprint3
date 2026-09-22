using Tyuiu.SadykovSV.Sprint3.Task7.V26.Lib;
namespace Tyuiu.SadykovSV.Sprint3.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double[] res = ds.GetMassFunction(start, stop);
            int len = stop - start + 1;
            double[] expected = new double[len];
            expected[0] = 19.81; expected[1] = 16.79; expected[2] = 13.87; expected[3] = 10.98;
            expected[4] = 7.94; expected[5] = 3.00; expected[6] = 3.23; expected[7] = -0.45;
            expected[8] = -3.79; expected[9] = -6.97; expected[10] = -10.00;
            CollectionAssert.AreEqual(expected, res);
        }
    }
}
