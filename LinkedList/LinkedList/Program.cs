using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static List<Node> nodesnext = new List<Node>();
        static void Main(string[] args)
        {
            var first = new Node(7);

            var second = new Node(3);
            first.Next = second;

            var third = new Node(3);
            second.Next = third;

            var fourth = new Node(8);
            third.Next = fourth;
            fourth.Next = first;

            FindRing(first);
        
            Console.ReadKey();
        }

        public static bool IsRing(Node node)
        {
            nodesnext.Add(node);

            if (nodesnext.Contains(node.Next))
                return true;
            else
                return false;

        }

        public static void FindRing(Node node)
        {
            if (IsRing(node))
            {
                Console.WriteLine($"У нас кольцо на элементе - {node.Value}");
            }
            else
            {
                if (node.Next != null)
                {
                    FindRing(node.Next);
                }
                else
                {
                    Console.WriteLine("Наш связный список без кольца!");
                }
            }

        }
    }
}
