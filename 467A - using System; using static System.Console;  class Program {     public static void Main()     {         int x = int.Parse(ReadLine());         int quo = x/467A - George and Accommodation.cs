using System;
using static System.Console;

class Program
{
    public static void Main()
    {
        int n = int.Parse(ReadLine());
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            string[] temp = ReadLine().Split();
            int p = int.Parse(temp[0]);
            int q = int.Parse(temp[1]);

            if ((q - p) >= 2)
                count++;
        }
        WriteLine(count);
        Read();
    }
}
