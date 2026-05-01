// https://www.hackerrank.com/challenges/migratory-birds/problem
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] count = new int[6];

        foreach (int bird in arr)
        {
            count[bird]++;
        }

        int maxCount = 0;
        int result = 1;

        for (int i = 1; i <= 5; i++)
        {
            if (count[i] > maxCount)
            {
                maxCount = count[i];
                result = i;
            }
        }

        Console.WriteLine(result);
    }
}
