using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_CSharp
{
    abstract class PrimeNumbers
    {
        /// <summary>
        /// Returns true if the number is prime
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        protected static bool IsPrime(int n)
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

                // Check every 6k +- 1, starting at 5
                int k = 5;

                // Loop while k is less or equal to r
                while (k <= r)
                {
                    if (n % k == 0) return false;
                    if (n % (k + 2) == 0) return false;
                    k += 6;
                }   
                // end of while loop

            }   
            // end of else statement

            return true;

        }
        // end of isPrime method

        /// <summary>
        /// Find the nth Prime number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        protected static int NthPrime(int n)
        {
            // Variable holding the prime number
            int primeNumber = 0;
            // Counter for the prime number we reached
            int primeCounter = 0;

            // Loop through the numbers from 2 to infinity until we reach the nth prime
            for (int i = 2; primeCounter < n ; i++)
            {
                // Check if the current number is a prime number
                if (IsPrime(i))
                {
                    // Store the prime number
                    primeNumber = i;
                    // Increase the prime number counter
                    primeCounter++;
                }
            }
            // return the prime number we found
            return primeNumber;
        }
        // end of NthPrime function
    }
    // end of IsPrime class
}
