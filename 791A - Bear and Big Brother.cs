using System;
class Program
{
    public static void Main()
    {
        string[] temp = Console.ReadLine().Split();
        int a = int.Parse(temp[0]);
        int b = int.Parse(temp[1]);
       
        int result=0;
        while (true)
        {
            a *= 3; b *= 2;
            result++;
            if (a > b)
                break;
        }
        Console.WriteLine(result);
    }
}
