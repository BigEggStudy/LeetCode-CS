//-----------------------------------------------------------------------------
// Runtime: 120ms
// Memory Usage: 32.6 MB
// Link: https://leetcode.com/submissions/detail/378613049/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0297_SerializeandDeserializeBinaryTree
    {
        private readonly char SPLITTER = ',';
        private readonly string NULL_VALUE = "null";

        // Encodes a tree to a single string.
        public string Serialize(TreeNode root)
        {
            var sb = new StringBuilder();
            Serialize(root, sb);
            return sb.ToString();
        }

        private void Serialize(TreeNode root, StringBuilder sb)
        {
            if (root == null) sb.Append(NULL_VALUE).Append(SPLITTER);
            else
            {
                sb.Append(root.val.ToString()).Append(SPLITTER);
                Serialize(root.left, sb);
                Serialize(root.right, sb);
            }
        }

        // Decodes your encoded data to tree.
        public TreeNode Deserialize(string data)
        {
            var splits = data.Split(SPLITTER);
            var list = new LinkedList<string>(splits);
            return Deserialize(list);
        }

        private TreeNode Deserialize(LinkedList<string> data)
        {
            if (data.First.Value == NULL_VALUE)
            {
                data.Remove(data.First);
                return null;
            }

            var root = new TreeNode(int.Parse(data.First.Value));
            data.Remove(data.First);
            root.left = Deserialize(data);
            root.right = Deserialize(data);
            return root;
        }
    }
}
