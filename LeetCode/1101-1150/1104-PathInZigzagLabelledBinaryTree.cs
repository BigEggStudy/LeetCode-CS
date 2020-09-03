//-----------------------------------------------------------------------------
// Runtime: 200ms
// Memory Usage: 25.2 MB
// Link: https://leetcode.com/submissions/detail/361224882/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1104_PathInZigzagLabelledBinaryTree
    {
        public IList<int> PathInZigZagTree(int label)
        {
            int nodeCount = 1;
            while (label >= nodeCount * 2)
                nodeCount *= 2;

            var result = new List<int>();
            while (label > 0)
            {
                result.Add(label);
                var maxLevellable = nodeCount * 2 - 1;
                var minLevellable = nodeCount;
                var parent = (maxLevellable + minLevellable - label) / 2;

                label = parent;
                nodeCount /= 2;
            }
            result.Reverse();
            return result;
        }
    }
}
