//-----------------------------------------------------------------------------
// Runtime: 200ms
// Memory Usage: 25.4 MB
// Link: https://leetcode.com/submissions/detail/352941120/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1033_MovingStonesUntilConsecutive
    {
        public int[] NumMovesStones(int a, int b, int c)
        {
            var arr = new int[] { a, b, c };
            Array.Sort(arr);

            var leftGap = arr[1] - arr[0] - 1;
            var rightGap = arr[2] - arr[1] - 1;

            if (leftGap == 0 && rightGap == 0) return new int[] { 0, 0 };
            var min = 2;
            if (leftGap == 0 || rightGap == 0) min = 1;
            if (leftGap == 1 || rightGap == 1) min = 1;

            return new int[] { min, leftGap + rightGap };
        }
    }
}
