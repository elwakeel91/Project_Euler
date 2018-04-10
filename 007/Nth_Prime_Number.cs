// URL of the problem
// https://www.hackerrank.com/contests/projecteuler/challenges/euler006/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution : PrimeNumbers
    {
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            // Store the number of test cases
            int t = Convert.ToInt32(Console.ReadLine());

            // Loop through the test cases
            for (int a0 = 0; a0 < t; a0++)
            {
                // Store the value of N
                int n = Convert.ToInt32(Console.ReadLine());
                // Print the value of the Nth prime number
                Console.WriteLine(NthPrime(n));
            }
        }
    }
}
