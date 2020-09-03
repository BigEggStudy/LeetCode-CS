using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0205_IsomorphicStrings_Test
    {
        [TestMethod]
        public void IsIsomorphicTest_1()
        {
            var solution = new _0205_IsomorphicStrings();
            Assert.IsTrue(solution.IsIsomorphic("egg", "add"));
        }

        [TestMethod]
        public void IsIsomorphicTest_2()
        {
            var solution = new _0205_IsomorphicStrings();
            Assert.IsFalse(solution.IsIsomorphic("foo", "bar"));
        }

        [TestMethod]
        public void IsIsomorphicTest_3()
        {
            var solution = new _0205_IsomorphicStrings();
            Assert.IsTrue(solution.IsIsomorphic("paper", "title"));
        }

        [TestMethod]
        public void IsIsomorphicTest_4()
        {
            var solution = new _0205_IsomorphicStrings();
            Assert.IsFalse(solution.IsIsomorphic("ab", "aa"));
        }
    }
}
