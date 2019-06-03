/******************************************************************************

Linked List  06 mayıs 2019 r1

*******************************************************************************/
using System;
namespace LinkedList
{
    public class LinkedList // The definition of a linked list
    {
        Node head; 				// head of list  
        public class Node 		// the constructor
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            } 
        }

       
        //---------------------------------------------------
        
        public void AddInFront(int new_data) //adding a node in a front of a list
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
             head = new_node;
        }
        
//----------------------------------------------------------------------------------------------------
        void InsertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given node cannot be null !");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }
        
        
        public Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        
        public void Append(int new_data)
        {
            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = new_node;
        }

//----------------------------------------------------------------------------------------------------------------------  
        
        //Other methods will be placed here ...
        public static void Main(String[] args)
        {
            LinkedList lst = new LinkedList();
            //creating of nodes
            lst.head = new Node(2);
            Node second = new Node(3);
            Node third = new Node(5);
            Node fourth = new Node(7);
            //linking of nodes
            lst.head.next = second;
            second.next = third;
            third.next = fourth;
            lst.printList();

            //Console.ReadLine();
        }
    } 
}