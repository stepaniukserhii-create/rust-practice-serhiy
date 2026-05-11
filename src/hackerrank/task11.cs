// https://www.hackerrank.com/challenges/diagonal-difference/problem
using System;

class Solution
{
    static int DiagonalDifference(int[][] arr)
    {
        int n = arr.Length;

        int primary = 0;
        int secondary = 0;

        for (int i = 0; i < n; i++)
        {
            primary += arr[i][i];
            secondary += arr[i][n - 1 - i];
        }

        return Math.Abs(primary - secondary);
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            arr[i] = Array.ConvertAll(input, int.Parse);
        }

        int result = DiagonalDifference(arr);

        Console.WriteLine(result);
    }
}
