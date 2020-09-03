using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0314_BinaryTreeVerticalOrderTraversal_Test
    {
        [TestMethod]
        public void VerticalOrder_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 9, 20, null, null, 15, 7 });

            var solution = new _0314_BinaryTreeVerticalOrderTraversal();
            var result = solution.VerticalOrder(root);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new int[] { 9 },
                new int[] { 3, 15 },
                new int[] { 20 },
                new int[] { 7 },
            }, result);
        }

        [TestMethod]
        public void VerticalOrder_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 9, 8, 4, 0, 1, 7 });

            var solution = new _0314_BinaryTreeVerticalOrderTraversal();
            var result = solution.VerticalOrder(root);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new int[] { 4 },
                new int[] { 9 },
                new int[] { 3, 0, 1 },
                new int[] { 8 },
                new int[] { 7 },
            }, result);
        }

        [TestMethod]
        public void VerticalOrder_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 9, 8, 4, 0, 1, 7, null, null, null, 2, 5 });

            var solution = new _0314_BinaryTreeVerticalOrderTraversal();
            var result = solution.VerticalOrder(root);
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new int[] { 4 },
                new int[] { 9, 5 },
                new int[] { 3, 0, 1 },
                new int[] { 8, 2 },
                new int[] { 7 },
            }, result);
        }
    }
}
