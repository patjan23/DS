using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimBST
{
    class Program
    {


        class Node
        {
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

        class Tree
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
                Node newNode = new Node();
                newNode.item = id;
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

            public Node trim(Node root, int min, int max)
            {
                // Base case: leaves' children are null
                if (root == null)
                    return root;
                // Case: current value too small - use trimmed right subtree
                if (root.item < min)
                    return trim(root.rightc, min, max);
                // Case: current value too large - use trimmed left subtree
                else if (root.item > max)
                    return trim(root.leftc, min, max);
                // Case: current value in range - trim both subtrees
                else if (min <= root.item && root.item <= max)
                {
                    root.leftc = trim(root.leftc, min, max);
                    root.rightc = trim(root.rightc, min, max);
                    return root;
                }
                // Make sure we've covered all the cases
                // (this should be unreachable if our cases are complete)
                return root;
            }
        }
        static void Main(string[] args)
        {
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
            Console.WriteLine("Inorder Traversal : ");
            theTree.Inorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            theTree.Preorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            theTree.Postorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
           

            theTree.trim(theTree.ReturnRoot(), 3, 8);
            theTree.Inorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.ReadLine();

        }
    }
}
