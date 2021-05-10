using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null) //CHECKING CONDITION FOR ASSUPTION OF NODE
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);

        }

        //At the front of the linked list 
        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);// Allocate the Node & Put in the data

         new_node.next = this.head;//THE PREVIOUS HEAD WILL ATTACHED TO NODE

            this.head = new_node; // THE NEW NODE WILL ATC AS HEAD
            Console.WriteLine($"Inserted into front {new_node.data}"); 

        }
        public void Append(int new_data)
        {
            Node new_node = new Node(new_data);// Allocate the Node & Put in the data

            // If the Linked List is empty then make the new node as head 
            if (head == null)
            {
                head = new Node(new_data);
                return;
            }

            else
            {
                new_node.next = null; //New node will be assumed null

                Node last = head; //Transversed head to end
                while (last.next != null)
                
                    last = last.next;
                

                // . Change the next of last node 
                last.next = new_node;
                return;
            }
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //temp=null
            }
            Console.WriteLine();
        }

    }
}
