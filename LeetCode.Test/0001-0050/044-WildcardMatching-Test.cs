using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _044_WildcardMatching_Test
    {
        [TestMethod]
        public void IsMatchingTest_CharacterNotMatch()
        {
            var solution = new _044_WildcardMatching();
            var result = solution.IsMatch("aa", "a");
            Assert.IsFalse(result);

            result = solution.IsMatch("aaa", "aa");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMatchingTest_CharacterMatch()
        {
            var solution = new _044_WildcardMatching();

            var result = solution.IsMatch("aa", "aa");
            Assert.IsTrue(result);

            result = solution.IsMatch("abc", "abc");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMatchingTest_Star_Multiple()
        {
            var solution = new _044_WildcardMatching();

            var result = solution.IsMatch("aa", "*");
            Assert.IsTrue(result);

            result = solution.IsMatch("aaa", "*");
            Assert.IsTrue(result);

            result = solution.IsMatch("aaaa", "b*");
            Assert.IsFalse(result);

            result = solution.IsMatch("abcd", "d*");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMatchingTest_Star_Zero()
        {
            var solution = new _044_WildcardMatching();

            var result = solution.IsMatch("ab", "a*b");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMatchingTest_MultipleStar()
        {
            var solution = new _044_WildcardMatching();

            var result = solution.IsMatch("caab", "c*a*b");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMatchingTest_Question()
        {
            var solution = new _044_WildcardMatching();

            var result = solution.IsMatch("ab", "?b");
            Assert.IsTrue(result);

            result = solution.IsMatch("ab", "?");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMatchingTest_QuestionWithStar()
        {
            var solution = new _044_WildcardMatching();

            var result = solution.IsMatch("aa", "?*");
            Assert.IsTrue(result);

            result = solution.IsMatch("ab", "?*");
            Assert.IsTrue(result);

            result = solution.IsMatch("hi", "*?");
            Assert.IsTrue(result);

            result = solution.IsMatch("abcdefg", "?*");
            Assert.IsTrue(result);

            result = solution.IsMatch("bbbba", "?*a");
            Assert.IsTrue(result);

            result = solution.IsMatch("ab", "?*c");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMatchingTest_MultipleQuestion()
        {
            var solution = new _044_WildcardMatching();

            var result = solution.IsMatch("aa", "??");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMatchingTest_StringNullOrEmpty()
        {
            var solution = new _044_WildcardMatching();

            var result = solution.IsMatch("", "?");
            Assert.IsFalse(result);

            result = solution.IsMatch("", "?*");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMatchingTest_MatcherNullOrEmpty()
        {
            var solution = new _044_WildcardMatching();

            var result = solution.IsMatch("abc", "");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsMatchingTest_StringAndMatcherBothNullOrEmpty()
        {
            var solution = new _044_WildcardMatching();

            var result = solution.IsMatch("", "");
            Assert.IsTrue(result);
        }
    }
}
