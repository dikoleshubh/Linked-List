using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Linked list Program");

            LinkedList list = new LinkedList(); //CREATING OBJECT OF LINKEDLIST CLASS

            list.InsertFront(70); // Adding data in list //UC2
            list.InsertFront(30);// Adding data in list //UC2
            list.InsertFront(56);

            Console.Read();
        }
    }
}
