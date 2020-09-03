//-----------------------------------------------------------------------------
// Runtime: 256ms
// Memory Usage: 256 ms
// Link: https://leetcode.com/submissions/detail/330116374/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0811_SubdomainVisitCount
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            var counts = new Dictionary<string, int>();
            foreach (var domain in cpdomains)
            {
                var cpinfo = domain.Split(' ');

                int count = int.Parse(cpinfo[0]);

                var frags = cpinfo[1].Split('.');
                var currentDomain = "";
                for (int i = frags.Length - 1; i >= 0; i--)
                {
                    currentDomain = frags[i] + (i < frags.Length - 1 ? "." : "") + currentDomain;
                    if (counts.TryGetValue(currentDomain, out var existCount))
                        counts[currentDomain] = existCount + count;
                    else
                        counts[currentDomain] = count;
                }
            }

            var answer = new List<string>();
            foreach (var domain in counts.Keys)
                answer.Add($"{counts[domain]} {domain}");
            return answer;
        }
    }
}
