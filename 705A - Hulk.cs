using static System.Console;
class Program
{
    static void Main()
    {
        int n = int.Parse(ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
                Write("I hate ");
            else
                Write("I love ");
            if (i == n - 1)
                Write("it ");
            else 
                Write("that ");
        }
        Read();
    }
}
