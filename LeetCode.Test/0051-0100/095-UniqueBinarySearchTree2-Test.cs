using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _095_UniqueBinarySearchTree2_Test
    {
        [TestMethod]
        public void GenerateTreesTest_Zero()
        {
            var solution = new _095_UniqueBinarySearchTree2();
            var result = solution.GenerateTrees(0);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GenerateTreesTest_One()
        {
            var solution = new _095_UniqueBinarySearchTree2();
            var result = solution.GenerateTrees(1);
            AssertHelper.AssertTrees(new List<int?[]>() { new int?[] { 1 } }, result);
        }

        [TestMethod]
        public void GenerateTreesTest_Two()
        {
            var solution = new _095_UniqueBinarySearchTree2();
            var result = solution.GenerateTrees(2);
            AssertHelper.AssertTrees(new List<int?[]>() {
                new int?[] { 1, null, 2 },
                new int?[] { 2, 1 }
            }, result);
        }

        [TestMethod]
        public void GenerateTreesTest_Three()
        {
            var solution = new _095_UniqueBinarySearchTree2();
            var result = solution.GenerateTrees(3);
            AssertHelper.AssertTrees(new List<int?[]>() {
                new int?[] { 1, null, 2, null, 3 },
                new int?[] { 1, null, 3, 2 },
                new int?[] { 2, 1, 3 },
                new int?[] { 3, 1, null, null, 2 },
                new int?[] { 3, 2, null, 1 }
            }, result);
        }
    }
}
