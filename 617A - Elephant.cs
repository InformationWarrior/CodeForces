using System;
using static System.Console;

class Program
{
    public static void Main()
    {
        int x = int.Parse(ReadLine());
        int quo = x / 5;
        int step = quo;
        if (x % 5 != 0)
            step += 1;            
        WriteLine(step);       
    }
}
