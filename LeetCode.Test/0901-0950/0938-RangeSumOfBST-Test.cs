using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0938_RangeSumOfBST_Test
    {
        [TestMethod]
        public void RangeSumBST_1()
        {
            var solution = new _0938_RangeSumOfBST();
            var result = solution.RangeSumBST(TestHelper.GenerateTree(new int?[] { 10, 5, 15, 3, 7, null, 18 }), 7, 15);
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void RangeSumBST_2()
        {
            var solution = new _0938_RangeSumOfBST();
            var result = solution.RangeSumBST(TestHelper.GenerateTree(new int?[] { 10, 5, 15, 3, 7, 13, 18, 1, null, 6 }), 6, 10);
            Assert.AreEqual(23, result);
        }
    }
}
