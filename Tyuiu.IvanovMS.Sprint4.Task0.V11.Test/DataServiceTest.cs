using System.Globalization;
using Tyuiu.IvanovMS.Sprint4.Task0.V11.Lib;
namespace Tyuiu.IvanovMS.Sprint4.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int res = ds.GetMultOddArrEl(numsArray);
            int wait = 4725;
            Assert.AreEqual(wait, res);
        }
    }
}
