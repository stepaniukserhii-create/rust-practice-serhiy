// https://www.hackerrank.com/challenges/sock-merchant/problem
using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] count = new int[101];

        foreach (int sock in arr)
        {
            count[sock]++;
        }

        int pairs = 0;

        for (int i = 0; i < count.Length; i++)
        {
            pairs += count[i] / 2;
        }

        Console.WriteLine(pairs);
    }
}
