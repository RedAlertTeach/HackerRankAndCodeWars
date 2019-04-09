using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList numberList = new LinkedList();
            Console.WriteLine("There are {0} items in the list.", numberList.Count());
            numberList.Traverse();
            numberList.RemoveAt(5);
            numberList.Add(60);
            numberList.Add(5);
            numberList.Add(11);
            numberList.Add(60);
            numberList.Add(15);
            numberList.Add(44);
            numberList.Add(60);
            numberList.Add(15);
            numberList.Add(44);
            numberList.Add(60);
            numberList.Add(15);
            numberList.Add(44);
            numberList.Add(60);
            numberList.Add(15);
            numberList.Add(44);
            Console.WriteLine("There are {0} items in the list.", numberList.Count());
            numberList.Traverse();
            numberList.RemoveAll(60);
            Console.WriteLine("There are {0} items in the list.", numberList.Count());
            numberList.Traverse();
            numberList.RemoveAt(3);
            Console.WriteLine("There are {0} items in the list.", numberList.Count());
            numberList.Traverse();
            numberList.Remove(5);
            Console.WriteLine("There are {0} items in the list.", numberList.Count());
            numberList.Traverse();
            numberList.RemoveFromStart();
            Console.WriteLine("There are {0} items in the list.", numberList.Count());
            numberList.Traverse();
            numberList.Add(48);
            numberList.Add(100);
            Console.WriteLine("There are {0} items in the list.", numberList.Count());
            numberList.Traverse();
            numberList.Remove(100);
            Console.WriteLine("There are {0} items in the list.", numberList.Count());
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

            }

            public void Remove(int item)
            {
                if (count > 0)
                {
                    if (head.data == item)
                    {
                        RemoveFromStart();
                    }
                    else
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
                            count--;
                        }
                    }
                }

            }
            public void RemoveAll(int item)
            {
                Node temp = head;
                Node prev = null;
                while (temp.next != null)
                {
                    if (temp.data == item)
                    {
                        if (prev != null)
                            prev.next = temp.next;
                        else
                            head = temp.next;

                        count--;
                    }
                    prev = temp;
                    temp = temp.next;
                }
            }
            public int Count()
            {
                return count;

            }
            public void RemoveAt(int itemIndex)
            {
                if (count > 0 && (itemIndex <= count - 1))
                {
                    int counter = 0;
                    Node temp = head;
                    Node prev = null;
                    while (counter <= itemIndex - 1)
                    {
                        prev = temp;
                        temp = temp.next;
                        counter++;
                    }

                    prev.next = temp.next;
                    count--;


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

