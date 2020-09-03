//-----------------------------------------------------------------------------
// Runtime: 332ms
// Memory Usage: 48.3 MB
// Link: https://leetcode.com/submissions/detail/360402386/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int x) { val = x; }
     * }
     */

    public class _1379_FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if (original == null || original == target)
                return cloned;

            var result = GetTargetCopy(original.left, cloned.left, target);
            if (result != null) return result;

            return GetTargetCopy(original.right, cloned.right, target);
        }
    }
}
