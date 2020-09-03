//-----------------------------------------------------------------------------
// Runtime: 288ms
// Memory Usage: 35.6 MB
// Link: https://leetcode.com/submissions/detail/263059422/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0218_TheSkylineProblem
    {
        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            var sortedList = new SortedList<int, IList<int>>();
            foreach (var building in buildings)
            {
                if (!sortedList.ContainsKey(building[0]))
                    sortedList.Add(building[0], new List<int>());
                sortedList[building[0]].Add(-building[2]);

                if (!sortedList.ContainsKey(building[1]))
                    sortedList.Add(building[1], new List<int>());
                sortedList[building[1]].Add(building[2]);
            }

            var result = new List<IList<int>>();
            var heights = new MaxPriorityQueue();
            foreach (var x in sortedList.Keys)
            {
                foreach (var height in sortedList[x])
                {
                    if (height < 0) heights.Insert(-height);
                    else heights.Delete(height);
                }

                if (heights.Size() == 0) result.Add(new List<int>() { x, 0 });
                else
                {
                    var height = heights.Max();
                    if (result.Count == 0 || result[result.Count - 1][1] != height)
                        result.Add(new List<int>() { x, height });
                }
            }

            return result;
        }

        public class MaxPriorityQueue : PriorityQueue
        {
            public MaxPriorityQueue() : base() { }

            public MaxPriorityQueue(int initCapacity) : base(initCapacity) { }

            protected override void Sink(int k)
            {
                while (2 * k <= N)
                {
                    int j = 2 * k;
                    if (j < N && pq[j] < pq[j + 1]) j++;
                    if (pq[k] >= pq[j]) break;
                    Swap(k, j);
                    k = j;
                }
            }

            protected override void Swim(int k)
            {
                while (k > 1 && pq[k / 2] < pq[k])
                {
                    Swap(k / 2, k);
                    k = k / 2;
                }
            }

            public int Max() => First();

            public int DeleteMax() => Delete();
        }

        public abstract class PriorityQueue
        {
            protected int N;
            protected int[] pq;

            public PriorityQueue() : this(1) { }

            public PriorityQueue(int initCapacity)
            {
                this.N = 0;
                pq = new int[initCapacity + 1];
            }

            public bool IsEmpty() => N == 0;

            public int Size() => N;

            public int First()
            {
                if (IsEmpty()) { throw new ArgumentOutOfRangeException(); }
                return pq[1];
            }

            public void Insert(int x)
            {
                if (N >= pq.Length - 1)
                    Resize(pq.Length * 2);

                pq[++N] = x;
                Swim(N);
            }

            protected abstract void Swim(int k);

            public int Delete()
            {
                var result = pq[1];
                Swap(1, N--);
                Sink(1);
                pq[N + 1] = 0;
                if (N > 0 && N == (pq.Length - 1) / 4)
                    Resize(pq.Length / 2);

                return result;
            }
            public void Delete(int x)
            {
                var index = -1;
                for (int i = 1; i <= N; i++)
                {
                    if (pq[i] == x)
                    {
                        index = i;
                        break;
                    }
                }

                Swap(index, N--);
                Sink(index);
                pq[N + 1] = 0;
                if (N > 0 && N == (pq.Length - 1) / 4)
                    Resize(pq.Length / 2);
            }

            protected abstract void Sink(int k);

            private void Resize(int newCapacity)
            {
                var temp = new int[newCapacity + 1];
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
