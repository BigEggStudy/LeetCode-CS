//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 24.8 MB
// Link: https://leetcode.com/submissions/detail/380542728/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0128_LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            var hashSet = new HashSet<int>(nums);

            var longestStreak = 0;
            for (int i = 0; i < nums.Length; i++)
                if (!hashSet.Contains(nums[i] - 1))
                {
                    int currentNum = nums[i], currentStreak = 1;
                    while (hashSet.Contains(currentNum + 1))
                    {
                        currentNum += 1;
                        currentStreak++;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            return longestStreak;
        }
    }
}
