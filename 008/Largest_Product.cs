// URL of the problem
// https://www.hackerrank.com/contests/projecteuler/challenges/euler008/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank_CSharp
{
    sealed class Solution
    {
        /// <summary>
        /// Calculates the largest product in the series
        /// </summary>
        /// <param name="sNum"></param>
        /// <param name="k"></param>
        static int LargestProduct(string sNum, int k, int n)
        {
            // Variable holding our product initialised as the first digit
            int largestProduct = 0;

            // Loop through the series of numbers
            for (int i = 0; i <= (n - k); i++)
            {
                // Create our mini series
                string mini_sNum = sNum.Substring(i, k);

                // Variable holding our temporary product value
                int product = 1;

                // Loop through the mini series
                for (int j = 0; j < k; j++)
                    // Calculate the product of the current mini series
                    product *= (int)(mini_sNum[j] - '0');

                // Check if we have a new largest product
                largestProduct = product > largestProduct ? product : largestProduct;
            }

            return largestProduct;
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
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string num = Console.ReadLine();
                Console.WriteLine(LargestProduct(num, k, n));
            }

            Console.ReadLine();
        }
    }
}
