//-----------------------------------------------------------------------------
// Runtime: 228ms
// Memory Usage: 29.8 MB
// Link: https://leetcode.com/submissions/detail/334976339/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0806_NumberOfLinesToWriteString
    {
        public int[] NumberOfLines(int[] widths, string S)
        {
            var lines = 1;
            var width = 0;
            foreach (var ch in S)
            {
                width += widths[ch - 'a'];

                if (width > 100)
                {
                    lines++;
                    width = widths[ch - 'a'];
                }
            }

            return new int[] { lines, width };
        }
    }
}
