/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

namespace LinkedList4
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


        public void printList() // prints out all nodes of a list
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
            Console.WriteLine();
        }
        public Node pop()
        {
            LLst TL = new LLst();
            Node lastNode = GetLastNode();

            return lastNode;
        }

        class Program
        {
            static void Main(string[] args)
            {
                LLst stack = new LLst();

                stack.push(4);
                stack.push(7);
                stack.push(0);


                stack.pop();

                Node n = stack.pop();
                Console.WriteLine(n.data + " was taken from the top");

               /*stack.pop();
                n = stack.pop();
                Console.WriteLine(n.data + " was taken from the top");  */

                //stack.printlist();

                Console.ReadKey();
            }
        }
    }
}