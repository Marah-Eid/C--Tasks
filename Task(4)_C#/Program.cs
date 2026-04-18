// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // 1
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        SumAndAverage(numbers);

        // 2
        DisplayCubes(5);

        // 3
        int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
        int[] resultYears = GetYears(years);
        Console.WriteLine("Years greater than 1950:");
        PrintIntArray(resultYears);

        // 4
        Console.WriteLine("Age in days: " + AgeInDays(20));

        // 5
        Console.WriteLine("Animal legs: " + Animals(2, 3, 5));

        // 6
        Console.WriteLine(Login("admin", "1234"));
        Console.WriteLine(Login("mara", "1111"));

        // 7
        Console.WriteLine("Power: " + Power(2, 4));

        // 8
        Console.WriteLine(IsLeapYear(2024));
        Console.WriteLine(IsLeapYear(2023));

        // 9
        Console.WriteLine(IsPrime(7));
        Console.WriteLine(IsPrime(8));

        // 10
        Console.WriteLine("Word count: " + CountWords("I love learning C sharp"));

        Console.ReadKey();
    }

    // 1
    static void SumAndAverage(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        double average = (double)sum / arr.Length;

        Console.WriteLine("The sum of 10 no is : " + sum);
        Console.WriteLine("The Average is : " + average);
    }

    // 2
    static void DisplayCubes(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Number is : " + i + " and cube of the " + i + " is : " + (i * i * i));
        }
    }

    // 3
    static int[] GetYears(int[] years)
    {
        int count = 0;

        for (int i = 0; i < years.Length; i++)
        {
            if (years[i] > 1950)
            {
                count++;
            }
        }

        int[] result = new int[count];
        int index = 0;

        for (int i = 0; i < years.Length; i++)
        {
            if (years[i] > 1950)
            {
                result[index] = years[i];
                index++;
            }
        }

        return result;
    }

    // 4
    static int AgeInDays(int age)
    {
        return age * 365;
    }

    // 5
    static int Animals(int chickens, int cows, int pigs)
    {
        if (chickens < 0 || cows < 0 || pigs < 0)
        {
            return 0;
        }

        return (chickens * 2) + (cows * 4) + (pigs * 4);
    }

    // 6
    static string Login(string username, string password)
    {
        string[] users = { "admin", "mara", "user" };
        string[] passwords = { "1234", "4321", "0000" };

        for (int i = 0; i < users.Length; i++)
        {
            if (username == users[i] && password == passwords[i])
            {
                return "pass";
            }
        }

        return "failed";
    }

    // 7
    static int Power(int num, int power)
    {
        int result = 1;

        for (int i = 1; i <= power; i++)
        {
            result *= num;
        }

        return result;
    }

    // 8
    static bool IsLeapYear(int year)
    {
        if (year < 1900 || year > 2024)
        {
            return false;
        }

        if (year % 400 == 0)
            return true;

        if (year % 100 == 0)
            return false;

        if (year % 4 == 0)
            return true;

        return false;
    }

    // 9
    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    // 10
    static int CountWords(string sentence)
    {
        int count = 1;

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ')
            {
                count++;
            }
        }

        return count;
    }

    static void PrintIntArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}