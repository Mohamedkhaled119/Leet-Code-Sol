namespace _2037._Minimum_Number_of_Moves_to_Seat_Everyone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seat = [3, 1, 5];
            int[] studens = [2, 7, 4];
            Console.WriteLine(MinMovesToSeat(seat,studens));
        }
        public static  int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);
            int Moves = 0;
            
            
            for (int i = 0;i<seats.Length;i++)
            {
               Moves+=students[i] - seats[i];
            }




            return Moves;
        }
    }
}
