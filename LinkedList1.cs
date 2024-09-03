using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekInData
{
    public class LinkedList1
    {
        public Node Head { get; set; }

        public LinkedList1() { }
        public LinkedList1(int data)
        {
        
            Head = new Node(data);
        
        }
        //o(n)
        public void Add(int data)
        {
            
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(data); ;
            
        }
        //o(n)
        public void Display()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write($"{current.Data}->");
                current = current.Next;
            }
        }

        //o(n)
        public void Length()
        {
            int count = 0;  
            Node current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            Console.WriteLine();
            Console.WriteLine(count);
        }

        //o(n)
        public void RemoveValue(int data)
        {
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
            Node current = Head;
            if (current.Data == data)
            {
                Head = Head.Next;
              
            }
            while (current != null)
            {
                if (current.Data == data)
                {

                    current.Next = current.Next.Next;
                    
                }
                current = current.Next;
            }

        }
        //o(n)
        public void RemoveIndex(int index)
        {
            Node current = Head;
            int count = 0;
            while (current != null)
            {
                if (count == index)
                {
                    current.Next = current.Next.Next;
                    break;
                }
                count++;
                current = current.Next;
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

        //לא סיימתי
        //public int Get(int index)
        //{
        //    Node current = Head;
        //    int count = 0;
        //    while (current != null)
        //    {
        //        if (current.Data == data)
        //        {
        //            return count;
        //        }
        //        count++;
        //        current = current.Next;
        //    }
        //    return -1;
        //}





    }
}
