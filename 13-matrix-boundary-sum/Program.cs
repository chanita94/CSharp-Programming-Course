namespace _13_matrix_boundary_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            matrix = FillMatrix(matrix);
            int sum = SumTheBorders(matrix);
            Console.WriteLine(sum);
        }
        static int[,] FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }
            return matrix;
        }
        static int SumTheBorders(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == matrix.GetLength(0) - 1 || j == matrix.GetLength(1) - 1)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
