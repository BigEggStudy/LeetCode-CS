//-----------------------------------------------------------------------------
// Runtime: 388ms
// Memory Usage: 30.3 MB
// Link: https://leetcode.com/submissions/detail/368563284/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1508_RangeSumOfSortedSubarraySums
    {
        public int RangeSum(int[] nums, int n, int left, int right)
        {
            var size = n * (n + 1) / 2;
            var arr = new int[size];
            var index = 0;
            for (int i = 0; i < n; i++)
            {
                var temp = 0;
                for (int j = i; j < n; j++)
                {
                    temp += nums[j];
                    arr[index++] = temp;
                }
            }

            Array.Sort(arr);

            var mod = 1000000007;
            var result = 0;
            for (int i = left - 1; i < right; i++)
            {
                result += arr[i] % mod;
                result %= mod;
            }

            return result;
        }
    }
}
