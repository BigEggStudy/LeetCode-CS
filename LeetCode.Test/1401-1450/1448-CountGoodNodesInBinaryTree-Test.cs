using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1448_CountGoodNodesInBinaryTree_Test
    {
        [TestMethod]
        public void GoodNodes_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 1, 4, 3, null, 1, 5 });

            var solution = new _1448_CountGoodNodesInBinaryTree();
            var result = solution.GoodNodes(root);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void GoodNodes_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 3, null, 4, 2 });

            var solution = new _1448_CountGoodNodesInBinaryTree();
            var result = solution.GoodNodes(root);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GoodNodes_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1 });

            var solution = new _1448_CountGoodNodesInBinaryTree();
            var result = solution.GoodNodes(root);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GoodNodes_4()
        {
            var root = TestHelper.GenerateTree(new int?[] { 2, null, 4, 10, 8, null, null, 4 });

            var solution = new _1448_CountGoodNodesInBinaryTree();
            var result = solution.GoodNodes(root);
            Assert.AreEqual(4, result);
        }
    }
}
