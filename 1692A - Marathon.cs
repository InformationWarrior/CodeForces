//Solution 1 

using static System.Console;
class Program
{
    static void Main()
    {
        int n = int.Parse(ReadLine());
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            string[] temp = ReadLine().Split();
            int[] a = new int[4];
            for (int j = 0; j < 4; j++)
            {
                a[j] = int.Parse(temp[j]);
            }
            if (a[1] > a[0])
                count++;
            if (a[2] > a[0])
                count++;
            if (a[3] > a[0])
                count++;
            WriteLine(count);            
        }
    }
}

//Solution 2

using static System.Console;
using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(ReadLine());        
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            string[] temp = ReadLine().Split();
            int[] a = new int[4];
            for (int j = 0; j < 4; j++)
            {
                a[j] = int.Parse(temp[j]);
            }
            count = Convert.ToInt32(a[1] > a[0]) + Convert.ToInt32(a[2] > a[0]) + Convert.ToInt32(a[3] > a[0]);            
            WriteLine(count);            
        }
    }
}

//Solution 3

using static System.Console;
using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(ReadLine());
        for (int i = 0; i < n; i++)
        {
            int count = 0;         
            int[] a = Array.ConvertAll(ReadLine().Split(), int.Parse);
            if (a[1] > a[0])
                count++;
            if (a[2] > a[0])
                count++;
            if (a[3] > a[0])
                count++;
            WriteLine(count);
        }
    }
}
