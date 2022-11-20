using static System.Console;
using System;
using System.Text;
class Program
{
    static void Main()
    {
        string arr = ReadLine();
        arr = arr.Replace("+", "");
        char[] ar = arr.ToCharArray();
        Array.Sort(ar);        
        StringBuilder str = new StringBuilder();
        int count = 0;
        while (count < ar.Length)
        {
            str.Append(ar[count]);            
            str.Append('+');
            count++;
        }        
        str.Remove(str.Length-1, 1);        
        WriteLine(str);
    }
}
