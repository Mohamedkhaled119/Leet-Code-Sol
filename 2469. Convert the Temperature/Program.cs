namespace _2469._Convert_the_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var temp = ConvertTemperature(36);
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }

        }
        public static double[] ConvertTemperature(double celsius)
        {
            double[] temps = { celsius + 273.15, (celsius * 1.80) + 32.00 };
            return temps;
        }

    }
}
