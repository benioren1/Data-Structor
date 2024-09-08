using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekInData
{
    internal class Queue1
    {

        public Node Head {  get; set; }
        public Node tail { get; set; }
        public int Count { get; set; }

        public Queue1() { }
        public Queue1(int data)
        {
            Head = new Node(data);
            tail = Head;
            Count ++;
        }

        public void Equeue(int data)
        {
            Node newnode = new Node(data);
            if (tail == null)
            {
                Head = newnode;
                tail = newnode;
            }
            else
            {

                tail.Next = newnode;
                tail = newnode;
                Count++;
            }
        }

        public int Dequeue()
        {
            

            int data = Head.Data;
            Head = Head.Next;
            if (Head == null)
            {
                tail = null; // If the queue becomes empty, update Tail as well
            }
            Count--;
            return data;
        }
        public int peek()
        { 
        
            return Head.Data;
        
        
        }


    }
}
