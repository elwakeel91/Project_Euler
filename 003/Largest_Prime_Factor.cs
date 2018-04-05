// URL of the problem
// https://www.hackerrank.com/contests/projecteuler/challenges/euler003

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    // Check if pN is a prime factor of num
    static bool isPrimeFactor(long num, long pN)
    {
        return (num % pN == 0) ? true : false;
    }

    // Divide our number n by the largest prime factor
    static void DivideByPF(ref long n, long pF)
    {
        // Divide by the largest PF until there is a remainder
        while (n % pF == 0)
        {
            n /= pF;
        }
    }

    // Find the prime numbers up to N
    static void PrimeNumbers(long n)
    {
        // Variable holding the largest Prime Factor
        long largestPF = 2;
        DivideByPF(ref n, largestPF);

        // if we cannot divide by the largest PF anymore and n is reduce to 1 then we have the largest PF
        if (n == 1)
        {
            // Print the largest prime factor
            Console.WriteLine(largestPF);
            return;
        }

        // Loop through the odd numbers up to N
        for (long i = 3; i <= n; i += 2)
        {
            // Initialise our isPrime bool
            bool isPrime = true;

            // Loop through the numbers up to 'i'
            for (long j = 2; j <= Math.Sqrt(i); j++)
            {
                // Check if 'i' is divisible by 'j'
                if (i % j == 0)
                {
                    // 'i' is not a prime number
                    isPrime = false;
                    break;
                }
            }

            // Check if 'i' is a prime number and prime factor
            if (isPrime && isPrimeFactor(n, i))
            {
                // Set 'i' as the largest prime factor
                largestPF = i;
                DivideByPF(ref n, largestPF);
                // if we cannot divide by the largest PF anymore and n is reduce to 1 then we have the largest PF
                if (n == 1)
                {
                    // Print the largest prime factor
                    Console.WriteLine(largestPF);
                    return;
                }
            }

        }
        // Print the largest prime factor
        Console.WriteLine(largestPF);
    }


    static void Main(String[] args)
    {
        // Get the number of test cases
        int t = Convert.ToInt32(Console.ReadLine());
        // Loop through the test cases
        for (int a0 = 0; a0 < t; a0++)
        {
            // Get the value for N
            long n = Convert.ToInt64(Console.ReadLine());
            PrimeNumbers(n);
        }
    }
}