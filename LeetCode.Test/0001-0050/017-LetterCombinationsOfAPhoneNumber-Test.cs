using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _017_LetterCombinationsOfAPhoneNumber_Test
    {
        [TestMethod]
        public void LetterCombinationsTest()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations("23");

            Assert.AreEqual(9, result.Count);
            Assert.IsTrue(result.Contains("ad"));
            Assert.IsTrue(result.Contains("ae"));
            Assert.IsTrue(result.Contains("af"));
            Assert.IsTrue(result.Contains("bd"));
            Assert.IsTrue(result.Contains("be"));
            Assert.IsTrue(result.Contains("bf"));
            Assert.IsTrue(result.Contains("cd"));
            Assert.IsTrue(result.Contains("ce"));
            Assert.IsTrue(result.Contains("cf"));
        }

        [TestMethod]
        public void LetterCombinationsTest_2()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations("234");

            Assert.AreEqual(27, result.Count);
        }

        [TestMethod]
        public void LetterCombinationsTest_EmptyString()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations("");

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void LetterCombinationsTest_WithZero()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations("20");

            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.Contains("a "));
            Assert.IsTrue(result.Contains("b "));
            Assert.IsTrue(result.Contains("c "));
        }

        [TestMethod]
        public void LetterCombinationsTest_OnlyHaveZero()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();

            var result = solution.LetterCombinations("0000");
            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result.Contains("    "));
        }

        [TestMethod]
        public void LetterCombinationsTest_WithOne()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();

            var result = solution.LetterCombinations("21");
            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.Contains("a"));
            Assert.IsTrue(result.Contains("b"));
            Assert.IsTrue(result.Contains("c"));

            result = solution.LetterCombinations("213");
            Assert.AreEqual(9, result.Count);
            Assert.IsTrue(result.Contains("ad"));
            Assert.IsTrue(result.Contains("ae"));
            Assert.IsTrue(result.Contains("af"));
            Assert.IsTrue(result.Contains("bd"));
            Assert.IsTrue(result.Contains("be"));
            Assert.IsTrue(result.Contains("bf"));
            Assert.IsTrue(result.Contains("cd"));
            Assert.IsTrue(result.Contains("ce"));
            Assert.IsTrue(result.Contains("cf"));
        }

        [TestMethod]
        public void LetterCombinationsTest_OnlyHaveOne()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();

            var result = solution.LetterCombinations("111");
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void LetterCombinationsTest_WithSeven()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations("27");

            Assert.AreEqual(12, result.Count);
            Assert.IsTrue(result.Contains("ap"));
            Assert.IsTrue(result.Contains("aq"));
            Assert.IsTrue(result.Contains("ar"));
            Assert.IsTrue(result.Contains("as"));
            Assert.IsTrue(result.Contains("bp"));
            Assert.IsTrue(result.Contains("bq"));
            Assert.IsTrue(result.Contains("br"));
            Assert.IsTrue(result.Contains("bs"));
            Assert.IsTrue(result.Contains("cp"));
            Assert.IsTrue(result.Contains("cq"));
            Assert.IsTrue(result.Contains("cr"));
            Assert.IsTrue(result.Contains("cs"));
        }

        [TestMethod]
        public void LetterCombinationsTest_WithNine()
        {
            var solution = new _017_LetterCombinationsOfAPhoneNumber();

            var result = solution.LetterCombinations("9");
            Assert.AreEqual(4, result.Count);
            Assert.IsTrue(result.Contains("w"));
            Assert.IsTrue(result.Contains("x"));
            Assert.IsTrue(result.Contains("y"));
            Assert.IsTrue(result.Contains("z"));

            result = solution.LetterCombinations("29");
            Assert.AreEqual(12, result.Count);
            Assert.IsTrue(result.Contains("aw"));
            Assert.IsTrue(result.Contains("ax"));
            Assert.IsTrue(result.Contains("ay"));
            Assert.IsTrue(result.Contains("az"));
            Assert.IsTrue(result.Contains("bw"));
            Assert.IsTrue(result.Contains("bx"));
            Assert.IsTrue(result.Contains("by"));
            Assert.IsTrue(result.Contains("bz"));
            Assert.IsTrue(result.Contains("cw"));
            Assert.IsTrue(result.Contains("cx"));
            Assert.IsTrue(result.Contains("cy"));
            Assert.IsTrue(result.Contains("cz"));
        }
    }
}
