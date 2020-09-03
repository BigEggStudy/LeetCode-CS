using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0359_LoggerRateLimiter_Test
    {
        [TestMethod]
        public void LoggerTest()
        {
            var logger = new _0359_LoggerRateLimiter();

            // logging string "foo" at timestamp 1
            var result = logger.ShouldPrintMessage(1, "foo");
            Assert.IsTrue(result);

            // logging string "bar" at timestamp 2
            result = logger.ShouldPrintMessage(2, "bar");
            Assert.IsTrue(result);

            // logging string "foo" at timestamp 3
            result = logger.ShouldPrintMessage(3, "foo");
            Assert.IsFalse(result);

            // logging string "bar" at timestamp 8
            result = logger.ShouldPrintMessage(8, "bar");
            Assert.IsFalse(result);

            // logging string "foo" at timestamp 10
            result = logger.ShouldPrintMessage(10, "foo");
            Assert.IsFalse(result);

            // logging string "foo" at timestamp 11
            result = logger.ShouldPrintMessage(11, "foo");
            Assert.IsTrue(result);
        }
    }
}
