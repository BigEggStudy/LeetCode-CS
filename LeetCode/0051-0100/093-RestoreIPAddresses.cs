//-----------------------------------------------------------------------------
// Runtime: 292ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{

    public class _093_RestoreIPAddresses
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            var results = new List<string>();
            RestoreIpAddresses(s, 0, "", 0, results);
            return results;
        }

        private void RestoreIpAddresses(string s, int startIndex, string existedString, int depth, List<string> results)
        {
            if (startIndex == s.Length && depth == 4)
            {
                results.Add(existedString);
                return;
            }
            if (startIndex == s.Length || depth == 4) { return; }

            for (int i = 1; i < 4; i++)
            {
                if ((startIndex + i > s.Length) || (i == 2 && s[startIndex] == '0'))
                    break;
                if (i == 3)
                {
                    var num = int.Parse(s.Substring(startIndex, i));
                    if (num > 255)
                        break;
                }

                var newString = string.IsNullOrWhiteSpace(existedString)
                    ? s.Substring(startIndex, i)
                    : string.Join(".", existedString, s.Substring(startIndex, i));
                RestoreIpAddresses(s, startIndex + i, newString, depth + 1, results);
            }
        }
    }
}
