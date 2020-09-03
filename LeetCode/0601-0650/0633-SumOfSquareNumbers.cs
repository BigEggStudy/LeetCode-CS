//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/359582880/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0633_SumOfSquareNumbers
    {
        public bool JudgeSquareSum(int c)
        {
            int i = (int)Math.Sqrt(c);
            if (i * i == c) return true;

            int j = 1;
            while (j <= i)
            {
                if (i * i + j * j == c) return true;
                else if (i * i + j * j < c) j++;
                else i--;
            }

            return false;
        }
    }
}
