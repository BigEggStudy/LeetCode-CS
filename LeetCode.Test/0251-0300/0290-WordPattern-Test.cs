using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0290_WordPattern_Test
    {
        [TestMethod]
        public void WordPattern_1()
        {
            var solution = new _0290_WordPattern();
            var result = solution.WordPattern("abba", "dog cat cat dog");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WordPattern_2()
        {
            var solution = new _0290_WordPattern();
            var result = solution.WordPattern("abba", "dog cat cat fish");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WordPattern_3()
        {
            var solution = new _0290_WordPattern();
            var result = solution.WordPattern("aaaa", "dog cat cat dog");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WordPattern_4()
        {
            var solution = new _0290_WordPattern();
            var result = solution.WordPattern("abba", "dog dog dog dog");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WordPattern_5()
        {
            var solution = new _0290_WordPattern();
            var result = solution.WordPattern("abc", "b c a");
            Assert.IsTrue(result);
        }
    }
}
