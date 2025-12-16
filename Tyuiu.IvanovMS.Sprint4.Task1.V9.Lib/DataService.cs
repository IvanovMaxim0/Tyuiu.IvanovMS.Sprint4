using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.IvanovMS.Sprint4.Task1.V9.Lib
{
    public class DataService : ISprint4Task1V9
    {
        public int Calculate(int[] array)
        {
            int n = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    n *= array[i];
                }

            }
            return n;
        }
    }
}
