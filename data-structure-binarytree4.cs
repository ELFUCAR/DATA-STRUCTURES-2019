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

bool isBST(Node node, int min, int max)
    {
    /* an empty tree is BST */
        if (node == null)
           {
              return true;
           }

        if (node.data < min || node.data > max)
           {
               return false;
           }

         return (isBST(node.left, min, node.data - 1)
             && isBST(node.right, node.data + 1, max));
    }

void insert(Node root, int key)
{
    if (root == null)		
    {
        Node node = new Node(key);
        this.root = node;
    }
    else if (key < root.data)
    {
        if (root.left != null)
        {
            insert(root.left, key);
        }
        else
        {
            root.left = new Node(key);
        }
    }
    else if (key > root.data)
    {
        if (root.right != null)
        {
            insert(root.right, key);
        }
        else
        {
            root.right = new Node(key);
        }
    }
}





static public void Main(String[] args)
{
    BinaryTree tree = new BinaryTree();
    
     tree.insert(tree.root, 10);
     tree.insert(tree.root, 7);
     tree.insert(tree.root, 11);
     tree.insert(tree.root, 20);
     tree.insert(tree.root, 17);
     tree.insert(tree.root, 8);

    Console.WriteLine("Preorder traversal ");
    tree.printPreorder(tree.root);

    int min = tree.getMin(tree.root);
    int max = tree.getMax(tree.root);
    
    Console.WriteLine("\n-----------------");
    if (tree.isBST(tree.root, min, max))
        Console.WriteLine("The tree is BST");
    else
        Console.WriteLine("The tree  is not BST");
 
}
}




