using System;
using System.Collections.Generic;
using System.Text;

namespace HW3
{
    
    class Node { protected Node next = null; }
    class CPU : Node
    {
        public CPU Next
        {
            get { return next as CPU; }
            set { next = value; }
        }
        

    }



}
