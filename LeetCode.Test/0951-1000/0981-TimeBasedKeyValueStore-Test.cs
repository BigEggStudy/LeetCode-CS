using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0981_TimeBasedKeyValueStore_Test
    {
        [TestMethod]
        public void TimeMapTest_1()
        {
            var solution = new _0981_TimeBasedKeyValueStore();
            solution.Set("foo", "bar", 1);
            Assert.AreEqual("bar", solution.Get("foo", 1));
            Assert.AreEqual("bar", solution.Get("foo", 3));
            solution.Set("foo", "bar2", 4);
            Assert.AreEqual("bar2", solution.Get("foo", 4));
            Assert.AreEqual("bar2", solution.Get("foo", 5));
        }

        [TestMethod]
        public void TimeMapTest_2()
        {
            var solution = new _0981_TimeBasedKeyValueStore();
            solution.Set("love", "high", 10);
            solution.Set("love", "low", 20);
            Assert.AreEqual(string.Empty, solution.Get("love", 5));
            Assert.AreEqual("high", solution.Get("love", 10));
            Assert.AreEqual("high", solution.Get("love", 15));
            Assert.AreEqual("low", solution.Get("love", 20));
            Assert.AreEqual("low", solution.Get("love", 25));
        }
    }
}
