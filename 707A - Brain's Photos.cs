using static System.Console;
using System;
class Program
{
    public static void Main()
    {
        string[] temp = ReadLine().Split();
        int n = int.Parse(temp[0]);
        int m = int.Parse(temp[1]);
        int color = 0;
        

        for (int i = 0; i < n; i++)
        {
            string[] c=ReadLine().Split();
            
            for (int j = 0; j < m; j++)
            {
                
                if (c[j] == "C" || c[j] == "M" || c[j] == "Y")
                {
                    color = 1;
                    break;
                }
            }
            if (color == 1)
                break;
        }
        if (color == 1)
            WriteLine("#Color");
        else
            WriteLine("#Black&White");

    }
}
