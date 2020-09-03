//-----------------------------------------------------------------------------
// Runtime: 152ms
// Memory Usage: 45.8 MB
// Link: https://leetcode.com/submissions/detail/360509218/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

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
    public class _1382_BalanceABinarySearchTree
    {
        public TreeNode BalanceBST(TreeNode root)
        {
            var list = new List<int>();
            InOrder(root, list);

            return BuildBalanceBST(list, 0, list.Count);
        }

        private TreeNode BuildBalanceBST(List<int> list, int left, int right)
        {
            if (left >= right) return null;
            var mid = left + (right - left) / 2;

            var root = new TreeNode(list[mid]);
            root.left = BuildBalanceBST(list, left, mid);
            root.right = BuildBalanceBST(list, mid + 1, right);
            return root;
        }

        private void InOrder(TreeNode node, IList<int> list)
        {
            if (node == null) return;

            InOrder(node.left, list);
            list.Add(node.val);
            InOrder(node.right, list);
        }
    }
}
