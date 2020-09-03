using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class _1491_AverageSalaryExcludingTheMinimumAndMaximumSalary_Test
    {
        [TestMethod]
        public void Average_1()
        {
            var solution = new _1491_AverageSalaryExcludingTheMinimumAndMaximumSalary();
            var result = solution.Average(new int[] { 4000, 3000, 1000, 2000 });
            Assert.AreEqual(2500.00000, result);
        }

        [TestMethod]
        public void Average_2()
        {
            var solution = new _1491_AverageSalaryExcludingTheMinimumAndMaximumSalary();
            var result = solution.Average(new int[] { 1000, 2000, 3000 });
            Assert.AreEqual(2000.00000, result);
        }

        [TestMethod]
        public void Average_3()
        {
            var solution = new _1491_AverageSalaryExcludingTheMinimumAndMaximumSalary();
            var result = solution.Average(new int[] { 6000, 5000, 4000, 3000, 2000, 1000 });
            Assert.AreEqual(3500.00000, result);
        }

        [TestMethod]
        public void Average_4()
        {
            var solution = new _1491_AverageSalaryExcludingTheMinimumAndMaximumSalary();
            var result = solution.Average(new int[] { 8000, 9000, 2000, 3000, 6000, 1000 });
            Assert.AreEqual(4750.00000, result);
        }
    }
}
