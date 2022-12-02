using System;
using System.Linq;
class Program
{
    public static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();

        a += b;

        a = SortString(a);
        c = SortString(c);

        if (a == c)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
        Console.Read();
    }

    static string SortString(string input)
    {
        char[] characters = input.ToArray();
        Array.Sort(characters);        
        return new string(characters);
    }
}
