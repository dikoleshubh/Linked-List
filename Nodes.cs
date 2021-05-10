using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    class Node
    {
        public int data; // integer value store data
        public Node next;

       
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
