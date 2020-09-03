using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _038_CountAndSay_Test
    {
        [TestMethod]
        public void CountAndSayTest()
        {
            var solution = new _038_CountAndSay();

            var result = solution.CountAndSay(2);
            Assert.AreEqual("11", result);

            result = solution.CountAndSay(3);
            Assert.AreEqual("21", result);

            result = solution.CountAndSay(4);
            Assert.AreEqual("1211", result);

            result = solution.CountAndSay(5);
            Assert.AreEqual("111221", result);

            result = solution.CountAndSay(6);
            Assert.AreEqual("312211", result);

            result = solution.CountAndSay(7);
            Assert.AreEqual("13112221", result);

            result = solution.CountAndSay(8);
            Assert.AreEqual("1113213211", result);

            result = solution.CountAndSay(9);
            Assert.AreEqual("31131211131221", result);

            result = solution.CountAndSay(10);
            Assert.AreEqual("13211311123113112211", result);
        }

        [TestMethod]
        public void CountAndSayTest_NEqualOne()
        {
            var solution = new _038_CountAndSay();

            var result = solution.CountAndSay(1);
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void CountAndSayTest_NLessThanOne()
        {
            var solution = new _038_CountAndSay();

            var result = solution.CountAndSay(0);
            Assert.AreEqual("1", result);

            result = solution.CountAndSay(-1);
            Assert.AreEqual("1", result);
        }
    }
}
