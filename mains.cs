using System;

class CombinedMain
{
    static void Main(string[] args)
    {
        Main1(args);
        Main2(args);
        Main3(args);
        Main4(args);
    }

    static void Main1(string[] args)
    {
        Console.WriteLine("Testing mathematical functions:");

        // Test Square function
        double num1 = 5.0;
        double squareResult = Task_One.Square(num1);
        Console.WriteLine("Square of {0} is {1}", num1, squareResult);

        // Test InchesToMillimeters function
        double lengthInInches = 10.0;
        double millimetersResult = Task_One.InchesToMillimeters(lengthInInches);
        Console.WriteLine("{0} inches is equal to {1} millimeters", lengthInInches, millimetersResult);

        // Test SquareRoot function
        double num2 = 16.0;
        double sqrtResult = Task_One.SquareRoot(num2);
        Console.WriteLine("Square root of {0} is {1}", num2, sqrtResult);

        // Test Cube function
        double num3 = 4.0;
        double cubeResult = Task_One.Cube(num3);
        Console.WriteLine("Cube of {0} is {1}", num3, cubeResult);

        // Test CircleArea function
        double radius = 5.0;
        double circleAreaResult = Task_One.CircleArea(radius);
        Console.WriteLine("Area of a circle with radius {0} is {1}", radius, circleAreaResult);

        // Test Greeting function
        string name = "John";
        string greetingResult = Task_One.Greeting(name);
        Console.WriteLine(greetingResult);
        Console.WriteLine("------------------------------------------------------------------------------------------");
    }

    static void Main2(string[] args)
    {
        object[] nestedArray = new object[]
                {
            9827, 5976, 9561, 1422, 2184, 3858,
            new object[]
            {
                5323, 1457, 6664, 8481, 4380,
                new object[]
                {
                    7976, 7322, 6699, 2154, 2587, 4610,
                    new object[]
                    {
                        2581, 9977, 6956, 1203, 7467, 9292, 4454, 9133, 6837, 4196, 1269, 8726, 4499, 4934,
                        new object[] {8050, 5585, 9759, 1938, 9956}
                    },
                    5536, 6560, 4326, 2403, 8728
                },
                3308
            },
            9517, 958, 3837,
            new object[]
            {
                1522,
                new object[]
                {
                    7156, 4741,
                    new object[]
                    {
                        6300, 7602, 8031, 2597, 5356, 3639, 5596, 1761, 9878, 7025, 9467, 6089
                    },
                    new object[] {6379, 492, 6782, 945, 2120, 1460, 6503, 7309, 2490},
                    9532, 3858, 1235, 9121, 2204, 4059, 8809, 335
                },
                6977, 9755, 5196
            }
                };

        // Flatten the nested array
        List<int> flattenedArray = FlattenArray(nestedArray);

        // Print the flattened array
        Console.WriteLine("Flattened Array:");
        foreach (var item in flattenedArray)
        {
            Console.Write(item + " ");

        }

    }
    private static List<int> FlattenArray(object[] nestedArray)
    {
        List<int> result = new List<int>();

        foreach (var item in nestedArray)
        {
            if (item is int)
            {
                result.Add((int)item);
            }
            else if (item is object[])
            {
                result.AddRange(FlattenArray((object[])item));
            }
            else
            {
                throw new ArgumentException("Invalid element type in the nested array.");
            }
        }

        return result;

    }


    static void Main3(string[] args)
    {
        Console.WriteLine("------------------------------------------------------------------------------------------");
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
        Console.WriteLine("------------------------------------------------------------------------------------------");
        int sum = CalculateSum(root);
        Console.WriteLine("Sum of the full structure: " + sum);

        // Report the deepest level of the structure

        int deepestLevel = FindDeepestLevel(root);
        Console.WriteLine("Deepest level of the structure: " + deepestLevel);

        // Report the number of nodes

        int numberOfNodes = CountNodes(root);
        Console.WriteLine("Number of nodes: " + numberOfNodes);
        Console.WriteLine("------------------------------------------------------------------------------------------");
    }
    private static int CalculateSum(Node root)
    {
        if (root == null)
            return 0;

        int sum = root.Value;
        if (root.Left != null)
            sum += CalculateSum(root.Left);
        if (root.Right != null)
            sum += CalculateSum(root.Right);

        return sum;
    }

    private static int FindDeepestLevel(Node root)
    {
        if (root == null)
            return 0;

        int leftDepth = FindDeepestLevel(root.Left);
        int rightDepth = FindDeepestLevel(root.Right);

        return 1 + Math.Max(leftDepth, rightDepth);
    }

    private static int CountNodes(Node root)
    {
        if (root == null)
            return 0;

        return 1 + CountNodes(root.Left) + CountNodes(root.Right);
    }



    static void Main4(string[] args)
    {

    }


}

