using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public Node Next { get; set; }
        public int Value { get; set; }


        public Node(int a)
        {

            Value = a;
        }

    }

}
