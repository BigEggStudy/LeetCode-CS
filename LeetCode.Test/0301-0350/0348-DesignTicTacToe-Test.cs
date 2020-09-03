using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0348_DesignTicTacToe_Test
    {
        [TestMethod]
        public void TicTacToe_1()
        {
            var toe = new _0348_DesignTicTacToe(3);

            Assert.AreEqual(0, toe.Move(0, 0, 1));
            Assert.AreEqual(0, toe.Move(0, 2, 2));
            Assert.AreEqual(0, toe.Move(2, 2, 1));
            Assert.AreEqual(0, toe.Move(1, 1, 2));
            Assert.AreEqual(0, toe.Move(2, 0, 1));
            Assert.AreEqual(0, toe.Move(1, 0, 2));
            Assert.AreEqual(1, toe.Move(2, 1, 1));
        }
    }
}
