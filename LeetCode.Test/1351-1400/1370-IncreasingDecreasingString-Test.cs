using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1370_IncreasingDecreasingString_Test
    {
        [TestMethod]
        public void SortString_1()
        {
            var solution = new _1370_IncreasingDecreasingString();
            var result = solution.SortString("aaaabbbbcccc");
            Assert.AreEqual("abccbaabccba", result);
        }

        [TestMethod]
        public void SortString_2()
        {
            var solution = new _1370_IncreasingDecreasingString();
            var result = solution.SortString("rat");
            Assert.AreEqual("art", result);
        }

        [TestMethod]
        public void SortString_3()
        {
            var solution = new _1370_IncreasingDecreasingString();
            var result = solution.SortString("leetcode");
            Assert.AreEqual("cdelotee", result);
        }

        [TestMethod]
        public void SortString_4()
        {
            var solution = new _1370_IncreasingDecreasingString();
            var result = solution.SortString("ggggggg");
            Assert.AreEqual("ggggggg", result);
        }

        [TestMethod]
        public void SortString_5()
        {
            var solution = new _1370_IncreasingDecreasingString();
            var result = solution.SortString("spo");
            Assert.AreEqual("ops", result);
        }
    }
}
