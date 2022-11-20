using System;
using static System.Console;
class Program
{
    static void Main()
    {
        long n = long.Parse(ReadLine());
        if (n % 2 == 0)
            WriteLine(n / 2);
        else
        {
            long val = (n + 1) / 2;
            val = -val;
            WriteLine(val);
        }
    }
}
