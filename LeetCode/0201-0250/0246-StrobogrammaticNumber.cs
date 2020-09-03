//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 21.6 MB
// Link: https://leetcode.com/submissions/detail/352418430/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0246_StrobogrammaticNumber
    {
        public bool IsStrobogrammatic(string num)
        {
            int i = 0, j = num.Length - 1;
            while (i <= j)
            {
                if ((num[i] == '0' && num[j] == '0') ||
                    (num[i] == '1' && num[j] == '1') ||
                    (num[i] == '8' && num[j] == '8') ||
                    (num[i] == '6' && num[j] == '9') ||
                    (num[i] == '9' && num[j] == '6'))
                {
                    i++;
                    j--;
                }
                else
                    return false;
            }

            return true;
        }
    }
}
