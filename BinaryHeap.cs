﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СourseWork
{
    public class BinaryHeap<T> where T : Rectangle
    {
        private List<T> minList;
        private List<T> maxList;


        public BinaryHeap()
        {
            minList = new List<T>();
            maxList = new List<T>();
        }

        public BinaryHeap(List<T> list)
        {
            minList = new List<T>(list);
            maxList = new List<T>(list);
            buildHeap();
        }

        //----------------------------------------------------------------------
        public int heapSize
        {
            get
            {
                return this.maxList.Count();
            }
        }

        int father(int i)
        {
            return (i - 1) / 2;
        }
        int left(int i)
        {
            return 2 * i + 1;
        }
        int right(int i)
        {
            return 2 * i + 2;
        }


        //----------------------------------------------------------------------
        public void add(T value)
        {
            minList.Add(value);
            maxList.Add(value);

            // max array moddifying
            int i = heapSize - 1;
            int parent = (i - 1) / 2;

            while (i > 0 && maxList[parent] < maxList[i])
            {
                T temp = maxList[i];
                maxList[i] = maxList[parent];
                maxList[parent] = temp;

                i = parent;
                parent = (i - 1) / 2;
            }

            // max array moddifying
            i = heapSize - 1;
            parent = (i - 1) / 2;

            while (i > 0 && minList[parent] > minList[i])
            {
                T temp = minList[i];
                minList[i] = minList[parent];
                minList[parent] = temp;

                i = parent;
                parent = (i - 1) / 2;
            }
        }

        // Поиск ведется по минимальной пирамиде(O(nlogn))
        public T find(int ID)
        {
            int index = findIndex(ID);
            return minList[index];
        }

        private int findIndex(int ID)
        {
            if (minList.Count < 1) return -1;

            List<int> indexesToIterateOver = new List<int>();
            indexesToIterateOver.Add(0);

            while (indexesToIterateOver.Count > 0)
            {
                List<int> newIndexesToIterateOver = new List<int>();

                foreach (int index in indexesToIterateOver)
                {
                    if (minList[index].getID() == ID) return index;
                    else
                    {
                        int leftChildIndex = left(minList[index].getID());
                        if (minList.Count - 1 >= leftChildIndex)
                            if (minList[leftChildIndex].getID() <= ID)
                                newIndexesToIterateOver.Add(leftChildIndex);

                        int rightChildIndex = right(minList[index].getID());
                        if (minList.Count - 1 >= rightChildIndex)
                            if (minList[rightChildIndex].getID() <= ID)
                                newIndexesToIterateOver.Add(rightChildIndex);
                    }
                }

                indexesToIterateOver = newIndexesToIterateOver;
            }

            return -2;
        }

        //TODO: It's better to use DAO object instead of methods in Binary Heap

        private int findIndexMaxHeap(int ID)
        {
            if (maxList.Count < 1) return -1;

            List<int> indexesToIterateOver = new List<int>();
            indexesToIterateOver.Add(0);

            while (indexesToIterateOver.Count > 0)
            {
                List<int> newIndexesToIterateOver = new List<int>();

                foreach (int index in indexesToIterateOver)
                {
                    if (maxList[index].getID() == ID) return index;
                    else
                    {
                        int leftChildIndex = left(maxList[index].getID());
                        if (maxList.Count - 1 <= leftChildIndex)
                            if (maxList[leftChildIndex].getID() <= ID)
                                newIndexesToIterateOver.Add(leftChildIndex);

                        int rightChildIndex = right(maxList[index].getID());
                        if (maxList.Count - 1 <= rightChildIndex)
                            if (maxList[rightChildIndex].getID() <= ID)
                                newIndexesToIterateOver.Add(rightChildIndex);
                    }
                }

                indexesToIterateOver = newIndexesToIterateOver;
            }

            return -2;
        }

        public void remove(int ID)
        {
            minList.RemoveAt(findIndex(ID));
            maxList.RemoveAt(findIndexMaxHeap(ID));

            buildHeap();
        }


        /*public static void Swap<T>(T lhs, T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        public int Parent(int key)
        {
            return (key - 1) / 2;
        }
        public void decreaseKey(int key, T new_val)
        {
            minList[key] = new_val;

            while (key != 0 && minList[key] <
                               minList[Parent(key)])
            {
                Swap(ref minList[key],
                     ref minList[Parent(key)]);
                key = Parent(key);
            }
        }

        public void deleteKey(int key)
        {
            decreaseKey(key, int.MinValue);
            extractMin();
        }*/
        //----------------------------------------------------------------------
        // Function to delete the root from Heap

        //----------------------------------------------------------------------
        public void heapify(int i)
        {
            int leftChild;
            int rightChild;
            int largestChild;

            for (; ; )
            {
                leftChild = 2 * i + 1;
                rightChild = 2 * i + 2;
                largestChild = i;

                if (leftChild < heapSize && maxList[leftChild] > maxList[largestChild])
                {
                    largestChild = leftChild;
                }

                if (rightChild < heapSize && maxList[rightChild] > maxList[largestChild])
                {
                    largestChild = rightChild;
                }

                if (largestChild == i)
                {
                    break;
                }

                T temp = maxList[i];
                maxList[i] = maxList[largestChild];
                maxList[largestChild] = temp;
                i = largestChild;
            }

            for (; ; )
            {
                leftChild = 2 * i + 1;
                rightChild = 2 * i + 2;
                largestChild = i;

                if (leftChild < heapSize && minList[leftChild] < minList[largestChild])
                {
                    largestChild = leftChild;
                }

                if (rightChild < heapSize && minList[rightChild] < minList[largestChild])
                {
                    largestChild = rightChild;
                }

                if (largestChild == i)
                {
                    break;
                }

                T temp = minList[i];
                minList[i] = minList[largestChild];
                minList[largestChild] = temp;
                i = largestChild;
            }
        }

        //----------------------------------------------------------------------
        private void buildHeap()
        {
            for (int i = heapSize / 2; i >= 0; i--)
            {
                heapify(i);
            }
        }

        public T getMax()
        {
            if (heapSize > 0)
                return maxList[0];
            return null;
        }
        public T getMin()
        {
            if (heapSize > 0)
                return minList[0];
            return null;
        }
    }
}