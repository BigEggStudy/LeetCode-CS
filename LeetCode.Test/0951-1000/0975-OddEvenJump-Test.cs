using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0975_OddEvenJump_Test
    {
        [TestMethod]
        public void OddEvenJumpsTest_1()
        {
            var solution = new _0975_OddEvenJump();
            Assert.AreEqual(2, solution.OddEvenJumps(new int[] { 10, 13, 12, 14, 15 }));
        }

        [TestMethod]
        public void OddEvenJumpsTest_2()
        {
            var solution = new _0975_OddEvenJump();
            Assert.AreEqual(3, solution.OddEvenJumps(new int[] { 2, 3, 1, 1, 4 }));
        }

        [TestMethod]
        public void OddEvenJumpsTest_3()
        {
            var solution = new _0975_OddEvenJump();
            Assert.AreEqual(3, solution.OddEvenJumps(new int[] { 5, 1, 3, 4, 2 }));
        }

        [TestMethod]
        public void OddEvenJumpsTest_OneItem()
        {
            var solution = new _0975_OddEvenJump();
            Assert.AreEqual(1, solution.OddEvenJumps(new int[] { 1 }));
        }

        [TestMethod]
        public void OddEvenJumpsTest_NotPosible()
        {
            var solution = new _0975_OddEvenJump();
            Assert.AreEqual(1, solution.OddEvenJumps(new int[] { 5, 1 }));
        }
    }
}
