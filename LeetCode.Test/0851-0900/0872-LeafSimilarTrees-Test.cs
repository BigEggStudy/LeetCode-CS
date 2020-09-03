using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0872_LeafSimilarTrees_Test
    {
        [TestMethod]
        public void LeafSimilar_1()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 3, 5, 1, 6, 2, 9, 8, null, null, 7, 4 });
            var root2 = TestHelper.GenerateTree(new int?[] { 3, 5, 1, 6, 2, 9, 8, null, null, 7, 4 });

            var solution = new _0872_LeafSimilarTrees();
            var result = solution.LeafSimilar(root1, root2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LeafSimilar_2()
        {
            var root1 = TestHelper.GenerateTree(new int?[] { 3, 5, 1, 6, 2, 9, 8, null, null, 7, 4 });
            var root2 = TestHelper.GenerateTree(new int?[] { 3, 5, 1, 4, 2, 9, 8, null, null, 7, 6 });

            var solution = new _0872_LeafSimilarTrees();
            var result = solution.LeafSimilar(root1, root2);
            Assert.IsFalse(result);
        }
    }
}
