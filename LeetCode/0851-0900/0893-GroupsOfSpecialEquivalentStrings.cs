//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 25.8 MB
// Link: https://leetcode.com/submissions/detail/331991776/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _0893_GroupsOfSpecialEquivalentStrings
    {
        public int NumSpecialEquivGroups(string[] A)
        {
            var set = new HashSet<string>();

            var odds = new char[(A[0].Length + 1) / 2];
            var evens = new char[A[0].Length / 2];
            var sb = new StringBuilder();

            foreach (var str in A)
            {
                for (var i = 0; i < str.Length; i++)
                {
                    if (i % 2 == 0) odds[i / 2] = str[i];
                    else evens[i / 2] = str[i];
                }

                Array.Sort(odds);
                Array.Sort(evens);

                sb.Clear();
                sb.Append(odds);
                sb.Append(evens);

                set.Add(sb.ToString());
            }

            return set.Count;
        }
    }
}
