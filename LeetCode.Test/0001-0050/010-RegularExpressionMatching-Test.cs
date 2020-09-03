using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _010_RegularExpressionMatching_Test
    {
        [TestMethod]
        public void IsMatchingTest_CharacterNotMatch()
        {
            var solution = new _010_RegularExpressionMatching();
            var result = solution.IsMatch("aa", "a");
            Assert.IsFalse(result);

            result = solution.IsMatch("aaa", "aa");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMatchingTest_CharacterMatch()
        {
            var solution = new _010_RegularExpressionMatching();

            var result = solution.IsMatch("aa", "aa");
            Assert.IsTrue(result);

            result = solution.IsMatch("abc", "abc");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMatchingTest_Star_Multiple()
        {
            var solution = new _010_RegularExpressionMatching();

            var result = solution.IsMatch("aa", "a*");
            Assert.IsTrue(result);

            result = solution.IsMatch("aaa", "a*");
            Assert.IsTrue(result);

            result = solution.IsMatch("aaaa", "b*");
            Assert.IsFalse(result);

            result = solution.IsMatch("abcd", "d*");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMatchingTest_Star_Zero()
        {
            var solution = new _010_RegularExpressionMatching();

            var result = solution.IsMatch("b", "a*b");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMatchingTest_MultipleStar()
        {
            var solution = new _010_RegularExpressionMatching();

            var result = solution.IsMatch("aab", "c*a*b");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMatchingTest_Dot()
        {
            var solution = new _010_RegularExpressionMatching();

            var result = solution.IsMatch("ab", ".b");
            Assert.IsTrue(result);

            result = solution.IsMatch("ab", ".");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMatchingTest_DotWithStar()
        {
            var solution = new _010_RegularExpressionMatching();

            var result = solution.IsMatch("aa", ".*");
            Assert.IsTrue(result);

            result = solution.IsMatch("ab", ".*");
            Assert.IsTrue(result);

            result = solution.IsMatch("abcdefg", ".*");
            Assert.IsTrue(result);

            result = solution.IsMatch("bbbba", ".*a*a");
            Assert.IsTrue(result);

            result = solution.IsMatch("ab", ".*c");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMatchingTest_MultipleDot()
        {
            var solution = new _010_RegularExpressionMatching();

            var result = solution.IsMatch("aa", "..");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMatchingTest_StringNullOrEmpty()
        {
            var solution = new _010_RegularExpressionMatching();

            var result = solution.IsMatch("", ".");
            Assert.IsFalse(result);

            result = solution.IsMatch("", ".*");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMatchingTest_MatcherNullOrEmpty()
        {
            var solution = new _010_RegularExpressionMatching();

            var result = solution.IsMatch("abc", "");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMatchingTest_StringAndMatcherBothNullOrEmpty()
        {
            var solution = new _010_RegularExpressionMatching();

            var result = solution.IsMatch("", "");
            Assert.IsTrue(result);
        }
    }
}
