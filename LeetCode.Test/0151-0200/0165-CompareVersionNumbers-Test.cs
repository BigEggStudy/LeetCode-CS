using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0165_CompareVersionNumbers_Test
    {
        [TestMethod]
        public void CompareVersion_1()
        {
            var solution = new _0165_CompareVersionNumbers();
            var result = solution.CompareVersion("1.01", "1.001");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CompareVersion_2()
        {
            var solution = new _0165_CompareVersionNumbers();
            var result = solution.CompareVersion("1.0", "1.0.0");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CompareVersion_3()
        {
            var solution = new _0165_CompareVersionNumbers();
            var result = solution.CompareVersion("0.1", "1.1");
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CompareVersion_4()
        {
            var solution = new _0165_CompareVersionNumbers();
            var result = solution.CompareVersion("1.0.1", "1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CompareVersion_5()
        {
            var solution = new _0165_CompareVersionNumbers();
            var result = solution.CompareVersion("7.5.2.4", "7.5.3");
            Assert.AreEqual(-1, result);
        }
    }
}
