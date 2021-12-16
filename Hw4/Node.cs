using System;
using System.Collections.Generic;
using System.Text;

namespace Hw4
{
    class Node
    {
        public string name;
        
        public int distance;

        public Node prevNode;
        public Node nextNode;

        public Node(string nameValue,  int distanceValue)
        {
            name = nameValue;
            distance = distanceValue;
            prevNode = null;
            nextNode = null;

        }
    }
}
