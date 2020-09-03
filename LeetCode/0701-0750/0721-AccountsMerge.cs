//-----------------------------------------------------------------------------
// Runtime: 468ms
// Memory Usage: 50 MB
// Link: https://leetcode.com/submissions/detail/376688693/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0721_AccountsMerge
    {
        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            var uf = new UnionFind();
            var emailToName = new Dictionary<string, string>();
            var emailToId = new Dictionary<string, int>();

            var id = 0;
            foreach (var account in accounts)
            {
                var name = string.Empty;
                foreach (var str in account)
                {
                    if (name == string.Empty)
                    {
                        name = str;
                        continue;
                    }

                    emailToName[str] = name;
                    if (!emailToId.ContainsKey(str))
                        emailToId[str] = id++;
                    uf.Union(emailToId[account[1]], emailToId[str]);
                }
            }

            var map = new Dictionary<int, IList<string>>();
            foreach (var email in emailToName.Keys)
            {
                var index = uf.Find(emailToId[email]);
                if (!map.ContainsKey(index))
                    map[index] = new List<string>();
                map[index].Add(email);
            }

            return map.Values.Select(list =>
            {
                IList<string> temp = list.OrderBy(e => e, StringComparer.Ordinal).ToList();
                temp.Insert(0, emailToName[list[0]]);
                return temp;
            }).ToList();
        }

        public class UnionFind
        {
            private int[] parents;

            public UnionFind()
            {
                parents = new int[10001];
                for (int i = 0; i < 10001; i++)
                    parents[i] = i;
            }

            public int Find(int index)
            {
                if (parents[index] != index)
                    parents[index] = Find(parents[index]);
                return parents[index];
            }

            public void Union(int index1, int index2)
            {
                parents[Find(index1)] = Find(index2);
            }
        }
    }
}
