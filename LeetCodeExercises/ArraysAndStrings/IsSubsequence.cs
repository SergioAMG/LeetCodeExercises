using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.ArraysAndStrings
{
    /*
     * Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

    A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
     */
    public class IsSubsequence
    {
        /// <summary>
        /// TimeComplexity = O(Max(S,T))
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsSubsequenceOf(string s, string t)
        {
            char[] sAsChar = s.ToCharArray();
            char[] tAsChar = t.ToCharArray();
            int sIndex = 0;
            int tIndex = 0;
            bool isSubsequenceOf = false;

            if (tAsChar.Length == 0 && sAsChar.Length == 0)
            {
                isSubsequenceOf = true;
                return isSubsequenceOf;
            }
            if (sAsChar.Length == 0 && tAsChar.Length > 0)
            {
                isSubsequenceOf = true;
                return isSubsequenceOf;
            }
            if (tAsChar.Length == 0 && sAsChar.Length > 0)
            {
                isSubsequenceOf = false;
                return isSubsequenceOf;
            }
            if ((sAsChar.Length == 1 && tAsChar.Length == 1) && sAsChar[sIndex] != tAsChar[tIndex])
            {
                isSubsequenceOf = false;
                return isSubsequenceOf;
            }
            if ((sAsChar.Length == 1 && tAsChar.Length == 1) && sAsChar[sIndex] == tAsChar[tIndex])
            {
                isSubsequenceOf = true;
                return isSubsequenceOf;
            }

            while (sIndex < sAsChar.Length)
            {
                if (tIndex == tAsChar.Length)
                {
                    isSubsequenceOf = false;
                    return isSubsequenceOf;
                }

                if (sAsChar[sIndex] != tAsChar[tIndex])
                {
                    tIndex++;
                    isSubsequenceOf = false;
                }
                else
                {
                    sIndex++;
                    tIndex++;
                    isSubsequenceOf = true;
                }
            }

            return isSubsequenceOf;
        }

        /// <summary>
        /// TimeComplexity = O(Max(S,T))
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsSubsequenceOfString(string s, string t)
        {
            int sIndex = 0;
            int tIndex = 0;

            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s.ElementAt(sIndex) == t.ElementAt(tIndex))
                    sIndex++;

                tIndex++;
            }

            return sIndex == s.Length;
        }
    }
}
