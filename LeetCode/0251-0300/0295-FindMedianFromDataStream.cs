//-----------------------------------------------------------------------------
// Runtime: 308ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0295_FindMedianFromDataStream
    {
        private readonly MinPriorityQueue minPQ;
        private readonly MaxPriorityQueue maxPQ;

        /** initialize your data structure here. */
        public _0295_FindMedianFromDataStream()
        {
            minPQ = new MinPriorityQueue();
            maxPQ = new MaxPriorityQueue();
        }

        public void AddNum(int num)
        {
            minPQ.Insert(num);
            maxPQ.Insert(minPQ.DeleteMin());

            if (minPQ.Size() < maxPQ.Size())
                minPQ.Insert(maxPQ.DeleteMax());
        }

        public double FindMedian()
        {
            if (minPQ.Size() > maxPQ.Size())
                return minPQ.Min();
            else
                return (minPQ.Min() + maxPQ.Max()) / 2.0;
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
                    if (j < N && pq[j] > pq[j + 1]) j++;
                    if (pq[k] <= pq[j]) break;
                    Swap(k, j);
                    k = j;
                }
            }

            protected override void Swim(int k)
            {
                while (k > 1 && pq[k / 2] > pq[k])
                {
                    Swap(k / 2, k);
                    k = k / 2;
                }
            }

            public int Min() => First();

            public int DeleteMin() => Delete();
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
