using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0843_GuesstheWord_Test
    {
        [TestMethod]
        public void FindSecretWordTest()
        {
            var wordlist = new string[] { "acckzz", "ccbazz", "eiowzz", "abcczz" };
            var master = new Master("acckzz", wordlist);

            var solution = new _0843_GuesstheWord();
            solution.FindSecretWord(wordlist, master);

            Assert.IsTrue(master.GuessCount <= 10);
        }
    }
}
