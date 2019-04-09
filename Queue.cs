using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.EnQueue(5);
            queue.EnQueue(10);
            queue.EnQueue(11);
            queue.Traverse();
            Console.WriteLine("The item at the front of the Queue is: {0}", queue.Peek());
            Console.WriteLine("DeQueueing...");
            queue.DeQueue();
            queue.Traverse();
            Console.WriteLine("EnQueueing...");
            queue.EnQueue(16);
            Console.WriteLine("EnQueueing...");
            queue.EnQueue(25);
            queue.Traverse();
            Console.WriteLine("The item at the front of the Queue is: {0}", queue.Peek());
            Console.WriteLine("DeQueueing...");
            queue.DeQueue();
            Console.WriteLine("DeQueueing...");
            queue.DeQueue();
            queue.Traverse();
            Console.WriteLine("The item at the front of the Queue is: {0}", queue.Peek());
        }

    }
    class Node
    {
        public int data;
        public Node next;
    }
    class Queue
    {
        private Node head;
        private Node tail;
        public int count = 0;

        public Queue()
        {
            head = null;
            tail = head;
        }
        public void EnQueue(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            count++;
        }
        public void DeQueue()
        {
            if (count > 0)
            {
                head = head.next;
                count--;
            }

        }
        public int Peek()
        {
            if (count > 0)
            {
                return head.data;
            }
            else
                throw new ArgumentOutOfRangeException();

        }

        public int Count()
        {
            return count;

        }

        public void Traverse()
        {
            Node temp = head;
            Console.Write("Head => ");
            while (temp != null)
            {
                Console.Write("{0} =>", temp.data);
                temp = temp.next;
            }
            Console.WriteLine("null");
        }

    }
}
