using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0662_MaximumWidthOfBinaryTree_Test
    {
        [TestMethod]
        public void WidthOfBinaryTree_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 3, 2, 5, 3, null, 9 });

            var solution = new _0662_MaximumWidthOfBinaryTree();
            var result = solution.WidthOfBinaryTree(root);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void WidthOfBinaryTree_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 3, null, 5, 3 });

            var solution = new _0662_MaximumWidthOfBinaryTree();
            var result = solution.WidthOfBinaryTree(root);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void WidthOfBinaryTree_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 3, 2, 5 });

            var solution = new _0662_MaximumWidthOfBinaryTree();
            var result = solution.WidthOfBinaryTree(root);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void WidthOfBinaryTree_4()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 3, 2, 5, null, null, 9, 6, null, null, 7 });

            var solution = new _0662_MaximumWidthOfBinaryTree();
            var result = solution.WidthOfBinaryTree(root);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void WidthOfBinaryTree_5()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 1, 1, 1, 1, 1, 1, null, null, null, 1, null, null, null, null, 2, 2, 2, 2, 2, 2, 2, null, 2, null, null, 2, null, 2 });

            var solution = new _0662_MaximumWidthOfBinaryTree();
            var result = solution.WidthOfBinaryTree(root);
            Assert.AreEqual(8, result);
        }
    }
}
