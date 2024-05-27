using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace BankingCashOpearation
{
   class Node
    {
        public String data;
        public Node next;
        public Node(string data)
        {
            this.data = data;
            next = null;
        }        
    }
    internal class Queue
    {
        Node head = null;
        Node tail = null;
        
        public void EnQueue(string data)
        {

            Queue  q = new Queue();
           
            Node node = new Node(data);

            //checking queue is empty
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }

            Console.WriteLine("added in queue successfully");
        }

        public void ViewQueue()
        {
            Node loop = head;

            if (head == null)
            {
                Console.WriteLine("List is empty");                
            }
            while (loop != null)
            {
                Console.WriteLine("Names are :"+loop.data);
                loop = loop.next;
            }
        }
        public void Dequeue()
        {
            //FIFO  =>23 =>34
            //remove data from head

            if(head != null)
            {
                if(head.next != null)
                {
                    head = head.next;                    
                }
            }
            else
            {
                Console.WriteLine("list is empty");
            }                       
        }

        public string Find()
        {
            Node loop = null;
            loop = head;
             
            return loop.data;                         
        }
        public void IsEmpty()
        {
            if(head == null)
            {
                Console.WriteLine("Queue is empty");
                //return "Queue is empty";
            }

            Console.WriteLine("Not Empty");
        }
        public void Size()
        {
            int size = 0;
            Node loop = null;
            loop = head;
            while (loop != null)
            {
                size++;
                loop = loop.next;
            }
            Console.WriteLine("size of queue is :"+size);
        }
    }
}
