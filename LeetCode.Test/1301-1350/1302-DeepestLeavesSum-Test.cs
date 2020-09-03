using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1302_DeepestLeavesSum_Test
    {
        [TestMethod]
        public void DeepestLeavesSum_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8 });

            var solution = new _1302_DeepestLeavesSum();
            var result = solution.DeepestLeavesSum(root);
            Assert.AreEqual(15, result);
        }
    }
}
