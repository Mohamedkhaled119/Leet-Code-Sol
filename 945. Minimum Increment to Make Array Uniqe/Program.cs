namespace _945._Minimum_Increment_to_Make_Array_Uniqe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 2];
            Console.WriteLine(MinIncrementForUnique(nums));
        }
        public static int MinIncrementForUnique(int[] nums)
        {
            int count = 0;
            Array.Sort (nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    int NewValue =nums[i]+1;
                    count += NewValue-nums[i-1];
                    nums[i] = NewValue;
                    
                }
            }


            return count;

        }
    }
}
