using System;

class Node
{
    public int data;
    public Node left, right;

    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

class BinaryTree
{
    Node root;
    public static int counter = 0;

    BinaryTree()
    {
        root = null;
    }



    void printPreorder(Node node)
    {
        if (node == null)
            return;
        Console.Write(node.data + "-");
        printPreorder(node.left);
        printPreorder(node.right);
    }


    bool search(Node root, int key)
    {
        while (root != null)
        {
            //Console.Write(root.data + "-");
            if (key > root.data)
                root = root.right;
            else if (key < root.data)
                root = root.left;
            else
                return true;
        }
        return false;
    }

    int getMax(Node root)
    {
        int maxi = 0; 
        while (root != null)
        {
                maxi = root.data;
                root = root.right;
                
        }
        return maxi;
    }

    int getMin(Node root)
    {
        int mini = 0; 
        while (root != null)
        {
                mini = root.data;
                root = root.left;
                
        }
        return mini;
    }




     Node searchRec(Node root, int key)
    {
        if (root == null || root.data == key)
            return root;

        if (root.data > key)
            return searchRec(root.left, key);

        return searchRec(root.right, key);
    }    




    static public void Main(String[] args)
    {
        BinaryTree tree = new BinaryTree();


        tree.root = new Node(10);
        
        tree.root.left = new Node(2);
        
        
        tree.root.right = new Node(13);
        tree.root.left.left = new Node(1);
        tree.root.left.right = new Node(15);
        tree.root.right.left = new Node(11);
        tree.root.right.right = new Node(25);
        
        Console.WriteLine("Preorder traversal ");
        tree.printPreorder(tree.root);

        /*
        Console.WriteLine("\n-----------------");
        if (tree.isBST(tree.root, 0, 20))
            Console.WriteLine("The tree is BST");
        else
            Console.WriteLine("The tree not is BST");
        */

        //Console.WriteLine ("\nInorder traversal ");
        //tree.printInorder (tree.root);

        //Console.WriteLine ("\nPostorder traversal ");
        //tree.printPostorder (tree.root);

        //-------------iterative------searching----
        
        Console.WriteLine ("\n-------------------");
        int key = 5;
        Console.WriteLine ("I am looking for " + key);
        Console.WriteLine (tree.search (tree.root, key));
        
        
        
        key = 11;
        Console.WriteLine ("I am looking for " + key);
        Console.WriteLine (tree.search (tree.root, key));
        
        key = 12;
        Console.WriteLine ("I am looking for " + key);
        Console.WriteLine (tree.search (tree.root, key));

        
        //-------------recursive------searching-----
        
        
        key = 17;
        Console.WriteLine ("I am looking for " + key);
        Node what = tree.searchRec (tree.root, key);
        if (what != null)
          Console.WriteLine ("I found " + what.data);
        else
          Console.WriteLine ("I didn't find " + key);
        
       Console.WriteLine("The min is: " + tree.getMin(tree.root));    
       Console.WriteLine("The max is: " + tree.getMax(tree.root));
        

    }
}



