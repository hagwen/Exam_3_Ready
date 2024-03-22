public static class Task_1
{
    public static double Square(double number)
    {
        double square = number * number;
        return square;
    }

    public static double InchesToMillimeters(double lengthInInches)
    {
        double lengthInMillimeters = lengthInInches * 25.4;
        return lengthInMillimeters;
    }

    public static double SquareRoot(double number)
    {
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
        double cube = number * number * number;
        return cube;
    }

    public static double CircleArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return area;
    }

    public static string Greeting(string name)
    {
        string greeting = "Hello, " + name + "! How are you today?";
        return greeting;
    }
}
