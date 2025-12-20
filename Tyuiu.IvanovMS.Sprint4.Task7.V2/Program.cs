using Tyuiu.IvanovMS.Sprint4.Task7.V2.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич | ПКТБ-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр '597643158942'. Преобразуйте ее       *");
        Console.WriteLine("* в матрицу 3 на 4 и подсчитайте cevve нечетных чисел в матрице.          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        int r = 3;
        int c = 4;
        string str = "597643158942";
        int ind = 0;
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Матрица:");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(str[ind] + "\t");
                ind++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Количество нечетных чисел в матрице: ");
        Console.WriteLine(ds.Calculate(r, c, str));
    }
}