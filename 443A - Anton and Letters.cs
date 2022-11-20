using static System.Console;
using System.Collections.Generic;
class Program
{
    static void Main()
    {       
        List<char> list = new List<char>();
        string s = ReadLine();
        char[] separator1 = { '{', '}' };        
        s = s.Trim(separator1);
        s = s.Replace(",", "");
        s = s.Replace(" ", "");        
        int i = 0;
        while (i < s.Length)
        {
            if (!list.Contains(s[i]))
                list.Add(s[i]);
            i++;
        }
        WriteLine(list.Count);
    }
}
