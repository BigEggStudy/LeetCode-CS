//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 23.9 MB
// Link: https://leetcode.com/submissions/detail/351821481/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0836_RectangleOverlap
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            return rec1[2] > rec2[0] &&
                   rec1[3] > rec2[1] &&
                   rec1[0] < rec2[2] &&
                   rec1[1] < rec2[3];
        }
    }
}
