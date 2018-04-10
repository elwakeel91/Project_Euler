// URL of the problem
// https://www.hackerrank.com/contests/projecteuler/challenges/euler005/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    /// <summary>
    /// Returns true if the number is prime
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    static bool IsPrime(int n)
    {
        // false if n = 1
        if (n < 2) return false;

        // true for n = 2 and n = 3
        else if (n < 4) return true;

        // false if n is even
        else if (n % 2 == 0) return false;

        // true for n = 5 and n = 7
        else if (n < 9) return true;

        // false if n is a multiple of 3
        else if (n % 3 == 0) return false;

        // All non-prime numbers below 25 have been ruled out

        else // Check numbers higher than 25
        {
            // Variable holding the sqrt of n
            int r = (int)Math.Sqrt(n);

            // Check if divisible by 5 or 7
            // Therefore every 6k +- 1, starting at 5
            int k = 5;

            // Loop while k is less or equal to r
            while (k <= r)
            {
                if (n % k == 0) return false;
                if (n % (k + 2) == 0) return false;
                k += 6;
            }   // end of while loop

        }   // end of else statement

        return true;

    }   // end of isPrime

    /// <summary>
    /// Calculates the smallest multiple of 'n'
    /// </summary>
    /// <param name="n"></param>
    static int SmallestMultiple(int n)
    {
        // Check if N is less than 3 i.e. 2 or 1
        if (n < 3)
            // N is the smallest multiple
            return n;

        // Variable holding the smallest multiple
        int smallestMultiple = 1;

        // Loop through the numbers from 1 to N
        for (int i = 1; i <= n; i++)
        {
            // Check if it's a prime number
            if (IsPrime(i))
            {
                // Variable holding (prime ^ k)
                int primePowerk = 0;

                // Loop while (prime number ^ k) is less than N
                for (int k = 1; (Math.Pow(i, k)) <= n ; k++)
                {
                    primePowerk = (int)Math.Pow(i, k);
                } 
                // end of for loop

                smallestMultiple *= primePowerk;
            } 
            // end of if statement
        }
        // end of for loop

        return smallestMultiple;
    } 
    // end of function

    /// <summary>
    /// Main program
    /// </summary>
    /// <param name="args"></param>
    static void Main(String[] args)
    {
        // Variable holding the value of test cases
        int t = Convert.ToInt32(Console.ReadLine());
        // Loop through the test cases
        for (int a0 = 0; a0 < t; a0++)
        {
            // Variable holding the value of N
            int n = Convert.ToInt32(Console.ReadLine());
            // Print the smallest multiple
            Console.WriteLine(SmallestMultiple(n));
        }

        Console.ReadLine();
    }
}