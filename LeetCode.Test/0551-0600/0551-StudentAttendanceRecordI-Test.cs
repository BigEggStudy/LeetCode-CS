using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _0551_StudentAttendanceRecordI_Test
    {
        [TestMethod]
        public void CheckRecord_1()
        {
            var solution = new _0551_StudentAttendanceRecordI();
            var result = solution.CheckRecord("PPALLP");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckRecord_2()
        {
            var solution = new _0551_StudentAttendanceRecordI();
            var result = solution.CheckRecord("PPALLL");
            Assert.IsFalse(result);
        }
    }
}
