using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1281_SubtractTheProductAndSumOfDigitsOfAnInteger_Test
    {
        [TestMethod]
        public void SubtractProductAndSum_1()
        {
            var solution = new _1281_SubtractTheProductAndSumOfDigitsOfAnInteger();
            var result = solution.SubtractProductAndSum(234);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void SubtractProductAndSum_2()
        {
            var solution = new _1281_SubtractTheProductAndSumOfDigitsOfAnInteger();
            var result = solution.SubtractProductAndSum(4421);
            Assert.AreEqual(21, result);
        }
    }
}
