using static System.Console;
using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(ReadLine());
        int[] arr = Array.ConvertAll(ReadLine().Split(), int.Parse);
        int sum = 0;
        int max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        for (int i = 0; i < n; i++)
        {
            int diff = max - arr[i];
            sum += diff;
        }
        WriteLine(sum);
    }
}
