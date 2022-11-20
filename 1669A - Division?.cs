using static System.Console;
class Program
{
    static void Main()
    {
        int t = int.Parse(ReadLine());
        for (int i = 0; i < t; i++)
        {
            int rating = int.Parse(ReadLine());
            if (rating >= 1900)
                WriteLine("Division 1");
            else if (rating >= 1600 && rating <= 1899)
                WriteLine("Division 2");
            else if (rating >= 1400 && rating <= 1599)
                WriteLine("Division 3");
            else if (rating <= 1399)
                WriteLine("Division 4");
        }
    }
}
