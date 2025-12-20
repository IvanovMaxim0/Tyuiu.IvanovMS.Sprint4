using Tyuiu.IvanovMS.Sprint4.Task5.V21.Lib;
namespace Tyuiu.IvanovMS.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { -1, 0, -1 , 0, 1 }, { -1, 0, -1, 0, 1 }, { -1, 0, -1, 0, 1 }, { -1, 0, -1, 0, 1 }, { -1, 0, -1, 0, 1 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[,] { { -1, 0, -1, 0, 1 }, { -1, 0, -1, 0, 1 }, { -1, 0, -1, 0, 1 }, { -1, 0, -1, 0, 1 }, { -1, 0, -1, 0, 1 } };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
