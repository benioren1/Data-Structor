using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekInData
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node(int d)
        {
            Data = d;
            Next = null;
        }
        public int Getvalue(Node node)
        { 
        
        return node.Data;
        }
        public Node GetNext(Node node)
        {
            
                return node.Next;

        }

        public void SetValue(Node node,int data)
        { 
        
            node.Data = data;
        }
        public void SetNext(Node node, Node newnode)
        {

            node.Next = newnode;

        }



    }
}
