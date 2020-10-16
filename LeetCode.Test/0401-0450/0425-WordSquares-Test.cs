using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0425_WordSquares_Test
    {
        [TestMethod]
        public void WordSquares_1()
        {
            var solution = new _0425_WordSquares();
            var result = solution.WordSquares(new string[] { "area", "lead", "wall", "lady", "ball" });
            AssertHelper.AssertList(new List<IList<string>>() {
                new string[] { "wall", "area", "lead", "lady" },
                new string[] { "ball", "area", "lead", "lady"},
            }, result);
        }

        [TestMethod]
        public void WordSquares_2()
        {
            var solution = new _0425_WordSquares();
            var result = solution.WordSquares(new string[] { "abat", "baba", "atan", "atal" });
            AssertHelper.AssertList(new List<IList<string>>() {
                new string[] { "baba", "abat", "baba", "atan" },
                new string[] { "baba", "abat", "baba", "atal"},
            }, result);
        }
    }
}
