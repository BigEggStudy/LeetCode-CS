//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 44.1 MB
// Link: https://leetcode.com/submissions/detail/352935063/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0643_MaximumAverageSubarrayI
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            var sum = 0;
            for (int i = 0; i < k; i++)
                sum += nums[i];

            double max = (double)sum / k;
            for (int i = k; i < nums.Length; i++)
            {
                sum = sum + nums[i] - nums[i - k];
                var average = (double)sum / k;
                if (average > max)
                    max = average;
            }

            return max;
        }
    }
}
