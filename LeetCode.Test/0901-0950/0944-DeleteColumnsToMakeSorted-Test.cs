using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0944_DeleteColumnsToMakeSorted_Test
    {
        [TestMethod]
        public void MinDeletionSize_1()
        {
            var solution = new _0944_DeleteColumnsToMakeSorted();
            var result = solution.MinDeletionSize(new string[] { "cba", "daf", "ghi" });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MinDeletionSize_2()
        {
            var solution = new _0944_DeleteColumnsToMakeSorted();
            var result = solution.MinDeletionSize(new string[] { "a", "b" });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MinDeletionSize_3()
        {
            var solution = new _0944_DeleteColumnsToMakeSorted();
            var result = solution.MinDeletionSize(new string[] { "zyx", "wvu", "tsr" });
            Assert.AreEqual(3, result);
        }
    }
}
