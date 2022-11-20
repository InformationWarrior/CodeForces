using System;
class Program
{
    public static void Main()
    {
        string[] token = Console.ReadLine().Split();
        int m = int.Parse(token[0]);
        int n = int.Parse(token[1]);
                
        int result = (m * n) / 2;
        Console.WriteLine(result);
    }
}
