using System;
using System.IO;



namespace Balanced

{

    class Program

    {

        static void Main(string[] args)

        {

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\balanced.txt";

            FileStream inFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(inFile);

            string contents = reader.ReadLine();

            string openingSymbols = "{[(";

            string closingSymbols = ")}]";

         //   Console.WriteLine("The contents of the file are:");


            while (contents != null)

            {

                Stack symbolStack = new Stack();

                bool valid = true;
                //   Console.WriteLine(contents);

                foreach (char c in contents)
                {
                    if (openingSymbols.Contains(c.ToString()))
                    {
                        symbolStack.Push(c);
                    }
                    else if (closingSymbols.Contains(c.ToString()))
                    {
                        if (symbolStack.Count() == 0)
                        {
                            valid = false;
                            break;
                        }
                        else
                        {
                            char compare = (char)symbolStack.Peek();
                            symbolStack.Pop();
                            if (!symbolsMatch(c, compare))
                            {
                                valid = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        valid = false;
                        break;
                    }
                }

                if (symbolStack.Count() != 0)
                    valid = false;

                if (valid)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                contents = reader.ReadLine();

            }

            reader.Close();

            inFile.Close();



        }
        static bool symbolsMatch(char close, char open)
        {
            if (open == '[')
            {
                if (close == ']')
                    return true;
                else
                    return false;

            }
            if (open == '{')
            {
                if (close == '}')
                    return true;
                else
                    return false;

            }
            if (open == '(')
            {
                if (close == ')')
                    return true;
                else
                    return false;

            }
            return false;
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
