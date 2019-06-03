
using System;

class Node
{
    public int key;
    public Node left, right;

    public Node(int item)
    {
        key = item;
        left = right = null;
    }
}

class BinaryTree
{
    Node root;

    BinaryTree()
    {
        root = null;
    }


    void printPostorder(Node node)
    {
        if (node == null)
            return;

        printPostorder(node.left);
        printPostorder(node.right);
        Console.Write(node.key + " ");
    }

    void printInorder(Node node)
    {
        if (node == null)
            return;
        printInorder(node.left);
        Console.Write(node.key + " ");
        printInorder(node.right);
    }

    void printPreorder(Node node)
    {
        if (node == null)
            return;

        Console.Write(node.key + " ");
        printPreorder(node.left);
        printPreorder(node.right);
    }

   
    static public void Main(String[] args)
    {
        BinaryTree tree = new BinaryTree();
        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(4);
        tree.root.left.right = new Node(5);

        Console.WriteLine("Preorder traversal ");
        tree.printPreorder(tree.root);

        Console.WriteLine("\nInorder traversal "); 
         tree.printInorder(tree.root);

        Console.WriteLine("\nPostorder traversal ");
        tree.printPostorder(tree.root);

        
    }
}






