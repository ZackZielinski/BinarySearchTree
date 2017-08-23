using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        private Node Root;

        public BinaryTree()
        {
            Root = new Node();

        }

        public Node Add(Node Root, int value)
        {

            if (Root == null)
            {
                Root.Data = value;
            }
            else if (value < Root.Data)
            {
                Root.LeftChild = Add(Root.LeftChild, value);
            }
            else
            {
                Root.RightChild = Add(Root.RightChild, value);
            }
            return Root;

        }
        
        public Node Search(Node node, int value)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Data == value)
            {
                return node;
            }
            else if (value < node.Data)
            {
                return Search(node.LeftChild, value);
            }
            else
            {
                return Search(node.RightChild, value);
            }
        }

    }
}
