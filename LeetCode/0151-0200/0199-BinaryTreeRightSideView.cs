//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 30.2 MB
// Link: https://leetcode.com/submissions/detail/378614277/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0199_BinaryTreeRightSideView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var results = new List<int>();
            if (root == null) return results;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var length = queue.Count;
                TreeNode node = null;
                for (int i = length; i > 0; i--)
                {
                    node = queue.Dequeue();
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                results.Add(node.val);
            }

            return results;
        }
    }
}
