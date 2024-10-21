
namespace _345.Revers_Vowels_of_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseVowels("IceCreAm"));
        
        }
        public static string ReverseVowels(string s)
        {
            int right = 0;
            int left = s.Length-1;
            char[] chars = s.ToCharArray();
            
            while(right < left) 
            {
                if ("aeiouAEIOU".Contains(chars[right]) && "aeiouAEIOU".Contains(chars[left]))
                {
                    char temp = chars[right];
                    chars[right] = chars[left];
                    chars[left] = temp;
                    right++;
                    left--;

                }
                if(!"aeiouAEIOU".Contains(chars[right]))
                {
                    right++;
                }
               if(!"aeiouAEIOU".Contains(chars[left]))
                {
                    left--;
                }
            }
            return new string(chars);
           
        }
    }
}
