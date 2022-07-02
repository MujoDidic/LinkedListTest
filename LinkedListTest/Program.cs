using System;

namespace LinkedListTest
{
    class Node
    {
        public int data;
        public Node Next;

        public Node (int i)
        {
            data = i;
            Next = null;
        }


        public void Print()
        {
            Console.Write("" + data + " -> ");

            if (Next != null)
            {
                Next.Print();
            }
        }

        public void AddToEnd(int data)
        {
            if(Next == null)
            {
                Next = new Node(data);
            }
            else
            {
                Next.AddToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            if (Next == null)
            {
                Next = new Node(data);
            }
            else if(data < Next.data)
            {
                Node temp = new Node(data);

                temp.Next = Next;
                Next = temp;
            }
            else
            {
                Next.AddSorted(data);
            }
        }

    }

    class MyList
    {
        public Node headNode;

        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd (int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }

        public void AddToBeginning(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.Next = headNode;
                headNode = temp;
            }
        }

        public void AddSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                AddToEnd(data);
            }
        }

        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Node MyNode = new Node(7);
            //MyNode.AddToEnd(5);
            //MyNode.AddToEnd(1);
            //MyNode.AddToEnd(10);
            //MyNode.AddToEnd(45);

            //MyNode.Print();

            MyList list = new MyList();

            //list.AddToEnd(7);
            //list.AddToEnd(8);
            //list.AddToEnd(6);
            //list.AddToEnd(9);
            //list.AddToEnd(3);

            //list.Print();
            //Console.WriteLine("\n");

            //list.AddToBeginning(7);
            //list.AddToBeginning(8);
            //list.AddToBeginning(6);
            //list.AddToBeginning(9);
            //list.AddToBeginning(3);


            //list.Print();
            //Console.WriteLine("\n");

            list.AddSorted(7);
            list.AddSorted(8);
            list.AddSorted(6);
            list.AddSorted(9);
            list.AddSorted(3);


            list.Print();
            Console.WriteLine("\n");

        }
    }
}
