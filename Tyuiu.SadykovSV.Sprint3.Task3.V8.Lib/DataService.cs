using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SadykovSV.Sprint3.Task3.V8.Lib
{
    public class DataService : ISprint3Task3V8
    {
        public int ConvertStringToInt(string value)
        {
            string res = "";
            foreach(char chr in value)
            {
                if (char.IsDigit(chr)) res += chr;
            }
            return Convert.ToInt32(res);
        }
    }
}
