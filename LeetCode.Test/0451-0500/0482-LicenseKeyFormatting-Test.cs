using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0482_LicenseKeyFormatting_Test
    {
        [TestMethod]
        public void LicenseKeyFormattingTest_1()
        {
            var solution = new _0482_LicenseKeyFormatting();
            var result = solution.LicenseKeyFormatting("5F3Z-2e-9-w", 4);
            Assert.AreEqual("5F3Z-2E9W", result);
        }

        [TestMethod]
        public void LicenseKeyFormattingTest_2()
        {
            var solution = new _0482_LicenseKeyFormatting();
            var result = solution.LicenseKeyFormatting("2-5g-3-J", 2);
            Assert.AreEqual("2-5G-3J", result);
        }
    }
}
