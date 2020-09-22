//-----------------------------------------------------------------------------
// Runtime: 200ms
// Memory Usage: 25.8 MB
// Link: https://leetcode.com/submissions/detail/394731091/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0216_CombinationSumIII
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            var results = new List<IList<int>>();
            Helper(0, k, n, new List<int>(), results);
            return results;
        }

        private void Helper(int index, int k, int n, IList<int> current, IList<IList<int>> results)
        {
            if (current.Count == k && n == 0)
            {
                results.Add(current);
                return;
            }
            if (index >= k || n < 0) return;

            var start = index == 0 ? 1 : current.Last() + 1;
            for (int i = start; i <= n && i < 10; i++)
            {
                var newList = new List<int>(current);
                newList.Add(i);
                Helper(index + 1, k, n - i, newList, results);
            }
        }
    }
}