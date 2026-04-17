// https://www.hackerrank.com/challenges/between-two-sets/problem
using System;
using System.Linq;

class Program
{
    static int GetTotalX(int[] a, int[] b)
    {
        int count = 0;

        int maxA = a.Max();
        int minB = b.Min();

        for (int i = maxA; i <= minB; i++)
        {
            bool valid = true;

            // check if i is multiple of all elements in a
            foreach (int num in a)
            {
                if (i % num != 0)
                {
                    valid = false;
                    break;
                }
            }

            // check if i divides all elements in b
            if (valid)
            {
                foreach (int num in b)
                {
                    if (num % i != 0)
                    {
                        valid = false;
                        break;
                    }
                }
            }

            if (valid)
                count++;
        }

        return count;
    }

    static void Main()
    {
        var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var b = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(GetTotalX(a, b));
    }
}
