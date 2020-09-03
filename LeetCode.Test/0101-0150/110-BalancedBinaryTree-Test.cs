using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _110_BalancedBinaryTree_Test
    {
        [TestMethod]
        public void IsBalancedTest_Valid()
        {
            var solution = new _110_BalancedBinaryTree();
            Assert.IsTrue(solution.IsBalanced(TestHelper.GenerateTree(new int?[] { 3, 9, 20, null, null, 15, 7 })));
        }

        [TestMethod]
        public void IsBalancedTest_Invalid()
        {
            var solution = new _110_BalancedBinaryTree();
            Assert.IsFalse(solution.IsBalanced(TestHelper.GenerateTree(new int?[] { 1, 2, 2, 3, 3, null, null, 4, 4 })));
        }

        [TestMethod]
        public void IsBalancedTest_Invalid_Long()
        {
            var solution = new _110_BalancedBinaryTree();
            Assert.IsFalse(solution.IsBalanced(TestHelper.GenerateTree(new int?[] { 1, 2, 2, 3, 3, 3, 3, 4, 4, null, null, null, null, 4, 4, 5, 5, null, null, 5, 5 })));
        }

        [TestMethod]
        public void IsBalancedTest_Null()
        {
            var solution = new _110_BalancedBinaryTree();
            Assert.IsTrue(solution.IsBalanced(null));
        }
    }
}
