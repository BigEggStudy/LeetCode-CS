//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 26.8 MB
// Link: https://leetcode.com/submissions/detail/262171481/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0617_MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null) return t2;
            if (t2 == null) return t1;

            var newNode = new TreeNode(t1.val + t2.val);
            newNode.left = MergeTrees(t1.left, t2.left);
            newNode.right = MergeTrees(t1.right, t2.right);
            return newNode;
        }
    }
}
