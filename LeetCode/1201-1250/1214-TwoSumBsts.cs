//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 32.3 MB
// Link: https://leetcode.com/submissions/detail/363011471/
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
    public class _1214_TwoSumBsts
    {
        public bool TwoSumBSTs(TreeNode root1, TreeNode root2, int target)
        {
            var stack = new Stack<TreeNode>();
            var values = new HashSet<int>();
            while (stack.Count > 0 || root1 != null)
            {
                while (root1 != null)
                {
                    stack.Push(root1);
                    root1 = root1.left;
                }

                root1 = stack.Pop();
                values.Add(root1.val);
                root1 = root1.right;
            }

            while (stack.Count > 0 || root2 != null)
            {
                while (root2 != null)
                {
                    stack.Push(root2);
                    root2 = root2.left;
                }

                root2 = stack.Pop();
                if (values.Contains(target - root2.val)) return true;
                root2 = root2.right;
            }

            return false;
        }
    }
}
