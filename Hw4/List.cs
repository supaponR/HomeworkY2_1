using System;
using System.Collections.Generic;
using System.Text;

namespace Hw4
{
    class List
    {
        private Node head;
        private Node tail;
        private int length;

        public int Length
        {
            get
            {
                return length;
            }
        }

        public void Insert(Node node, int index)
        {
            if (index > length)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == 0) //แทนโหนดหัว
            {
                if (head is null)//ถ้าชี้ว่าง ก็ให้ไปชี้โหนดใหม่
                {
                    head = node;
                }
                if (tail is null)//ถ้าโหนดท้ายว่างก็ให้ชี้ห่าง
                {
                    tail = node;
                }
                if (!(head is null || tail is null)) //ถ้าทั้งหัวทั้งหางไม่ว่าง
                {
                    node.nextNode = head; //โหนดมาใหม่ให้ชี้ไปที่หัว
                    head.prevNode = node;// ให้โหนดก่อนหน้าไปชี้โหนดใหม่ที่เข้ามา
                    head = node;//เปลี่ยนพ้อยเตอร์ที่ชี้หัว ให้ชี้โหนดใหม่ที่เข้ามา
                }
            }
            else if (index == length)
            {
                node.prevNode = tail;
                tail.nextNode = node;
                tail = node;
            }
            else
            {
                Node ptr = head;
                while (index > 0)
                {
                    ptr = head.nextNode;
                }
                ptr.prevNode.nextNode = node;
                node.prevNode = ptr.prevNode;
                node.nextNode = ptr;
                ptr.prevNode = node;
            }
            length++;

        }


        public Node GetNode(int index)
        {
            if (index >= length)
            {
                throw new IndexOutOfRangeException();
            }

            Node ptr = head;
            while (index > 0)
            {
                ptr = ptr.nextNode;
                index--;
            }

            return ptr;
        }


    }
}
