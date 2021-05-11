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
            if (this.head == null) //CHECKING CONDITION FOR ASSUMPTION OF NODE
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


        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine($"Invalid Position{ position}");
            }
            if (position == 1)
            {
                var newNode = new Node(data); //create object and passing data
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;//
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine($"Position Out Of Range{ position}");
                }
            }
            return head;
        }
        public void DeleteFirstNode()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            head = temp.next;
            Console.WriteLine($"Successfully Delete First Element {temp.data}");

        }
 /// <summary>
 /// /
 /// </summary>
        public void DeleteLastNode()//Last node deletation
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }

                Console.WriteLine($"Successfully Delete Last Element {temp.next.data}");
                temp.next = null;
            }

        }

        //SEARCH SPECIFIC LEMENT IN LINKED LIST
        public bool search( int x)
        {
            Node current = head; // Initialize current
            while (current != null)
            {
                if (current.data == x)
                    return true; // data found
                current = current.next;
            }
            return false; // data not found
        }
        public void InsertAtAfterValue(int after, int data)
        {

            if (head == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            else
            {
                Node temp = head;

                while (temp != null)
                {
                    if (temp.data == after)
                    {
                        Node node = new Node(data);
                        node.next = temp.next;//Make next of new Node as  next of prev_node
                        temp.next = node;//ake next of prev node  as newnode
                        break;
                    }
                    temp = temp.next;
                }
                Console.WriteLine($"Successfully added Element {after} After {data}");


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
