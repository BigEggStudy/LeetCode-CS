using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0951_FlipEquivalentBinaryTrees_Test
    {
        [TestMethod]
        public void FlipEquiv_1()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5, 6, null, null, null, 7, 8 });
            var root2 = TestHelper.GenerateTree(new int?[] { 1, 3, 2, null, 6, 4, 5, null, null, null, null, 8, 7 });

            var solution = new _0951_FlipEquivalentBinaryTrees();
            var result = solution.FlipEquiv(root1, root2);
            Assert.IsTrue(result);
        }
    }
}
