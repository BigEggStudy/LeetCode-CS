using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0401_BinaryWatch_Test
    {
        [TestMethod]
        public void ReadBinaryWatch_1()
        {
            var solution = new _0401_BinaryWatch();
            var result = solution.ReadBinaryWatch(1);
            AssertHelper.AssertList(new string[] { "0:01", "0:02", "0:04", "0:08", "0:16", "0:32", "1:00", "2:00", "4:00", "8:00" }, result);
        }
    }
}
