

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
    static void node(string[] args)
    {
        // Construct the tree structure
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

        // Calculate sum of the full structure
        int sum = CalculateSum(root);
        Console.WriteLine("Sum of the full structure: " + sum);

        // Report the deepest level of the structure
        int deepestLevel = FindDeepestLevel(root);
        Console.WriteLine("Deepest level of the structure: " + deepestLevel);

        // Report the number of nodes
        int numberOfNodes = CountNodes(root);
        Console.WriteLine("Number of nodes: " + numberOfNodes);
    }

    static int CalculateSum(Node node)
    {
        if (node == null)
            return 0;

        return node.Value + CalculateSum(node.Left) + CalculateSum(node.Right);
    }

    static int FindDeepestLevel(Node node)
    {
        if (node == null)
            return 0;

        int leftDepth = FindDeepestLevel(node.Left);
        int rightDepth = FindDeepestLevel(node.Right);

        return 1 + Math.Max(leftDepth, rightDepth);
    }

    static int CountNodes(Node node)
    {
        if (node == null)
            return 0;

        return 1 + CountNodes(node.Left) + CountNodes(node.Right);
    }
}
