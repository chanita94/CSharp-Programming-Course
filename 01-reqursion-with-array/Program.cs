namespace data_structures_exercises
{
    //Write a program to receive an array of numbers and condense them by summing adjacent couples of elements
    //until a single number is obtained. 
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int result = Reqursion(arr);
            Console.WriteLine(result);
        }
        public static int Reqursion(int[] arr)
        {
            int[] arrSums = new int[arr.Length - 1];
            int result = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arrSums[i] = arr[i] + arr[i + 1];
            }
            if (arrSums.Length != 1)
            {
                result = Reqursion(arrSums);
            }
            else
            {
                result = arrSums[0];
            }
            return result;
        }
    }
}
