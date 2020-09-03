using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1108_DefangingAnIPAddress_Test
    {
        [TestMethod]
        public void DefangIPaddr_1()
        {
            var solution = new _1108_DefangingAnIPAddress();
            var result = solution.DefangIPaddr("1.1.1.1");
            Assert.AreEqual("1[.]1[.]1[.]1", result);
        }

        [TestMethod]
        public void DefangIPaddr_2()
        {
            var solution = new _1108_DefangingAnIPAddress();
            var result = solution.DefangIPaddr("255.100.50.0");
            Assert.AreEqual("255[.]100[.]50[.]0", result);
        }
    }
}
