using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0155_MinStack_Test
    {
        [TestMethod]
        public void MinStackTest()
        {
            _0155_MinStack minStack = new _0155_MinStack();

            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);

            var result = minStack.GetMin();
            Assert.AreEqual(-3, result);

            minStack.Pop();
            result = minStack.Top();
            Assert.AreEqual(0, result);

            result = minStack.GetMin();
            Assert.AreEqual(-2, result);
        }
    }
}
