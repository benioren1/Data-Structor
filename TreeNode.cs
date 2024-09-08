using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekInData
{
    public class TreeNode1
    {
        public int Data { get; set; }
        public TreeNode1 Left { get; set; }
        public TreeNode1 Right { get; set; }

        public TreeNode1(int data)
        { 
        
            this.Data = data;
            Left = null;
            Right = null;
        
        }



    }
}
