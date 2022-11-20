//Solution 1
using static System.Console;
class Program
{
    public static void Main()
    {
        string s = ReadLine();
        string t = ReadLine();
        int len1 = s.Length;
        int len2 = t.Length;
        bool rev = false;
        for (int i = 0; i < len1; i++)
        {
            if ((len1==len2)&&(s[i] == t[len1 - 1 - i]))
                rev = true;
            else
            {
                rev = false;
                break;
            }
        }
        if (rev == false) WriteLine("NO");
        else WriteLine("YES");
    }
}

//Solution 2
using static System.Console;
using System.Text;
class Program
{
    public static void Main()
    {
        string s = ReadLine();
        string t = ReadLine();
        int len = t.Length;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < len; i++)
        {
            sb.Append(t[len-1-i]);
        }
        string t1 = sb.ToString();
        if (s==t1) WriteLine("YES");
        else WriteLine("NO");
    }
}
