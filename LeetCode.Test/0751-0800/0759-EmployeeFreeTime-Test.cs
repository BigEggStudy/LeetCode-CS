using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class _0759_EmployeeFreeTime_Test
    {
        [TestMethod]
        public void EmployeeFreeTime_1()
        {
            var schedule = new List<IList<Interval>>()
            {
                new List<Interval>() { new Interval(1, 2), new Interval(5, 6) },
                new List<Interval>() { new Interval(1, 3) },
                new List<Interval>() { new Interval(4, 10) },
            };

            var solution = new _0759_EmployeeFreeTime();
            var result = solution.EmployeeFreeTime(schedule);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(3, result[0].start);
            Assert.AreEqual(4, result[0].end);
        }

        [TestMethod]
        public void EmployeeFreeTime_2()
        {
            var schedule = new List<IList<Interval>>()
            {
                new List<Interval>() { new Interval(1, 3), new Interval(6, 7) },
                new List<Interval>() { new Interval(2, 4) },
                new List<Interval>() { new Interval(2, 5), new Interval(9, 12) },
            };

            var solution = new _0759_EmployeeFreeTime();
            var result = solution.EmployeeFreeTime(schedule);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(5, result[0].start);
            Assert.AreEqual(6, result[0].end);
            Assert.AreEqual(7, result[1].start);
            Assert.AreEqual(9, result[1].end);
        }
    }
}
