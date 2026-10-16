namespace data_structures_exercises
{
    //Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
    //3 3 6 1 => 12 1
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool equals = AreThereEqualElements(nums);
            while (equals == true)
            {
                nums = SumingEqualNums(nums);
                equals = AreThereEqualElements(nums);
            }
            PrintingList(nums);
        }
        static bool AreThereEqualElements(List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
        static List<int> SumingEqualNums(List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] = nums[i] + nums[i + 1];
                    nums.RemoveAt(i + 1);
                }
            }
            return nums;
        }
        static void PrintingList(List<int> nums)
        {
            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
        }
    }
}