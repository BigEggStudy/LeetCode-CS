//-----------------------------------------------------------------------------
// Runtime: 264ms
// Memory Usage: 33 MB
// Link: https://leetcode.com/submissions/detail/373718130/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0735_AsteroidCollision
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var stack = new Stack<int>();
            foreach (var asteroid in asteroids)
            {
                var explodeBoth = false;

                while (stack.Count > 0 && asteroid < 0 && stack.Peek() > 0)
                {
                    if (stack.Peek() + asteroid < 0)
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (stack.Peek() + asteroid == 0)
                        stack.Pop();

                    explodeBoth = true;
                    break;
                }

                if (!explodeBoth)
                    stack.Push(asteroid);
            }

            var result = new int[stack.Count];
            for (int i = stack.Count - 1; i >= 0; i--)
                result[i] = stack.Pop();

            return result;
        }
    }
}
