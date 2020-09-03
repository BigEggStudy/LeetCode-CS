using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0784_LetterCasePermutation_Test
    {
        [TestMethod]
        public void LetterCasePermutation_1()
        {
            var solution = new _0784_LetterCasePermutation();
            var result = solution.LetterCasePermutation("a1b2");
            AssertHelper.AssertList(new string[] { "a1b2", "a1B2", "A1b2", "A1B2" }, result);
        }

        [TestMethod]
        public void LetterCasePermutation_2()
        {
            var solution = new _0784_LetterCasePermutation();
            var result = solution.LetterCasePermutation("3z4");
            AssertHelper.AssertList(new string[] { "3z4", "3Z4" }, result);
        }

        [TestMethod]
        public void LetterCasePermutation_3()
        {
            var solution = new _0784_LetterCasePermutation();
            var result = solution.LetterCasePermutation("12345");
            AssertHelper.AssertList(new string[] { "12345" }, result);
        }
    }
}
