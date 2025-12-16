using Tyuiu.IvanovMS.Sprint4.Task2.V7.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        Console.Title = "Спринт #4 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Одномерные массивы (генератор случайных чисел)                          *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич | ПКТБ-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
        Console.WriteLine("* случайными в диапазоне от 4 до 9 подсчитать сумму четных элементов      *");
        Console.WriteLine("* массива.                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = new int[12];
        for (int i = 0; i < 12; i++)
        {
            array[i] = rnd.Next(4, 10);
        }

        for (int i = 0; i < 12; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(array));
    }
}