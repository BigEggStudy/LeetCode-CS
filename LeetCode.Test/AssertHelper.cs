using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    public static class AssertHelper
    {
        public static void AssertLinkList(int[] expected, ListNode actual)
        {
            Assert.IsNotNull(actual);
            Assert.IsNotNull(expected);
            Assert.IsTrue(expected.Length > 0);

            var current = actual;
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.IsNotNull(current);
                Assert.AreEqual(expected[i], current.val);
                current = current.next;
            }

            Assert.IsNull(current);
        }

        public static void AssertArray<T>(T[] expected, T[] actual, bool ignoreLength = false)
        {
            if (!ignoreLength)
            {
                Assert.AreEqual(expected.Length, actual.Length, message: "length is not match");
            }

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], message: $"i {i} is not match");
            }
        }

        public static void AssertArray<T>(T[,] expected, T[,] actual)
        {
            var rowCount = expected.GetLength(0);
            var colCount = expected.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j], message: $"i {i}, j {j} is not match");
                }
            }
        }

        public static void AssertArray<T>(T[][] expected, T[][] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length, message: "length is not match");

            var rowCount = expected.Length;
            var colCount = expected[0].Length;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j], message: $"i {i}, j {j} is not match");
                }
            }
        }

        public static void AssertList<T>(T[] expected, IList<T> actual)
        {
            Assert.AreEqual(expected.Length, actual.Count, message: "length is not match");

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], message: $"i {i} is not match");
            }
        }

        public static void AssertList<T>(IList<IList<T>> expected, IList<IList<T>> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count, message: "length is not match");

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Count, actual[i].Count, message: $"row {i} length is not match");
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j], message: $"i {i}, j {j} is not match");
                }
            }
        }

        public static void AssertMatrix(int[,] expected, int[,] actual)
        {
            Assert.AreEqual(expected.Length, actual.Length, message: "length is not match");
            Assert.AreEqual(expected.GetLength(0), actual.GetLength(0), message: "first axis length is not match");
            Assert.AreEqual(expected.GetLength(1), actual.GetLength(1), message: "second axis length is not match");

            for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }

        public static void AssertTree(int?[] expected, TreeNode actual)
        {
            if (expected == null || expected.Length == 0) Assert.IsNull(actual);
            var expectedTreeRoot = TestHelper.GenerateTree(expected);

            AssertTree(expectedTreeRoot, actual);
        }

        public static void AssertTree(TreeNode expected, TreeNode actual)
        {
            if (expected == null) Assert.IsNull(actual);

            var stack1 = new Stack<TreeNode>();
            stack1.Push(expected);
            var stack2 = new Stack<TreeNode>();
            stack2.Push(actual);

            while (stack1.Count > 0 && stack2.Count > 0)
            {
                var cur1 = stack1.Pop();
                var cur2 = stack2.Pop();
                Assert.AreEqual(cur1.val, cur2.val);
                if (cur1.left == null)
                {
                    Assert.IsNull(cur2.left);
                }
                else
                {
                    stack1.Push(cur1.left);
                    stack2.Push(cur2.left);
                }
                if (cur1.right == null)
                {
                    Assert.IsNull(cur2.right);
                }
                else
                {
                    stack1.Push(cur1.right);
                    stack2.Push(cur2.right);
                }
            }

            Assert.AreEqual(0, stack1.Count);
            Assert.AreEqual(0, stack2.Count);
        }

        public static void AssertTrees(IList<int?[]> expected, IList<TreeNode> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count, "count not match");
            for (int i = 0; i < expected.Count; i++)
            {
                AssertTree(expected[i], actual[i]);
            }
        }
    }
}
