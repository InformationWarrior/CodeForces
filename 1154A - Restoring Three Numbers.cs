using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(ReadLine().Split(), int.Parse);
        Array.Sort(arr);        
        int n = arr[3];
        Write("{0} {1} {2}", n - arr[0], n - arr[1], n - arr[2]);
    }
}
