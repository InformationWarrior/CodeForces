using static System.Console;
using System;
class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            var arr = ReadLine().Split();
            for (int j = 0; j < 5; j++)
            {
                if (arr[j] == "1")
                    WriteLine(Math.Abs(i - 2) + Math.Abs(j - 2));
            }
        }
    }    
}
