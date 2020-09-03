using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1071_GreatestCommonDivisorOfStrings_Test
    {
        [TestMethod]
        public void GcdOfStrings_1()
        {
            var solution = new _1071_GreatestCommonDivisorOfStrings();
            var result = solution.GcdOfStrings("ABCABC", "ABC");
            Assert.AreEqual("ABC", result);
        }

        [TestMethod]
        public void GcdOfStrings_2()
        {
            var solution = new _1071_GreatestCommonDivisorOfStrings();
            var result = solution.GcdOfStrings("ABABAB", "ABAB");
            Assert.AreEqual("AB", result);
        }

        [TestMethod]
        public void GcdOfStrings_3()
        {
            var solution = new _1071_GreatestCommonDivisorOfStrings();
            var result = solution.GcdOfStrings("LEET", "CODE");
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void GcdOfStrings_4()
        {
            var solution = new _1071_GreatestCommonDivisorOfStrings();
            var result = solution.GcdOfStrings("NLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGM", "NLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGMNLZGM");
            Assert.AreEqual("NLZGM", result);
        }
    }
}
