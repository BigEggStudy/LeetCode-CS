//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 22.7 MB
// Link: https://leetcode.com/submissions/detail/363520520/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1256_EncodeNumber
    {
        public string Encode(int num)
        {
            return Convert.ToString(num + 1, 2).Substring(1);
        }
    }
}
