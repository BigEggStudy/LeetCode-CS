using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1344_AngleBetweenHandsOfAClock_Test
    {
        [TestMethod]
        public void AngleClock_1()
        {
            var solution = new _1344_AngleBetweenHandsOfAClock();
            var result = solution.AngleClock(12, 30);
            Assert.AreEqual(165, result);
        }

        [TestMethod]
        public void AngleClock_2()
        {
            var solution = new _1344_AngleBetweenHandsOfAClock();
            var result = solution.AngleClock(3, 30);
            Assert.AreEqual(75, result);
        }

        [TestMethod]
        public void AngleClock_3()
        {
            var solution = new _1344_AngleBetweenHandsOfAClock();
            var result = solution.AngleClock(3, 15);
            Assert.AreEqual(7.5, result);
        }

        [TestMethod]
        public void AngleClock_4()
        {
            var solution = new _1344_AngleBetweenHandsOfAClock();
            var result = solution.AngleClock(4, 50);
            Assert.AreEqual(155, result);
        }

        [TestMethod]
        public void AngleClock_5()
        {
            var solution = new _1344_AngleBetweenHandsOfAClock();
            var result = solution.AngleClock(12, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AngleClock_6()
        {
            var solution = new _1344_AngleBetweenHandsOfAClock();
            var result = solution.AngleClock(1, 57);
            Assert.AreEqual(76.5, result);
        }
    }
}
