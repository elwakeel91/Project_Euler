// URL of the problem
// https://www.hackerrank.com/contests/projecteuler/challenges/euler004/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    /// <summary>
    /// Create a list of palindromes 
    /// </summary>
    /// <param name="n"></param>
    static void Palindromes(List<int> n)
    {
        // Loop through the first three-digit-numbers
        for (int i = 101; i < 1000; i++)
        {
            // Loop through the second three-digit-numbers where the product is at least six-digits
            for (int j = (100000 / i); j < 1000; j++)
            {
                // Check if the product is a palindrome and isn't already in our list
                if (isPalindrome(i * j) && !n.Contains(i * j))
                    // Add the palindrome to our list
                    n.Add(i * j);
            }
        }
    }


    /// <summary>
    /// Check if the number is a palindrome
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    static bool isPalindrome(int n)
    {
        // String variable to hold our original and new numbers
        string originalNumber = n.ToString();

        // Variable holding the position of our last digit
        int lastDigitPosition = originalNumber.Length - 1;

        // Loop through the digits of the number
        for (int i = 0; i < originalNumber.Length / 2; i++)
        {
            // Compare the digits on either end of the number
            if (originalNumber[i] != originalNumber[lastDigitPosition - i])
                // They aren't the same number so return false
                return false;
        }

        // All the comparisons in our loop passed the test so this number is a Palindrome
        return true;
    }

    static void Main(String[] args)
    {
        // Create an empty list of palindromes
        List<int> palindromeList = new List<int>();
        // Fill the list
        Palindromes(palindromeList);
        // Sort the list
        palindromeList.Sort();

        // Get the number of test cases from the user
        int t = Convert.ToInt32(Console.ReadLine());
        // Loop through the test cases
        for (int a0 = 0; a0 < t; a0++)
        {
            // Get the number to check against from the user
            int n = Convert.ToInt32(Console.ReadLine());
            // Loop through our palindromes list
            for (int i = 0; i < palindromeList.Count; i++)
            {
                // Check if the number from the user is smaller than the current number in the list
                if (n <= palindromeList[i])
                {
                    // Return the previous number in the list
                    Console.WriteLine(palindromeList[i - 1]);
                    break;
                }
            }
        }
    }
}