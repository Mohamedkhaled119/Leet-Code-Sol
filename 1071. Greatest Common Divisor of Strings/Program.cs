namespace _1071._Greatest_Common_Divisor_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GcdOfStrings("ABCDEF","ABC"));
        }

        public static int GCD(int n1, int n2)
        {
            while (n1 != 0 && n2 != 0)
            {
                if (n1 > n2)
                {
                    n1 %= n2;
                }
                else
                {
                    n2 %= n1;
                }
            }

            return n1 | n2;
        }
        public static string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
            {
                return "";
            }

            int gcdLen = GCD(str1.Length, str2.Length);
            return str1.Substring(0, gcdLen);
        }
    }
}
