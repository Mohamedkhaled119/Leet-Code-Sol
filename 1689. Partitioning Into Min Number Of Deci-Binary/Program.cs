namespace _1689._Partitioning_Into_Min_Number_Of_Deci_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinPartitions("82734"));
        }
        public static int MinPartitions(string n)
        {
            int max = 0;
            foreach (char c in n)
            {
                int num = c-'0';
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
