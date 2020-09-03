using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _107_BinaryTreeLevelOrderTraversal2_Test
    {
        [TestMethod]
        public void LevelOrderBottomTest()
        {
            var solution = new _107_BinaryTreeLevelOrderTraversal2();
            var result = solution.LevelOrderBottom(TestHelper.GenerateTree(new int?[] { 3, 9, 20, null, null, 15, 7 }));
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 15, 7 },
                new List<int>() { 9, 20 },
                new List<int>() { 3 },
            }, result);
        }

        [TestMethod]
        public void LevelOrderBottomTest_Null()
        {
            var solution = new _107_BinaryTreeLevelOrderTraversal2();
            var result = solution.LevelOrderBottom(null);
            AssertHelper.AssertList(new List<IList<int>>(), result);
        }
    }
}
