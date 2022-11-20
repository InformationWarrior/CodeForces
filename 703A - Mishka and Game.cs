using static System.Console;
class Program
{
    static void Main()
    {
        int n = int.Parse(ReadLine());
        int mCount=0;
        int cCount=0;
        for (int i = 0; i < n; i++)
        {
            string[] temp = ReadLine().Split();
            int m = int.Parse(temp[0]);
            int c = int.Parse(temp[1]);
            if (m > c)
                mCount++;
            else if (c > m)
                cCount++;
        }
        if (mCount > cCount)
            WriteLine("Mishka");
        else if (cCount > mCount)
            WriteLine("Chris");
        else
            WriteLine("Friendship is magic!^^");
    }
}
