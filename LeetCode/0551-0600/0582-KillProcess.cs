//-----------------------------------------------------------------------------
// Runtime: 340ms
// Memory Usage: 49.7 MB
// Link: https://leetcode.com/submissions/detail/371138386/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0582_KillProcess
    {
        public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            var parent = new Dictionary<int, List<int>>();
            for (int i = 0; i < pid.Count; i++)
            {
                if (!parent.ContainsKey(ppid[i]))
                    parent[ppid[i]] = new List<int>();
                parent[ppid[i]].Add(pid[i]);
            }

            var result = new List<int>();
            var queue = new Queue<int>();
            queue.Enqueue(kill);
            while (queue.Count > 0)
            {
                var id = queue.Dequeue();
                result.Add(id);
                if (!parent.ContainsKey(id)) continue;

                foreach (var child in parent[id])
                    queue.Enqueue(child);
            }

            return result;
        }
    }
}
