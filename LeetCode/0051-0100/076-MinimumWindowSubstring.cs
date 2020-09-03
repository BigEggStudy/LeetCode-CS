//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 25.6 MB
// Link: https://leetcode.com/submissions/detail/378572790/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _076_MinimumWindowSubstring
    {
        public string MinWindow(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || t.Length > s.Length) { return string.Empty; }

            var counts = new int[256];
            foreach (var ch in t)
                counts[ch]++;

            var remaining = t.Length;
            int left = 0, right = 0, minStart = 0, minLength = int.MaxValue;
            while (right < s.Length)
            {
                if (--counts[s[right++]] >= 0) remaining--;
                while (remaining == 0)
                {
                    if (right - left < minLength)
                    {
                        minLength = right - left;
                        minStart = left;
                    }
                    if (++counts[s[left++]] > 0) remaining++;
                }
                if (minLength == t.Length)
                    break;
            }

            return minLength == int.MaxValue ? string.Empty : s.Substring(minStart, minLength);
        }
    }
}
