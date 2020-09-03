using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _078_Subsets_Test
    {
        [TestMethod]
        public void SubsetsTest()
        {
            var solution = new _078_Subsets();
            var result = solution.Subsets(new int[] { 1, 2, 3 });

            Assert.AreEqual(8, result.Count);
            AssertHelper.AssertList(new int[] { }, result[0]);
            AssertHelper.AssertList(new int[] { 1 }, result[1]);
            AssertHelper.AssertList(new int[] { 2 }, result[2]);
            AssertHelper.AssertList(new int[] { 1, 2 }, result[3]);
            AssertHelper.AssertList(new int[] { 3 }, result[4]);
            AssertHelper.AssertList(new int[] { 1, 3 }, result[5]);
            AssertHelper.AssertList(new int[] { 2, 3 }, result[6]);
            AssertHelper.AssertList(new int[] { 1, 2, 3 }, result[7]);
        }

        [TestMethod]
        public void SubsetsTest_NotOrdered()
        {
            var solution = new _078_Subsets();
            var result = solution.Subsets(new int[] { 3, 2, 1 });

            Assert.AreEqual(8, result.Count);
            AssertHelper.AssertList(new int[] { }, result[0]);
            AssertHelper.AssertList(new int[] { 1 }, result[1]);
            AssertHelper.AssertList(new int[] { 2 }, result[2]);
            AssertHelper.AssertList(new int[] { 1, 2 }, result[3]);
            AssertHelper.AssertList(new int[] { 3 }, result[4]);
            AssertHelper.AssertList(new int[] { 1, 3 }, result[5]);
            AssertHelper.AssertList(new int[] { 2, 3 }, result[6]);
            AssertHelper.AssertList(new int[] { 1, 2, 3 }, result[7]);
        }

        [TestMethod]
        public void SubsetsTest_EmptyNums()
        {
            var solution = new _078_Subsets();
            var result = solution.Subsets(new int[] { });

            Assert.AreEqual(1, result.Count);
            AssertHelper.AssertList(new int[] { }, result[0]);
        }

        [TestMethod]
        public void SubsetsTest_OneItem()
        {
            var solution = new _078_Subsets();
            var result = solution.Subsets(new int[] { 1 });

            Assert.AreEqual(2, result.Count);
            AssertHelper.AssertList(new int[] { }, result[0]);
            AssertHelper.AssertList(new int[] { 1 }, result[1]);
        }
    }
}
