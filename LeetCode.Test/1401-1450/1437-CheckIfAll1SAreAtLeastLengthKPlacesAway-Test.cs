using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1437_CheckIfAll1SAreAtLeastLengthKPlacesAway_Test
    {
        [TestMethod]
        public void KLengthApart_1()
        {
            var solution = new _1437_CheckIfAll1SAreAtLeastLengthKPlacesAway();
            var result = solution.KLengthApart(new int[] { 1, 0, 0, 0, 1, 0, 0, 1 }, 2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void KLengthApart_2()
        {
            var solution = new _1437_CheckIfAll1SAreAtLeastLengthKPlacesAway();
            var result = solution.KLengthApart(new int[] { 1, 0, 0, 1, 0, 1 }, 2);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void KLengthApart_3()
        {
            var solution = new _1437_CheckIfAll1SAreAtLeastLengthKPlacesAway();
            var result = solution.KLengthApart(new int[] { 1, 1, 1, 1, 1 }, 0);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void KLengthApart_4()
        {
            var solution = new _1437_CheckIfAll1SAreAtLeastLengthKPlacesAway();
            var result = solution.KLengthApart(new int[] { 0, 1, 0, 1 }, 1);
            Assert.IsTrue(result);
        }
    }
}
