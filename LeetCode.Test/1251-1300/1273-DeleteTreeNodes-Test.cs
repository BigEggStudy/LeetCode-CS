using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1273_DeleteTreeNodes_Test
    {
        [TestMethod]
        public void DeleteTreeNodes_1()
        {
            var solution = new _1273_DeleteTreeNodes();
            var result = solution.DeleteTreeNodes(7, new int[] { -1, 0, 0, 1, 2, 2, 2 }, new int[] { 1, -2, 4, 0, -2, -1, -1 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DeleteTreeNodes_2()
        {
            var solution = new _1273_DeleteTreeNodes();
            var result = solution.DeleteTreeNodes(7, new int[] { -1, 0, 0, 1, 2, 2, 2 }, new int[] { 1, -2, 4, 0, -2, -1, -2 });
            Assert.AreEqual(6, result);
        }
    }
}
