/******************************************************************************
POLINOMIAL

*******************************************************************************/

using System;

public class LinkedList // The definition of a linked list
{
    public Node head;              // head of list  
    public class Node              // the constructor
    {
        public int exp;
        public int coef;
        public Node next;
        public Node(int p_exp,int p_coef)
        {
            exp = p_exp;
            coef = p_coef;
            next=null;
            
        }
    }

    public void AddFirst(int p_exp,int p_coef) //adding a node in a front of a list
    {
        Node new_node = new Node(p_exp,p_coef);
        new_node.next = head;
        head = new_node;
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


 public double Value(double x) // prints out all nodes of a list
    {
        double value=0;
        Node n = head;
        while (n != null)
        {
            value+=n.coef*Math.Pow(x,n.exp);
            n = n.next;
        }
        
       return value;
    }
    
 

 public LinkedList Derivatives() // prints out all nodes of a list
    {
        LinkedList W= new LinkedList();
        Node n = head;
        
        Console.Write("Derivatives-W(x)= ");
       
        while (n != null){
            if(n.exp>0)
            {
       
             W.AddFirst(n.exp-1,n.exp*n.coef);
            }
            n = n.next;
        }
        
        return W;
       
    }
   
    
 public LinkedList Carp(int a) // prints out all nodes of a list
 
    {
        LinkedList C= new LinkedList();
        Console.Write("multiply by a="+ a +" --> ");
        Node n = head;
        while (n != null)
        {
            if(a!=0)
            {
            C.AddFirst(n.exp,a*n.coef);
            }
            
            else{
                C.AddFirst(n.coef,n.exp);
                Console.Write("a=0");
            }
            n = n.next;
        }
        
       return C;
    }


    public void PrintList() // prints out all nodes of a list
    {
        Node n = head;
        Console.Write("P(x)= ");
       while (n != null)
     
         {
            if (n.coef==1) 
            {
                Console.Write("x^"+n.exp);
            }
            else if (n.coef==-1) 
            {
                Console.Write("-x^"+n.exp);
            }
            else if (n.exp==1) 
            {
                Console.Write(n.coef+"x");
            }
            
            else if (n.exp==0) 
            {
                Console.Write(n.coef);
            }
            
            else 
            {
                Console.Write(n.coef+"x^"+n.exp);
            }
            
            if (n.next !=null && n.next.coef>0) 
            { 
                Console.Write(" + "); 
                
            }
            
            n = n.next;
        }
    Console.WriteLine();

} //class


public class Program
{

    // Main method 
    static public void Main()
    {

        LinkedList P = new LinkedList();

         P.AddFirst(3,-1);
         P.AddFirst(2,2);
         P.AddFirst(1,4);
         P.AddFirst(0,-4);
         
         
         P.ReverseLinkedList();
         P.PrintList() ;
         
         
         double x=2;
         Console.WriteLine("P("+ x +")="+ P.Value(x));
         
         x=0;
         Console.WriteLine("P("+ x +")="+ P.Value(x));
         
         
         
         LinkedList W = P.Derivatives();
         W.ReverseLinkedList();
         W.PrintList();
         x=0;
         Console.WriteLine("w("+ x +")="+ W.Value(x));
         
         
      
         int a=3;
         LinkedList C = P.Carp(a);
         C.ReverseLinkedList();
         C.PrintList();
         
   

        //Console.WriteLine(lst.head.data);

        //Console.ReadKey();

    }
}
}




