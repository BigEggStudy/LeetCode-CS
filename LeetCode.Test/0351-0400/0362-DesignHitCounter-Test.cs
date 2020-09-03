using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0362_DesignHitCounter_Test
    {
        [TestMethod]
        public void HitCounterTest_1()
        {
            var counter = new _0362_DesignHitCounter();

            // hit at timestamp 1.
            counter.Hit(1);

            // hit at timestamp 2.
            counter.Hit(2);

            // hit at timestamp 3.
            counter.Hit(3);

            // get hits at timestamp 4, should return 3.
            Assert.AreEqual(3, counter.GetHits(4));

            // hit at timestamp 300.
            counter.Hit(300);

            // get hits at timestamp 300, should return 4.
            Assert.AreEqual(4, counter.GetHits(300));

            // get hits at timestamp 301, should return 3.
            Assert.AreEqual(3, counter.GetHits(301));
        }
    }
}
