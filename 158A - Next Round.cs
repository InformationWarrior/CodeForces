using System;
class Program
{
    public static void Main()
    {
        string[] token1 = Console.ReadLine().Split();
        int n = int.Parse(token1[0]);
        int k = int.Parse(token1[1]);

        int sum = 0;

        string[] token2 = Console.ReadLine().Split();

        int[] a = new int[n];        

        for (int i = 0; i < n ; i++)
        {
            a[i] = int.Parse(token2[i]);           
        }
        for(int i = 0; i < n; i++)
        {
            if (a[i] >= a[k-1] && a[i]>0)
            {
                sum++;
            }
        }
        Console.WriteLine(sum);        
    }
}
