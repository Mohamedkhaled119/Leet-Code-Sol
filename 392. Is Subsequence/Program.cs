namespace _392._Is_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string  s = "bcd", t = "uubcd";
            Console.WriteLine(IsSubsequence(s,t));
        }
        public static bool IsSubsequence(string s, string t)
        {
            int first = 0;
            int second=0;
            if (s == "")
            {
                return true;
            }
            while (second < t.Length)
            {
                if (s[first] == t[second])
                {
                    first++;
                    second++;
                    if(first== s.Length)
                    {
                        return true;
                    }
                }
                else
                {
                    second++;


                }

            }
            
            return false;
        }
    }
}
