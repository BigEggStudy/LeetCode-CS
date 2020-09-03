using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1022_SumOfRootToLeafBinaryNumbers_Test
    {
        [TestMethod]
        public void SumRootToLeaf_1()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 0, 1, 0, 1, 0, 1 });

            var solution = new _1022_SumOfRootToLeafBinaryNumbers();
            var result = solution.SumRootToLeaf(root);
            Assert.AreEqual(22, result);
        }

        [TestMethod]
        public void SumRootToLeaf_2()
        {
            var root = TestHelper.GenerateTree(new int?[] { 1, 0, 1, 0, 1, 0 });

            var solution = new _1022_SumOfRootToLeafBinaryNumbers();
            var result = solution.SumRootToLeaf(root);
            Assert.AreEqual(15, result);
        }
    }
}
