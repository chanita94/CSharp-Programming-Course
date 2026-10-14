namespace data_structures_exercises
{
    //The array should be rotated to the right side 
    //You receive an array of strings and count of rotation you need to perform.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[ ] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int a = 0; a < n; a++)
            {
                int lastElement = arr[arr.Length-1];
                for (int i = arr.Length-1; i >0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = lastElement;
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            
        }
    }
}
