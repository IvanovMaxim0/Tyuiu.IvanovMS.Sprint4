using Tyuiu.IvanovMS.Sprint4.Task5.V21.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();
        int[,] matrix = new int[5, 5];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(-8, 3);
            }
        }
        Console.Title = "Спринт #4 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Двумерные массивы  (генератор случайных чисел)                          *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич  | ПКТБ-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* случайными значениями в диапазоне от -8 до 2. Заменить положительные    *");
        Console.WriteLine("* элементы на 1.                                                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(ds.Calculate(matrix)[k, j] + "\t");
            }
            Console.WriteLine();
        }

    }
}