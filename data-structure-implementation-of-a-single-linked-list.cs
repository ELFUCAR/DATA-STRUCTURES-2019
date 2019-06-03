//---------------------------------------
//implementation of a single linked list
//----------------------------------------

using System;

namespace LinkedList
{
    public class LinkedList
    {
        Node head; // head of list  
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            } 
        }

        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
            Console.WriteLine();
        }


        public static void Main(String[] args)
        {
     
            LinkedList lst = new LinkedList();

            lst.head = new Node(2);
            Node second = new Node(3);
            Node third = new Node(5);
            Node fourth = new Node(7);

            lst.head.next = second;
            second.next = third;
            third.next = fourth;
            lst.printList();

            //Console.ReadLine();
  
        }
    }

    
}


