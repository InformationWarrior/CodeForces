using System.Collections.Generic;
using static System.Console;
class Program
{
    static void Main()
    {
        int t = int.Parse(ReadLine());
        for (int i = 0; i < t; i++)
        {
            List<int> list = new List<int>();
            int k = int.Parse(ReadLine());
            int j = 1;
            while (j <= k)
            {
                if (j % 10 != 3 && j % 3 != 0)
                    list.Add(j);
                else
                    k++;
                j++;
            }            
            int n = list.Count;
            int[] arr = list.ToArray();
            WriteLine(arr[n - 1]);            
        }
    }
}
