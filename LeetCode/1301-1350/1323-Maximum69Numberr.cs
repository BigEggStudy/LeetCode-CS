//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.8 MB
// Link: https://leetcode.com/submissions/detail/327400322/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1323_Maximum69Numberr
    {
        public int Maximum69Number(int num)
        {
            int sixPointer = -1;
            int pointer = 0;

            int temp = num;
            while (temp > 0)
            {
                if (temp % 10 == 6)
                    sixPointer = pointer;

                temp /= 10;
                pointer++;
            }

            if (sixPointer == -1) return num;

            return num + 3 * (int)Math.Pow(10, sixPointer);
        }
    }
}
