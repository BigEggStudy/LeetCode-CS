using System.Collections.Generic;

namespace LeetCode.Test
{
    public static class TestHelper
    {
        public static ListNode GenerateList(int[] nums)
        {
            if (nums == null || nums.Length == 0) { return null; }

            var i = 0;
            var first = new ListNode(nums[i]);
            var current = first;

            while (++i < nums.Length)
            {
                current.next = new ListNode(nums[i]);
                current = current.next;
            }

            return first;
        }

        public static TreeNode GenerateTree(int?[] nums)
        {
            if (nums == null || nums.Length == 0) { return null; }

            var i = 0;
            var first = new TreeNode(nums[i++].Value);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(first);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (i < nums.Length && nums[i].HasValue)
                {
                    var node = new TreeNode(nums[i].Value);
                    current.left = node;
                    queue.Enqueue(node);
                }
                if (i + 1 < nums.Length && nums[i + 1].HasValue)
                {
                    var node = new TreeNode(nums[i + 1].Value);
                    current.right = node;
                    queue.Enqueue(node);
                }
                i += 2;
            }

            return first;
        }

        public static TreeLinkNode GenerateLinkTree(int?[] nums)
        {
            if (nums == null || nums.Length == 0) { return null; }

            var i = 0;
            var first = new TreeLinkNode(nums[i++].Value);
            var queue = new Queue<TreeLinkNode>();
            queue.Enqueue(first);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (i < nums.Length && nums[i].HasValue)
                {
                    var node = new TreeLinkNode(nums[i].Value);
                    current.left = node;
                    queue.Enqueue(node);
                }
                if (i + 1 < nums.Length && nums[i + 1].HasValue)
                {
                    var node = new TreeLinkNode(nums[i + 1].Value);
                    current.right = node;
                    queue.Enqueue(node);
                }
                i += 2;
            }

            return first;
        }
    }
}
