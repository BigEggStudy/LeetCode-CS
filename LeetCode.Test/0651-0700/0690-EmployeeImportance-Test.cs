using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode._0690_EmployeeImportance;

namespace LeetCode.Test
{
    [TestClass]
    public class _0690_EmployeeImportance_Test
    {
        [TestMethod]
        public void GetImportance_1()
        {
            var employees = new List<Employee>();
            employees.Add(new Employee()
            {
                id = 1,
                importance = 5,
                subordinates = new int[] { 2, 3 }
            });
            employees.Add(new Employee()
            {
                id = 2,
                importance = 3,
                subordinates = new int[] { }
            });
            employees.Add(new Employee()
            {
                id = 3,
                importance = 3,
                subordinates = new int[] { }
            });

            var solution = new _0690_EmployeeImportance();
            var result = solution.GetImportance(employees, 1);
            Assert.AreEqual(11, result);
        }
    }
}
