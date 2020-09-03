//-----------------------------------------------------------------------------
// Runtime: 120ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0753_CrackingtheSafe
    {
        public string CrackSafe(int n, int k)
        {
            var totalSize = (int)Math.Pow(k, n);
            var alreadySeen = new HashSet<string>();
            var results = new StringBuilder();

            var start = new string('0', n - 1);
            DFS(start, k, totalSize, alreadySeen, results);
            results.Append(start);

            return results.ToString();
        }

        private void DFS(string currentString, int k, int totalSize, ISet<string> alreadySeen, StringBuilder results)
        {
            if (alreadySeen.Count == totalSize)
                return;

            for (int i = 0; i < k; i++)
            {
                var newString = currentString + i.ToString();
                if (alreadySeen.Contains(newString))
                    continue;

                alreadySeen.Add(newString);
                DFS(newString.Substring(1), k, totalSize, alreadySeen, results);
                results.Append(i);
            }
        }
    }
}
