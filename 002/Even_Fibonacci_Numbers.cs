
/* By considering the terms in the Fibonacci sequence whose values do not exceed N, 
 * find the sum of the even-valued terms. 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        // Get the number of cases we will test
        int t = Convert.ToInt32(Console.ReadLine());

        // Loop through the test cases
        for (int a0 = 0; a0 < t; a0++)
        {
            // Get the value of N
            ulong n = Convert.ToUInt64(Console.ReadLine());
            // Variable holding our running sum
            ulong sum = 0;
            // Loop through the numbers up to N
            for (ulong x = 2, y = 1; x <= n;)
            {
                // Check if the current number is even
                if (x % 2 == 0)
                    // Add it to our running sum
                    sum += x;

                // Get the next number in the series
                x += y;
                y = x - y;
            }

            // Print out the sum
            Console.WriteLine(sum);
        }
    }
}