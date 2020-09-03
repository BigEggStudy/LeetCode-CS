using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0212_WordSearchII_Test
    {
        [TestMethod]
        public void FindWordsTest_1()
        {
            var board = new char[][]
            {
                new char[] { 'o', 'a', 'a', 'n' },
                new char[] { 'e', 't', 'a', 'e' },
                new char[] { 'i', 'h', 'k', 'r' },
                new char[] { 'i', 'f', 'l', 'v' }
            };

            var solution = new _0212_WordSearchII();
            var result = solution.FindWords(board, new string[] { "oath", "pea", "eat", "rain" });
            AssertHelper.AssertList(new string[] { "oath", "eat" }, result);
        }

        [TestMethod]
        public void FindWordsTest_2()
        {
            var board = new char[][]
            {
                new char[] { 'o', 'a', 'a', 'n' },
                new char[] { 'e', 't', 'a', 'e' },
                new char[] { 'i', 'h', 'k', 'r' },
                new char[] { 'i', 'f', 'l', 'v' }
            };

            var solution = new _0212_WordSearchII();
            var result = solution.FindWords(board, new string[] { "fhta", "flkhta" });
            AssertHelper.AssertList(new string[] { "fhta", "flkhta" }, result);
        }
    }
}
