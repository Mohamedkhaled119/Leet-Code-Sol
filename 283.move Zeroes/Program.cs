
namespace _283.move_Zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoveZeroes([0, 1, 0, 3, 12]);
            Console.WriteLine("Hello, World!");
        }
        public static void MoveZeroes(int[] nums)
        {
            int len = nums.Length;
            int slow = 0;
            int fast = 0;
            while (fast < len)
            {
                if (nums[fast] != 0)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
                fast++;
            }
            for (int i = slow; i < len; i++) nums[i] = 0;
        }

    }
}
