//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 30.3 MB	
// Link: https://leetcode.com/submissions/detail/370019042/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _103_BinaryTreeZigzagLevelOrderTraversal
    {
        private Queue<TreeNode> queue = new Queue<TreeNode>();

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var results = new List<IList<int>>();
            if (root == null) return results;

            queue.Enqueue(root);
            var leftToRight = true;

            while (queue.Count > 0)
            {
                var levelSize = queue.Count;
                var result = new int[levelSize];

                for (int i = 0; i < levelSize; i++)
                {
                    var node = queue.Dequeue();
                    result[leftToRight ? i : (levelSize - i - 1)] = node.val;

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                results.Add(result);
                leftToRight = !leftToRight;
            }

            return results;
        }
    }
}
