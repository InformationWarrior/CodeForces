using static System.Console;
class Program
{
    public static void Main()
    {
        int n = int.Parse(ReadLine());
        string[] temp1 = ReadLine().Split();
        bool prob = false;
        for (int i = 0; i <n; i++)
        {           
            int a = int.Parse(temp1[i]);            
            if (a == 1)
                prob = true;
        }
        if (prob == true) WriteLine("HARD");
        else WriteLine("EASY");
    }
}
