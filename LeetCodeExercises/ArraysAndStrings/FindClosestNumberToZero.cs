using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.ArraysAndStrings
{
    /*
    * Given an integer array nums of size n, return the number with the value closest to 0 in nums. If there are multiple answers, return the number with the largest value.
    */
    public class FindClosestNumberToZero
    {
        /// <summary>
        /// TimeComplexity = O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindClosestNumber(int[] nums)
        {
            int result = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i]) < Math.Abs(result))
                {
                    result = nums[i];
                }
                else if (Math.Abs(nums[i]) == Math.Abs(result))
                {
                    if (nums[i] > result)
                        result = nums[i];
                }
            }
            return result;
        }
    }
}
