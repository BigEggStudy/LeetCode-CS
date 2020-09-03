using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0979_DistributeCoinsInBinaryTree_Test
    {
        [TestMethod]
        public void DistributeCoinsTest_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 0, 0 });

            var solution = new _0979_DistributeCoinsInBinaryTree();
            var result = solution.DistributeCoins(root);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DistributeCoinsTest_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 0, 3, 0 });

            var solution = new _0979_DistributeCoinsInBinaryTree();
            var result = solution.DistributeCoins(root);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void DistributeCoinsTest_3()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 0, 2 });

            var solution = new _0979_DistributeCoinsInBinaryTree();
            var result = solution.DistributeCoins(root);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DistributeCoinsTest_4()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 0, 0, null, 3 });

            var solution = new _0979_DistributeCoinsInBinaryTree();
            var result = solution.DistributeCoins(root);
            Assert.AreEqual(4, result);
        }
    }
}
