using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _041_FirstMissingPositive_Test
    {
        [TestMethod]
        public void FirstMissingPositiveTest()
        {
            var input = new int[] { 3, 4, -1, 1 };

            var solution = new _041_FirstMissingPositive();
            var result = solution.FirstMissingPositive(input);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FirstMissingPositiveTest_AllSame()
       { 
            var input = new int[] { 3, 3, 3, 3 };

            var solution = new _041_FirstMissingPositive();
            var result = solution.FirstMissingPositive(input);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FirstMissingPositiveTest_ResultLarger()
        {
            var input = new int[] { 1, 2, 0 };

            var solution = new _041_FirstMissingPositive();
            var result = solution.FirstMissingPositive(input);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FirstMissingPositiveTest_Empty()
        {
            var solution = new _041_FirstMissingPositive();
            var result = solution.FirstMissingPositive(new int[] { });

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FirstMissingPositiveTest_OneItem_One()
        {
            var solution = new _041_FirstMissingPositive();
            var result = solution.FirstMissingPositive(new int[] { 1 });

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FirstMissingPositiveTest_OneItem_NotOne()
        {
            var solution = new _041_FirstMissingPositive();
            var result = solution.FirstMissingPositive(new int[] { 0 });
            Assert.AreEqual(1, result);

            result = solution.FirstMissingPositive(new int[] { 2 });
            Assert.AreEqual(1, result);
        }
    }
}
