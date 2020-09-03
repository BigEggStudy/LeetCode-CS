//-----------------------------------------------------------------------------
// Runtime: 36ms
// Memory Usage: 14.6 MB
// Link: https://leetcode.com/submissions/detail/357929135/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _096_UniqueBinarySearchTree
    {
        public int NumTrees(int n)
        {
            long result = 1;
            for (int i = 0; i < n; i++)
                result = result * 2 * (2 * i + 1) / (i + 2);

            return (int)result;
        }
    }
}
