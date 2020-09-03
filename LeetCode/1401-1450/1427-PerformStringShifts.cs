//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 24.3 MB
// Link: https://leetcode.com/submissions/detail/325036732/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1427_PerformStringShifts
    {
        public string StringShift(string s, int[][] shift)
        {
            var leftShift = 0;
            foreach (var oneShift in shift)
                leftShift += oneShift[0] == 0 ? oneShift[1] : -oneShift[1];

            if (leftShift == 0) return s;

            leftShift %= s.Length;
            if (leftShift > 0)
                return s.Substring(leftShift) + s.Substring(0, leftShift);
            else
                return s.Substring(s.Length + leftShift) + s.Substring(0, s.Length + leftShift);
        }
    }
}
