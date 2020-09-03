//-----------------------------------------------------------------------------
// Runtime: 312ms
// Memory Usage: 49.8 MB
// Link: https://leetcode.com/submissions/detail/372006171/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0609_FindDuplicateFileInSystem
    {
        public IList<IList<string>> FindDuplicate(string[] paths)
        {
            var map = new Dictionary<string, IList<string>>();
            foreach (var path in paths)
            {
                var values = path.Split(' ');
                var dir = values[0];
                for (int i = 1; i < values.Length; i++)
                {
                    var name_content = values[i].Split('(');
                    var name = name_content[0];
                    var content = name_content[1].Substring(0, name_content[1].Length - 1);

                    if (!map.ContainsKey(content))
                        map[content] = new List<string>();
                    map[content].Add($"{dir}/{name}");
                }
            }

            var result = new List<IList<string>>();
            foreach (var files in map.Values)
                if (files.Count > 1)
                    result.Add(files);

            return result;
        }
    }
}
