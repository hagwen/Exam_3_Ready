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


    }


    static void Main3(string[] args)
    {

    }



    static void Main4(string[] args)
    {

    }


}

