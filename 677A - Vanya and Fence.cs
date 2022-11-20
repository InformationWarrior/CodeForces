using static System.Console;
class Program
{
    public static void Main()
    {
        string[] temp = ReadLine().Split();
        int n = int.Parse(temp[0]);
        int h = int.Parse(temp[1]);
        string[] temp1 = ReadLine().Split();
        int width = 0;
        for (int i = 0; i <n; i++)
        {           
            int a = int.Parse(temp1[i]);
            int height = (a>h)?2:1;
            width += height;
        }
        WriteLine(width);
    }
}
