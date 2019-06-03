/******************************************************************************
Linked list3

*******************************************************************************/
using System;

namespace LinkedList3
{
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

    public class LLst
    {
        public Node head;

        public Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

      public void push(int new_data)
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
       
       
       
       

    class Program
    {
        static void Main(string[] args)
        {
            LLst LL = new LLst();
           

           
            Console.ReadKey();
        }
    }
}}