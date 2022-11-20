using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(ReadLine().Split(), int.Parse);
        int n = arr[0];
        int k = arr[1];
        for (int i = 0; i < k; i++)
        {
            if (n % 10 == 0)
                n /= 10;
            else
                n--;
        }
        WriteLine(n);
    }
}
