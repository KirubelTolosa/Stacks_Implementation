using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);            
            myStack.Push(4);
            myStack.Print();
            Console.WriteLine();
            Console.WriteLine("Poped element is : " + myStack.Pop());
            myStack.Print();
        }
    }
    // LIFO
    class Stack
    {
        Node topNode;
        public Stack()
        {
            topNode = null;
        }
        public void Push(int data)
        {
            if (topNode == null)
            { 
                topNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = topNode;
                topNode = temp; 
            }
        }
        public int Pop()
        {
            int item = topNode.data;
            if (topNode == null)
            {
                return 0;
            }
            else
            {                
                topNode = topNode.next;
            }
                return item;
        }
        public void Print()
        {
            Node temp = topNode;
            if (temp == null)
                Console.WriteLine("This is empty!"); 
            else
            { 
                while (temp != null)
                {
                    Console.Write("|" + temp.data + "|->");
                    temp = temp.next;
                }
            }
        }
    }

    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }      
    }
}
