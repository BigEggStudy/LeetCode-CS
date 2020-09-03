//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 21.6 MB
// Link: https://leetcode.com/submissions/detail/358362139/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0434_NumberOfSegmentsInAString
    {
        public int CountSegments(string s)
        {
            return s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
