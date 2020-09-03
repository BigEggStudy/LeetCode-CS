//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/343614888/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _1271_Hexspeak
    {
        public string alphabet = "OI23456789ABCDEF";

        public string ToHexspeak(string num)
        {
            var number = long.Parse(num);

            var sb = new StringBuilder();
            while (number > 0)
            {
                var curr = (int)(number % 16);
                if (curr > 1 && curr < 10) return "ERROR";

                sb.Insert(0, alphabet[curr]);

                number /= 16;
            }

            return sb.ToString();
        }
    }
}
