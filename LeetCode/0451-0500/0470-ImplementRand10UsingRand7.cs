//-----------------------------------------------------------------------------
// Runtime: 228ms
// Memory Usage: 29.3 MB
// Link: https://leetcode.com/submissions/detail/387689354/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    /**
     * The Rand7() API is already defined in the parent class SolBase.
     * public int Rand7();
     * @return a random integer in the range 1 to 7
     */
    public class _0470_ImplementRand10UsingRand7 : Rand7Base
    {
        public int Rand10()
        {
            int r = 40;

            while (r >= 40)
                r = (Rand7() - 1) * 7 + Rand7() - 1;

            return r % 10 + 1;
        }
    }

    public class Rand7Base
    {
        private readonly Random random = new Random();

        public int Rand7()
        {
            return random.Next(7) + 1;
        }
    }
}
