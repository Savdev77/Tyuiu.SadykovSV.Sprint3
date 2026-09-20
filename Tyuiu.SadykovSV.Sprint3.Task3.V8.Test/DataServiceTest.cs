using Tyuiu.SadykovSV.Sprint3.Task3.V8.Lib;

namespace Tyuiu.SadykovSV.Sprint3.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();
            string str = "vc,x12fc fc!e";
            int res = ds.ConvertStringToInt(str);
            int expected = 12;
            Assert.AreEqual(expected, res);
        }
    }
}
