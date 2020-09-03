using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0134_GasStation_Test
    {
        [TestMethod]
        public void CanCompleteCircuit_1()
        {
            var solution = new _0134_GasStation();
            var result = solution.CanCompleteCircuit(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CanCompleteCircuit_2()
        {
            var solution = new _0134_GasStation();
            var result = solution.CanCompleteCircuit(new int[] { 2, 3, 4 }, new int[] { 3, 4, 3 });
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CanCompleteCircuit_3()
        {
            var solution = new _0134_GasStation();
            var result = solution.CanCompleteCircuit(new int[] { 5, 1, 2, 3, 4 }, new int[] { 4, 4, 1, 5, 1 });
            Assert.AreEqual(4, result);
        }
    }
}
