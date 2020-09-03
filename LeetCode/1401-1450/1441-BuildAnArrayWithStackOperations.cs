//-----------------------------------------------------------------------------
// Runtime: 384ms
// Memory Usage: 32.6 MB
// Link: https://leetcode.com/submissions/detail/337419741/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1441_BuildAnArrayWithStackOperations
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            var result = new List<string>();
            var currentValue = 1;
            for (int i = 0; i < target.Length; i++, currentValue++)
            {
                while (target[i] != currentValue)
                {
                    result.Add("Push");
                    result.Add("Pop");
                    currentValue++;
                }
                result.Add("Push");
            }

            return result;
        }
    }
}
