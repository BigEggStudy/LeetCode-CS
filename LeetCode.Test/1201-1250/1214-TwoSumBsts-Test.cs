using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1214_TwoSumBsts_Test
    {
        [TestMethod]
        public void TwoSumBSTs_1()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 2, 1, 4 });
            var root2 = TestHelper.GenerateTree(new int?[] { 1, 0, 3 });

            var solution = new _1214_TwoSumBsts();
            var result = solution.TwoSumBSTs(root1, root2, 5);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TwoSumBSTs_2()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 0, -10, 10 });
            var root2 = TestHelper.GenerateTree(new int?[] { 5, 1, 7, 0, 2 });

            var solution = new _1214_TwoSumBsts();
            var result = solution.TwoSumBSTs(root1, root2, 18);
            Assert.IsFalse(result);
        }
    }
}
