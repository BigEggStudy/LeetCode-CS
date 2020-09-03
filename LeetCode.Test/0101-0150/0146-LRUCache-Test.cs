using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0146_LRUCache_Test
    {
        [TestMethod]
        public void LRUCacheTest()
        {
            var cache = new _0146_LRUCache(2 /* capacity */ );

            cache.Put(1, 1);
            cache.Put(2, 2);
            var result = cache.Get(1);      // returns 1
            Assert.AreEqual(1, result);
            cache.Put(3, 3);    // evicts key 2
            result = cache.Get(2);          // returns -1 (not found)
            Assert.AreEqual(-1, result);
            cache.Put(4, 4);    // evicts key 1
            result = cache.Get(1);          // returns -1 (not found)
            Assert.AreEqual(-1, result);
            result = cache.Get(3);          // returns 3
            Assert.AreEqual(3, result);
            result = cache.Get(4);          // returns 4
            Assert.AreEqual(4, result);
        }
    }
}
