using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0865_SmallestSubtreeWithAllTheDeepestNodes_Test
    {
        [TestMethod]
        public void SubtreeWithAllDeepest_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 });

            var solution = new _0865_SmallestSubtreeWithAllTheDeepestNodes();
            var result = solution.SubtreeWithAllDeepest(root);
            AssertHelper.AssertTree(new int?[] { 2, 7, 4 }, result);
        }
    }
}
