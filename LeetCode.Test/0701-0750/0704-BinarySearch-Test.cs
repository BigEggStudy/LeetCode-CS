using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0704_BinarySearch_Test
    {
        [TestMethod]
        public void Search_1()
        {
            var solution = new _0704_BinarySearch();
            var result = solution.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Search_2()
        {
            var solution = new _0704_BinarySearch();
            var result = solution.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2);
            Assert.AreEqual(-1, result);
        }
    }
}
