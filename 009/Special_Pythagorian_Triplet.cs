// URL of the problem
// https://www.hackerrank.com/contests/projecteuler/challenges/euler009/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        // Using the formula b = ( N^2 - 2aN ) / ( 2N - 2a ) to solve the problem
        static int TripleProduct(int n)
        {

            int a, b, c;                    // Variables holding our values of a, b and c
            int tripleProduct = -1;         // Triple product variable initialised at -1


            // Loop through the possible values of a up to (N / 3)
            for (a = 1; a < n / 3; a++)
            {
                // Calculate b and c
                b = ((int)Math.Pow(n, 2) - 2 * a * n) / (2 * n - 2 * a);
                c = n - b - a;

                // Check all the conditions have been met
                if (a < b && b < c && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                {
                    // Calculate the triple product
                    tripleProduct = a * b * c;
                }
            }

            // Return the largest value of triple product
            return tripleProduct;
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
                Console.WriteLine(TripleProduct(n));
            }
        }
    }
}
