using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeSolutions
{
    public class MinMax
    {
        public int min;
        public int max;
    }
    public class PrintTreeVerticalOrder
    {

        public void FindMinMax(BinaryTreeSolutions_1.Node root , MinMax min , MinMax max , int hd)
        {
            if (root == null)
                return;

            if(hd<min.min)
            {
                min.min = hd;
            }
            else if(hd > max.max)
            {
                min.max = hd;
            }

            FindMinMax(root.left, min, max, hd - 1);
            FindMinMax(root.right, min, max, hd + 1);
        }

        public void Print(BinaryTreeSolutions_1.Node root , int linenumber , int hd)
        {
            if (root == null)
                return;
            if (hd == linenumber)
                Console.WriteLine(root.data);

            Print(root.left, linenumber, hd - 1);
            Print(root.right, linenumber, hd + 1);
        }

        public void PrintVertical(BinaryTreeSolutions_1.Node root, MinMax max , MinMax min)
        {
            for(int i=min.min;i<=max.max;i++)
            {
                Print(root, i, 0);
            }
        }
    }
}
