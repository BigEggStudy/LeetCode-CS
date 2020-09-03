//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/333024631/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
     *         this.val = val;
     *         this.left = left;
     *         this.right = right;
     *     }
     * }
     */
    public class _0872_LeafSimilarTrees
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var leaves1 = new List<int>();
            var leaves2 = new List<int>();

            InOrder(root1, leaves1);
            InOrder(root2, leaves2);

            return leaves1.SequenceEqual(leaves2);
        }

        private void InOrder(TreeNode node, IList<int> leaves)
        {
            if (node == null) return;
            if (node.left == null && node.right == null)
            {
                leaves.Add(node.val);
                return;
            }

            InOrder(node.left, leaves);
            InOrder(node.right, leaves);
        }
    }
}
