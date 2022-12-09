//Solution 1

using System.Text;
using static System.Console;
class Program
{
    static void Main()
    {
        int t = int.Parse(ReadLine());
        for (int i = 0; i < t; i++)
        {
            StringBuilder a = new StringBuilder();
            string b = ReadLine();
            
            if (b.Length <= 2)
                WriteLine(b);
            else
            {
                int j = 1;
                a.Append(b[0]);
                while (j <= b.Length)
                {
                    a.Append(b[j]);
                    j += 2;
                }
            }
            WriteLine(a);
        }
    }    
}

//Solution 2

using static System.Console;
class Program
{
    static void Main()
    {
        int t = int.Parse(ReadLine());
        for (int i = 0; i < t; i++)
        {
            string b = ReadLine();
            string a = b.Substring(0, 2);
            for (int j = 3; j <=b.Length; j+=2)
            {
                a += b[j];
            }
            WriteLine(a);
        }
    }    
}
