// https://www.hackerrank.com/challenges/kangaroo/problem
using System;

class Program
{
    static string Kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 <= v2)
            return "NO";

        if ((x2 - x1) % (v1 - v2) == 0)
            return "YES";
        else
            return "NO";
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int x1 = int.Parse(input[0]);
        int v1 = int.Parse(input[1]);
        int x2 = int.Parse(input[2]);
        int v2 = int.Parse(input[3]);

        Console.WriteLine(Kangaroo(x1, v1, x2, v2));
    }
}
