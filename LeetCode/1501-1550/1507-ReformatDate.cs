//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 23.4 MB
// Link: https://leetcode.com/submissions/detail/368551226/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1507_ReformatDate
    {
        public string ReformatDate(string date)
        {
            var months = new Dictionary<string, string>()
            {
                { "Jan", "01" },
                { "Feb", "02" },
                { "Mar", "03" },
                { "Apr", "04" },
                { "May", "05" },
                { "Jun", "06" },
                { "Jul", "07" },
                { "Aug", "08" },
                { "Sep", "09" },
                { "Oct", "10" },
                { "Nov", "11" },
                { "Dec", "12" }
            };

            var split = date.Split(' ');
            var day = int.Parse(split[0].Substring(0, split[0].Length - 2));
            return $"{split[2]}-{months[split[1]]}-{day:00}";
        }
    }
}
