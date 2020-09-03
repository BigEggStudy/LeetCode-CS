//-----------------------------------------------------------------------------
// Runtime: 292ms
// Memory Usage: 34.1 MB
// Link: https://leetcode.com/submissions/detail/359552897/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0332_ReconstructItinerary
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            var map = new Dictionary<string, MinPriorityQueue>();
            foreach (var ticket in tickets)
            {
                if (!map.ContainsKey(ticket[0]))
                    map.Add(ticket[0], new MinPriorityQueue());
                map[ticket[0]].Insert(ticket[1]);
            }

            var result = new List<string>();
            Visit("JFK", map, result);
            return result;
        }

        private void Visit(string airport, IDictionary<string, MinPriorityQueue> map, IList<string> route)
        {
            while (map.ContainsKey(airport) && map[airport].Size() > 0)
            {
                var target = map[airport].DeleteMin();
                Visit(target, map, route);
            }
            route.Insert(0, airport);
        }

        public class MinPriorityQueue : PriorityQueue
        {
            public MinPriorityQueue() : base() { }

            public MinPriorityQueue(int initCapacity) : base(initCapacity) { }

            protected override void Sink(int k)
            {
                while (2 * k <= N)
                {
                    int j = 2 * k;
                    if (j < N && pq[j].CompareTo(pq[j + 1]) > 0) j++;
                    if (pq[k].CompareTo(pq[j]) <= 0) break;
                    Swap(k, j);
                    k = j;
                }
            }

            protected override void Swim(int k)
            {
                while (k > 1 && pq[k / 2].CompareTo(pq[k]) > 0)
                {
                    Swap(k / 2, k);
                    k = k / 2;
                }
            }

            public string Min() => First();

            public string DeleteMin() => Delete();
        }

        public abstract class PriorityQueue
        {
            protected int N;
            protected string[] pq;

            public PriorityQueue() : this(1) { }

            public PriorityQueue(int initCapacity)
            {
                this.N = 0;
                pq = new string[initCapacity + 1];
            }

            public bool IsEmpty() => N == 0;

            public int Size() => N;

            public string First()
            {
                if (IsEmpty()) { throw new ArgumentOutOfRangeException(); }
                return pq[1];
            }

            public void Insert(string x)
            {
                if (N >= pq.Length - 1)
                    Resize(pq.Length * 2);

                pq[++N] = x;
                Swim(N);
            }

            protected abstract void Swim(int k);

            public string Delete()
            {
                var result = pq[1];
                Swap(1, N--);
                Sink(1);
                pq[N + 1] = string.Empty;
                if (N > 0 && N == (pq.Length - 1) / 4)
                    Resize(pq.Length / 2);

                return result;
            }

            protected abstract void Sink(int k);

            private void Resize(int newCapacity)
            {
                var temp = new string[newCapacity + 1];
                for (int i = 1; i <= N; i++)
                    temp[i] = pq[i];

                pq = temp;
            }

            protected void Swap(int index1, int index2)
            {
                var temp = pq[index1];
                pq[index1] = pq[index2];
                pq[index2] = temp;
            }
        }
    }
}
