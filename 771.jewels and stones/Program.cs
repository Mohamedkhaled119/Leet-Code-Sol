namespace _771.jewels_and_stones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumJewelsInStones("aA", "AAabbbbb"));

        }
        public static  int NumJewelsInStones(string jewels, string stones)
        {
            int stone_counter = 0;
            foreach (char jewel in jewels)
            { 
                foreach (char stone in stones)
                {
                    if (jewel == stone)
                    {
                        stone_counter++;
                    }
                }
            }
            return stone_counter;


        }
    }
}
