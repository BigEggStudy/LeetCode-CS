//-----------------------------------------------------------------------------
// Runtime: 264ms
// Memory Usage: 33 MB
// Link: https://leetcode.com/submissions/detail/352950804/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _0443_StringCompression
    {
        public int Compress(char[] chars)
        {
            int index = 0, count = 0;
            char current = chars[0];
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == current)
                    count++;
                else
                {
                    chars[index++] = current;

                    if (count > 1)
                    {
                        var countStr = count.ToString();
                        foreach (var ch in countStr)
                            chars[index++] = ch;
                    }

                    current = chars[i];
                    count = 1;
                }
            }

            chars[index++] = current;
            if (count > 1)
            {
                var countStr = count.ToString();
                foreach (var ch in countStr)
                    chars[index++] = ch;
            }

            return index;
        }
    }
}
