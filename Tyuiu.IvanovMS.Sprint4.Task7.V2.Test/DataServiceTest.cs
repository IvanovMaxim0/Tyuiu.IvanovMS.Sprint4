using Tyuiu.IvanovMS.Sprint4.Task7.V2.Lib;
namespace Tyuiu.IvanovMS.Sprint4.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];
            string str = "597643158942";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 39;
            Assert.AreEqual(wait, res);
        }
    }
}
