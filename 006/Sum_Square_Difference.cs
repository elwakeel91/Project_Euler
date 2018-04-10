// URL of the problem
// https://www.hackerrank.com/contests/projecteuler/challenges/euler006/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Calculates the sum of the numbers from 1 to n
        /// </summary>
        /// <param name="n"></param>
        static int SumOfSeries(int n)
        {
            return (n * (1 + n)) / 2;
        }

        /// <summary>
        /// Calculates the sum of the numbers from (1^2 to n^2)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int SumOfSquaredSeries(int n)
        {
            return (n * (n + 1) * (2 * n + 1)) / 6;
        }

        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int totalSum = (int)Math.Pow(SumOfSeries(n), 2) + SumOfSquaredSeries(n);

                Console.WriteLine(totalSum);
            }
        }
    }
}
