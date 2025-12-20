using Tyuiu.IvanovMS.Sprint4.Task6.V27.Lib;
namespace Tyuiu.IvanovMS.Sprint4.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            var figures = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            int res = ds.Calculate(figures);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
