//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0818_RaceCar
    {
        private const int INT_BITS = sizeof(int) * 8; // compile time constant

        public int Racecar(int target)
        {
            var dp = new int[target + 1];
            for (int i = 1; i <= target; i++)
                dp[i] = int.MaxValue;
            dp[0] = 0;

            for (int i = 1; i <= target; i++)
            {
                var k = INT_BITS - GetLeadingZeros(i);
                if ((1 << k) - 1 == i)
                {
                    dp[i] = k;
                    continue;
                }

                for (int q = 0; q < k - 1; q++)
                    dp[i] = Math.Min(dp[i], k + q + 1 + dp[i - ((1 << (k - 1)) - (1 << q))]);

                if ((1 << k) - 1 - i < i)
                    dp[i] = Math.Min(dp[i], k + 1 + dp[(1 << k) - 1 - i]);
            }

            return dp[target];
        }

        // https://stackoverflow.com/questions/10439242/count-leading-zeroes-in-an-int32
        private int GetLeadingZeros(int x)
        {
            // do the smearing
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            // count the ones
            x -= x >> 1 & 0x55555555;
            x = (x >> 2 & 0x33333333) + (x & 0x33333333);
            x = (x >> 4) + x & 0x0f0f0f0f;
            x += x >> 8;
            x += x >> 16;
            return INT_BITS - (x & 0x0000003f); // subtract # of 1s from 32
        }
    }
}
