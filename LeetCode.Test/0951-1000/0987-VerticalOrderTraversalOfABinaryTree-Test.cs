using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0987_VerticalOrderTraversalOfABinaryTree_Test
    {
        [TestMethod]
        public void VerticalTraversal_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 9, 20, null, null, 15, 7 });

            var solution = new _0987_VerticalOrderTraversalOfABinaryTree();
            var result = solution.VerticalTraversal(root);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new int[] { 9 },
                new int[] { 3, 15 },
                new int[] { 20 },
                new int[] { 7 },
            }, result);
        }

        [TestMethod]
        public void VerticalTraversal_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5, 6, 7 });

            var solution = new _0987_VerticalOrderTraversalOfABinaryTree();
            var result = solution.VerticalTraversal(root);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new int[] { 4 },
                new int[] { 2 },
                new int[] { 1, 5, 6 },
                new int[] { 3 },
                new int[] { 7 },
            }, result);
        }

        [TestMethod]
        public void VerticalTraversal_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { 0, 2, 1, 3, null, null, null, 4, 5, null, 7, 6, null, 10, 8, 11, 9 });

            var solution = new _0987_VerticalOrderTraversalOfABinaryTree();
            var result = solution.VerticalTraversal(root);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new int[] { 4, 10, 11 },
                new int[] { 3, 6, 7 },
                new int[] { 2, 5, 8, 9 },
                new int[] { 0 },
                new int[] { 1 },
            }, result);
        }
    }
}
