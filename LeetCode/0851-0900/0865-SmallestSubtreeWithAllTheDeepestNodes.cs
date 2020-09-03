//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 24.4 MB	
// Link: https://leetcode.com/submissions/detail/371102091/
//-----------------------------------------------------------------------------

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
    public class _0865_SmallestSubtreeWithAllTheDeepestNodes
    {
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            return GetDeepest(root, 0).node;
        }

        private (TreeNode node, int deep) GetDeepest(TreeNode node, int deep)
        {
            if (node == null) return (node, 0);

            (var leftNode, var leftDeep) = GetDeepest(node.left, deep + 1);
            (var rightNode, var rightDeep) = GetDeepest(node.right, deep + 1);

            if (leftDeep > rightDeep) return (leftNode, leftDeep + 1);
            else if (leftDeep < rightDeep) return (rightNode, rightDeep + 1);
            else
                return (node, leftDeep + 1);
        }
    }
}
