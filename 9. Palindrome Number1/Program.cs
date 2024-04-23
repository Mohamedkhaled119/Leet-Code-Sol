namespace _9._Palindrome_Number1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
        }
        public static bool IsPalindrome(int x)
        {
            int result = 0;
            int y = x;
            while (y > 0)
            {
                result = result * 10 + y % 10;
                y /= 10;
            }
            return result == x;
            
            
        }
    }
}
