using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode.FindTheRunningMedian
{
    public class Solution
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            RunningMedian rm = new RunningMedian();

            for (int i = 1; i <= n; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                rm.AddValue(value);
                Console.WriteLine(rm.FindMedian().ToString("F1"));
            }
        }

        public class RunningMedian
        {
            SortedSet<int> minHeap;
            SortedSet<int> maxHeap;

            public RunningMedian()
            {
                minHeap = new SortedSet<int>();
                maxHeap = new SortedSet<int>();
            }

            public void AddValue(int value)
            {
                if (minHeap.Count == maxHeap.Count)
                {
                    if (minHeap.Count > 0 && value > minHeap.Min)
                    {
                        maxHeap.Add(minHeap.Min);
                        minHeap.Remove(minHeap.Min);

                        minHeap.Add(value);
                    }
                    else
                        maxHeap.Add(value);
                }
                else
                {
                    if (value < maxHeap.Max)
                    {
                        minHeap.Add(maxHeap.Max);
                        maxHeap.Remove(maxHeap.Max);

                        maxHeap.Add(value);
                    }
                    else
                        minHeap.Add(value);
                }
            }

            public double FindMedian()
            {
                if (maxHeap.Count == 0)
                    return 0;

                if (minHeap.Count == maxHeap.Count)
                {
                   return (double)(minHeap.Min + maxHeap.Max) / 2;
                }
                else 
                {
                    return maxHeap.Max;
                }                
            }
        }

        public class RunningMedian_AsVideo
        {
            SortedSet<int> lowerHeap;
            SortedSet<int> higherHeap;

            public RunningMedian_AsVideo()
            {
                lowerHeap = new SortedSet<int>();
                higherHeap = new SortedSet<int>();
            }

            public void AddValue(int value)
            {
                if ((lowerHeap.Count == 0) || (value < lowerHeap.Max))
                    lowerHeap.Add(value);
                else
                    higherHeap.Add(value);

                Rebalance();            
            }

            private void Rebalance()
            {
                if (lowerHeap.Count - higherHeap.Count >= 2)
                {
                    int maxHeapRoot = lowerHeap.Max;
                    lowerHeap.Remove(maxHeapRoot);

                    higherHeap.Add(maxHeapRoot);
                }
                else if (higherHeap.Count - lowerHeap.Count >= 2)
                {
                    int minHeapRoot = higherHeap.Min;
                    higherHeap.Remove(minHeapRoot);

                    lowerHeap.Add(minHeapRoot);
                }
            }

            public double FindMedian()
            {
                double result = -1;
                if (lowerHeap.Count == higherHeap.Count)
                {
                    result = (lowerHeap.Max + higherHeap.Min) / 2.0;                    
                }
                else if (lowerHeap.Count > higherHeap.Count)
                {
                    result = lowerHeap.Max;
                }
                else if (higherHeap.Count > lowerHeap.Count)
                {
                    result = higherHeap.Min;
                }
                return result;
            }
        }
    }

}
