//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 30.2 MB
// Link: https://leetcode.com/submissions/detail/406714064/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    public class _0449_SerializeAndDeserializeBST
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            var sb = PostOrder(root, new StringBuilder());
            if (sb.Length > 0)
                sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (string.IsNullOrEmpty(data)) return null;

            var nums = data.Split().Select(n => int.Parse(n)).ToList();
            return Helper(int.MinValue, int.MaxValue, nums);
        }

        private StringBuilder PostOrder(TreeNode root, StringBuilder sb)
        {
            if (root == null) return sb;
            PostOrder(root.left, sb);
            PostOrder(root.right, sb);
            sb.Append(root.val);
            sb.Append(" ");
            return sb;
        }

        private TreeNode Helper(int lower, int upper, IList<int> nums)
        {
            if (nums.Count == 0) return null;
            var value = nums.Last();
            if (value < lower || value > upper) return null;

            nums.RemoveAt(nums.Count - 1);
            var root = new TreeNode(value);
            root.right = Helper(value, upper, nums);
            root.left = Helper(lower, value, nums);
            return root;
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec ser = new Codec();
    // Codec deser = new Codec();
    // String tree = ser.serialize(root);
    // TreeNode ans = deser.deserialize(tree);
    // return ans;
}
