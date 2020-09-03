using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1025_DivisorGame_Test
    {
        [TestMethod]
        public void DivisorGame_1()
        {
            var solution = new _1025_DivisorGame();
            var result = solution.DivisorGame(1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DivisorGame_2()
        {
            var solution = new _1025_DivisorGame();
            var result = solution.DivisorGame(2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DivisorGame_3()
        {
            var solution = new _1025_DivisorGame();
            var result = solution.DivisorGame(3);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DivisorGame_4()
        {
            var solution = new _1025_DivisorGame();
            var result = solution.DivisorGame(4);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DivisorGame_5()
        {
            var solution = new _1025_DivisorGame();
            var result = solution.DivisorGame(5);
            Assert.IsFalse(result);
        }
    }
}
