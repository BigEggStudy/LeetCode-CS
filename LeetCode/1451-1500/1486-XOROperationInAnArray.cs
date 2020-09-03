//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.4 MB
// Link: https://leetcode.com/submissions/detail/358271770/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1486_XOROperationInAnArray
    {
        public int XorOperation(int n, int start)
        {
            var result = 0;
            for (int i = 0; i < n; i++)
                result ^= start + i * 2;

            return result;
        }
    }
}
