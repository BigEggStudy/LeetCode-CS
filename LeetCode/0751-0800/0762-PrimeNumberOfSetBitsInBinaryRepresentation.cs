//-----------------------------------------------------------------------------
// Runtime: 48ms
// Memory Usage: 14.5 MB
// Link: https://leetcode.com/submissions/detail/335599017/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0762_PrimeNumberOfSetBitsInBinaryRepresentation
    {
        public int CountPrimeSetBits(int L, int R)
        {
            var count = 0;
            for (int i = L; i <= R; i++)
            {
                var bits = CountBits(i);
                if (bits == 2 || bits == 3 || bits == 5 || bits == 7 ||
                    bits == 11 || bits == 13 || bits == 17 || bits == 19)
                    count++;
            }

            return count;
        }

        private int CountBits(int num)
        {
            var count = 0;
            while (num > 0)
            {
                num &= num - 1;
                count++;
            }

            return count;
        }
    }
}
