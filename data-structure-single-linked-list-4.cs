//Single Linked List - version 4
using System;

public class LinkedList // The definition of a linked list
{
    public Node head;              // head of list  
    public class Node              // the constructor
    {
        public int exp;
        public int coef;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public void AddFirst(int p_exp,int p_coef) //adding a node in a front of a list
    {
        Node new_node = new Node(p_exp,p_exp);
        new_node.next = head;
        head = new_node;
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

    public void AddLast(int new_data)
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

    public void InsertAfter(int prev_key, int new_data)
    {
        Node n = head;
        while (n != null && n.data != prev_key)
        {
            n = n.next;
        }
        Node new_node = new Node(new_data);
        new_node.next = n.next;
        n.next = new_node;
    }


    public void InsertBefore(int next_key, int new_data)
    {
        if (head == null) return;
        if (head.data == next_key)
        {
            AddFirst(new_data);
            return;
        }

        Node prev = null;
        Node cur = head;

        while (cur != null && cur.data != next_key)
        {
            prev = cur;
            cur = cur.next;
        }
        
        Node new_node = new Node(new_data);

        prev.next = new_node;
        new_node.next = cur;

    }

    public void Update(int key, int new_data)
    {
        if (head == null) return;
        if (head.data == key)
        {
            AddFirst(new_data);
            return;
        }

        Node prev = null;
        Node cur = head;

        while (cur != null && cur.data != key)
        {
            prev = cur;
            cur = cur.next;
        }
        
            prev.next = cur;
            cur.data = new_data;
    }
    

    public void ReverseLinkedList()
    {
        Node prev = null;
        Node current = head;
        Node temp = null;
        while (current != null)
        {
            temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }
        head = prev;
    }

    public void DeleteNodebyKey(int key)
    {
        Node temp = head;
        Node prev = null;
        if (temp != null && temp.data == key)
        {
            head = temp.next;
            return;
        }
        while (temp != null && temp.data != key)
        {
            prev = temp;
            temp = temp.next;
        }
        if (temp == null)
        {
            return;
        }
        prev.next = temp.next;
    }



    public void PrintList() // prints out all nodes of a list
    {
        Node n = head;
        while (n != null)
        {
            Console.Write(n.data + " ");
            n = n.next;
        }
        Console.WriteLine();
    }

} //class


public class Program
{

    // Main method 
    static public void Main()
    {

        LinkedList lst = new LinkedList();

        lst.AddFirst(1);
        lst.AddFirst(3);
        lst.AddFirst(5);
        lst.AddLast(7);
        lst.InsertAfter(7, 6);
        //lst.Update(7, 100);
        

        lst.PrintList();
        lst.ReverseLinkedList();
        lst.PrintList();
        lst.DeleteNodebyKey(3);
        lst.InsertBefore(5, 200);
        lst.PrintList();
        lst.Update(1,33);
        lst.PrintList();
        //Console.WriteLine(lst.head.data);

        //Console.ReadKey();

    }
}


