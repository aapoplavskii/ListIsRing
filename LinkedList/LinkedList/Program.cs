using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static List<Node> nodesnext = new List<Node>();
        static void Main(string[] args)
        {
            var finish = false;

            var first = new Node(7);

            var second = new Node(3);
            first.Next = second;

            var third = new Node(3);
            second.Next = third;

            var fourth = new Node(8);
            third.Next = fourth;
            fourth.Next = second;

            if (IsRing(first))
            {
                Console.WriteLine($"У нас кольцо на элементе - {first.Value}");
                finish = true;
            }

            if (!finish)
            {
                if (IsRing(second))
                {
                    Console.WriteLine($"У нас кольцо на элементе - {second.Value}");
                    finish = true;
                }
            }

            if (!finish)
            {
                if (IsRing(third))
                {
                    Console.WriteLine($"У нас кольцо на элементе - {third.Value}");
                    finish = true;
                }
            }

            if (!finish)
            {
                if (IsRing(fourth))
                {
                    Console.WriteLine($"У нас кольцо на элементе - {fourth.Value}");
                    finish = true;
                }
            }

            if (!finish)
                Console.WriteLine("Наш связный список без кольца!");

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
