using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0617_MergeTwoBinaryTrees_Test
    {
        [TestMethod]
        public void MergeTreesTest()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 1, 3, 2, 5 });
            var root2 = TestHelper.GenerateTree(new int?[] { 2, 1, 3, null, 4, null, 7 });

            var solution = new _0617_MergeTwoBinaryTrees();
            var result = solution.MergeTrees(root1, root2);
            AssertHelper.AssertTree(new int?[] { 3, 4, 5, 5, 4, null, 7 }, result);
        }
    }
}
