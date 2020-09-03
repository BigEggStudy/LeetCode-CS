using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0222_CountCompleteTreeNodes_Test
    {
        [TestMethod]
        public void CountNodesTest()
        {
            var solution = new _0222_CountCompleteTreeNodes();
            Assert.AreEqual(2, solution.CountNodes(TestHelper.GenerateTree(new int?[] { 1, 2 })));
            Assert.AreEqual(3, solution.CountNodes(TestHelper.GenerateTree(new int?[] { 1, 2, 3 })));
            Assert.AreEqual(4, solution.CountNodes(TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4 })));
            Assert.AreEqual(5, solution.CountNodes(TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5 })));
            Assert.AreEqual(6, solution.CountNodes(TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5, 6 })));
            Assert.AreEqual(7, solution.CountNodes(TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5, 6, 7 })));
        }

        [TestMethod]
        public void CountNodesTest_Null()
        {
            var solution = new _0222_CountCompleteTreeNodes();
            Assert.AreEqual(0, solution.CountNodes(null));
        }

        [TestMethod]
        public void CountNodesTest_JustRoot()
        {
            var solution = new _0222_CountCompleteTreeNodes();
            Assert.AreEqual(1, solution.CountNodes(TestHelper.GenerateTree(new int?[] { 1 })));
        }
    }
}
