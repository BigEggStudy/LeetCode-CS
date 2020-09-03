using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _101_SymmetricTree_Test
    {
        [TestMethod]
        public void IsSymmetricTest()
        {
            var solution = new _101_SymmetricTree();
            Assert.IsTrue(solution.IsSymmetric(TestHelper.GenerateTree(new int?[] { 1, 2, 2, 3, 4, 4, 3 })));
        }

        [TestMethod]
        public void IsSymmetricTest_StructureDifferent()
        {
            var solution = new _101_SymmetricTree();
            Assert.IsFalse(solution.IsSymmetric(TestHelper.GenerateTree(new int?[] { 1, 2, 2, null, 3, null, 3 })));
        }

        [TestMethod]
        public void IsSymmetricTest_ValueDifferent()
        {
            var solution = new _101_SymmetricTree();
            Assert.IsFalse(solution.IsSymmetric(TestHelper.GenerateTree(new int?[] { 1, 2, 2, null, 3, 4 })));
        }

        [TestMethod]
        public void IsSymmetricTest_Null()
        {
            var solution = new _101_SymmetricTree();
            Assert.IsTrue(solution.IsSymmetric(null));
        }
    }
}
