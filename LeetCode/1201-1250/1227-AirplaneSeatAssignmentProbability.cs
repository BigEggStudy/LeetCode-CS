//-----------------------------------------------------------------------------
// Runtime: 44ms
// Memory Usage: 14.9 MB
// Link: https://leetcode.com/submissions/detail/371134754/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1227_AirplaneSeatAssignmentProbability
    {
        public double NthPersonGetsNthSeat(int n)
        {
            return n == 1 ? 1.0 : 0.5;
        }
    }
}
