//Solution 1

using static System.Console;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<long> list = new List<long>();
        long n = long.Parse(ReadLine());
        while (n > 0)
        {
            long remainder = n % 10;
            if (remainder == 4 || remainder == 7)
            {
                list.Add(remainder);
            }
            long quo = n / 10;
            n = quo;
        }
        if (list.Count == 4 || list.Count == 7)
            WriteLine("YES");
        else
            WriteLine("NO");
    }
}

//Solution 2

using static System.Console;
class Program
{
    static void Main()
    {        
        long n = long.Parse(ReadLine());
        int count = 0;
        while (n > 0)
        {            
            if (n % 10 == 4 || n % 10 == 7)
                count++;
            n /= 10;
        }
        if (count == 4 || count == 7)
            WriteLine("YES");
        else
            WriteLine("NO");
    }
}
