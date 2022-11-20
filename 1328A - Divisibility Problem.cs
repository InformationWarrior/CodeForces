using System;
class Program
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        for (int i = 1; i <= t; i++)
        {
            string[] temp = Console.ReadLine().Split();
            int a = int.Parse(temp[0]);
            int b = int.Parse(temp[1]);

            if (a % b == 0)
                Console.WriteLine("0");
            else
            {
                int w = (a % b);
                Console.WriteLine(b - w);
            }
        }
    }
}
