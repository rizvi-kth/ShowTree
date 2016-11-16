using System;

namespace ShowTree
{
    public class BTree
    {
        public void PrintTree(Node rootNode)
        {
            TraverseTree(rootNode, 0);
        }

        void TraverseTree(Node parent, int level)
        {
            if (parent != null)
            {
                // Make the Indent
                string indent = " ";
                for (int i = 0; i < level; i++)
                {
                    //indent += " | ";
                    indent += "  ";
                }
                indent += "|";

                // Make Parent/Child marking
                if (parent.leftNode == null && parent.rightNode == null)
                    indent += "-- "; // Leaf node
                else
                    indent += "+- ";

                Console.WriteLine(indent + parent.NodeID + "(" + level +")");
                TraverseTree(parent.leftNode, level + 1);
                TraverseTree(parent.rightNode, level + 1); // Backtracking
            }
        }

        public Node MakeRoot( int p)
        {
            return new Node(p, 0);
        }

        public void Addnode(Node parent,int ins_val, int level)
        {
            if (parent.NodeID >= ins_val)
            {
                if (parent.rightNode == null)
                {
                    parent.rightNode = new Node( ins_val, level + 1);
                }
                else
                {
                    Addnode(parent.rightNode, ins_val, level + 1);
                }
            }
            else
            {
                if (parent.leftNode == null)
                {
                    parent.leftNode = new Node(ins_val, level + 1);
                }
                else
                {
                    Addnode(parent.leftNode, ins_val, level + 1);
                }
            }
        }
    }
}