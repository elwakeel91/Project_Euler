using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static ulong SumOfMultiples(ulong k, ulong n)
    {
        // Go up to n-1
        n--;
        // Divide n by k
        n = (n / k);
        // Return the sum of the value from k to n
        return (ulong)(n * (k + (k * n)) / 2.0d);
    }

    static void Main(String[] args)
    {
        while (true)
        {
            // Get the value of N
            ulong n = Convert.ToUInt64(Console.ReadLine());
            // Print the sume of the multiples of 3 and 5 less than N
            ulong sum = SumOfMultiples((ulong)3, n) + SumOfMultiples((ulong)5, n) - SumOfMultiples((ulong)15, n);
            Console.WriteLine(sum);
        }
        
    }
}