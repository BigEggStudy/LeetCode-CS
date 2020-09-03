using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0877_StoneGame_Test
    {
        [TestMethod]
        public void StoneGame_1()
        {
            var solution = new _0877_StoneGame();
            var result = solution.StoneGame(new int[] { 5, 3, 4, 5 });
            Assert.IsTrue(result);
        }
    }
}
