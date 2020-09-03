using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1323_Maximum69Numberr_Test
    {
        [TestMethod]
        public void Maximum69Number_1()
        {
            var solution = new _1323_Maximum69Numberr();
            var result = solution.Maximum69Number(9669);
            Assert.AreEqual(9969, result);
        }

        [TestMethod]
        public void Maximum69Number_2()
        {
            var solution = new _1323_Maximum69Numberr();
            var result = solution.Maximum69Number(9996);
            Assert.AreEqual(9999, result);
        }

        [TestMethod]
        public void Maximum69Number_3()
        {
            var solution = new _1323_Maximum69Numberr();
            var result = solution.Maximum69Number(9999);
            Assert.AreEqual(9999, result);
        }
    }
}
