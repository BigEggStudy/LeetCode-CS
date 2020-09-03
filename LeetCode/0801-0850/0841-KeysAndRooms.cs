//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 26.5 MB
// Link: https://leetcode.com/submissions/detail/368941673/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0841_KeysAndRooms
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var seen = new HashSet<int>();
            seen.Add(0);
            var queue = new Queue<int>();
            queue.Enqueue(0);

            while (queue.Count > 0)
            {
                var roomId = queue.Dequeue();
                foreach (var key in rooms[roomId])
                {
                    if (!seen.Contains(key))
                    {
                        seen.Add(key);
                        queue.Enqueue(key);
                    }
                }
            }

            return seen.Count == rooms.Count;
        }
    }
}
