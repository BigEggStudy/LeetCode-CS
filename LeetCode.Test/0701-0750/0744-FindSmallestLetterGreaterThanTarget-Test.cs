using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0744_FindSmallestLetterGreaterThanTarget_Test
    {
        [TestMethod]
        public void NextGreatestLetter_1()
        {
            var solution = new _0744_FindSmallestLetterGreaterThanTarget();
            var result = solution.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'a');
            Assert.AreEqual('c', result);
        }

        [TestMethod]
        public void NextGreatestLetter_2()
        {
            var solution = new _0744_FindSmallestLetterGreaterThanTarget();
            var result = solution.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'c');
            Assert.AreEqual('f', result);
        }

        [TestMethod]
        public void NextGreatestLetter_3()
        {
            var solution = new _0744_FindSmallestLetterGreaterThanTarget();
            var result = solution.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'd');
            Assert.AreEqual('f', result);
        }

        [TestMethod]
        public void NextGreatestLetter_4()
        {
            var solution = new _0744_FindSmallestLetterGreaterThanTarget();
            var result = solution.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'g');
            Assert.AreEqual('j', result);
        }

        [TestMethod]
        public void NextGreatestLetter_5()
        {
            var solution = new _0744_FindSmallestLetterGreaterThanTarget();
            var result = solution.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'j');
            Assert.AreEqual('c', result);
        }

        [TestMethod]
        public void NextGreatestLetter_6()
        {
            var solution = new _0744_FindSmallestLetterGreaterThanTarget();
            var result = solution.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'k');
            Assert.AreEqual('c', result);
        }
    }
}
