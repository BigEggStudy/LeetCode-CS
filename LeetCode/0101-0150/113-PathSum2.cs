//-----------------------------------------------------------------------------
// Runtime: 292ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _113_PathSum2
    {
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            var current = new List<int>();
            var results = new List<IList<int>>();
            PathSum(root, sum, current, results);
            return results;
        }

        public void PathSum(TreeNode root, int sum, IList<int> current, IList<IList<int>> results)
        {
            if (root == null) return;

            sum -= root.val;
            current.Add(root.val);
            if (root.left == null && root.right == null && sum == 0)
            {
                results.Add(new List<int>(current));
                current.RemoveAt(current.Count - 1);
                return;
            }

            PathSum(root.left, sum, current, results);
            PathSum(root.right, sum, current, results);
            current.RemoveAt(current.Count - 1);
        }
    }
}
