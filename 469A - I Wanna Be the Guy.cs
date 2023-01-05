https://codeforces.com/contest/469/problem/A

using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int n = int.Parse(ReadLine());
        int[] arr1 = Array.ConvertAll(ReadLine().Split(), int.Parse);        
        int[] arr2 = Array.ConvertAll(ReadLine().Split(), int.Parse);
        bool flag1 = false; bool flag2 = false;
        
        int[] indexes = new int[n+1];
        
        for (int i = 1; i < arr1.Length; i++)
        {
           indexes[arr1[i]]++;
        }
        for (int i = 1; i < arr2.Length; i++)
        {
           indexes[arr2[i]]++;
        }
        
        string ans = "I become the guy.";
        
        for (int i = 1; i < indexes.Length; i++){
            if(indexes[i]==0){
                ans = "Oh, my keyboard!";
                break;
            }
        }
        Console.WriteLine(ans);
    }
}
