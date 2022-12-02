using System;
class Program
{
    public static void Main()
    {
        string[] token = Console.ReadLine().Split();
        int k = int.Parse(token[0]);
        int n = int.Parse(token[1]);
        int w = int.Parse(token[2]);
        int result = 0;
        int cost = 0;

        for (int i = 1; i <= w; i++)
        {
            cost += i * k;            
        }
        if (cost > n)
        {
            result = cost - n;
            Console.WriteLine(result);
        }            
        else
            Console.WriteLine("0");
    }
}
