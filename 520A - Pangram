using System.Collections.Generic;
using static System.Console;
class Program
{
    public static void Main()
    {
        int n = int.Parse(ReadLine());
        string str = ReadLine();
        str = str.ToLower();
        char[] ch = str.ToCharArray();
        List<char> li = new List<char>();
        for (int i = 0; i < n; i++)
        {
            if (!li.Contains(ch[i]))
                li.Add(ch[i]);
        }
        if(li.Count==26) WriteLine("YES");
        else WriteLine("NO");        
        Read();
    }
}
