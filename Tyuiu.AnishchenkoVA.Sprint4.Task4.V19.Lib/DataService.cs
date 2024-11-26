using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AnishchenkoVA.Sprint4.Task4.V19.Lib
{
    public class DataService : ISprint4Task4V19
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            int c = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        c += matrix[i,j];
                    }
                }
            }
            return c;
        }
    }
}
