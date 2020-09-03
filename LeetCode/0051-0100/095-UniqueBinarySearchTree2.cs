//-----------------------------------------------------------------------------
// Runtime: 208ms
// Memory Usage: 28.8 MB
// Link: https://leetcode.com/submissions/detail/357928874/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _095_UniqueBinarySearchTree2
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0) return new List<TreeNode>();

            return GenerateTrees(1, n);
        }

        public IList<TreeNode> GenerateTrees(int start, int end)
        {
            List<TreeNode> trees = new List<TreeNode>();

            if (start > end)
            {
                trees.Add(null);
                return trees;
            }

            for (int i = start; i <= end; i++)
            {
                var leftTrees = GenerateTrees(start, i - 1);
                var rightTrees = GenerateTrees(i + 1, end);

                foreach (var leftTree in leftTrees)
                    foreach (var rightTree in rightTrees)
                    {
                        var current = new TreeNode(i);
                        current.left = leftTree;
                        current.right = rightTree;
                        trees.Add(current);
                    }
            }

            return trees;
        }
    }
}
