using static System.Console;
class Program
{
    public static void Main()
    {
        int n = int.Parse(ReadLine());
        int sum = 0, count = 0;
        for (int i = 1;; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                sum += j;
            }
            if (sum > n)
                break;
            count++;
        }
        WriteLine(count);
    }
}
