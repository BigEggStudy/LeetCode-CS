using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0777_SwapAdjacentInLRString_Test
    {
        [TestMethod]
        public void CanTransformTest()
        {
            var solution = new _0777_SwapAdjacentInLRString();
            var result = solution.CanTransform("RXXLRXRXL", "XRLXXRRLX");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanTransformTest_2()
        {
            var solution = new _0777_SwapAdjacentInLRString();
            var result = solution.CanTransform("X", "L");
            Assert.IsFalse(result);
        }
    }
}
