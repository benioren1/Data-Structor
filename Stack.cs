using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekInData
{
    public class Stack
    {
        public Node Top { get; set; }
        public int count { get; set; }

        public Stack() { }
        public Stack(int data) 
        {
        
            Top = new Node(data);
            count = 0;
            
       
        }

        public  void push(int data)
        {
            if (Top == null)
            {
                Top = new Node(data);
                count++;
            }
            else 
            {
                Node newnode = new Node(data);
                newnode.Next = Top;
                Top = newnode;
                count++;
            }
        }

        public int Pop()
        {
            int data = Top.Data;
            Top = Top.Next;
            count --;
            return data;
            
        }

        public int peek()
        {

            return Top.Data;
        
        }

        public int counter()
        {
            return count;
        
        }




    }
}
