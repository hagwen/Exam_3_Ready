class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

class Task_3
{
    static void tree(string[] args)
    {
        Node root = new Node(180);
        root.Left = new Node(918);
        root.Left.Right = new Node(379);
        root.Left.Right.Right = new Node(299);
        root.Left.Right.Right.Left = new Node(607);
        root.Left.Right.Right.Left.Left = new Node(190);
        root.Left.Right.Right.Left.Right = new Node(902);
        root.Left.Right.Right.Left.Right.Right = new Node(416);
        root.Right = new Node(961);
        root.Right.Right = new Node(581);

        int sum = CalculateSumOfTree(root);
        Console.WriteLine("Sum of the full structure: " + sum);

        int deepestLevel = FindDeepestLevelOfTree(root);
        Console.WriteLine("Deepest level of the structure: " + deepestLevel);

        int numberOfNodes = CountNodesInTree(root);
        Console.WriteLine("Number of nodes: " + numberOfNodes);
    }

    static int CalculateSumOfTree(Node node)
    {
        if (node == null)
            return 0;

        return node.Value + CalculateSumOfTree(node.Left) + CalculateSumOfTree(node.Right);
    }

    static int FindDeepestLevelOfTree(Node node)
    {
        if (node == null)
            return 0;

        int leftDepth = FindDeepestLevelOfTree(node.Left);
        int rightDepth = FindDeepestLevelOfTree(node.Right);

        return 1 + Math.Max(leftDepth, rightDepth);
    }


    static int CountNodesInTree(Node node)
    {
        if (node == null)
            return 0;

        return 1 + CountNodesInTree(node.Left) + CountNodesInTree(node.Right);
    }
}
