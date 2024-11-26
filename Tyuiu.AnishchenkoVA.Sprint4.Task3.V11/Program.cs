using Tyuiu.AnishchenkoVA.Sprint4.Task3.V11.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint4.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 4 до 9.              *");
            Console.WriteLine("* Подсчитайте количество нечетных элементов во всем массиве.              *");
            Console.WriteLine("* {8,6,9,4,5} , {9,4,8,5,6} , {9,7,9,8,4} , {4,6,5,7,8} , {6,6,7,6,4}     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrx = { { 8, 6, 9, 4, 5 }, { 9, 4, 8, 5, 6 }, { 9, 7, 9, 8, 4 }, { 4, 6, 5, 7, 8 }, { 6, 6, 7, 6, 4 } };
            int rows = matrx.GetUpperBound(0) + 1;
            int cols = matrx.Length / rows;

            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrx[i, j]}  \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Количество нечетных элементов = ");
            Console.WriteLine(ds.Calculate(matrx));
            Console.ReadKey();

        }
    }
}
