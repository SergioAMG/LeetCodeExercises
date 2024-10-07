using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercises.ArraysAndStrings
{
    /*
     *You are given an array prices where prices[i] is the price of a given stock on the ith day
     *You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
     *Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0
     */
    public class BestTimeToBuyAndSellStock
    {
        /// <summary>
        /// TimeComplexity = O(nxm)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            int maxProfit = profit;
            int leftIndex = 0;
            int rightIndex = leftIndex + 1;

            while (prices.Length != leftIndex +1)
            {
                profit = (Math.Abs(prices[rightIndex]) - Math.Abs(prices[leftIndex])) > 0 ?
                    Math.Abs(prices[rightIndex]) - Math.Abs(prices[leftIndex]) : 0;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
                rightIndex++;
                if (rightIndex == prices.Length)
                {
                    leftIndex++;
                    rightIndex = leftIndex + 1;
                }

            }

            return maxProfit;
        }
    }
}
