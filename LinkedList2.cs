using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList2
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList numberList = new LinkedList();
            numberList.Traverse();
            numberList.Add(5);
            numberList.Add(11);
            numberList.Add(60);
            numberList.Add(15);
            numberList.Add(44);
            numberList.Traverse();
            numberList.Remove(60);
            numberList.Traverse();
            numberList.RemoveFromStart();
            numberList.Traverse();
            numberList.Add(48);
            numberList.Add(100);
            numberList.Traverse();
            numberList.Remove(100);
            numberList.Traverse();

        }
        class Node
        {
            public int data;
            public Node next;
        }
        class LinkedList
        {
            private Node head;
            private Node current;
            public int count = 0;

            public LinkedList()
            {
                head = null;
                current = head;
            }
            public void Add(int data)
            {
                Node newNode = new Node();
                newNode.data = data;
                if (head == null)
                {
                    head = newNode;
                    current = head;
                }
                else
                {
                    current.next = newNode;
                    current = newNode;
                }
                count++;
            }
            public void RemoveFromStart()
            {
                if (count > 0)
                {
                    head = head.next;
                    count--;
                }
                else
                {
                    Console.WriteLine("No elements exist in this linked list.");
                }
            }

            public void Remove(int item)
            {
                if (count > 0)
                {
                    Node temp = head;
                    Node prev = null;
                    while (temp.next != null && temp.data != item)
                    {
                        prev = temp;
                        temp = temp.next;
                    }
                    if (temp != null)
                    {
                        prev.next = temp.next;
                    }

                }
                else
                {
                    Console.WriteLine("No elements exist in this linked list.");
                }
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

}
