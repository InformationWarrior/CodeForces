using System;
class Program
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());        

        for(int i = 1; i <= t; i++)
        {
            int sum1 = 0, sum2 = 0;

            string num = Console.ReadLine();
            string num1 = num.Substring(0, 3);
            string num2 = num.Substring(3, 3);

            int a = int.Parse(num1);
            int b = int.Parse(num2);

            int x, y = 0;

            while (a > 0)
            {
                x = a % 10;
                sum1 += x;
                a /= 10;
            }

            while (b > 0)
            {
                y = b % 10;
                sum2 += y;
                b /= 10;
            }

            if (sum1 == sum2)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }    
        

    }
}
