using Tyuiu.IvanovMS.Sprint4.Task1.V9.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Одномерные массивы (ввод с клавиатуры)                                  *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнила: Иванов Максим Сергеевич  | ПКТБ-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 8 подсчитать произведение   *");
        Console.WriteLine("* нечетных элементов массива.                                             *");
        Console.WriteLine("* С клавиатуры: 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = new int[13];
        for (int i = 0; i < 13; i++)
        {
            Console.WriteLine($"Введите значение {i + 1} элемента массива:");

            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(array));
    }
}