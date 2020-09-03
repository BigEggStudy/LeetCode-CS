using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0637_AverageOfLevelsInBinaryTree_Test
    {
        [TestMethod]
        public void AverageOfLevels_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 3, 9, 20, null, null, 15, 7 });

            var solution = new _0637_AverageOfLevelsInBinaryTree();
            var result = solution.AverageOfLevels(root);
            AssertHelper.AssertList(new double[] { 3, 14.5, 11 }, result);
        }
    }
}
