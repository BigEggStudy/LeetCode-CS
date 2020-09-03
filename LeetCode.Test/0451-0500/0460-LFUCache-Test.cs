using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0460_LFUCache_Test
    {
        [TestMethod]
        public void LFUCache_1()
        {
            _0460_LFUCache cache = new _0460_LFUCache(2);

            cache.Put(1, 1);
            cache.Put(2, 2);
            Assert.AreEqual(1, cache.Get(1));
            cache.Put(3, 3);
            Assert.AreEqual(-1, cache.Get(2));
            Assert.AreEqual(3, cache.Get(3));
            cache.Put(4, 4);
            Assert.AreEqual(-1, cache.Get(1));
            Assert.AreEqual(3, cache.Get(3));
            Assert.AreEqual(4, cache.Get(4));
        }

        [TestMethod]
        public void LFUCache_2()
        {
            _0460_LFUCache cache = new _0460_LFUCache(2);

            cache.Put(2, 1);
            Assert.AreEqual(1, cache.Get(2));
        }

        [TestMethod]
        public void LFUCache_3()
        {
            _0460_LFUCache cache = new _0460_LFUCache(2);

            cache.Put(3, 1);
            cache.Put(2, 1);
            cache.Put(2, 2);
            cache.Put(4, 4);
            Assert.AreEqual(2, cache.Get(2));
        }
    }
}
