using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.ArraysAndStrings
{
    /*
     * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

    Symbol       Value
    I             1
    V             5
    X             10
    L             50
    C             100
    D             500
    M             1000
    For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

    Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.
    Given a roman numeral, convert it to an integer.
     */
    public class RomanToInteger
    {
        private Dictionary<char, int> map = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        /// <summary>
        /// TimeComplexity = O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int RomanToInt(string s)
        {
            char[] chars = s.ToCharArray();
            int output = 0;
            int indexToMove = 0;

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    output += map[chars[i]];
                }
                else
                {
                    Tuple<int, int> result = TrySubstractionRules(chars[i - 1], chars[i]);
                    output += result.Item1;
                    indexToMove = result.Item2;
                }
                i = i - indexToMove;
            }

            return output;
        }

        /// <summary>
        /// TimeComplexity = O(1)
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private Tuple<int,int> TrySubstractionRules(char left, char right)
        {
            if (left == 'I' && right == 'V')
            {
                return Tuple.Create(4, 1);
            }
            else if (left == 'I' && right == 'X')
            {
                return Tuple.Create(9, 1);
            }

            else if (left == 'X' && right == 'L')
            {
                return Tuple.Create(40, 1);
            }
            else if (left == 'X' && right == 'C')
            {
                return Tuple.Create(90, 1);
            }

            else if (left == 'C' && right == 'D')
            {
                return Tuple.Create(400, 1);
            }
            else if (left == 'C' && right == 'M')
            {
                return Tuple.Create(900, 1);
            }
            else
            {
                return Tuple.Create(map[right], 0);
            }
        }
    }
}
