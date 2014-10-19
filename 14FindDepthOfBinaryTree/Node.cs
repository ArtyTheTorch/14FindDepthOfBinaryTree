using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14FindDepthOfBinaryTree
{
    class Node
    {
        public int data;
        public Node left, right;

        public Node(int data) {
            this.data = data;
            left = null;
            right = null;
        }
    }
}
