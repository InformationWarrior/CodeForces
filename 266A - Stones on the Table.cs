using static System.Console;
class Program
{
    static void Main()
    {
        int n = int.Parse(ReadLine());
        string s = ReadLine();
        int count = 0;
        for (int i = 0; i < n-1; i++)
        {
            if (s[i] == s[i + 1])
                count++;
        }
        WriteLine(count);     
    }
}
