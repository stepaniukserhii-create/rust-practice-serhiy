// https://www.hackerrank.com/challenges/staircase/problem
using System;

class Solution
{
    static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string(' ', n - i) + new string('#', i));
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        staircase(n);
    }
}
