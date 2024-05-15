namespace _3110._Score_of_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ScoreOfString("hello"));
        }
        public static  int ScoreOfString(string s)
        {
            int sum = 0;
            char[] chars = s.ToCharArray();
            for (int i=1;i<chars.Length;i++)
            {
                int abs = Math.Abs(chars[i] - chars[i-1]);
                sum += abs;
            }
            return sum;

        }
    }
}
