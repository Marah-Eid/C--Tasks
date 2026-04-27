using System;

// ============================================================
// 1. POLYMORPHISM — Method Overloading
// ============================================================

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Add(int a, int b, int c) => a + b + c;

    public decimal Add(decimal a, decimal b) => a + b;
}

// ============================================================
// 2. POLYMORPHISM — Method Overriding
// ============================================================

public class Animal
{
    public virtual void Speak()
        => Console.WriteLine("...");
}

public class Dog : Animal
{
    public override void Speak()
        => Console.WriteLine("Woof!");
}

public class Cat : Animal
{
    public override void Speak()
        => Console.WriteLine("Meow!");
}

// ============================================================
// 3. ABSTRACTION — Abstract Class (Appliance)
// ============================================================

public abstract class Appliance
{
    public string Brand { get; set; }

    protected Appliance(string brand) => Brand = brand;

    public abstract void TurnOn();
    public abstract void TurnOff();
}

public class WashingMachine : Appliance
{
    public WashingMachine(string brand) : base(brand) { }

    public override void TurnOn()
        => Console.WriteLine($"{Brand} washing machine: starting wash cycle...");

    public override void TurnOff()
        => Console.WriteLine($"{Brand} washing machine: cycle complete, stopping.");
}

public class AirConditioner : Appliance
{
    public AirConditioner(string brand) : base(brand) { }

    public override void TurnOn()
        => Console.WriteLine($"{Brand} AC: cooling mode activated.");

    public override void TurnOff()
        => Console.WriteLine($"{Brand} AC: shutdown complete.");
}

// ============================================================
// 4. ENCAPSULATION — BankAccount
// ============================================================

public class BankAccount
{
    private decimal _balance;

    public decimal Balance => _balance; // read-only property

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");
        _balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");
        _balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {_balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");
        if (amount > _balance)
        {
            Console.WriteLine("Insufficient funds! Withdrawal denied.");
            return;
        }
        _balance -= amount;
        Console.WriteLine($"Withdrew {amount:C}. New balance: {_balance:C}");
    }
}

// ============================================================
// 5. ABSTRACT CLASS — Employee & Salary
// ============================================================

public abstract class Employee
{
    public string Name { get; set; }

    protected Employee(string name) => Name = name;

    public abstract decimal CalculateSalary();

    public virtual void PrintInfo()
        => Console.WriteLine($"{Name}: {CalculateSalary():C}/month");
}

public class FullTimeEmployee : Employee
{
    private readonly decimal _monthlySalary;

    public FullTimeEmployee(string name, decimal monthlySalary)
        : base(name) => _monthlySalary = monthlySalary;

    public override decimal CalculateSalary() => _monthlySalary;
}

public class PartTimeEmployee : Employee
{
    private readonly decimal _hourlyRate;
    private readonly int _hoursWorked;

    public PartTimeEmployee(string name, decimal hourlyRate, int hoursWorked)
        : base(name)
    {
        _hourlyRate = hourlyRate;
        _hoursWorked = hoursWorked;
    }

    public override decimal CalculateSalary() => _hourlyRate * _hoursWorked;
}

// ============================================================
// 6. ENCAPSULATION — Person with private field & property
// ============================================================

public class Person
{
    private string _name;
    private int _age;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            _name = value;
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            if (value < 0 || value > 150)
                throw new ArgumentException("Age must be between 0 and 150.");
            _age = value;
        }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
        => Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
}

// ============================================================
// 7. ABSTRACTION — Abstract Shape with Area
// ============================================================

public abstract class Shape
{
    public abstract double GetArea();

    public virtual void PrintArea()
        => Console.WriteLine($"{GetType().Name} area: {GetArea():F2}");
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea() => Width * Height;
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius) => Radius = radius;

    public override double GetArea() => Math.PI * Radius * Radius;
}

// ============================================================
// MAIN — Testing Everything
// ============================================================

class Program
{
    static void Main()
    {
        // --- 1. Method Overloading ---
        Console.WriteLine("=== Calculator (Method Overloading) ===");
        Calculator calc = new Calculator();
        Console.WriteLine($"Add(3, 4)         = {calc.Add(3, 4)}");
        Console.WriteLine($"Add(1, 2, 3)      = {calc.Add(1, 2, 3)}");
        Console.WriteLine($"Add(1.5m, 2.3m)   = {calc.Add(1.5m, 2.3m)}");

        Console.WriteLine();

        // --- 2. Method Overriding ---
        Console.WriteLine("=== Animals (Method Overriding) ===");
        Animal[] animals = { new Dog(), new Cat() };
        foreach (var a in animals)
            a.Speak();

        Console.WriteLine();

        // --- 3. Appliance Abstraction ---
        Console.WriteLine("=== Appliances (Abstraction) ===");
        Appliance[] appliances =
        {
            new WashingMachine("Samsung"),
            new AirConditioner("LG")
        };
        foreach (var appliance in appliances)
        {
            appliance.TurnOn();
            appliance.TurnOff();
        }

        Console.WriteLine();

        // --- 4. BankAccount Encapsulation ---
        Console.WriteLine("=== BankAccount (Encapsulation) ===");
        BankAccount account = new BankAccount(500m);
        account.Deposit(200m);
        account.Withdraw(100m);
        account.Withdraw(700m); // should be denied
        Console.WriteLine($"Final balance: {account.Balance:C}");

        Console.WriteLine();

        // --- 5. Employee Abstract Class ---
        Console.WriteLine("=== Employees (Abstract Class) ===");
        Employee[] staff =
        {
            new FullTimeEmployee("Alice", 4500m),
            new PartTimeEmployee("Bob", 20m, 80)
        };
        foreach (var e in staff)
            e.PrintInfo();

        Console.WriteLine();

        // --- 6. Person Encapsulation ---
        Console.WriteLine("=== Person (Encapsulation) ===");
        Person person = new Person("Sara", 28);
        person.Introduce();

        Console.WriteLine();

        // --- 7. Shape Abstraction ---
        Console.WriteLine("=== Shapes (Abstraction + Inheritance) ===");
        Shape[] shapes =
        {
            new Rectangle(5, 3),
            new Circle(4)
        };
        foreach (var shape in shapes)
            shape.PrintArea();
    }
}
