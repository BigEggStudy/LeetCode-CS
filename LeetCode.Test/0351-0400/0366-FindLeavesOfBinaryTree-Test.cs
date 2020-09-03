using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0366_FindLeavesOfBinaryTree_Test
    {
        [TestMethod]
        public void FindLeaves_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5 });

            var solution = new _0366_FindLeavesOfBinaryTree();
            var result = solution.FindLeaves(root);
            AssertHelper.AssertList(new List<IList<int>>() {
                new int[] { 4, 5, 3 },
                new int[] { 2 },
                new int[] { 1 },
            }, result);
        }
    }
}
