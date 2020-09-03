using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0742_ClosestLeafInABinaryTree_Test
    {
        [TestMethod]
        public void FindClosestLeaf_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 3, 2 });

            var solution = new _0742_ClosestLeafInABinaryTree();
            var result = solution.FindClosestLeaf(root, 1);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FindClosestLeaf_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1 });

            var solution = new _0742_ClosestLeafInABinaryTree();
            var result = solution.FindClosestLeaf(root, 1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindClosestLeaf_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, null, null, null, 5, null, 6 });

            var solution = new _0742_ClosestLeafInABinaryTree();
            var result = solution.FindClosestLeaf(root, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FindClosestLeaf_4()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2 });

            var solution = new _0742_ClosestLeafInABinaryTree();
            var result = solution.FindClosestLeaf(root, 1);
            Assert.AreEqual(2, result);
        }
    }
}
