using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(10);
            stack.Push(11);
            stack.Traverse();
            Console.WriteLine("The item at the front of the stack is: {0}", stack.Peek());
            Console.WriteLine("Popping...");
            stack.Pop();
            stack.Traverse();
            Console.WriteLine("Pushing...");
            stack.Push(16);
            Console.WriteLine("Pushing...");
            stack.Push(25);
            stack.Traverse();
            Console.WriteLine("The item at the front of the stack is: {0}", stack.Peek());
            Console.WriteLine("Popping...");
            stack.Pop();
            Console.WriteLine("Popping...");
            stack.Pop();
            stack.Traverse();
            Console.WriteLine("The item at the front of the stack is: {0}", stack.Peek());
        }
    }
    class Node
    {
        public int data;
        public Node next;
    }
    class Stack
    {
        private Node head;
       
        private int count = 0;

        public Stack()
        {
            head = null;
          
        }
        public void Push(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            if (head == null)
            {
                head = newNode;
                
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            count++;
        }
        public void Pop()
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
