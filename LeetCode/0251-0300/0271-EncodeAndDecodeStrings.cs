//-----------------------------------------------------------------------------
// Runtime: 284ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0271_EncodeAndDecodeStrings
    {
        // Encodes a list of strings to a single string.
        public string encode(IList<string> strs)
        {
            var sb = new StringBuilder();
            foreach (var str in strs)
            {
                sb.Append(IntToString(str.Length));
                sb.Append(str);
            }
            return sb.ToString();
        }

        // Decodes a single string to a list of strings.
        public IList<string> decode(string s)
        {
            var index = 0;
            var result = new List<string>();
            while (index < s.Length)
            {
                var length = StringToint(s.Substring(index, 4));
                index += 4;
                result.Add(s.Substring(index, length));
                index += length;
            }

            return result;
        }


        private string IntToString(int num)
        {
            var bytes = new char[4];
            for (int i = 3; i >= 0; i--)
                bytes[3 - i] = (char)(num >> (i * 8) & 0xff);

            return new string(bytes);
        }

        private int StringToint(string num)
        {
            var result = 0;
            foreach (var ch in num)
                result = (result << 8) + (int)ch;
            return result;
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.decode(codec.encode(strs));
}
