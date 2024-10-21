namespace _605._can_place_flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    if ((i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                    {
                        n--;
                        flowerbed[i] = 1;
                    }
                }
            }

            return n <= 0;
        }

    }
}
