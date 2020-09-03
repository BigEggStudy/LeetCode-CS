//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 32.9 MB
// Link: https://leetcode.com/submissions/detail/357621851/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0222_CountCompleteTreeNodes
    {
        public int CountNodes(TreeNode root)
        {
            if (root == null) { return 0; }

            // Find Depth
            var current = root;
            var depth = 0;
            while (current.left != null)
            {
                current = current.left;
                depth++;
            }

            if (depth == 0) return 1;

            var count = (int)Math.Pow(2, depth) - 1;

            var l = 0;
            var r = count;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                if (FindNode(root, mid, count, depth))
                    l = mid + 1;
                else
                    r = mid - 1;
            }

            return count + l;
        }

        public bool FindNode(TreeNode root, int index, int count, int depth)
        {
            var l = 0;
            var r = count;
            for (int i = 0; i < depth; i++)
            {
                var mid = l + (r - l) / 2;
                if (index <= mid)
                {
                    root = root.left;
                    r = mid;
                }
                else
                {
                    root = root.right;
                    l = mid + 1;
                }
            }
            return root != null;
        }
    }
}
