// See https://aka.ms/new-console-template for more information
using LeetCodeExercises.ArraysAndStrings;
using LeetCodeExercises.HashmapsAndSets;

// Arrays And Strings

#region FindClosestNumberToZero
/*
Console.WriteLine("Program Started");
Console.WriteLine();
FindClosestNumberToZero findClosestNumberToZero = new();
Console.WriteLine(findClosestNumberToZero.FindClosestNumber([-4, -2, 1, -4, 8]) + "= [-4, -2, 1, 4, 8] = 1");
Console.WriteLine();
Console.WriteLine("Program Ended");
*/
#endregion

#region MergeStringsAlternately
/*
Console.WriteLine("Program Started");
Console.WriteLine();
MergeStringsAlternately mergeStringsAlternately = new();
Console.WriteLine(mergeStringsAlternately.MergeAlternately("abc", "pqr"));
Console.WriteLine("apbqcr");
Console.WriteLine();
Console.WriteLine("Program Ended");
*/
#endregion

#region RomanToInteger
/*
Console.WriteLine("Program Started");
Console.WriteLine();
RomanToInteger romanToInteger = new();
Console.WriteLine("III");
Console.WriteLine(romanToInteger.RomanToInt("III"));
Console.WriteLine(3);
Console.WriteLine();
Console.WriteLine("Program Ended");
*/
#endregion

#region IsSubsequence
/*
Console.WriteLine("Program Started");
Console.WriteLine();
IsSubsequence isSubsequence = new();
Console.WriteLine(isSubsequence.IsSubsequenceOf("acb", "ahbgdc"));
Console.WriteLine(false);
Console.WriteLine(isSubsequence.IsSubsequenceOfString("acb", "ahbgdc"));
Console.WriteLine(false);
Console.WriteLine();
Console.WriteLine("Program Ended");
*/
#endregion

#region BestTimeToBuyAndSellStock
/*
Console.WriteLine("Program Started");
Console.WriteLine();
BestTimeToBuyAndSellStock bestTimeToBuyAndSellStock = new();
Console.WriteLine(bestTimeToBuyAndSellStock.MaxProfit([7, 1, 5, 3, 6, 4]));
Console.WriteLine(5);
Console.WriteLine();
Console.WriteLine("Program Ended");
*/
#endregion

#region LongestCommonPrefix
/*
Console.WriteLine("Program Started");
Console.WriteLine();
LongestCommonPrefix longestCommonPrefix = new();
Console.WriteLine(longestCommonPrefix.CalculateLongestCommonPrefix(["flower", "flow", "flight"]));
Console.WriteLine("fl");
Console.WriteLine();
Console.WriteLine("Program Ended");
*/
#endregion

#region SummaryRanges
/*
Console.WriteLine("Program Started");
Console.WriteLine();
SummaryRanges summaryRanges = new();
PrintListContent(summaryRanges.CalculateSummaryRanges([0, 1, 2, 4, 5, 7]));
Console.WriteLine();
PrintListContent(new List<string> { "0->2", "4->5", "7" });
Console.WriteLine();
Console.WriteLine("Program Ended");
*/
#endregion

// Hashmaps And Sets

#region JewelsAndStones
/*
Console.WriteLine("Program Started");
Console.WriteLine();
JewelsAndStones jewelsAndStones = new JewelsAndStones();
Console.WriteLine(jewelsAndStones.NumJewelsInStonesOptimized("aA", "aAAbbbb"));
Console.WriteLine(3);
Console.WriteLine();
Console.WriteLine("Program Ended");
*/
#endregion

#region Helpers
void PrintListContent(IList<string> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        if (i != list.Count - 1)
        {
            Console.Write(list[i] + ", ");
        }
        else
        {
            Console.Write(list[i]);
        }
    }
}
#endregion