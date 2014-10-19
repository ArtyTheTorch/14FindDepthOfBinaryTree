using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14FindDepthOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree btObj = new BinaryTree();
            Node iniRoot = btObj.addNode(5);

            btObj.insertNode(btObj.root,iniRoot);
            btObj.insertNode(btObj.root, btObj.addNode(6));
            btObj.insertNode(btObj.root, btObj.addNode(10));
            btObj.insertNode(btObj.root, btObj.addNode(2));
            btObj.insertNode(btObj.root, btObj.addNode(3));
            btObj.displayTree(btObj.root);

            System.Console.WriteLine();
            System.Console.WriteLine(btObj.height(btObj.root));

            Console.ReadLine();
        }
    }
}
