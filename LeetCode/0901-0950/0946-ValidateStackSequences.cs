//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 26.5 MB
// Link: https://leetcode.com/submissions/detail/370219905/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0946_ValidateStackSequences
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            var popIndex = 0;
            var stack = new Stack<int>();
            foreach (var num in pushed)
            {
                stack.Push(num);
                while (stack.Count > 0 && stack.Peek() == popped[popIndex])
                {
                    stack.Pop();
                    popIndex++;
                }
            }

            return popIndex == popped.Length;
        }
    }
}
