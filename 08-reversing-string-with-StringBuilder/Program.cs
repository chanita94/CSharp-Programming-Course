using System.Text;

namespace data_structures_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Input string cannot be null.");
            }
            else
            {
                StringBuilder sb = new StringBuilder(input.Length);
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    sb.Append(input[i]);
                }
                Console.WriteLine($"Reversed string: {sb.ToString()}");
            }


        }

    }

}
