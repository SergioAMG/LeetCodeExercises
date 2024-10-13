using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.HashmapsAndSets
{
    /*
     *You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.
     *Letters are case sensitive, so "a" is considered a different type of stone from "A".
     */
    public class JewelsAndStones
    {
        /// <summary>
        /// Time Complexity = O(n2)
        /// </summary>
        /// <param name="jewels"></param>
        /// <param name="stones"></param>
        /// <returns></returns>
        public int NumJewelsInStones(string jewels, string stones)
        {
            int counter = 0;
            int maxCount = 0;

            for (int i = 0; i < jewels.Length; i++)
            {
                for (int j = 0; j < stones.Length; j++)
                {
                    if (stones[j] == jewels[i])
                    {
                        counter++;
                    }
                }
                maxCount = counter;
            }

            return maxCount;
        }

        /// <summary>
        /// Time Complexity = O(n+m)
        /// </summary>
        /// <param name="jewels"></param>
        /// <param name="stones"></param>
        /// <returns></returns>
        public int NumJewelsInStonesOptimized(string jewels, string stones)
        {
            int counter = 0;
            HashSet<char> jewelSet = new HashSet<char>(jewels);

            foreach (char stone in stones)
            {
                if (jewelSet.Contains(stone))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}