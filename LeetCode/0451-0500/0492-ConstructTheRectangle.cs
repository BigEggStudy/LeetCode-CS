//-----------------------------------------------------------------------------
// Runtime: 200ms
// Memory Usage: 25.3 MB
// Link: https://leetcode.com/submissions/detail/345098085/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0492_ConstructTheRectangle
    {
        public int[] ConstructRectangle(int area)
        {
            var w = (int)Math.Sqrt(area);
            while (area % w != 0) w--;
            return new int[] { area / w, w };
        }
    }
}
