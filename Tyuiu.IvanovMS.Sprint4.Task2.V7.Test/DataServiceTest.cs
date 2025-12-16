using Tyuiu.IvanovMS.Sprint4.Task2.V7.Lib;
namespace Tyuiu.IvanovMS.Sprint4.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[12];
            for (int i = 0; i < 12; i++)
            {
                array[i] = i;
            }
            int wait = 30;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
