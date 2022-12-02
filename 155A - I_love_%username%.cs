using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int n = int.Parse(ReadLine());
        int count = 0;
        int[] arr = Array.ConvertAll(ReadLine().Split(), int.Parse);

        int min = arr[0];
        int max = arr[0];
        for (int j = 0; j < n; j++)
        {
            if (arr[j] > max)
            {
                max = arr[j];
                count++;
            }
            if (arr[j] < min)
            {
                min = arr[j];
                count++;
            }
        }
        WriteLine(count);
    }
}
