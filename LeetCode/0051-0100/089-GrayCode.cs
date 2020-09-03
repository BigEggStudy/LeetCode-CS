//-----------------------------------------------------------------------------
// Runtime: 288ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _089_GrayCode
    {
        public IList<int> GrayCode(int n)
        {
            var result = new List<int>() { 0 };
            if (n == 0) return result;
            result.Add(1);
            var pointer = 1;

            while (pointer < n)
            {
                var value = 1 << pointer;
                for (var i = result.Count - 1; i >= 0; i--)
                {
                    result.Add(value + result[i]);
                }
                pointer++;
            }

            return result;
        }
    }
}
