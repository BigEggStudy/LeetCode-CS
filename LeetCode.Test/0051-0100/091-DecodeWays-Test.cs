using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _091_DecodeWays_Test
    {
        [TestMethod]
        public void NumDecodingsTest_Zero()
        {
            var solution = new _091_DecodeWays();
            Assert.AreEqual(0, solution.NumDecodings("0"));
            Assert.AreEqual(0, solution.NumDecodings("00"));
            Assert.AreEqual(0, solution.NumDecodings("000"));
        }

        [TestMethod]
        public void NumDecodingsTest_Length1()
        {
            var solution = new _091_DecodeWays();
            for (var i = 1; i < 10; i++)
                Assert.AreEqual(1, solution.NumDecodings(i.ToString()));
        }

        [TestMethod]
        public void NumDecodingsTest_Length2()
        {
            var solution = new _091_DecodeWays();
            for (var i = 11; i < 99; i++)
                if (i / 10 * 10 == i)
                    Assert.AreEqual(i <= 20 ? 1 : 0, solution.NumDecodings(i.ToString()));
                else
                    Assert.AreEqual(i > 26 ? 1 : 2, solution.NumDecodings(i.ToString()));
        }

        [TestMethod]
        [Timeout(20)]
        public void NumDecodingTest()
        {
            var solution = new _091_DecodeWays();
            Assert.AreEqual(3, solution.NumDecodings("226"));
            Assert.AreEqual(2, solution.NumDecodings("626"));
            Assert.AreEqual(4, solution.NumDecodings("2626"));
            Assert.AreEqual(2, solution.NumDecodings("1026"));
            Assert.AreEqual(8, solution.NumDecodings("262626"));
            Assert.AreEqual(4, solution.NumDecodings("102626"));
            Assert.AreEqual(4, solution.NumDecodings("261026"));
            Assert.AreEqual(2, solution.NumDecodings("101026"));
        }

        [TestMethod]
        public void NumDecodingsTest_ContainZero()
        {
            var solution = new _091_DecodeWays();
            Assert.AreEqual(0, solution.NumDecodings("30"));
        }

        [TestMethod]
        [Timeout(20)]
        public void NumDecodingTest_LongInput()
        {
            var solution = new _091_DecodeWays();
            Assert.AreEqual(0, solution.NumDecodings("6065812287883668764831544958683283296479682877898293612168136334983851946827579555449329483852397155"));
        }
    }
}
