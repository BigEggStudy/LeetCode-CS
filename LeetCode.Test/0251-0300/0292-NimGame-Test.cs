using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0292_NimGame_Test
    {
        [TestMethod]
        public void CanWinNimTest()
        {
            var solution = new _0292_NimGame();
            Assert.IsTrue(solution.CanWinNim(1));
            Assert.IsTrue(solution.CanWinNim(2));
            Assert.IsTrue(solution.CanWinNim(3));
            Assert.IsFalse(solution.CanWinNim(4));
            Assert.IsTrue(solution.CanWinNim(5));
            Assert.IsTrue(solution.CanWinNim(6));
            Assert.IsTrue(solution.CanWinNim(7));
            Assert.IsFalse(solution.CanWinNim(8));
            Assert.IsTrue(solution.CanWinNim(9));
        }
    }
}
