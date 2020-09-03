using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1381_DesignAStackWithIncrementOperation_Test
    {
        [TestMethod]
        public void DesignAStackWithIncrementOperation_1()
        {
            var customStack = new _1381_DesignAStackWithIncrementOperation(3);

            customStack.Push(1);
            customStack.Push(2);
            Assert.AreEqual(2, customStack.Pop());
            customStack.Push(2);
            customStack.Push(3);
            customStack.Push(4);
            customStack.Increment(5, 100);
            customStack.Increment(2, 100);
            Assert.AreEqual(103, customStack.Pop());
            Assert.AreEqual(202, customStack.Pop());
            Assert.AreEqual(201, customStack.Pop());
            Assert.AreEqual(-1, customStack.Pop());
        }
    }
}
