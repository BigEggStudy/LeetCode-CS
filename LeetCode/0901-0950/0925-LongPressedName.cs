//-----------------------------------------------------------------------------
// Runtime: 72ms
// Memory Usage: 22.1 MB
// Link: https://leetcode.com/submissions/detail/352808891/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0925_LongPressedName
    {
        public bool IsLongPressedName(string name, string typed)
        {
            int i = 0, j = 0;
            while (i < name.Length && j < typed.Length)
            {
                if (name[i] == typed[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    if (j > 0 && typed[j] == typed[j - 1])
                        j++;
                    else
                        return false;
                }
            }

            while (j < typed.Length && j > 0 && typed[j] == typed[j - 1])
                j++;

            return i == name.Length && j == typed.Length;
        }
    }
}
