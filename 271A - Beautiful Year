using static System.Console;
class Program
{
    static void Main()
    {
        int y = int.Parse(ReadLine());
        while (true)
        {
            y++;
            int a = y / 1000;            
            int b = (y / 100) % 10;
            int c = (y / 10) % 10;
            int d = (y % 10);
            if (a != b && a != c && a != d && b != c && b != d && c != d)
                break;
        }
        WriteLine(y);
    }
}
