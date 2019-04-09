using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string phrase = Console.ReadLine();

            phrase = new string((from c in phrase
                                where !Char.IsPunctuation(c) && !Char.IsWhiteSpace(c)
                                select c).ToArray()).ToLower();

            Stack stack1 = new Stack();
            Stack stack2 = new Stack();

            foreach (char c in phrase)
            {
                stack1.Push(c);
            }

            int count = phrase.Length/2;
            bool odd = (phrase.Length % 2) == 1 ? true : false;

            for (int i = 1; i <= count; i++)
            {
                stack2.Push(stack1.Peek());
                stack1.Pop();
            }
            if (odd)
            {
                stack1.Pop();
            }
            bool palindrome = true;

            for (int i = 1; i <= count; i++)
            {
                if (stack2.Peek() != stack1.Peek())
                {
                    palindrome = false;
                    break;
                }
                stack2.Pop();
                stack1.Pop();


            }
            if (palindrome)
            {
                Console.WriteLine("The phrase is a palindrome.");
            }
            else
                Console.WriteLine("The phrase is NOT a palindrome.");





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
