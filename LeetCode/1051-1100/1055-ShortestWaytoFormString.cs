//-----------------------------------------------------------------------------
// Runtime: 76ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _1055_ShortestWaytoFormString
    {
        public int ShortestWay(string source, string target)
        {
            var map = new int[26];
            foreach (var c in source)
                map[c - 'a']++;

            var j = 0;
            var i = 0;
            while (i < target.Length)
            {
                if (map[target[i] - 'a'] == 0) return -1;

                if (target[i] == source[j % source.Length])
                    i++;
                j++;
            }
            return j % source.Length == 0 ? j / source.Length : j / source.Length + 1;
        }
    }
}
