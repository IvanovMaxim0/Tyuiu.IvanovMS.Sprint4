using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.IvanovMS.Sprint4.Task0.V11.Lib
{
    public class DataService : ISprint4Task0V11
    {
        public int GetMultOddArrEl(int[] array)
        {
            int n = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    n *= array[i];
                }
                    
            }
            return n;
        }
    }
}
