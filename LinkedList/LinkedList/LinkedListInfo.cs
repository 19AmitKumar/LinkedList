using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //LinkedList is a linear Data structure
    //It consist of group of nodes in a squence
    //Data-Ecach node of a linkedlist store data
    //Address-Each node of a LikedList contains the adress of next node,"next"
    internal class LinkedListInfo
    {
        public Node head;
        
        public void Add(int data)
        {
            Node node=new Node(data);
            if(head == null)
            {
                this.head=node;
            }
            else
            {
                Node temp=head;
                while(temp.next!=null) 
                { 
                    temp=temp.next;
                }
                temp.next=node;
            }
            Console.WriteLine(node.data);
        }
        public void Display()
        {
            Node temp = head;
            if(temp == null)
            {
                Console.WriteLine("Linked List is Empty");

            }
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

        }
    }
}
