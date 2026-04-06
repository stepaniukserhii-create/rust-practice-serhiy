// https://www.hackerrank.com/challenges/apple-and-orange/problem
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int appleCount = 0;
        int orangeCount = 0;

        foreach (int d in apples)
        {
            int position = a + d;
            if (position >= s && position <= t)
            {
                appleCount++;
            }
        }

        foreach (int d in oranges)
        {
            int position = b + d;
            if (position >= s && position <= t)
            {
                orangeCount++;
            }
        }

        Console.WriteLine(appleCount);
        Console.WriteLine(orangeCount);
    }

    static void Main(string[] args)
    {
        var st = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int s = st[0];
        int t = st[1];

        var ab = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int a = ab[0];
        int b = ab[1];

        var mn = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int m = mn[0];
        int n = mn[1];

        List<int> apples = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> oranges = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
