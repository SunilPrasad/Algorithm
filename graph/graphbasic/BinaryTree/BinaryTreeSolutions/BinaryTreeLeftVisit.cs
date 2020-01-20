using System;

namespace BinaryTreeSolutions
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int data)
        {
            this.data = data;
        }
    }

    public class BinaryTree
    {
        public Node root;

        private int maxLevel = 0;

        public void LeftVisitUtil(Node rootNode,int level)
        {
            if (rootNode == null)
                return;

            if(maxLevel < level)
            {
                Console.WriteLine(rootNode.data);
                maxLevel = level;
            }

            LeftVisitUtil(rootNode.left, level + 1);
            LeftVisitUtil(rootNode.right, level + 1);
        }

        public void LeftVisit()
        {
            LeftVisitUtil(root, 1);
        }
    }



    public class Program
    {
        /* testing for example nodes */
        //public static void Main(string[] args)
        //{
        //    /* creating a binary tree and entering the nodes */
        //    BinaryTree tree = new BinaryTree();
        //    tree.root = new Node(12);
        //    tree.root.left = new Node(10);
        //    tree.root.right = new Node(30);
        //    tree.root.right.left = new Node(25);
        //    tree.root.right.right = new Node(40);
        //    tree.root.right.right.right = new Node(50);

        //    tree.LeftVisit();
        //}
    }
}
