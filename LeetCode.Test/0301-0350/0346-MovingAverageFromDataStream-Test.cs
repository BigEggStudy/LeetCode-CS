using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0346_MovingAverageFromDataStream_Test
    {
        [TestMethod]
        public void Next_1()
        {
            var solution = new _0346_MovingAverageFromDataStream(3);
            var result = solution.Next(1);
            Assert.AreEqual(1, result);

            result = solution.Next(10);
            Assert.AreEqual(5.5, result);

            result = solution.Next(3);
            Assert.AreEqual(4.66666666666667, result, 0.000001);

            result = solution.Next(5);
            Assert.AreEqual(6, result);
        }
    }
}
