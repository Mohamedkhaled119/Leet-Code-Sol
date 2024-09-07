using System.Runtime.InteropServices.Marshalling;

namespace _1768._Merge_Strings_Alternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MergeAlternately("ab","pqr"));
        }
        public static string MergeAlternately(string word1, string word2)
        {
            char[] FirstWord=word1.ToCharArray();
            char[] SecondWord=word2.ToCharArray();
            int compare = 0;
            if(FirstWord.Length >= SecondWord.Length)
            {
                compare = FirstWord.Length;
            }
            else
            {
                compare=SecondWord.Length;
            }
            string ans = "";
            for (int i = 0; i < compare; i++)
            {
                if (i < FirstWord.Length)
                {
                    ans += FirstWord[i];
                }
                if (i < SecondWord.Length)
                {
                    ans += SecondWord[i];
                }
            }
            return ans;


        }
    
    }
}
