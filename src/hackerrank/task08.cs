// https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int maxScore = scores[0];
        int minScore = scores[0];

        int maxBreaks = 0;
        int minBreaks = 0;

        for (int i = 1; i < n; i++)
        {
            if (scores[i] > maxScore)
            {
                maxScore = scores[i];
                maxBreaks++;
            }
            else if (scores[i] < minScore)
            {
                minScore = scores[i];
                minBreaks++;
            }
        }

        Console.WriteLine($"{maxBreaks} {minBreaks}");
    }
}
