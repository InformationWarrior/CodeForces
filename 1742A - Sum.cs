using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int t = int.Parse(ReadLine());
        for (int i = 0; i < t; i++)
        {
            int[] arr = Array.ConvertAll(ReadLine().Split(), int.Parse);
            int a = arr[0];
            int b = arr[1];
            int c = arr[2];
            if (a + b == c || a + c == b || b + c == a)
                WriteLine("YES");
            else
                WriteLine("NO");
        }
    }    
}
