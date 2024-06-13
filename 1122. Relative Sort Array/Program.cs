using System.Collections.Immutable;

namespace _1122._Relative_Sort_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = [26, 21, 11, 20, 50, 34, 1, 18];
            int[] arr2 = [21, 11, 26, 20];
            var result=RelativeSortArray(arr1, arr2);
            foreach(int i in result) 
            {
                Console.WriteLine(i);
            }
        }
        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            int[]Ans = new int[arr1.Length];
            int Ans_counter = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                for(int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        Ans[Ans_counter] = arr1[j];
                        arr1[j] = -1;
                        Ans_counter++;
                    }
                }           
            }
            Array.Sort(arr1);
            
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != -1)
                {
                    Ans[i]=(arr1[i]);
                }
            }
             return Ans;
        }
    }
}
