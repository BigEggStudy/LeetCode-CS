//-----------------------------------------------------------------------------
// Runtime: 344ms
// Memory Usage: 36.5 MB
// Link: https://leetcode.com/submissions/detail/369917460/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0370_RangeAddition
    {
        public int[] GetModifiedArray(int length, int[][] updates)
        {
            var result = new int[length];

            foreach (var update in updates)
            {
                result[update[0]] += update[2];
                if (update[1] + 1 < length)
                    result[update[1] + 1] -= update[2];
            }

            var sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += result[i];
                result[i] = sum;
            }

            return result;
        }
    }
}
