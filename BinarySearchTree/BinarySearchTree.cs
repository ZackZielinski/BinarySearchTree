using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        private Node Root;
        private string UserInput;
        private int UserValue;
        private Node DisplayNode;
        private int RetryCounter;

        public BinarySearchTree()
        {
            Root = null;
            DisplayNode = null;
            RetryCounter = 0;
        }

        private Node Add(Node Root, int value)
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

        private Node Search(Node node, int value)
        {
            if (node.Data != value)
            {
                Console.WriteLine("Sorry. That node is not on this tree.");
                Console.ReadLine();
                return null;
            }
            else
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

        private void CreateTree()
        {
            Root = new Node('P');
            Root.LeftChild = new Node('Q');
            Root.RightChild = new Node('R');
            Root.LeftChild.LeftChild = new Node('A');
            Root.LeftChild.RightChild = new Node('B');
            Root.RightChild.LeftChild = new Node('X');
        }

        public void StartTree()
        {
            CreateTree();

            Console.WriteLine("Select whether you would like to Add a node or Search for one.");
            UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "Add":
                    Console.WriteLine("Enter in a value to add for your node");
                    UserValue = Int32.Parse(Console.ReadLine());
                    Add(Root, UserValue);
                    break;
                case "Search":
                    Console.WriteLine("Enter in a value to search for your node");
                    UserValue = Int32.Parse(Console.ReadLine());
                    Search(Root, UserValue);
                    break;
                default:
                    RetryCounter++;
                    while (RetryCounter < 3)
                    {
                        Console.WriteLine("Error. Invalid Input.");
                        Console.ReadLine();
                        StartTree();
                    }
                    break;
            }

        }

    }
}
