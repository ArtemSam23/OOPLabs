# Отчет по лабораторной работе №1
## Упражнение 1
Напишем программу Hello World на языке C#:
```csharp
namespace Lab01;
internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
```
Для компиляции и запуска программы необходимо ввести следующие команды:
```bash
$ cd Projects/Labs/Lab01/
$ dotnet build
$ dotnet run
```
## Упражнение 2
Создание программы с помощью среды разработки Rider.
Напиишем программу приветсвия пользователя:
```csharp
namespace Lab01;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Please enter your name");
        var myName = Console.ReadLine( );
        if (string.IsNullOrEmpty(myName))
        {
            Console.WriteLine("Hello, anonymous user");
        }
        else
        {
            Console.WriteLine("Hello, {0}", myName);
        }
    }
}
```
## Упражнение 3
Отладка программы с помощью среды разработки Rider.
<img width="1157" alt="Screenshot 2023-03-05 at 22 28 59" src="https://user-images.githubusercontent.com/90460154/222983846-8b489d6a-058b-4a5e-a2da-f96d006bc293.png">
## Упражнение 4
Обработка исключений в программе.
```csharp
namespace Lab01;
internal static class Program
{
    public static void Main(string[ ] args)
    {
        try
        {
            Console.WriteLine ("Please enter the first integer"); string temp = Console.ReadLine( );
            int i = Int32.Parse(temp);
            Console.WriteLine ("Please enter the second integer"); temp = Console.ReadLine( );
            int j = Int32.Parse(temp);
            int k = i / j;
            Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k);
        }
        catch(FormatException e) {
            Console.WriteLine("You entered an incorrect value");
        }
        catch(DivideByZeroException e) {
            Console.WriteLine("You tried to divide by zero");
        }
        catch(Exception e) {
            Console.WriteLine("An exception was thrown: {0}", e.Message);
        }
    }
}
 ```
## Упражнение 5
Расчет площади треугольника по формуле Герона.
```csharp
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
```
