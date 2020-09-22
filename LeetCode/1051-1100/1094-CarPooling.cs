//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 25.6 MB
// Link: https://leetcode.com/submissions/detail/398909090/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1094_CarPooling
    {
        public bool CarPooling(int[][] trips, int capacity)
        {
            var timestamp = new int[1001];

            foreach (int[] trip in trips)
            {
                timestamp[trip[1]] += trip[0];
                timestamp[trip[2]] -= trip[0];
            }

            int ued_capacity = 0;
            foreach (int number in timestamp)
            {
                ued_capacity += number;
                if (ued_capacity > capacity)
                    return false;
            }
            return true;
        }
    }
}
