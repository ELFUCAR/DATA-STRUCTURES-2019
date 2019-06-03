//---------------------------------------
//implementation of a single linked list (2)
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
        
        
        public void AddInFront(int new_data) //adding a node in a front of a list
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
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
            
            lst.AddInFront(100);
            
            lst.printList();
            
            //----------------------------------
            Console.Write(lst.head.data + " ");
            Console.Write(second.data + " ");
            Console.Write(third.data + " ");
    
            //Console.ReadLine();
  
        }
    }

    
}




