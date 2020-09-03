//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 35.6 MB
// Link: https://leetcode.com/submissions/detail/381388417/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0484_FindPermutation
    {
        public int[] FindPermutation(string s)
        {
            var result = new int[s.Length + 1];
            result[0] = 1;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                    result[i + 1] = i + 2;
                else
                {
                    var j = i;
                    while (i < s.Length && s[i] == 'D')
                        i++;
                    for (int k = j, num = i + 1; k <= i; k++, num--)
                        result[k] = num;
                    i--;
                }
            }

            return result;
        }
    }
}
