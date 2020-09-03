//-----------------------------------------------------------------------------
// Runtime: 220ms
// Memory Usage: 28.4 MB
// Link: https://leetcode.com/submissions/detail/260940023/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0338_CountingBits
    {
        public int[] CountBits(int num)
        {
            var result = new int[num + 1];
            int b = 1;
            while (b <= num)
            {
                var i = 0;
                while (i < b && b + i <= num)
                {
                    result[i + b] = result[i] + 1;
                    i++;
                }

                b <<= 1;
            }

            return result;
        }
    }
}
