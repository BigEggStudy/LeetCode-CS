//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 25.5 MB
// Link: https://leetcode.com/submissions/detail/256634543/
//-----------------------------------------------------------------------------

using System.Text;

namespace LeetCode
{
    public class _0482_LicenseKeyFormatting
    {
        public string LicenseKeyFormatting(string S, int K)
        {
            S = S.ToUpper().Replace("-", "");
            var sb = new StringBuilder();
            var groupSize = S.Length % K;
            if (groupSize == 0) groupSize = K;

            for (int i = 0; i < S.Length; i++)
            {
                if (groupSize == 0)
                {
                    sb.Append("-");
                    groupSize = K;
                }

                sb.Append(S[i]);
                groupSize--;
            }

            return sb.ToString();
        }
    }
}
