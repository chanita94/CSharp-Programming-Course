namespace _03_array_Pascal_s_triangle
{
    //4 rows
    //1
    //1 1
    //1 2 1
    //1 3 3 1
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int[] row = new int [numberOfRows];
            row [0] = 1;
            for (int i = 0; i < numberOfRows; i++)//for the rows
            {
                for (int j = i; j>0;j--)//from right to left
                {
                    row[j] = row[j]+row[j-1];                    
                }
                for (int n = 0; n <= i; n++)//only print 
                {
                    Console.Write(row[n] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
