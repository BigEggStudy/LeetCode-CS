//-----------------------------------------------------------------------------
// Runtime: 304ms
// Memory Usage: 35 MB
// Link: https://leetcode.com/submissions/detail/365336197/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1152_AnalyzeUserWebsiteVisitPattern
    {
        public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website)
        {
            var tuples = new List<(string n, int t, string w)>();
            for (int i = 0; i < username.Length; i++)
                tuples.Add((username[i], timestamp[i], website[i]));

            var userVisit = new Dictionary<string, IList<string>>();
            foreach (var tuple in tuples.OrderBy(t => t.t))
            {
                if (!userVisit.ContainsKey(tuple.n))
                    userVisit[tuple.n] = new List<string>();
                userVisit[tuple.n].Add(tuple.w);
            }

            var counts = new Dictionary<string, int>();
            var maxCount = int.MinValue;
            var resultStr = string.Empty;
            foreach (var visit in userVisit.Values)
            {
                if (visit.Count < 3) continue;

                var visitSet = new HashSet<string>();
                for (int i = 0; i < visit.Count; i++)
                    for (int j = i + 1; j < visit.Count; j++)
                        for (int k = j + 1; k < visit.Count; k++)
                        {
                            var str = $"{visit[i]} {visit[j]} {visit[k]}";
                            if (!visitSet.Contains(str))
                            {
                                visitSet.Add(str);
                                if (!counts.ContainsKey(str))
                                    counts[str] = 1;
                                else
                                    counts[str]++;
                            }

                            if (maxCount < counts[str])
                            {
                                maxCount = counts[str];
                                resultStr = str;
                            }
                            else if (maxCount == counts[str] && str.CompareTo(resultStr) < 0)
                                resultStr = str;
                        }
            }

            var result = resultStr.Split(' ');
            return result.Length < 3 ? new List<string>() : result.ToList();
        }
    }
}
