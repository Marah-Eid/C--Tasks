using System;

class Program
{
    static void Main(string[] args)
    {
        // 1) 
        string[] arr = { "1", "7", "9", "45" };
        string[] arr2 = { "Str", "alex", "moh" };
        string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

        Console.WriteLine("Question 1:");
        PrintArray(arr);
        PrintArray(arr2);
        PrintArray(arr3);

        // 2) 
        string[] fruits = { "Tomato", "Banana", "Watermelon" };

        Console.WriteLine("\nQuestion 2:");
        Console.WriteLine("Index of Tomato: " + Array.IndexOf(fruits, "Tomato"));
        Console.WriteLine("Index of Banana: " + Array.IndexOf(fruits, "Banana"));

        // 3) 
        string[] favoriteFood = { "Pizza", "Burger", "Pasta", "Shawarma", "Rice" };
        string[] favoriteSport = { "Football", "Basketball", "Tennis" };
        string[] favoriteMovie = { "Inception", "Titanic", "Avatar", "Interstellar" };

        Console.WriteLine("\nQuestion 3:");
        Console.WriteLine("Favorite Food:");
        foreach (string item in favoriteFood)
            Console.WriteLine(item);

        Console.WriteLine("\nFavorite Sport:");
        foreach (string item in favoriteSport)
            Console.WriteLine(item);

        Console.WriteLine("\nFavorite Movie:");
        foreach (string item in favoriteMovie)
            Console.WriteLine(item);

        // 4) 
        Console.WriteLine("\nQuestion 4:");
        Console.Write("Input three numbers separated by comma: ");
        string input = Console.ReadLine();

        string[] numbers = input.Split(',');
        int n1 = int.Parse(numbers[0]);
        int n2 = int.Parse(numbers[1]);
        int n3 = int.Parse(numbers[2]);

        int sum = n1 + n2 + n3;
        Console.WriteLine("The sum of three numbers: " + sum);

        // 5) 
        Console.WriteLine("\nQuestion 5:");
        int oddSum = 0;

        Console.WriteLine("Odd numbers from 1 to 100:");
        for (int i = 1; i <= 100; i += 2)
        {
            Console.Write(i + " ");
            oddSum += i;
        }

        Console.WriteLine("\nThe Sum of odd Numbers is: " + oddSum);

        // 6) 
        Console.WriteLine("\nQuestion 6:");
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3 - i; j++)
                Console.Write(" ");

            for (int k = 1; k <= i; k++)
                Console.Write("*");

            Console.WriteLine();
        }

        // 7) 
        Console.WriteLine("\nQuestion 7:");
        int num = 1;

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4 - i; j++)
                Console.Write(" ");

            for (int k = 1; k <= i; k++)
            {
                Console.Write(num + " ");
                num++;
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }

    static void PrintArray(string[] arr)
    {
        foreach (string item in arr)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}