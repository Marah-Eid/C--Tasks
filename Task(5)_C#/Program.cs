using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // 1
        MyClass obj1 = new MyClass();

        // 2
        IntroClass obj2 = new IntroClass();
        obj2.SayHello("Scott");

        // 3
        FactorialClass obj3 = new FactorialClass();
        Console.WriteLine("Factorial = " + obj3.Factorial(5));

        // 4
        SortClass obj4 = new SortClass();
        int[] array = { 11, -2, 4, 35, 0, 8, -9 };
        obj4.SortArray(array);

        // 5
        DateDifference obj5 = new DateDifference();
        DateTime date1 = new DateTime(1981, 11, 03);
        DateTime date2 = new DateTime(2013, 09, 04);
        obj5.GetDifference(date1, date2);

        // 6
        StringToDate obj6 = new StringToDate();
        obj6.ConvertDate("12-08-2004");

        Console.ReadKey();
    }
}

// 1
class MyClass
{
    public MyClass()
    {
        Console.WriteLine("MyClass class has initialized!");
    }
}

// 2
class IntroClass
{
    public void SayHello(string name)
    {
        Console.WriteLine("Hello All, I am " + name);
    }
}

// 3
class FactorialClass
{
    public int Factorial(int num)
    {
        int result = 1;

        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }

        return result;
    }
}

// 4
class SortClass
{
    public void SortArray(int[] arr)
    {
        Array.Sort(arr);

        Console.Write("Sorted array: { ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(" }");
    }
}

// 5
class DateDifference
{
    public void GetDifference(DateTime date1, DateTime date2)
    {
        if (date1 > date2)
        {
            DateTime temp = date1;
            date1 = date2;
            date2 = temp;
        }

        int years = date2.Year - date1.Year;
        int months = date2.Month - date1.Month;
        int days = date2.Day - date1.Day;

        if (days < 0)
        {
            months--;
            DateTime previousMonth = date2.AddMonths(-1);
            days += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
        }

        if (months < 0)
        {
            years--;
            months += 12;
        }

        Console.WriteLine("Difference: " + years + " years, " + months + " months, " + days + " day.");
    }
}

// 6
class StringToDate
{
    public void ConvertDate(string dateString)
    {
        DateTime date = DateTime.ParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Converted Date: " + date.ToString("yyyy-MM-dd"));
        Console.WriteLine("Converted DateTime: " + date.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}