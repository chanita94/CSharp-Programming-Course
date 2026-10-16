namespace data_structures_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string [] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "end")
            {
                if (command[0]== "Contains")
                {
                    Contains(nums, int.Parse(command[1]));
                }
                else if (command[0]== "PrintEven")
                {
                    PrintEven(nums);
                }
                else if (command[0] == "PrintOdd")
                {
                    PrintOdd(nums);
                }
                else if (command[0] == "Sum")
                {
                    GetSum(nums);
                }
                command = Console.ReadLine().Split().ToArray();
            }
        }
        static void Contains(List<int> nums, int n)
        {
            if(nums.Contains(n))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static void PrintEven(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]%2==0)
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }
        static void PrintOdd(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }
        static void GetSum(List<int>nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
