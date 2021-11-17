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

            var tmp = first;

            while (true)
            {
                if (IsRing(tmp))
                {
                    Console.WriteLine($"У нас кольцо на элементе - {tmp.Value}");
                    break;
                }

                if (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                else
                {
                    Console.WriteLine("Наш связный список без кольца!");
                    break;
                }

            }
        
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
    }
}
