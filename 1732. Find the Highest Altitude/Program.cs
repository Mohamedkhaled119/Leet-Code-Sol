namespace _1732._Find_the_Highest_Altitude
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(LargestAltitude([-5, 1, 5, 0, -7]));
        }
        public static int LargestAltitude(int[] gain)
        {
            List<int> result = new List<int>();
            result.Add(0);
            for (int i = 0; i < gain.Length; i++)
            {
                 result.Add( result[i]  + gain[i]);

            }
            return result.Max(x=>x);

        }
    }
}
