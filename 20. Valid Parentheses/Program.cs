namespace _20._Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("()"));
            Console.ReadKey();
        }
        public static bool IsValid(string s)
        {
           Stack<char> stack = new Stack<char>();
            char[] c=s.ToCharArray();
           for (int i = 0; i < s.Length; i++)
           {
                if (c[i] == '(')
                {
                    stack.Push(')');
                }
                else if (c[i]=='{')
                {
                    stack.Push('}');
                }
                else if (c[i]=='[')
                {
                    stack.Push(']');
                }
                else if(stack.Count == 0 || stack.Pop() != c[i])
                {
                    return false;
                }

           }
           if (stack.Count == 0)
           {
                return true;
           }
           else { return false; }

            


        }
    }
}
