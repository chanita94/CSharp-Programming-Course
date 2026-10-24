using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace _12_diagonal_difference_in_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,]matrix = new int[size,size];
            matrix=FillMatrix(matrix);
            int firstDiagonal = 0;
            int secondDiagonal = 0;
            for (int i = 0; i < size; i++)
            {
                firstDiagonal += matrix[i, i];
            }
            for (int i = size-1;i >= 0; i--)
            {
                secondDiagonal += matrix[size - i - 1, i];
            }
            Console.WriteLine(Math.Abs(firstDiagonal-secondDiagonal));
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

    }
}
