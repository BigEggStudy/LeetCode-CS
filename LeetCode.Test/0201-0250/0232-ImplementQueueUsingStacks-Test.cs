using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0232_ImplementQueueUsingStacks_Test
    {
        [TestMethod]
        public void ImplementQueueUsingStacks_1()
        {
            var solution = new _0232_ImplementQueueUsingStacks();
            solution.Push(1);
            solution.Push(2);
            Assert.AreEqual(1, solution.Peek());
            Assert.AreEqual(1, solution.Pop());
            Assert.IsFalse(solution.Empty());
        }
    }
}
