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
![Screenshot 2023-03-05 at 22.28.59.png](..%2F..%2F..%2FDesktop%2FScreenshot%202023-03-05%20at%2022.28.59.png)
## Упражнение 4
Обработка исключений в программе.
```csharp
namespace Lab01;
```
## Упражнение 5
Расчет площади треугольника по формуле Герона.
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
## Упражнение 6
Расчет площади треугольника по формуле Герона.
```csharp
internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Please enter the first side of the triangle");
        var firstSide = Console.ReadLine( );
        Console.WriteLine("Please enter the second side of the triangle");
        var secondSide = Console.ReadLine( );
        Console.WriteLine("Please enter the third side of the triangle");
        var thirdSide = Console.ReadLine( );
        try
        {
            var firstSideValue = double.Parse(firstSide);
            var secondSideValue = double.Parse(secondSide);
            var thirdSideValue = double.Parse(thirdSide);
            var halfPerimeter = (firstSideValue + secondSideValue + thirdSideValue) / 2;
            var area = Math.Sqrt(halfPerimeter * (halfPerimeter - firstSideValue) * (halfPerimeter - secondSideValue) * (halfPerimeter - thirdSideValue));
            Console.WriteLine("Area of the triangle = {0}", area);
        }
        catch (FormatException)
        {
            Console.WriteLine("You entered an incorrect value");
        }
    }
}
```