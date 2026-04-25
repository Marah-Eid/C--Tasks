using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("=== MathUtilities ===");
        double squared = MathUtilities.Square(4);
        double squareRoot = MathUtilities.SquareRoot(16);
        double max = MathUtilities.Max(10, 25);

        Console.WriteLine($"Square of 4: {squared}");
        Console.WriteLine($"Square Root of 16: {squareRoot}");
        Console.WriteLine($"Max of 10 and 25: {max}");

      
        Console.WriteLine("\n=== Converter ===");
        double fahrenheit = Converter.CelsiusToFahrenheit(100);
        double miles = Converter.KilometersToMiles(10);

        Console.WriteLine($"100°C in Fahrenheit: {fahrenheit}°F");
        Console.WriteLine($"10 km in Miles: {miles:F4} miles");

      
        Console.WriteLine("\n=== VisitorCounter ===");
        VisitorCounter v1 = new VisitorCounter();
        VisitorCounter v2 = new VisitorCounter();
        VisitorCounter v3 = new VisitorCounter();

        Console.WriteLine($"Total Visitors: {VisitorCounter.Count}");

        
        Console.WriteLine("\n=== Company ===");
        Company.CompanyName = "Anthropic";

        Company emp1 = new Company("Alice");
        Company emp2 = new Company("Bob");
        Company emp3 = new Company("Charlie");

        emp1.PrintInfo();
        emp2.PrintInfo();
        emp3.PrintInfo();
    }
}

//  Task 1: Static Class 
static class MathUtilities
{
    public static double Square(int a)
    {
        return a * a;
    }

    public static double SquareRoot(double number)
    {
        return Math.Sqrt(number);
    }

    public static double Max(double a, double b)
    {
        return (a > b) ? a : b;
    }
}

//  Task 2:
class Converter
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double KilometersToMiles(double km)
    {
        return km * 0.621371;
    }
}

// Task 3: Static field 
class VisitorCounter
{
    public static int Count = 0;

    public VisitorCounter()
    {
        Count++;
    }
}

//  Task 4: Static property (company name) + non-static property (employee name)
class Company
{
    public static string CompanyName { get; set; }
    public string EmployeeName { get; set; }

    public Company(string employeeName)
    {
        EmployeeName = employeeName;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Employee: {EmployeeName} | Company: {CompanyName}");
    }
}