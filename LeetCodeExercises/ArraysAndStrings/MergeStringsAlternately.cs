using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.ArraysAndStrings
{
    /*
    * You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string
    * Return the merged string.
    */
    public class MergeStringsAlternately
    {
        /// <summary>
        /// TimeComplexity = O(n)
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public string MergeAlternately(string word1, string word2)
        {
            char[] left = word1.ToArray<char>();
            char[] right = word2.ToArray<char>();
            int indexLeft = 0;
            int indexRight = 0;
            char[] joined = new char[left.Length + right.Length];
            int counter = joined.Length;
            int cursor = 0;

            while (counter > 0)
            {
                if (indexLeft < left.Length)
                {
                    joined[cursor] = left[indexLeft];
                    counter = counter - 1;
                    cursor = cursor + 1;
                    indexLeft++;
                }
                if (indexRight < right.Length)
                {
                    joined[cursor] = right[indexRight];
                    counter = counter - 1;
                    cursor = cursor + 1;
                    indexRight++;
                }
            }
            string result = new string(joined);
            return result;
        }
    }
}
