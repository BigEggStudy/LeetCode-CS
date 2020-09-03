//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 31 MB
// Link: https://leetcode.com/submissions/detail/344219487/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _107_BinaryTreeLevelOrderTraversal2
    {
        private Queue<TreeNode> queue = new Queue<TreeNode>();

        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var results = new List<IList<int>>();
            if (root == null) return results;
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var result = new List<int>();

                var levelSize = queue.Count;
                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();
                    result.Add(node.val);
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                results.Add(result);
            }

            results.Reverse();
            return results;
        }
    }
}
