//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 20.8 MB
// Link: https://leetcode.com/submissions/detail/339601732/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /*
    // Definition for Employee.
    class Employee {
        public int id;
        public int importance;
        public IList<int> subordinates;
    }
    */

    public class _0690_EmployeeImportance
    {
        public int GetImportance(IList<Employee> employees, int id)
        {
            var map = employees.ToDictionary(e => e.id, e => e);
            return DFS(map, id);
        }

        private int DFS(IDictionary<int, Employee> map, int id)
        {
            var result = map[id].importance;
            foreach (var subId in map[id].subordinates)
                result += DFS(map, subId);
            return result;
        }

        public class Employee
        {
            public int id;
            public int importance;
            public IList<int> subordinates;
        }
    }
}
