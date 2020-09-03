using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0895_MaximumFrequencyStack_Test
    {
        [TestMethod]
        public void FreqStackTest()
        {
            var freqStack = new _0895_MaximumFrequencyStack();

            freqStack.Push(5);
            freqStack.Push(7);
            freqStack.Push(5);
            freqStack.Push(7);
            freqStack.Push(4);
            freqStack.Push(5);
            Assert.AreEqual(5, freqStack.Pop());
            Assert.AreEqual(7, freqStack.Pop());
            Assert.AreEqual(5, freqStack.Pop());
            Assert.AreEqual(4, freqStack.Pop());
        }
    }
}
