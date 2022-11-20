using static System.Console;
class Program
{
    public static void Main()
    {
        int t = int.Parse(ReadLine());
        for (int i = 1; i <= t; i++)
        {
            int n = int.Parse(ReadLine());
            int a = 0;
            if (n > 2)
            {
                if (n % 2 == 0)
                    a = (n / 2) - 1;
                else
                    a = n / 2;
                WriteLine(a);
            }
            else               
                WriteLine(a);
        }
    }
}
