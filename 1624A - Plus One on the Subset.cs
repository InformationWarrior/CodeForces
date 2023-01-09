using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int t = int.Parse(ReadLine());
        while (t-->0)
        {
            int n = int.Parse(ReadLine());
            int[] arr = Array.ConvertAll(ReadLine().Split(), int.Parse);
            Array.Sort(arr);
            int min = arr[0];
            int max = arr[n - 1];
            WriteLine(max - min);
        }
    }
}
