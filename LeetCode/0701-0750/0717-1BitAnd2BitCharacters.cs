//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.8 MB
// Link: https://leetcode.com/submissions/detail/345125910/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0717_1BitAnd2BitCharacters
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            int i = 0;
            for (; i < bits.Length; i++)
            {
                if (bits[i] == 1) i++;
                else
                {
                    if (i == bits.Length - 1)
                        return true;
                }
            }

            return false;
        }
    }
}
