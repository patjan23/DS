using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextRandomPointer
{
    class Program
    {

       public class Node
        {
            public int data;//Node data
          public  Node next, random;//Next and random reference

            //Node constructor
            public Node(int data)
            {
                this.data = data;
                this.next = this.random = null;
            }
        }

        // linked list class
        class LinkedList
        {
             public Node head;//Linked list head reference

            // Linked list constructor
            public LinkedList(Node head)
            {
                this.head = head;
            }

            // push method to put data always at the head
            // in the linked list.
            public void push(int data)
            {
                Node node = new Node(data);
                node.next = this.head;
                this.head = node;
            }

            // Method to print the list.
             public void print()
            {
                Node temp = head;
                while (temp != null)
                {
                    Node random = temp.random;
                    int randomData = (random != null) ? random.data : -1;
                    Console.WriteLine("Data = " + temp.data +
                                       ", Random data = " + randomData);
                    temp = temp.next;
                }
            }

            // Actual clone method which returns head
            // reference of cloned linked list.
            public LinkedList clone()
            {
                // Initialize two references, one with original
                // list's head.
                Node origCurr = this.head, cloneCurr = null;

                // Hash map which contains node to node mapping of
                // original and clone linked list.
                Dictionary<Node, Node> map = new Dictionary<Node, Node>();

                // Traverse the original list and make a copy of that
                // in the clone linked list.
                while (origCurr != null)
                {
                    cloneCurr = new Node(origCurr.data);
                    map.Add(origCurr, cloneCurr);
                    origCurr = origCurr.next;
                }

                // Adjusting the original list reference again.
                origCurr = this.head;

                // Traversal of original list again to adjust the next
                // and random references of clone list using hash map.
                while (origCurr != null)
                {
                    cloneCurr = map[origCurr]; //(origCurr);
                    cloneCurr.next = map[origCurr.next];
                    cloneCurr.random = map[origCurr.random];
                    origCurr = origCurr.next;
                }

                //return the head reference of the clone list.
                return new LinkedList(map[this.head]);
            }
        }

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(new Node(5));
           

            // Making a clone of the original linked list.
            LinkedList clone = list.clone();

            // Print the original and cloned linked list.
            Console.WriteLine("Original linked list");
            list.print();
            Console.WriteLine("\nCloned linked list");
            clone.print();
        }
    }
}
