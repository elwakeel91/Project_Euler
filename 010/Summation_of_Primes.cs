// URL of the problem
// https://www.hackerrank.com/contests/projecteuler/challenges/euler010/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution : PrimeNumbers
    {
        // Calculates the sum of the prime numbers
        static int PrimesSum(int n)
        {
            int sum = 0;                        // Variable holding our running sum value

            // Loop through the numbers from 0 to N
            for (int i = 0; i <= n; i++)
            {
                // Check if it's a prime number
                if (IsPrime(i))
                    // Add it to our running sum
                    sum += i;
            }
            // Return the value of sum
            return sum;
        }

        static void Main(String[] args)
        {
            // Get the number of test cases from the user
            int t = Convert.ToInt32(Console.ReadLine());

            // Loop through the test cases
            for (int a0 = 0; a0 < t; a0++)
            {
                // Get the value of N from the user
                int n = Convert.ToInt32(Console.ReadLine());
                // Output the result
                Console.WriteLine(PrimesSum(n));
            }
        }
    }
}
