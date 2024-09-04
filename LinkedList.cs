using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekInData
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList() { }

        //o(1)
        public LinkedList(int data)
        {
        
            Head = new Node(data);
        
        }
        //o(n)
        public void Add(int data)
        {
            if (Head == null)
            {
                Node newNode = new Node(data);
                Head = newNode;
                return;
            }
            if (Head != null)
            {
                if (Head.Data == null)
                {
                    Head.Data = data;
                    return;
                }
                Node newNode = new Node(data);
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        //o(n)
        public string Display()
        {
            Node current = Head;
            string values = "";
            if (current != null)
            {
                values += current.Data.ToString();
                current = current.Next;
            }
            while (current != null)
            {
                values += " -> " + current.Data;
                current = current.Next;
            }
            return values;
        }

        //o(n)
        public int Length()
        {
            int count = 0;  
            Node current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        //o(n)
        public void RemoveValue(int data)
        {
            if (Head == null)
                return;
            Node current = Head;
            if (current.Data == data)
            { 
               Head = Head.Next;
                return;
            }
            while (current.Next != null)
            {
                if (current.Next.Data  == data)
                { 
                
                    current.Next = current.Next.Next;
                    break;
                }
                current = current.Next;
            }
            
        }

        //o(n)
        public void RemoveAllValues(int data)
        {
            while (Head != null && Head.Data == data)
            {
                Head = Head.Next; 
            }
            Node current = Head;
            while (current != null && current.Next != null)
            {
                if (current.Next.Data == data)
                {
                   
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }
        }
        //o(n)
        public void RemoveIndex(int index)
        {
            if (index == 0)
            {
                if (Head != null)
                {
                    Head = Head.Next;
                }
                return;
            }
            if (Head == null || index < 0)
            {
                return;
            }
            Node temp = Head;
            Node prev = null;
            for (int i = 0; i < index && temp.Next != null; i++)
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp != null && prev != null)
            {
                prev.Next = temp.Next;
            }
        }
        //o(n)
        public int Find(int data)
        {
            Node current = Head;
            int count = 0;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return count;
                }
                count++;
                current = current.Next;
            }
            return -1;
        }

       //o(n)
        public int Get(int index)
        {
            Node current = Head;
            int count = 0;
            while (current != null)
            {
                if (count== index)
                {
                    return current.Data;
                }
                count++;
                current = current.Next;
            }
            return -1;
        }





    }
}
