//-----------------------------------------------------------------------------
// Runtime: 144ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _065_ValidNumber
    {
        public bool IsNumber(string s)
        {
            bool hasPoint = false, hasE = false;

            int i = 0;
            while (i < s.Length && s[i] == ' ') i++;
            int end = s.Length - 1;
            while (end >= 0 && s[end] == ' ') end--;
            if (i >= s.Length) { return false; }
            if (s[i] == '+' || s[i] == '-') i++;

            var head = i;
            char ch;
            for (; i <= end; i++)
            {
                ch = s[i];
                if (ch == '.')
                {
                    if (hasPoint || hasE) { return false; }
                    if (i == head && i == end) { return false; }
                    if (i == head && i < end && (s[i + 1] > '9' || s[i + 1] < '0')) { return false; }
                    hasPoint = true;
                }
                else if (ch == 'e' || ch == 'E')
                {
                    if (hasE || i == head) { return false; }
                    if (i < end && (s[i + 1] == '+' || s[i + 1] == '-')) i++;
                    if (i >= end) { return false; }

                    hasE = true;
                }
                else if (ch < '0' || ch > '9')
                    return false;
            }

            return true;
        }
    }
}
