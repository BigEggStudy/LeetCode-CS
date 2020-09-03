//-----------------------------------------------------------------------------
// Runtime: 80ms
// Memory Usage: 24.1 MB
// Link: https://leetcode.com/submissions/detail/357945290/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _1062_LongestRepeatingSubstring
    {
        private const int a = 26;
        private long modulus = (long)Math.Pow(2, 32);

        public int LongestRepeatingSubstring(string S)
        {
            var n = S.Length;
            var nums = new int[n];

            for (int i = 0; i < n; i++)
                nums[i] = S[i] - 'a';

            int left = 1, right = n;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (Search(nums, mid) != -1) left = mid + 1;
                else right = mid - 1;
            }

            return left - 1;
        }

        private int Search(int[] nums, int targetLength)
        {
            var n = nums.Length;

            long h = 0;
            for (int i = 0; i < targetLength; i++)
                h = (h * a + nums[i]) % modulus;

            var seen = new HashSet<long>();
            seen.Add(h);

            long aL = 1;
            for (int i = 1; i <= targetLength; i++)
                aL = (aL * a) % modulus;

            for (int start = 1; start < n - targetLength + 1; start++)
            {
                h = (h * a - nums[start - 1] * aL % modulus + modulus) % modulus;
                h = (h + nums[start + targetLength - 1]) % modulus;
                if (seen.Contains(h)) return start;
                seen.Add(h);
            }

            return -1;
        }
    }
}
