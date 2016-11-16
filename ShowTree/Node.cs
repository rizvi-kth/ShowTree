namespace ShowTree
{
    public class Node
    {
        public Node(int id, int lv)
        {
            NodeID = id;
            level = lv;
        }

        public int NodeID;
        public int level;
        public string NodeLabel;
        public Node leftNode;
        public Node rightNode;

    }
}