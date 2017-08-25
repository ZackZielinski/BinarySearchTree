using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int? Data;
        public Node LeftChild;
        public Node RightChild;

        public Node(int Data)
        {
            this.Data = Data;
            LeftChild = null;
            RightChild = null;
        }
    }
}
