using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1290_ConvertBinaryNumberInALinkedListToInteger_Test
    {
        [TestMethod]
        public void GetDecimalValue_1()
        {
            var solution = new _1290_ConvertBinaryNumberInALinkedListToInteger();
            var result = solution.GetDecimalValue(TestHelper.GenerateList(new int[] { 1, 0, 1 }));
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void GetDecimalValue_2()
        {
            var solution = new _1290_ConvertBinaryNumberInALinkedListToInteger();
            var result = solution.GetDecimalValue(TestHelper.GenerateList(new int[] { 0 }));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetDecimalValue_3()
        {
            var solution = new _1290_ConvertBinaryNumberInALinkedListToInteger();
            var result = solution.GetDecimalValue(TestHelper.GenerateList(new int[] { 1 }));
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetDecimalValue_4()
        {
            var solution = new _1290_ConvertBinaryNumberInALinkedListToInteger();
            var result = solution.GetDecimalValue(TestHelper.GenerateList(new int[] { 1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 }));
            Assert.AreEqual(18880, result);
        }

        [TestMethod]
        public void GetDecimalValue_5()
        {
            var solution = new _1290_ConvertBinaryNumberInALinkedListToInteger();
            var result = solution.GetDecimalValue(TestHelper.GenerateList(new int[] { 0 }));
            Assert.AreEqual(0, result);
        }
    }
}
