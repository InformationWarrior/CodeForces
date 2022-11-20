using static System.Console;
using System;
class Program
{
    static void Main()
    {
        int t = int.Parse(ReadLine());
        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(ReadLine());            
            int pile = n / 2;
            int[] arr = new int[n];
            
            for (int j = 1; j <= n; j++)
                arr[j - 1] = (int)Math.Pow(2, j);
            
            int sumA = arr[n - 1];            
            for (int j = 0; j < pile-1; j++)
                sumA += arr[j];

            int sumB = 0;
            for (int j = pile-1; j < n-1; j++)
                sumB += arr[j];

            int ans = sumA - sumB;
            WriteLine(ans);
        }
    }
}
