//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 32.3 MB
// Link: https://leetcode.com/submissions/detail/378986347/
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
    public class _0545_BoundaryOfBinaryTree
    {
        private enum Flag { ROOT, LEFT, RIGHT, MIDDLE }

        public IList<int> BoundaryOfBinaryTree(TreeNode root)
        {
            if (root == null) return new List<int>();

            var leftBoundary = new List<int>();
            var leaves = new List<int>();
            var rightBoundary = new List<int>();

            PreOrder(root, leftBoundary, leaves, rightBoundary, Flag.ROOT);

            leftBoundary.AddRange(leaves);
            rightBoundary.Reverse();
            leftBoundary.AddRange(rightBoundary);

            return leftBoundary;
        }

        private void PreOrder(TreeNode root, List<int> leftBoundary, List<int> leaves, List<int> rightBoundary, Flag flag)
        {
            if (root == null) return;

            if (flag == Flag.ROOT || flag == Flag.LEFT)
                leftBoundary.Add(root.val);
            else if (flag == Flag.RIGHT)
                rightBoundary.Add(root.val);
            else if (root.left == null && root.right == null)
                leaves.Add(root.val);

            if (root.left != null)
                PreOrder(root.left, leftBoundary, leaves, rightBoundary, UpdateFlag(root, flag, true));
            if (root.right != null)
                PreOrder(root.right, leftBoundary, leaves, rightBoundary, UpdateFlag(root, flag, false));
        }

        private Flag UpdateFlag(TreeNode root, Flag flag, bool isLeft)
        {
            if (flag == Flag.ROOT)
                return isLeft ? Flag.LEFT : Flag.RIGHT;

            if (flag == Flag.LEFT && !isLeft && root.left != null)
                return Flag.MIDDLE;

            if (flag == Flag.RIGHT && isLeft && root.right != null)
                return Flag.MIDDLE;

            return flag;
        }
    }
}
