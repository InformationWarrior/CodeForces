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
