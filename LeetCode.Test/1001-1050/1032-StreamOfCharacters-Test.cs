using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1032_StreamOfCharacters_Test
    {
        [TestMethod]
        public void StreamCheckerTest_1()
        {
            var solution = new _1032_StreamOfCharacters(new string[] { "cd", "f", "kl" });
            Assert.IsFalse(solution.Query('a'));          // return false
            Assert.IsFalse(solution.Query('b'));          // return false
            Assert.IsFalse(solution.Query('c'));          // return false
            Assert.IsTrue(solution.Query('d'));          // return true, because 'cd' is in the wordlist
            Assert.IsFalse(solution.Query('e'));          // return false
            Assert.IsTrue(solution.Query('f'));          // return true, because 'f' is in the wordlist
            Assert.IsFalse(solution.Query('g'));          // return false
            Assert.IsFalse(solution.Query('h'));          // return false
            Assert.IsFalse(solution.Query('i'));          // return false
            Assert.IsFalse(solution.Query('j'));          // return false
            Assert.IsFalse(solution.Query('k'));          // return false
            Assert.IsTrue(solution.Query('l'));          // return true, because 'kl' is in the wordlist
        }

        [TestMethod]
        public void StreamCheckerTest_2()
        {
            var solution = new _1032_StreamOfCharacters(new string[] { "ab", "baa" });
            Assert.IsFalse(solution.Query('a'));
            Assert.IsTrue(solution.Query('b'));
            Assert.IsFalse(solution.Query('a'));
            Assert.IsTrue(solution.Query('a'));
        }

        [TestMethod]
        [Timeout(100)]
        public void StreamCheckerTest_3()
        {
            var input = new string[500];
            for (int i = 0; i < 500; i++)
                input[i] = new string('a', 1000 + i) + "b";

            var solution = new _1032_StreamOfCharacters(input);

            for (int i = 0; i < 5000; i++)
                Assert.IsFalse(solution.Query('a'));
        }
    }
}
