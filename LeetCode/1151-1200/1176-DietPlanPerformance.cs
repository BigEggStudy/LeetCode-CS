//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 32.6 MB
// Link: https://leetcode.com/submissions/detail/342799216/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1176_DietPlanPerformance
    {
        public int DietPlanPerformance(int[] calories, int k, int lower, int upper)
        {
            var point = 0;
            var sum = 0;

            for (int i = 0; i < calories.Length; i++)
            {
                sum += calories[i];
                if (i >= k) sum -= calories[i - k];

                if (i >= k - 1)
                {
                    if (sum > upper) point++;
                    else if (sum < lower) point--;
                }
            }

            return point;
        }
    }
}
