//Solution 1
using static System.Console;
class Program
{
    public static void Main()
    {
        int n = int.Parse(ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            string s = ReadLine();
            if (s == "Tetrahedron")
            {
                int value = 4;
                sum += value;
            }
            else if (s == "Cube")
            {
                int value = 6;
                sum += value;
            }
            else if (s == "Octahedron")
            {
                int value = 8;
                sum += value;
            }
            else if (s == "Dodecahedron")
            {
                int value = 12;
                sum += value;
            }
            else if (s == "Icosahedron")
            {
                int value = 20;
                sum += value;
            }
        }
        WriteLine(sum);
    }
}

//Solution 2

using static System.Console;
class Program
{
    public static void Main()
    {
        int n = int.Parse(ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            string s = ReadLine();
            if (s == "Tetrahedron")
                sum += 4;
            else if (s == "Cube")
                sum += 6;
            else if (s == "Octahedron")
                sum += 8;
            else if (s == "Dodecahedron")
                sum += 12;
            else if (s == "Icosahedron")
                sum += 20;
        }
        WriteLine(sum);        
    }
}
