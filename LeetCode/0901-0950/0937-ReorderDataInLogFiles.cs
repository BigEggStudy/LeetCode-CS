//-----------------------------------------------------------------------------
// Runtime: 256ms
// Memory Usage: 33.2 MB
// Link: https://leetcode.com/submissions/detail/260394149/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0937_ReorderDataInLogFiles
    {
        public string[] ReorderLogFiles(string[] logs)
        {
            if (logs == null || logs.Length == 0) return new string[0];

            List<string> letterLogs = new List<string>();
            List<string> digitLogs = new List<string>();
            foreach (string log in logs)
            {
                if (char.IsDigit(log[log.IndexOf(' ') + 1])) digitLogs.Add(log);
                else letterLogs.Add(log);
            }

            letterLogs.Sort((a, b) =>
            {
                string sub1 = a.Substring(a.IndexOf(' ') + 1);
                string sub2 = b.Substring(b.IndexOf(' ') + 1);

                int result = sub1.CompareTo(sub2);
                if (result == 0)
                    result = a.Substring(0, a.IndexOf(' ')).CompareTo(b.Substring(0, b.IndexOf(' ')));

                return result;
            });

            letterLogs.AddRange(digitLogs);

            return letterLogs.ToArray();
        }
    }
}
