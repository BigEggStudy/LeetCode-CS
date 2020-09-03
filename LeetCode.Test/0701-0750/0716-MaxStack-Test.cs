using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0716_MaxStack_Test
    {
        [TestMethod]
        public void MaxStackTest()
        {
            var stack = new _0716_MaxStack();
            stack.Push(5);
            stack.Push(1);
            stack.Push(5);
            Assert.AreEqual(5, stack.Top());
            Assert.AreEqual(5, stack.PopMax());
            Assert.AreEqual(1, stack.Top());
            Assert.AreEqual(5, stack.PeekMax());
            Assert.AreEqual(1, stack.Pop());
            Assert.AreEqual(5, stack.Top());
        }

        [TestMethod]
        public void MaxStackTest_2()
        {
            var stack = new _0716_MaxStack();
            stack.Push(5);
            stack.Push(1);
            Assert.AreEqual(5, stack.PopMax());
            Assert.AreEqual(1, stack.Top());
            Assert.AreEqual(1, stack.PeekMax());
        }
    }
}
