//-----------------------------------------------------------------------------
// Runtime: 272ms
// Memory Usage: 33 MB
// Link: https://leetcode.com/submissions/detail/372042707/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0636_ExclusiveTimeOfFunctions
    {
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            var stack = new Stack<int>();
            var result = new int[n];

            var start = 0;
            foreach (var log in logs)
            {
                var str = log.Split(':');
                var id = int.Parse(str[0]);
                var time = int.Parse(str[2]);
                if (str[1] == "start")
                {
                    if (stack.Count > 0)
                        result[stack.Peek()] += time - start;
                    stack.Push(id);
                    start = time;
                }
                else
                {
                    result[stack.Peek()] += time - start + 1;
                    stack.Pop();
                    start = time + 1;
                }
            }

            return result;
        }
    }
}
