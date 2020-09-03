//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 27.1 MB
// Link: https://leetcode.com/submissions/detail/372912819/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0403_FrogJump
    {
        public bool CanCross(int[] stones)
        {
            var seen = new HashSet<(int location, int step)>();
            var stonesSet = new HashSet<int>(stones);

            var last = stones[stones.Length - 1];

            var stack = new Stack<(int location, int step)>();
            stack.Push((0, 0));
            while (stack.Count > 0)
            {
                (int location, int step) = stack.Pop();
                if (seen.Contains((location, step))) continue;
                seen.Add((location, step));

                if (location == last) return true;
                else if (location < last)
                {
                    for (int i = step - 1; i < step + 2; i++)
                    {
                        if (i <= 0) continue;
                        if (stonesSet.Contains(location + i))
                            stack.Push((location + i, i));
                    }
                }
            }

            return false;
        }
    }
}
