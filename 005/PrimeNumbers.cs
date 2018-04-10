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

                // Check if divisible by 5 or 7
                // Therefore every 6k +- 1, starting at 5
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
    } 
    // end of IsPrime class
}
