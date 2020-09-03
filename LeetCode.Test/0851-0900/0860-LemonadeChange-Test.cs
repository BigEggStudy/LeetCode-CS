using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0860_LemonadeChange_Test
    {
        [TestMethod]
        public void LemonadeChange_1()
        {
            var solution = new _0860_LemonadeChange();
            var result = solution.LemonadeChange(new int[] { 5, 5, 5, 10, 20 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LemonadeChange_2()
        {
            var solution = new _0860_LemonadeChange();
            var result = solution.LemonadeChange(new int[] { 5, 5, 10 });
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LemonadeChange_3()
        {
            var solution = new _0860_LemonadeChange();
            var result = solution.LemonadeChange(new int[] { 10, 10 });
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LemonadeChange_4()
        {
            var solution = new _0860_LemonadeChange();
            var result = solution.LemonadeChange(new int[] { 5, 5, 10, 10, 20 });
            Assert.IsFalse(result);
        }
    }
}
