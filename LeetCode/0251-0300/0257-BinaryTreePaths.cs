//-----------------------------------------------------------------------------
// Runtime: 248ms
// Memory Usage: 31.8 MB
// Link: https://leetcode.com/submissions/detail/344758530/
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
    public class _0257_BinaryTreePaths
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            if (root == null) return new List<string>();

            var result = new List<IList<int>>();
            GetPath(root, new List<int>(), result);

            return result.Select(i => string.Join("->", i)).ToList();
        }

        public void GetPath(TreeNode node, IList<int> current, IList<IList<int>> result)
        {
            var next = new List<int>(current);
            if (node == null) return;

            next.Add(node.val);
            if (node.left == null && node.right == null)
                result.Add(next);
            else
            {
                GetPath(node.left, next, result);
                GetPath(node.right, next, result);
            }
        }
    }
}
