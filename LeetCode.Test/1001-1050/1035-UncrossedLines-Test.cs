using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1035_UncrossedLines_Test
    {
        [TestMethod]
        public void MaxUncrossedLines_1()
        {
            var solution = new _1035_UncrossedLines();
            var result = solution.MaxUncrossedLines(new int[] { 1, 4, 2 }, new int[] { 1, 2, 4 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MaxUncrossedLines_2()
        {
            var solution = new _1035_UncrossedLines();
            var result = solution.MaxUncrossedLines(new int[] { 2, 5, 1, 2, 5 }, new int[] { 10, 5, 2, 1, 5, 2 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void MaxUncrossedLines_3()
        {
            var solution = new _1035_UncrossedLines();
            var result = solution.MaxUncrossedLines(new int[] { 1, 3, 7, 1, 7, 5 }, new int[] { 1, 9, 2, 5, 1 });
            Assert.AreEqual(2, result);
        }
    }
}
