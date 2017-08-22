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
            Root = null;
        }

        public void CraftTree()
        {
            Root = new Node('Z');
        }

    }
}
