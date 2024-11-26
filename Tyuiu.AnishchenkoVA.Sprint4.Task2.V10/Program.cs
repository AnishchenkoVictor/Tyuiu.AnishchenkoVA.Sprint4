using Tyuiu.AnishchenkoVA.Sprint4.Task2.V10.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint4.Task2.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Анищенко В. А. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Анищенко Виктор Александрович | ИИПБ-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов                     *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 2 до 6               *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива.                     *");
            Console.WriteLine("* С клавиатуры: 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.Write("Введите длину массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] res = new int[len];
            for (int i = 0; i < len; i++)
            {
                res[i] = rnd.Next(1,6);
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(res[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Произведение нечетных элементов массива = ");
            Console.WriteLine(ds.Calculate(res));
            Console.ReadKey();
        }
    }
}
