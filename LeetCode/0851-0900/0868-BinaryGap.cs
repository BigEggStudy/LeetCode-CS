//-----------------------------------------------------------------------------
// Runtime: 32ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/336964634/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0868_BinaryGap
    {
        public int BinaryGap(int N)
        {
            var last = -1;
            var result = 0;
            for (int i = 0; i < 32; i++)
            {
                if (((N >> i) & 1) == 1)
                {
                    if (last >= 0)
                        result = Math.Max(result, i - last);
                    last = i;
                }
            }

            return result;
        }
    }
}
