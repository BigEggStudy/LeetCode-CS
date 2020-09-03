using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _034_SearchForARange_Test
    {
        [TestMethod]
        public void SearchRangeTest()
        {
            var input = new int[] { 5, 7, 7, 8, 8, 10 };
            var solution = new _034_SearchForARange();

            var result = solution.SearchRange(input, 5);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);

            result = solution.SearchRange(input, 10);
            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(5, result[1]);
        }

        [TestMethod]
        public void SearchRangeTest_WithDuplicate()
        {
            var input = new int[] { 5, 7, 7, 8, 8, 10 };
            var solution = new _034_SearchForARange();

            var result = solution.SearchRange(input, 8);
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(4, result[1]);

            result = solution.SearchRange(input, 7);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [TestMethod]
        public void SearchRangeTest_NotFound()
        {
            var input = new int[] { 5, 7, 7, 8, 8, 10 };
            var solution = new _034_SearchForARange();

            var result = solution.SearchRange(input, 6);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);

            result = solution.SearchRange(input, 4);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);

            result = solution.SearchRange(input, 9);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);

            result = solution.SearchRange(input, 11);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);
        }

        [TestMethod]
        public void SearchRangeTest_OneItem_Match()
        {
            var input = new int[] { 5 };

            var solution = new _034_SearchForARange();
            var result = solution.SearchRange(input, 5);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
        }

        [TestMethod]
        public void SearchRangeTest_OneItem_NotMatch()
        {
            var input = new int[] { 5 };

            var solution = new _034_SearchForARange();
            var result = solution.SearchRange(input, 6);

            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);
        }

        [TestMethod]
        public void SearchRangeTest_AllSame()
        {
            var input = new int[] { 5, 5 };

            var solution = new _034_SearchForARange();
            var result = solution.SearchRange(input, 5);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }
    }
}
