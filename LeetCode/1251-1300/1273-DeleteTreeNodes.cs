//-----------------------------------------------------------------------------
// Runtime: 152ms
// Memory Usage: 33.2 MB
// Link: https://leetcode.com/submissions/detail/369294285/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1273_DeleteTreeNodes
    {
        public int DeleteTreeNodes(int nodes, int[] parent, int[] value)
        {
            var counts = new int[nodes];
            for (int i = nodes - 1; i > 0; i--)
            {
                value[parent[i]] += value[i];
                counts[parent[i]] += (value[i] == 0 ? 0 : counts[i] + 1);
            }

            return value[0] == 0 ? 0 : counts[0] + 1;
        }
    }
}
