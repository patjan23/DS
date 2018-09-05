using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    class Program
    {

        public class LinkedList
        {
            public Node head;

            public class Node
            {
                public int data;
                public Node next;

                Node(int d)
                {
                    data = d;
                    next = null;
                }
            }

            /* Function to reverse the linked list */
            Node reverse(Node node)
            {
                Node prev = null;
                Node current = node;
                Node next = null;
                while (current != null)
                {
                    next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }
                node = prev;
                return node;
            }


            // prints content of double linked list
            void printList(Node node)
            {
                while (node != null)
                {
                    Console.WriteLine (node.data + " ");
                    node = node.next;
                }
            }
        }
        static void Main(string[] args)
        {
      //      LinkedList list = new LinkedList();
      //      list.head = new Node(1);
      //      list.head.next = new Node(2);
      //      list.head.next.next = new Node(3);
      //      list.head.next.next.next = new Node(4);
      //      list.head.next.next.next.next = new Node(5);
            
             

      //      list.print(); // print original list
      ////      list.rearrange(head); // rearrange list as per ques
      //      Console.WriteLine("");
      //      list.print(); // print modified list
            Console.ReadKey(); 
        }
    }
}
