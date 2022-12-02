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


//Method 2
using System;
class Program
{
    public static void Main()
    {
        int X = 0, Y = 0;
        for (int i = 0; i < 5; i++)
        {
            string[] token = Console.ReadLine().Split();

            for (int j = 0; j < token.Length; j++)
            {
                if (token[j] == "1")
                {
                    X = j + 1;
                    Y = i + 1;
                    break;
                }
            }
        }

        int ans = Math.Abs(X - 3) + Math.Abs(Y - 3);

        Console.WriteLine(ans);
    }
}
