//Solution 1

using System;
class Program
{
    public static void Main()
    {
        string s1 = Console.ReadLine();
        char[] ch = s1.ToCharArray();
        Array.Sort(ch);
        int count = 0;
        for(int i = 0; i < ch.Length-1; i++)
        {
            if (ch[i] == ch[i + 1])
                continue;
            count++; 
        }
        if (count % 2 == 0)
            Console.WriteLine("IGNORE HIM!");
        else
            Console.WriteLine("CHAT WITH HER!");
        
    }
}


//Solution 2

using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        string s1 = Console.ReadLine();
        char[] ch = s1.ToCharArray();
        // Array.Sort(ch);

        List<char> li = new List<char>();

        for (int i = 0; i < ch.Length; i++)
        {
            if (!li.Contains(ch[i]))
            {
                li.Add(ch[i]);
            }
        }
        if (li.Count % 2 != 0)
            Console.WriteLine("IGNORE HIM!");
        else
            Console.WriteLine("CHAT WITH HER!");

    }
}
    
