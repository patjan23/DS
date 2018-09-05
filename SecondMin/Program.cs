using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondMin
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
            void printPreorder(Node node, List<int> k)
            {
               
                if (node == null)
                    return;
                k.Add(node.key);

                /* first print data of node */
                Console.Write(node.key + " ");

                /* then recur on left sutree */
                printPreorder(node.left,k);

                /* now recur on right subtree */
                printPreorder(node.right,k);
            }

            public void printPostorder() { printPostorder(root); }
            public void printInorder() { printInorder(root); }
            public void printPreorder(List<int> k) { printPreorder(root,k); }
        }

        static void Main(string[] args)
        {

            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            List<int> k = new List<int>();
            Console.Write("Preorder traversal of binary tree is ");
            tree.printPreorder(k);
            k.Sort();
            Console.Write("Second smallest : " + k[1]  );
            Console.ReadKey();
        }
    }
}
