// https://www.hackerrank.com/challenges/grading/problem
using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 38)
            {
                int nextMultiple = ((grade / 5) + 1) * 5;

                if (nextMultiple - grade < 3)
                {
                    grade = nextMultiple;
                }
            }

            Console.WriteLine(grade);
        }
    }
}

