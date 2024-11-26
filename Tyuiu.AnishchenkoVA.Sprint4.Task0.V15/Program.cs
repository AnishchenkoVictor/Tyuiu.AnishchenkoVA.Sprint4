using Tyuiu.AnishchenkoVA.Sprint4.Task0.V15.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint4.Task0.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов                     *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9               *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива.                     *");
            Console.WriteLine("* {9, 8, 7, 6, 5, 7, 3, 2, 7, 3}                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] res = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + "\t");
            }

            Console.WriteLine("\n" + "***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Произведение нечетных элементов массива = ");
            Console.Write(ds.GetMultOddArrEl(res));

            Console.ReadKey();
        }
    }
}
