using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _103_BinaryTreeZigzagLevelOrderTraversal_Test
    {
        [TestMethod]
        public void ZigzagLevelOrder()
        {
            var solution = new _103_BinaryTreeZigzagLevelOrderTraversal();
            var result = solution.ZigzagLevelOrder(TestHelper.GenerateTree(new int?[] { 3, 9, 20, null, null, 15, 7 }));
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 3 },
                new List<int>() { 20, 9 },
                new List<int>() { 15, 7 }
            }, result);
        }

        [TestMethod]
        public void ZigzagLevelOrder_Null()
        {
            var solution = new _103_BinaryTreeZigzagLevelOrderTraversal();
            var result = solution.ZigzagLevelOrder(null);
            AssertHelper.AssertList(new List<IList<int>>(), result);
        }
    }
}
