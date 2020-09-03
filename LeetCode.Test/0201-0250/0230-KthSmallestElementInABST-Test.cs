using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0230_KthSmallestElementInABST_Test
    {
        [TestMethod]
        public void KthSmallest_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 1, 4, null, 2 });

            var solution = new _0230_KthSmallestElementInABST();
            var result = solution.KthSmallest(root, 1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void KthSmallest_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 5, 3, 6, 2, 4, null, null, 1 });

            var solution = new _0230_KthSmallestElementInABST();
            var result = solution.KthSmallest(root, 3);
            Assert.AreEqual(3, result);
        }
    }
}
