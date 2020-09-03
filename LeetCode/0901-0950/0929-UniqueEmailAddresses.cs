//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 26.6 MB
// Link: https://leetcode.com/submissions/detail/257155145/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0929_UniqueEmailAddresses
    {
        public int NumUniqueEmails(string[] emails)
        {
            var hashSet = new HashSet<string>();

            foreach (var email in emails)
            {
                var at_index = email.IndexOf('@');
                var local = email.Substring(0, at_index);
                var domain = email.Substring(at_index);

                var plus_index = local.IndexOf('+');
                if (plus_index >= 0)
                    local = local.Substring(0, plus_index);
                local = local.Replace(".", "");

                hashSet.Add(local + domain);
            }

            return hashSet.Count;
        }
    }
}
