using System;

namespace HeightOfTree
{
    /*
    1. If tree is empty then return 0
2. Else
     (a) Get the max depth of left subtree recursively  i.e., 
          call maxDepth( tree->left-subtree)
     (a) Get the max depth of right subtree recursively  i.e., 
          call maxDepth( tree->right-subtree)
     (c) Get the max of max depths of left and right 
          subtrees and add 1 to it for the current node.
         max_depth = max(max dept of left subtree,  
                             max depth of right subtree) 
                             + 1
     (d) Return max_depth
     */
    class Program
    {

        public class Node
        {
            public Node(int p)
            {
                item = p;
            }
            public int item;
            public Node leftc;
            public Node rightc;
            public void display()
            {
                Console.Write("[");
                Console.Write(item);
                Console.Write("]");
            }
        }

        public class Tree
        {
            public Node root;
            public Tree()
            {
                root = null;
            }
            public Node ReturnRoot()
            {
                return root;
            }
            public void Insert(int id)
            {
                Node newNode = new Node(id);
               // newNode.item = id;
                if (root == null)
                    root = newNode;
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;
                        if (id < current.item)
                        {
                            current = current.leftc;
                            if (current == null)
                            {
                                parent.leftc = newNode;
                                return;
                            }
                        }
                        else
                        {
                            current = current.rightc;
                            if (current == null)
                            {
                                parent.rightc = newNode;
                                return;
                            }
                        }
                    }
                }
            }
            public void Preorder(Node Root)
            {
                if (Root != null)
                {
                    Console.Write(Root.item + " ");
                    Preorder(Root.leftc);
                    Preorder(Root.rightc);
                }
            }
            public void Inorder(Node Root)
            {
                if (Root != null)
                {
                    Inorder(Root.leftc);
                    Console.Write(Root.item + " ");
                    Inorder(Root.rightc);
                }
            }
            public void Postorder(Node Root)
            {
                if (Root != null)
                {
                    Postorder(Root.leftc);
                    Postorder(Root.rightc);
                    Console.Write(Root.item + " ");
                }
            }

           public int MaxHeight(Node p)
            {
                if( p== null)
                   return 0;

                int leftDepth = MaxHeight(p.leftc);
                int rightDepth = MaxHeight(p.rightc);
                if (leftDepth > rightDepth)
                    return leftDepth + 1;
                else
                    return rightDepth + 1;
            }
        }

        static void Main(string[] args)
        {
            /* Tree tree = new Tree();
             tree.root = new Node(1);
             tree.root.leftc = new Node(2);
             tree.root.rightc = new Node(3);
             tree.root.leftc.leftc = new Node(4);
             tree.root.leftc.rightc = new Node(5);*/

            Tree theTree = new Tree();
            theTree.Insert(1);
            theTree.Insert(2);
            theTree.Insert(3);
            theTree.Insert(4);
            theTree.Insert(5);
            theTree.Insert(6);
            theTree.Insert(7);
            theTree.Insert(8);
            theTree.Insert(9);
            theTree.Insert(10);
            theTree.Insert(11);
            theTree.Insert(12);
            theTree.Insert(13);
            theTree.Insert(14);
            theTree.Insert(15);
            int height = theTree.MaxHeight(theTree.root);
            Console.WriteLine(" height = {0}", height);
            Console.ReadKey();
        }
    }
}
