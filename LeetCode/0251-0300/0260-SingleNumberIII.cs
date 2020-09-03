//-----------------------------------------------------------------------------
// Runtime: 228ms
// Memory Usage: 31.4 MB
// Link: https://leetcode.com/submissions/detail/357932607/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0260_SingleNumberIII
    {
        public int[] SingleNumber(int[] nums)
        {
            int bitmask = 0;
            foreach (int num in nums)
                bitmask ^= num;

            int diff = bitmask & (-bitmask);
            int x = 0;

            foreach (int num in nums)
                if ((num & diff) != 0)
                    x ^= num;

            return new int[] { x, bitmask ^ x };
        }
    }
}
