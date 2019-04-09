using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningMedian
{
    public class MinHeap
    {
        private int numberOfItems = 0;
        private int[] minHeap = null;
        public MinHeap(int size)
        {
            minHeap = new int[size];

        }
        public int size()
        {
            return numberOfItems;
        }
        public void push(int data)
        {
            minHeap[numberOfItems] = data;
            numberOfItems++;
            heapifyUp();
        }
        public int getLeftChildIndex(int parentIndex)
        {
            return ((2 * parentIndex) + 1);

        }
        public int getRightChildIndex(int parentIndex)
        {
            return ((2 * parentIndex) + 2);

        }
        public int getParentIndex(int childIndex)
        {
            return ((childIndex / 2) - 1);
        }
        public bool hasLeftChild(int index)
        {
            return (getLeftChildIndex(index) < numberOfItems);

        }
        public bool hasRightChild(int index)
        {
            return (getRightChildIndex(index) < numberOfItems);

        }
        public bool hasParent(int index)
        {
            return (getParentIndex(index) >= 0);
        }
        public int leftChildValue(int index)
        {
            return (minHeap[getLeftChildIndex(index)]);
        }
        public int rightChildValue(int index)
        {
            return (minHeap[getRightChildIndex(index)]);
        }
        public int parentValue(int index)
        {
            return (minHeap[getParentIndex(index)]);
        }
        public void swap(int indexOne, int indexTwo)
        {
            int temp = minHeap[indexOne];
            minHeap[indexOne] = minHeap[indexTwo];
            minHeap[indexTwo] = temp;
        }
        public int peek()
        {
            if (numberOfItems == 0)
                throw new InvalidOperationException("The heap is empty.");
            return minHeap[0];
        }
        public int pop()
        {
            if (numberOfItems == 0)
                throw new InvalidOperationException("The heap is empty.");
            int data = minHeap[0];
            minHeap[0] = minHeap[numberOfItems - 1];
            numberOfItems--;
            heapifyDown();
            return data;
        }
        private void heapifyUp()
        {
            int index = numberOfItems - 1;
            while (hasParent(index) && (parentValue(index)) > minHeap[index])
            {
                swap(index, getParentIndex(index));
                index = getParentIndex(index);
            }
        }
        private void heapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int smallerChildIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && (rightChildValue(index) < leftChildValue(index)))
                    smallerChildIndex = getRightChildIndex(index);
                if (minHeap[smallerChildIndex] < minHeap[index])
                {
                    swap(smallerChildIndex, index);
                    index = smallerChildIndex;
                }
                else
                    break;
            }
        }
    }
    public class MaxHeap
    {
        private int numberOfItems = 0;
        private int[] maxHeap = null;
        public MaxHeap(int size)
        {
            maxHeap = new int[size];

        }
        public int size()
        {
            return numberOfItems;
        }
        public void push(int data)
        {
            maxHeap[numberOfItems] = data;
            numberOfItems++;
            heapifyUp();
        }
        public int getLeftChildIndex(int parentIndex)
        {
            return ((2 * parentIndex) + 1);

        }
        public int getRightChildIndex(int parentIndex)
        {
            return ((2 * parentIndex) + 2);

        }
        public int getParentIndex(int childIndex)
        {
            return ((childIndex / 2) - 1);
        }
        public bool hasLeftChild(int index)
        {
            return (getLeftChildIndex(index) < numberOfItems);

        }
        public bool hasRightChild(int index)
        {
            return (getRightChildIndex(index) < numberOfItems);

        }
        public bool hasParent(int index)
        {
            return (getParentIndex(index) >= 0);
        }
        public int leftChildValue(int index)
        {
            return (maxHeap[getLeftChildIndex(index)]);
        }
        public int rightChildValue(int index)
        {
            return (maxHeap[getRightChildIndex(index)]);
        }
        public int parentValue(int index)
        {
            return (maxHeap[getParentIndex(index)]);
        }
        public void swap(int indexOne, int indexTwo)
        {
            int temp = maxHeap[indexOne];
            maxHeap[indexOne] = maxHeap[indexTwo];
            maxHeap[indexTwo] = temp;
        }
        public int peek()
        {
            if (numberOfItems == 0)
                throw new InvalidOperationException("The heap is empty.");
            return maxHeap[0];
        }
        public int pop()
        {
            if (numberOfItems == 0)
                throw new InvalidOperationException("The heap is empty.");
            int data = maxHeap[0];
            maxHeap[0] = maxHeap[numberOfItems - 1];
            numberOfItems--;
            heapifyDown();
            return data;
        }
        private void heapifyUp()
        {
            int index = numberOfItems - 1;
            while (hasParent(index) && (parentValue(index)) < maxHeap[index])
            {
                swap(index, getParentIndex(index));
                index = getParentIndex(index);
            }
        }
        private void heapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int largerChildIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && (rightChildValue(index) > leftChildValue(index)))
                    largerChildIndex = getRightChildIndex(index);
                if (maxHeap[largerChildIndex] > maxHeap[index])
                {
                    swap(largerChildIndex, index);
                    index = largerChildIndex;
                }
                else
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfItems = Convert.ToInt32(Console.ReadLine());
            MaxHeap min = new MaxHeap((numberOfItems / 2) + 1);
            MinHeap max = new MinHeap((numberOfItems / 2) + 1);
            for (int i = 1; i <= numberOfItems; i++)
            {
                int data = Convert.ToInt32(Console.ReadLine());
                if (min.size() == 0)
                {
                    min.push(data);
                }
                else
                {
                    if (min.size() > max.size())
                    {
                        if (min.peek() > data)
                        {
                            max.push(min.peek());
                            min.pop();
                            min.push(data);
                        }
                        else
                            max.push(data); 
                    }
                    else
                    {
                        if (max.peek() >= data)
                            min.push(data);
                        else
                         {
                            min.push(max.peek());
                            max.pop();
                            max.push(data);
                        }
                        
                            

                    }
                }
                double median = ((i % 2) == 0) ? ((min.peek() + max.peek()) / 2.0) : (double)min.peek();
                Console.WriteLine("{0}", median);
            }
        }
    }
}
