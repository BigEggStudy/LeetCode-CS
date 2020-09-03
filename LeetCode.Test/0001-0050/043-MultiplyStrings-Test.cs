using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _043_MultiplyStrings_Test
    {
        [TestMethod]
        public void MultiplyTest_SmallNumber()
        {
            var solution = new _043_MultiplyStrings();
            var result = solution.Multiply("123", "2");

            Assert.AreEqual("246", result);
        }

        [TestMethod]
        public void MultiplyTest_SmallNumber_2()
        {
            var solution = new _043_MultiplyStrings();
            var result = solution.Multiply("725071900", "6478");

            Assert.AreEqual("4697015768200", result);
        }

        [TestMethod]
        public void MultiplyTest_MultiplyZero()
        {
            var solution = new _043_MultiplyStrings();
            var result = solution.Multiply("123", "0");

            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void MultiplyTest_LargeNumber()
        {
            var solution = new _043_MultiplyStrings();
            var result = solution.Multiply("1234567890", "987654321");

            Assert.AreEqual("1219326311126352690", result);
        }

        [TestMethod]
        public void MultiplyTest_LargeNumber_2()
        {
            var solution = new _043_MultiplyStrings();
            var result = solution.Multiply("988644447352690", "988644447352690");

            Assert.AreEqual("977417843281305829149250236100", result);
        }
    }
}
