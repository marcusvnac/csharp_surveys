using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSurveys.RackerRank.CrackingTheCode
{
    public class MinIntHeap
    {
        private static readonly int capacity = 10;
        private int size = 0;

        int[] items = new int[capacity];

        private int GetLeftChildIndex(int parentIndex) { return 2 * parentIndex + 1; }
        private int GetRightChildIndex(int parentIndex) { return 2 * parentIndex + 2; }
        private int GetParentIndex(int childIndex) { return (childIndex - 1) / 2; }

        private bool HasLeftChild(int index) { return GetLeftChildIndex(index) < size; }
        private bool HasRightChild(int index) { return GetRightChildIndex(index) < size; }

        private bool HasParent(int index) { return GetParentIndex(index) >= 0; }


        private int LeftChild(int index) { return items[GetLeftChildIndex(index)]; }
        private int RightChild(int index) { return items[GetRightChildIndex(index)]; }
        private int Parent(int index) { return items[GetParentIndex(index)]; }

        private void Swap(int indexOne, int indexTwo)
        {
            int temp = items[indexOne];
            items[indexOne] = items[indexTwo];
            items[indexTwo] = temp;
        }

        private void EnsureExtraCapacity()
        {
            if (size == items.Length)
            {
                int[] newItems = new int[capacity * 2];
                Array.Copy(items, newItems, items.Length);
                items = newItems;
            }
        }

        public int Peek()
        {
            if (size == 0)
                throw new Exception("Array is Empty");

            return items[0];
        }

        public int Poll()
        {
            if (size == 0)
                throw new Exception("Array is Empty");

            int item = items[0];
            items[0] = items[size - 1];
            size--;
            HeapifyDown();

            return item;
        }

        private void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                int smallerChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && RightChild(index) < LeftChild(index))
                {
                    smallerChildIndex = GetRightChildIndex(index);
                }

                if (items[index] < items[smallerChildIndex])
                    break;
                else
                    Swap(index, smallerChildIndex);

                index = smallerChildIndex;
            }
        }

        public void Add(int item)
        {
            EnsureExtraCapacity();
            items[size] = item;
            size++;
            HeapifyUp();
        }

        private void HeapifyUp()
        {
            int index = size - 1;
            while (HasParent(index) && Parent(index) > items[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }
    }
}
