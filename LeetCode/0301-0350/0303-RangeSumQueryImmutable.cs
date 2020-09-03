//-----------------------------------------------------------------------------
// Runtime: 140ms
// Memory Usage: 35.3 MB
// Link: https://leetcode.com/submissions/detail/352778066/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0303_RangeSumQueryImmutable
    {
        private readonly int[] sums;

        public _0303_RangeSumQueryImmutable(int[] nums)
        {
            sums = new int[nums.Length];

            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                sums[i] = sum;
            }
        }

        public int SumRange(int i, int j)
        {
            if (i == 0)
                return sums[j];
            else
                return sums[j] - sums[i - 1];
        }
    }

    /**
     * Your NumArray object will be instantiated and called as such:
     * NumArray obj = new NumArray(nums);
     * int param_1 = obj.SumRange(i,j);
     */
}
