using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.ArraysAndStrings
{
    /*
     * You are given a sorted unique integer array nums.
     * A range [a,b] is the set of all integers from a to b (inclusive).
     * Return the smallest sorted list of ranges that cover all the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.
     * Each range [a,b] in the list should be output as:
     * "a->b" if a != b
     * "a" if a == b
     */
    public class SummaryRanges
    {
        /// <summary>
        /// TimeComplexity = O(n)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public IList<string> CalculateSummaryRanges(int[] nums)
        {
            List<string> output = new();

            if (nums.Length == 0)
            {
                return output;
            }

            int minRange = nums[0];
            int maxRange = 0;

            if (nums.Length == 1)
            {
                output.Add(nums[0].ToString());
                return output;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                {
                    if (minRange == nums[i])
                    {
                        output.Add(nums[i].ToString());
                    }
                    else
                    {
                        output.Add(minRange.ToString() + "->" + nums[i].ToString());
                    }
                    return output;
                }
                if (nums[i] != nums[i + 1] - 1)
                {
                    maxRange = nums[i];
                    if (minRange == maxRange)
                    {
                        output.Add(nums[i].ToString());
                    }
                    else
                    {
                        output.Add(minRange.ToString() + "->" + maxRange.ToString());
                    }
                    minRange = nums[i + 1];
                }
            }
            return output;
        }
    }
}
