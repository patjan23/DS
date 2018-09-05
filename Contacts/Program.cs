using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Program
    {

        public  class Node
        {
            public int occurences;
           public  Dictionary<char, Node> children = new Dictionary<char, Node>();

            public Node()
            {
                occurences = 1;
            }
        }

        public  class Trie
        {
            Node root;

            public Trie()
            {
                root = new Node();
            }
            public void addName(String s)
            {
                Node current = root;
                for (int i = 0; i < s.Length; i++)
                {
                    if (current.children.ContainsKey(s[i]))
                    {
                        // Move to node and increment occurences
                        current = current.children[s[i]];
                        current.occurences++;
                    }
                    else
                    {
                        // Make new node and update current
                        Node newNode = new Node();
                        current.children.Add(s[i], newNode);
                        current = newNode;
                    }
                }
            }
            public int findPartial(String s)
            {
                Node current = root;
                for (int i = 0; i < s.Length; i++)
                {
                    if (!current.children.ContainsKey(s[i]))
                    {
                        return 0; // Key not found
                    }
                    else
                    {
                        current = current.children[s[i]];
                    }
                }
                return current.occurences;
            }
        }


        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Trie trie = new Trie();
            List<string> oplst = new List<string>();
            List<string> nameLst = new List<string>();
            List<string> contactlst = new List<string>();
            for (int a0 = 0; a0 < n; a0++)
            {
                string[] tokens_op = Console.ReadLine().Split(' ');
                string op = tokens_op[0];
                string contact = tokens_op[1];
                oplst.Add(op);
                contactlst.Add(contact);
            }

            for (int a0 = 0; a0 < n; a0++)
            {
                if (oplst[a0] == "add")
                    trie.addName(contactlst[a0]);
                else
                {
                    //  int k = nameLst.Where(s => s.Contains(contactlst[a0])).Count();
                    int k = trie.findPartial(contactlst[a0]);
                    Console.WriteLine(k);
                }

            }
            Console.ReadKey();


        }
    }
}
