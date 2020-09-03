//-----------------------------------------------------------------------------
// Runtime: 252ms
// Memory Usage: 42.6 MB
// Link: https://leetcode.com/submissions/detail/368582934/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1343_NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold
    {
        public int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            if (arr.Length < k) return 0;

            int count = 0, sum = 0;
            long sum2 = threshold * k;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (i + 1 >= k)
                {
                    if (sum >= sum2)
                        count += 1;
                    sum -= arr[i + 1 - k];
                }
            }

            return count;
        }
    }
}
