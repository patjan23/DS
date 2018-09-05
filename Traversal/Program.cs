using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal
{
    class Program
    {

        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        public class BinaryTree
        {
            // Root of Binary Tree
            public Node root;
            public BinaryTree()
            {
                root = null;
            }


            /* Given a binary tree, print its nodes according to the
              "bottom-up" postorder traversal. */
            void printPostorder(Node node)
            {
                if (node == null)
                    return;

                // first recur on left subtree
                printPostorder(node.left);

                // then recur on right subtree
                printPostorder(node.right);

                // now deal with the node
                Console.Write(node.key + " ");
            }

            /* Given a binary tree, print its nodes in inorder*/
            void printInorder(Node node)
            {
                if (node == null)
                    return;

                /* first recur on left child */
                printInorder(node.left);

                /* then print the data of node */
                Console.Write(node.key + " ");

                /* now recur on right child */
                printInorder(node.right);
            }

            /* Given a binary tree, print its nodes in preorder*/
            void printPreorder(Node node)
            {
                if (node == null)
                    return;

                /* first print data of node */
                Console.Write(node.key + " ");

                /* then recur on left sutree */
                printPreorder(node.left);

                /* now recur on right subtree */
                printPreorder(node.right);
            }

            public void printPostorder() { printPostorder(root); }
            public void printInorder() { printInorder(root); }
            public void printPreorder() { printPreorder(root); }
        }

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.Write("Preorder traversal of binary tree is ");
            tree.printPreorder();

            Console.Write("\nInorder traversal of binary tree is ");
            tree.printInorder();

            Console.Write("\nPostorder traversal of binary tree is ");
            tree.printPostorder();
        }
    }
}

    /*

    using System;
// you can also use other imports, for example:
 using System.Collections.Generic;
using System.Linq;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
    {
        public int solution(Point2D[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            List<float> slope1 = new List<float>();
            List<float> slope2 = new List<float>();
            List<float> slope3 = new List<float>();
            List<float> slope4 = new List<float>();
            //int i = 0;
            foreach (var k in A)
            {
                // Console.Write(k.x);
                //  Console.Write(k.y);
                if ((k.y > 0) && (k.x > 0))
                    slope1.Add((float)(0 - k.y) / (0 - k.x));

                if ((k.y > 0) && (k.x < 0))
                    slope2.Add((float)(0 - k.y) / (0 - k.x));

                if ((k.y < 0) && (k.x < 0))
                    slope3.Add((float)(0 - k.y) / (0 - k.x));

                if ((k.y < 0) && (k.x > 0))
                    slope4.Add((float)(0 - k.y) / (0 - k.x));

            }
            return slope1.Distinct().Count() + slope2.Distinct().Count() + slope3.Distinct().Count() + slope4.Distinct().Count();


        }*/
