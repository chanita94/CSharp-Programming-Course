using System.Text;

namespace data_structures_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            StringBuilder sb = new StringBuilder();
            sb = DeleteEmptyPlaces(input);
            bool isTrue = IsItPalindrome(sb);
            Console.WriteLine(isTrue);
        }

        static StringBuilder DeleteEmptyPlaces(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    sb.Append(input[i]);
                }
            }
            return sb;
        }
        static bool IsItPalindrome (StringBuilder sb)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] != sb[sb.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
