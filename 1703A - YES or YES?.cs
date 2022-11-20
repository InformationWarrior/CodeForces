using static System.Console;
class Program
{
    public static void Main()
    {
        int t = int.Parse(ReadLine());
        for (int i = 1; i <= t; i++)
        {
            string s = ReadLine();
            s = s.ToUpper();
            if (s.Equals("YES"))
                WriteLine("YES");
            else
                WriteLine("NO");
        }
    }
}
