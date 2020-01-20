using BinaryTreeSolutions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeSolutions_1
{
    public class LevelOrderTraversal
    {
        public static void Main()
        {

           Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);

            root.left.left = new Node(4);
            root.left.right = new Node(5);

            root.right.left = new Node(6);
            root.right.right = new Node(7);
            //root.right.right.right = new Node(8);
            //root.right.right.right.right = new Node(9);

            //BinaryTree binaryTree = new BinaryTree();
            //binaryTree.LevelOrderTraversal(root);

            MinMax minMax = new MinMax();
            PrintTreeVerticalOrder printTreeVerticalOrder = new PrintTreeVerticalOrder();
            printTreeVerticalOrder.FindMinMax(root,minMax,minMax,0); ;

            Console.WriteLine(minMax.max);
            Console.WriteLine(minMax.min);

            printTreeVerticalOrder.PrintVertical(root, minMax, minMax);
        }

    }

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

        public Queue<Node> queue=new Queue<Node>();

        public void LevelOrderTraversal(Node root)
        {
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                var node = queue.Dequeue();

                Console.WriteLine(node.data);

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }           
        }

       
    }
}
