//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0743_NetworkDelayTime
    {
        public int NetworkDelayTime(int[][] times, int N, int K)
        {
            var graph = new Dictionary<int, List<Node>>();
            foreach (var edge in times)
            {
                if (!graph.ContainsKey(edge[0]))
                    graph.Add(edge[0], new List<Node>());
                graph[edge[0]].Add(new Node(edge[2], edge[1]));
            }

            var pq = new MinPriorityQueue();
            pq.Insert(new Node(0, K));

            var distances = new Dictionary<int, int>();

            while (pq.Size() > 0)
            {
                var node = pq.DeleteMin();
                if (distances.ContainsKey(node.Target)) continue;

                distances.Add(node.Target, node.Distance);
                if (graph.ContainsKey(node.Target))
                    foreach (var edge in graph[node.Target])
                        if (!distances.ContainsKey(edge.Target))
                            pq.Insert(new Node(node.Distance + edge.Distance, edge.Target));
            }

            if (distances.Count != N) return -1;
            return distances.Values.Max();
        }

        public class Node : IComparable<Node>
        {
            public Node(int distance, int target)
            {
                Distance = distance;
                Target = target;
            }

            public int Distance { get; set; }
            public int Target { get; set; }

            public int CompareTo(Node other)
            {
                return Distance.CompareTo(other.Distance);
            }
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

            public Node Min() => First();

            public Node DeleteMin() => Delete();
        }

        public abstract class PriorityQueue
        {
            protected int N;
            protected Node[] pq;

            public PriorityQueue() : this(1) { }

            public PriorityQueue(int initCapacity)
            {
                this.N = 0;
                pq = new Node[initCapacity + 1];
            }

            public bool IsEmpty() => N == 0;

            public int Size() => N;

            public Node First()
            {
                if (IsEmpty()) { throw new ArgumentOutOfRangeException(); }
                return pq[1];
            }

            public void Insert(Node x)
            {
                if (N >= pq.Length - 1)
                    Resize(pq.Length * 2);

                pq[++N] = x;
                Swim(N);
            }

            protected abstract void Swim(int k);

            public Node Delete()
            {
                var result = pq[1];
                Swap(1, N--);
                Sink(1);
                pq[N + 1] = null;
                if (N > 0 && N == (pq.Length - 1) / 4)
                    Resize(pq.Length / 2);

                return result;
            }

            protected abstract void Sink(int k);

            private void Resize(int newCapacity)
            {
                var temp = new Node[newCapacity + 1];
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
