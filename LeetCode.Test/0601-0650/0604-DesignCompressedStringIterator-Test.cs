using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0604_DesignCompressedStringIterator_Test
    {
        [TestMethod]
        public void DesignCompressedStringIterator_1()
        {
            var solution = new _0604_DesignCompressedStringIterator("L1e2t1C1o1d1e1");

            Assert.AreEqual('L', solution.Next());
            Assert.AreEqual('e', solution.Next());
            Assert.AreEqual('e', solution.Next());
            Assert.AreEqual('t', solution.Next());
            Assert.AreEqual('C', solution.Next());
            Assert.AreEqual('o', solution.Next());
            Assert.AreEqual('d', solution.Next());
            Assert.IsTrue(solution.HasNext());
            Assert.AreEqual('e', solution.Next());
            Assert.IsFalse(solution.HasNext());
            Assert.AreEqual(' ', solution.Next());
        }
    }
}
