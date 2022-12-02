//Method 1

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

//Method 2

using System;
class Program
{
    public static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();

        int[] arr1 = new int[500];
        int[] arr2 = new int[500];

        for (int i = 0; i < a.Length; i++)
        {
            arr1[a[i]]++;
        }

        for (int i = 0; i < b.Length; i++)
        {
            arr1[b[i]]++;
        }

        for (int i = 0; i < c.Length; i++)
        {
            arr2[c[i]]++;
        }

        string ans = "YES";
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                ans = "NO";
                break;
            }
        }
        Console.WriteLine(ans);
    }
}
