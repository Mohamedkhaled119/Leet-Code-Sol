namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] candies = { 2, 3, 5, 1, 3 };
            int Extra = 3;
           IList<bool>x= KidsWithCandies(candies, Extra);
            foreach(bool i in x)
            {
                Console.WriteLine(i);
            }
        }
        public  static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {

            int max = candies.Max();
            return candies.Select(x => x + extraCandies >= max).ToList<bool>();
        }
    }
}
