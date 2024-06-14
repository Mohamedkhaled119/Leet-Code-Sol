using System.Collections;

namespace _66.plus_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Test = [8,9,9,9];
          var ans=  PlusOne(Test);
            foreach (var i in ans)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                else
                {
                    digits[i] = 0;

                }
            }
            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;

            return newNumber;
        }
    }
}
