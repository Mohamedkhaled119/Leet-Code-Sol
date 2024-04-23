namespace _58._Length_of_Last_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
            Console.ReadKey();
        }
        public static int LengthOfLastWord(string s)
        {
            string sTrimmed =s.TrimEnd();
            string[] Words = sTrimmed.Split();
            string last = Words[Words.Length-1];
            return last.Length;
        }
    }
}
