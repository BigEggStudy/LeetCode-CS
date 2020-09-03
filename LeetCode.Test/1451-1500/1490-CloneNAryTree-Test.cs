using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _1490_CloneNAryTree_Test
    {
        [TestMethod]
        public void CloneTree_1()
        {
            var root = GenerateTree(new int?[] { 1, null, 3, 2, 4, null, 5, 6 });

            var solution = new _1490_CloneNAryTree();
            var result = solution.CloneTree(root);

            AssertTree(new int?[] { 1, null, 3, 2, 4, null, 5, 6 }, result);
        }

        [TestMethod]
        public void CloneTree_2()
        {
            var root = GenerateTree(new int?[] { 1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null, null, 14 });

            var solution = new _1490_CloneNAryTree();
            var result = solution.CloneTree(root);

            AssertTree(new int?[] { 1, null, 2, 3, 4, 5, null, null, 6, 7, null, 8, null, 9, 10, null, null, 11, null, 12, null, 13, null, null, 14 }, result);
        }


        private static _1490_CloneNAryTree.Node GenerateTree(int?[] nums)
        {
            if (nums == null || nums.Length == 0) { return null; }

            var i = 0;
            var first = new _1490_CloneNAryTree.Node(nums[i++].Value);
            var queue = new Queue<_1490_CloneNAryTree.Node>();
            queue.Enqueue(first);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                while (i < nums.Length && nums[i].HasValue)
                {
                    var node = new _1490_CloneNAryTree.Node(nums[i].Value);
                    current.children.Add(node);
                    queue.Enqueue(node);
                    i++;
                }
            }

            return first;
        }

        private static void AssertTree(int?[] expected, _1490_CloneNAryTree.Node actual)
        {
            if (expected == null || expected.Length == 0) Assert.IsNull(actual);
            var expectedTreeRoot = GenerateTree(expected);

            AssertTree(expectedTreeRoot, actual);
        }

        private static void AssertTree(_1490_CloneNAryTree.Node expected, _1490_CloneNAryTree.Node actual)
        {
            if (expected == null) Assert.IsNull(actual);

            var stack1 = new Stack<_1490_CloneNAryTree.Node>();
            stack1.Push(expected);
            var stack2 = new Stack<_1490_CloneNAryTree.Node>();
            stack2.Push(actual);

            while (stack1.Count > 0 && stack2.Count > 0)
            {
                var cur1 = stack1.Pop();
                var cur2 = stack2.Pop();
                Assert.AreEqual(cur1.val, cur2.val);
                Assert.AreEqual(cur1.children.Count, cur2.children.Count);

                foreach (var child in cur1.children)
                    stack1.Push(child);
                foreach (var child in cur2.children)
                    stack2.Push(child);
            }

            Assert.AreEqual(0, stack1.Count);
            Assert.AreEqual(0, stack2.Count);
        }
    }
}
