using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _062_UniquePaths_Test
    {
        [TestMethod]
        public void UniquePathsTest()
        {
            var solution = new _062_UniquePaths();
            var result = solution.UniquePaths(3, 7);

            Assert.AreEqual(28, result);
        }

        [TestMethod]
        public void UniquePathsTest_OneRow()
        {
            var solution = new _062_UniquePaths();
            var result = solution.UniquePaths(1, 7);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UniquePathsTest_OneColumn()
        {
            var solution = new _062_UniquePaths();
            var result = solution.UniquePaths(7, 1);

            Assert.AreEqual(1, result);
        }
    }
}
