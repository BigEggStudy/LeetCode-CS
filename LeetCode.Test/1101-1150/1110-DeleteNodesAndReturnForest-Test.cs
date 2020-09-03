using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _1110_DeleteNodesAndReturnForest_Test
    {
        [TestMethod]
        public void DelNodes_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5, 6, 7 });

            var solution = new _1110_DeleteNodesAndReturnForest();
            var result = solution.DelNodes(root, new int[] { 3, 5 });
            AssertHelper.AssertTrees(new List<int?[]>() {
                new int?[] { 6 },
                new int?[] { 7 },
                new int?[] { 1, 2, null, 4 },
            }, result);
        }

        [TestMethod]
        public void DelNodes_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5, 6, 7 });

            var solution = new _1110_DeleteNodesAndReturnForest();
            var result = solution.DelNodes(root, new int[] { 1, 2 });
            AssertHelper.AssertTrees(new List<int?[]>() {
                new int?[] { 4 },
                new int?[] { 5 },
                new int?[] { 3, 6, 7 },
            }, result);
        }
    }
}
