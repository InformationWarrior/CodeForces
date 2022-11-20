using static System.Console;
class Program
{
    static void Main()
    {
        string[] temp = ReadLine().Split();
        int a1 = int.Parse(temp[0]);
        int a2 = int.Parse(temp[1]);
        int a3 = int.Parse(temp[2]);
        int a4 = int.Parse(temp[3]);
        char[] s = ReadLine().ToCharArray();
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Equals('1'))
                sum += a1;
            else if (s[i].Equals('2'))
                sum += a2;
            else if (s[i].Equals('3'))
                sum += a3;
            else if (s[i].Equals('4'))
                sum += a4;
        }       
        WriteLine(sum);
    }
}
