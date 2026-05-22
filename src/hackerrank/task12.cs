https://www.hackerrank.com/challenges/drawing-book/problem
using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int fromFront = p / 2;
        int fromBack = n / 2 - p / 2;

        Console.WriteLine(Math.Min(fromFront, fromBack));
    }
}
