using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _094_BinaryTreeInorderTraversal_Test
    {
        [TestMethod]
        public void InorderTraversalTest()
        {
            var solution = new _094_BinaryTreeInorderTraversal();
            var result = solution.InorderTraversal(TestHelper.GenerateTree(new int?[] { 1, 2, 3 }));
            AssertHelper.AssertList(new int[] { 2, 1, 3 }, result);
        }
        
        [TestMethod]
        public void InorderTraversalTest_Empty()
        {
            var solution = new _094_BinaryTreeInorderTraversal();
            var result = solution.InorderTraversal(TestHelper.GenerateTree(new int?[] { }));
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void InorderTraversalTest_WithNull()
        {
            var solution = new _094_BinaryTreeInorderTraversal();
            var result = solution.InorderTraversal(TestHelper.GenerateTree(new int?[] { 1, null, 2, 3 }));
            AssertHelper.AssertList(new int[] { 1, 3, 2 }, result);
            result = solution.InorderTraversal(TestHelper.GenerateTree(new int?[] { 1, 2, null, 3, 4 }));
            AssertHelper.AssertList(new int[] { 3, 2, 4, 1 }, result);
        }

                [TestMethod]
        public void InorderTraversalTest_OnlyOne()
        {
            var solution = new _094_BinaryTreeInorderTraversal();
            var result = solution.InorderTraversal(TestHelper.GenerateTree(new int?[] { 1 }));
            AssertHelper.AssertList(new int[] { 1 }, result);
        }
    }
}
