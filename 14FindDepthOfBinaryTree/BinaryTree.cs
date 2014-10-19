using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14FindDepthOfBinaryTree
{
    class BinaryTree
    {
        public Node root;
        static int count = 0;

        public BinaryTree()
        {
            root = null;
        }

        public Node addNode(int data)
        {
            Node newNode = new Node(data);

            if (root == null)
            {
                root = newNode;
            }
            count++;
            return newNode;
        }

        public void insertNode(Node root, Node newNode)
        {
            Node temp;
            temp = root;

            if (newNode.data < temp.data)
            {
                if (temp.left == null)
                {
                    temp.left = newNode;
                }
                else
                {
                    temp = temp.left;
                    insertNode(temp, newNode);
                }
            }
            else if (newNode.data > temp.data)
            {
                if (temp.right == null)
                {
                    temp.right = newNode;
                }
                else
                {
                    temp = temp.right;
                    insertNode(temp, newNode);
                }
            }
        }
        public void displayTree(Node root)
        {
            Node temp = root;
            if (temp == null)
            {
                return;
            }
            else
            {
                displayTree(temp.left);
                System.Console.Write(temp.data + " ");
                displayTree(temp.right);
            }
        }

        public int height(Node temp)
        {
            if (temp == null)
                return 0;
            int heightLeft = height(temp.left);
            int heightRight = height(temp.right);

            if (heightLeft > heightRight)
                return heightLeft + 1;
            else
                return heightRight + 1;
        }
    }
}
