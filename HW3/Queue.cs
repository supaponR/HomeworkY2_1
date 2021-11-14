using System;
using System.Collections.Generic;
using System.Text;

namespace HW3
{
    class Queue
    {
        public InformationChar root = null;
        public void Push(InformationChar newNode)
        {
            if( root == null)
            {
                root = newNode;
            }
            else
            {
                InformationChar info = root;
                while(info.Next != null)
                {
                    info = info.Next;
                }
                info.Next = newNode;
            }
        }

        public InformationChar Pop()
        {
            InformationChar info = root;
            root = root.Next;
            info.Next = null;
            return info;
        }

        public InformationChar Get(int index)
        {
            InformationChar info = root;
            while(index > 0)
            {
                if(info == null)
                {
                    throw new IndexOutOfRangeException();
                }
                info = info.Next;
                index--;
            }
            return info;
        }


    }
}
