//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0327_CountOfRangeSum
    {
        public int CountRangeSum(int[] nums, int lower, int upper)
        {
            var sums = new long[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
                sums[i + 1] = sums[i] + nums[i];

            return CountWhileMergeSort(sums, 0, nums.Length + 1, lower, upper);
        }

        private int CountWhileMergeSort(long[] sums, int start, int end, int lower, int upper)
        {
            if (end - start <= 1) return 0;
            int mid = start + (end - start) / 2;
            int count = CountWhileMergeSort(sums, start, mid, lower, upper)
                      + CountWhileMergeSort(sums, mid, end, lower, upper);

            int j = mid, k = mid, t = mid;
            long[] cache = new long[end - start];
            for (int i = start, r = 0; i < mid; ++i, ++r)
            {
                while (k < end && sums[k] - sums[i] < lower) k++;
                while (j < end && sums[j] - sums[i] <= upper) j++;
                count += j - k;

                while (t < end && sums[t] < sums[i]) cache[r++] = sums[t++];
                cache[r] = sums[i];
            }
            for (int i = start; i < t; i++)
                sums[i] = cache[i - start];

            return count;
        }
    }
}
