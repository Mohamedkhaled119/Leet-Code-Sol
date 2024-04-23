using System.Globalization;

namespace _26._Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 1, 2, 3 };

            Console.WriteLine(RemoveDuplicates(num));


            Console.ReadKey();
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[j] != nums[i])
                {
                    nums[++j] = nums[i];
                }
            }
            return j + 1;// number of unique elements
        }


    }
   
      
    
}
