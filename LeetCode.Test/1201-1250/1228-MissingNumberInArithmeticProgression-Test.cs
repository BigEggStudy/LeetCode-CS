using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1228_MissingNumberInArithmeticProgression_Test
    {
        [TestMethod]
        public void MissingNumber_1()
        {
            var solution = new _1228_MissingNumberInArithmeticProgression();
            var result = solution.MissingNumber(new int[] { 5, 7, 11, 13 });
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void MissingNumber_2()
        {
            var solution = new _1228_MissingNumberInArithmeticProgression();
            var result = solution.MissingNumber(new int[] { 15, 13, 12 });
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void MissingNumber_3()
        {
            var solution = new _1228_MissingNumberInArithmeticProgression();
            var result = solution.MissingNumber(new int[] { 0, 0, 0, 0 });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MissingNumber_4()
        {
            var solution = new _1228_MissingNumberInArithmeticProgression();
            var result = solution.MissingNumber(new int[] { 4, 4, 4, 4 });
            Assert.AreEqual(4, result);
        }
    }
}
