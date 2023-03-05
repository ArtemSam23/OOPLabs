namespace Lab01;

static class Program
{
    private static void Main()
    {
        try
        {
            ReadTriangleSide(out var a, "first");
            ReadTriangleSide(out var b, "second");
            ReadTriangleSide(out var c, "third");
            var p = (a + b + c) / 2;
            if (!IsTriangle(a, b, c))
            {
                throw new Exception("The triangle with such sides does not exist.");
            }

            var area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Area of the triangle = {0}", area);
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }

    private static void ReadTriangleSide(out double sideValue, string sideName)
    {
        Console.Write("Enter the {0} side of the triangle: ", sideName);
        while (!double.TryParse(Console.ReadLine(), out sideValue) || sideValue <= 0)
        {
            Console.WriteLine("The side of the triangle must be a positive number.");
            Console.Write("Enter the {0} side of the triangle: ", sideName);
        }
    }

    private static bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}