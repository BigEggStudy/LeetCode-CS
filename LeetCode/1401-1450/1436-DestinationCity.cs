//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 26.6 MB
// Link: https://leetcode.com/submissions/detail/334995736/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1436_DestinationCity
    {
        public string DestCity(IList<IList<string>> paths)
        {
            var set = new HashSet<string>();
            foreach (var path in paths)
                set.Add(path[1]);
            foreach (var path in paths)
                set.Remove(path[0]);

            return set.First();
        }
    }
}
