//-----------------------------------------------------------------------------
// Runtime: 256ms
// Memory Usage: 34.7 MB
// Link: https://leetcode.com/submissions/detail/360495712/
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
    public class _0894_AllPossibleFullBinaryTrees
    {
        public IList<TreeNode> AllPossibleFBT(int N)
        {
            var cache = new Dictionary<int, IList<TreeNode>>();
            return AllPossibleFBT(N, cache);
        }

        private IList<TreeNode> AllPossibleFBT(int n, Dictionary<int, IList<TreeNode>> cache)
        {
            if (n % 2 == 0) return new List<TreeNode>();
            if (cache.ContainsKey(n)) return cache[n];
            if (n == 1)
            {
                cache[n] = new List<TreeNode>() { new TreeNode(0) };
                return cache[n];
            }

            var results = new List<TreeNode>();
            for (int left = 1; left < n; left += 2)
            {
                int right = n - 1 - left;
                foreach (var leftNode in AllPossibleFBT(left))
                    foreach (var rightNode in AllPossibleFBT(right))
                    {
                        var root = new TreeNode(0);
                        root.left = leftNode;
                        root.right = rightNode;
                        results.Add(root);
                    }
            }

            cache[n] = results;
            return cache[n];
        }
    }
}
