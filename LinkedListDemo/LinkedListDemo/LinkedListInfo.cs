using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    // Linked list is a linear data structure 
    // it consists of groups of nodes in a sequence
    // 1 Data - each node of a linked list can store a data.
    // 2 Address - each node of a linked list contains an address to the next node, "next"
    internal class LinkedListInfo
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(head == null )
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data);
        }
    }
}
