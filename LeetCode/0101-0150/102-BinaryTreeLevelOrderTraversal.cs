//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 30.6 MB
// Link: https://leetcode.com/submissions/detail/378987791/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _102_BinaryTreeLevelOrderTraversal
    {
        private Queue<TreeNode> queue = new Queue<TreeNode>();

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var results = new List<IList<int>>();
            if (root == null) return results;
            queue.Enqueue(root);

            while(queue.Count > 0)
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

            return results;
        }
    }
}
