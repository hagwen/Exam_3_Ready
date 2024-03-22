public static class Task_One
{

    public static double Square(double number)
    {
        // Implementation of Square function
        double square = number * number;
        return square;
    }

    public static double InchesToMillimeters(double lengthInInches)
    {
        // Implementation of InchesToMillimeters function
        double lengthInMillimeters = lengthInInches * 25.4;
        return lengthInMillimeters;
    }

    public static double SquareRoot(double number)
    {
        // Implementation of SquareRoot function
        double guess = number / 2.0;
        double sqrt = 0.0;
        while (true)
        {
            sqrt = (guess + number / guess) / 2.0;
            if (Math.Abs(sqrt - guess) < 0.0001)
                break;
            guess = sqrt;
        }
        return sqrt;
    }

    public static double Cube(double number)
    {
        // Implementation of Cube function
        double cube = number * number * number;
        return cube;
    }

    public static double CircleArea(double radius)
    {
        // Implementation of CircleArea function
        double area = Math.PI * radius * radius;
        return area;
    }

    public static string Greeting(string name)
    {
        // Implementation of Greeting function
        string greeting = "Hello, " + name + "! How are you today?";
        return greeting;
    }

}
