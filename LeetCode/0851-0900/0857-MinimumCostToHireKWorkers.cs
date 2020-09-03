//-----------------------------------------------------------------------------
// Runtime: 156ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0857_MinimumCostToHireKWorkers
    {
        public double MincostToHireWorkers(int[] quality, int[] wage, int K)
        {
            var workers = new List<Worker>();
            for (int i = 0; i < quality.Length; i++)
                workers.Add(new Worker(quality[i], wage[i]));
            workers.Sort();

            var pool = new Heap(K);
            var qualityTotal = 0;
            var result = double.MaxValue;
            foreach (var worker in workers)
            {
                pool.Offer(-worker.Quality);
                qualityTotal += worker.Quality;

                if (pool.Size() > K)
                {
                    var maxQualityWorker = -1 * pool.Poll();
                    qualityTotal -= (int)maxQualityWorker;
                }
                if (pool.Size() == K)
                {
                    result = Math.Min(result, qualityTotal * worker.Ratio);
                }
            }
            return result;
        }

        public class Worker : IComparable<Worker>
        {
            public Worker(int quality, int wage)
            {
                Quality = quality;
                Wage = wage;
            }

            public int Quality { get; set; }

            public int Wage { get; set; }

            public double Ratio { get { return Wage * 1.0 / Quality; } }

            public int CompareTo(Worker other)
            {
                return Ratio.CompareTo(other.Ratio);
            }
        }

        public class Heap
        {
            double[] heap = null;
            int size = 0;

            public Heap(int k)
            {
                heap = new double[k + 1];
            }

            public int Size()
            {
                return size;
            }

            public void Offer(double val)
            {
                heap[size++] = val;
                HeapifyUp();
            }

            public double Peek()
            {
                if (size == 0) throw new InvalidOperationException();
                return heap[0];
            }

            public double Poll()
            {
                if (size == 0) throw new InvalidOperationException();
                double resp = heap[0];
                if (size > 1)
                {
                    heap[0] = heap[size - 1];
                    HeapifyDown();
                }

                size--;
                return resp;
            }

            private void HeapifyUp()
            {
                int index = size - 1;
                while (HasParent(index))
                {
                    int parentIndex = GetParentIndex(index);
                    if (heap[parentIndex] > heap[index])
                        Swap(parentIndex, index);
                    else
                        break;

                    index = parentIndex;
                }
            }

            private void HeapifyDown()
            {
                int index = 0;
                while (HasLeftChild(index))
                {
                    int left = GetLeftChildIndex(index), right = GetRightChildIndex(index), minIndex = left;
                    double min = heap[left];
                    if (HasRightChild(index) && heap[right] < min)
                    {
                        min = heap[right];
                        minIndex = right;
                    }


                    if (heap[index] > min)
                        Swap(index, minIndex);
                    else
                        break;

                    index = minIndex;
                }
            }

            private void Swap(int index1, int index2)
            {
                double temp = heap[index1];
                heap[index1] = heap[index2];
                heap[index2] = temp;
            }

            private bool HasParent(int index)
            {
                return (index + 1) / 2 - 1 >= 0;
            }

            private bool HasLeftChild(int index)
            {
                return index * 2 + 1 < size;
            }

            private bool HasRightChild(int index)
            {
                return index * 2 + 2 < size;
            }

            private int GetParentIndex(int index)
            {
                return (index + 1) / 2 - 1;
            }

            private int GetLeftChildIndex(int index)
            {
                return index * 2 + 1;
            }

            private int GetRightChildIndex(int index)
            {
                return index * 2 + 2;
            }
        }
    }
}
