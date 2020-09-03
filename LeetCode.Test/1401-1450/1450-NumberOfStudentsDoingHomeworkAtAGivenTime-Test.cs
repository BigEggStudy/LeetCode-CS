using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1450_NumberOfStudentsDoingHomeworkAtAGivenTime_Test
    {
        [TestMethod]
        public void BusyStudent_1()
        {
            var solution = new _1450_NumberOfStudentsDoingHomeworkAtAGivenTime();
            var result = solution.BusyStudent(new int[] { 1, 2, 3 }, new int[] { 3, 2, 7 }, 4);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void BusyStudent_2()
        {
            var solution = new _1450_NumberOfStudentsDoingHomeworkAtAGivenTime();
            var result = solution.BusyStudent(new int[] { 4 }, new int[] { 4 }, 4);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void BusyStudent_3()
        {
            var solution = new _1450_NumberOfStudentsDoingHomeworkAtAGivenTime();
            var result = solution.BusyStudent(new int[] { 4 }, new int[] { 4 }, 5);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void BusyStudent_4()
        {
            var solution = new _1450_NumberOfStudentsDoingHomeworkAtAGivenTime();
            var result = solution.BusyStudent(new int[] { 1, 1, 1, 1 }, new int[] { 1, 3, 2, 4 }, 7);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void BusyStudent_5()
        {
            var solution = new _1450_NumberOfStudentsDoingHomeworkAtAGivenTime();
            var result = solution.BusyStudent(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10 }, 5);
            Assert.AreEqual(5, result);
        }
    }
}
