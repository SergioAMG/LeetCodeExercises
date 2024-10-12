using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.ArraysAndStrings
{
    /*
     * Write a function to find the longest common prefix string amongst an array of strings.
     * If there is no common prefix, return an empty string "".
     */
    public class LongestCommonPrefix
    {
        /// <summary>
        /// TimeComplexity = O(mxn)
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string CalculateLongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            int minLength = int.MaxValue;
            foreach (string s in strs)
            {
                if (s.Length < minLength)
                {
                    minLength = s.Length;
                }
            }

            int i = 0;
            while (i < minLength)
            {
                foreach (string s in strs)
                {
                    if (s[i] != strs[0][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }
                i++;
            }

            return strs[0].Substring(0, i);
        }
    }
}