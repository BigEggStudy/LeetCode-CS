//-----------------------------------------------------------------------------
// Runtime: 288ms
// Memory Usage: 44.8 MB
// Link: https://leetcode.com/submissions/detail/368567689/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1238_CircularPermutationInBinaryRepresentation
    {
        public IList<int> CircularPermutation(int n, int start)
        {
            var result = new List<int>();
            result.Add(start);

            var queue = new Queue<int>();
            queue.Enqueue(start);

            var visited = new HashSet<int>() { start };
            while (queue.Count > 0)
            {
                var temp = queue.Dequeue();
                int mask = 1;

                for (int i = 0; i < n; i++)
                {
                    int m = mask << i;
                    int num = temp ^ m;
                    if (!visited.Contains(num))
                    {
                        queue.Enqueue(num);
                        visited.Add(num);
                        result.Add(num);
                        break;
                    }
                }
            }

            return result;
        }
    }
}
