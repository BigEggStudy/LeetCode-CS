//-----------------------------------------------------------------------------
// Runtime: 60ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _029_DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0) { throw new DivideByZeroException(); }
            uint a = dividend > 0 ? (uint)dividend : (uint)-dividend;
            uint b = divisor > 0 ? (uint)divisor : (uint)-divisor;

            uint result = 0, c = 0;
            var index = 0;
            while (a >= b)
            {
                c = b;
                for (index = 0; a >= c && c != 0; index++, c *= 2)
                {
                    a -= c;
                    result += (uint)1 << index;
                }
            }

            return (dividend ^ divisor) >> 31 == -1
                ? (int)-result
                : result > int.MaxValue ? int.MaxValue : (int)result;
        }
    }
}
