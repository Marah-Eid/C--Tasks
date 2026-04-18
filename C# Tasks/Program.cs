// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

//Task1
Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"My name is {name} and I am {age} years old");
Console.ReadKey();

//Task2
/*Console.Write("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.Write($"the {num} is even");

}
else {
    Console.Write($"the {num} is odd");
}*/

//Task3

/*Console.Write("Enter a string: ");
string text = Console.ReadLine();

Console.WriteLine("You entered: " + text);

Console.ReadKey();*/

//Task 4 
/*
Console.Write("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    Console.Write("positive");
}

 else if (num < 0)
{
    Console.Write("negative");

}
else
{
    Console.Write("zero");

} */

//Task5

//Console.Write("Enter a year");
//int num = Convert.ToInt32(Console.ReadLine());
//if ((num % 4 == 0 && num % 100 != 0) ||  num %400==0 )
//{
//    Console.WriteLine(" a Leap Year");
//}
//else
//{
//    Console.WriteLine("Not a Leap Year");
//}

//Task6
//Console.Write("Enter a mark");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num >= 50)
//{
//    Console.WriteLine("passed");
//}
//else
//{
//    Console.WriteLine("failed");
//}

//Task7
//Console.Write("Enter number1");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter number2");

//int num1 = Convert.ToInt32(Console.ReadLine());
//if (num > num1)
//{
//    Console.WriteLine($"{num}is bigger than {num1}");
//}
//else
//{
//    Console.WriteLine($"{num1}is bigger than {num}");


//}

//Task8

//Console.Write("Enter number1");
//int num = Convert.ToInt32(Console.ReadLine());
//if(num%5==0 && num % 3 == 0)
//{
//    Console.WriteLine("divisble by 3 and 5");
//}
//else
//{
//    Console.WriteLine("not divisble by 3 and 5");

//}

//Task9
//Console.Write("Enter letter");
//char c =Convert.ToChar(Console.ReadLine().ToLower());
//if(c =='a'|| c=='u' || c=='i' ||c=='e' || c == 'o')
//{
//    Console.WriteLine("vowles");
//}
//else
//{
//    Console.WriteLine("not vowles");
//}

// Task 10
//int age = 16;
//if (age < 13)
//    Console.WriteLine("Child");
//else if (age < 20)
//    Console.WriteLine("Teenager");
//else
//    Console.WriteLine("Adult");

// Task 11
//int day = 3;
//switch (day)
//{
//    case 1: Console.WriteLine("Sunday"); break;
//    case 2: Console.WriteLine("Monday"); break;
//    case 3: Console.WriteLine("Tuesday"); break;
//    case 4: Console.WriteLine("Wednesday"); break;
//    case 5: Console.WriteLine("Thursday"); break;
//    case 6: Console.WriteLine("Friday"); break;
//    case 7: Console.WriteLine("Saturday"); break;
//}

// Task 12
//int month = 5;
//switch (month)
//{
//    case 1: Console.WriteLine("January"); break;
//    case 2: Console.WriteLine("February"); break;
//    case 3: Console.WriteLine("March"); break;
//    case 4: Console.WriteLine("April"); break;
//    case 5: Console.WriteLine("May"); break;
//    case 6: Console.WriteLine("June"); break;
//    case 7: Console.WriteLine("July"); break;
//    case 8: Console.WriteLine("August"); break;
//    case 9: Console.WriteLine("September"); break;
//    case 10: Console.WriteLine("October"); break;
//    case 11: Console.WriteLine("November"); break;
//    case 12: Console.WriteLine("December"); break;
//}

// Task 13 (calculator)
//int a = 10, b = 5;
//char op = '+';

//switch (op)
//{
//    case '+': Console.WriteLine(a + b); break;
//    case '-': Console.WriteLine(a - b); break;
//    case '*': Console.WriteLine(a * b); break;
//    case '/': Console.WriteLine(a / b); break;
//}

// Task 14 (grade)
//char grade = 'A';
//switch (grade)
//{
//    case 'A': Console.WriteLine("Excellent"); break;
//    case 'B': Console.WriteLine("Very Good"); break;
//    case 'C': Console.WriteLine("Good"); break;
//    case 'D': Console.WriteLine("Pass"); break;
//    case 'F': Console.WriteLine("Fail"); break;
//}

// Task 15
//int num = 2;
//switch (num)
//{
//    case 1: Console.WriteLine("One"); break;
//    case 2: Console.WriteLine("Two"); break;
//    case 3: Console.WriteLine("Three"); break;
//}

// Task 16 (even/odd with switch)
//int n = 7;
//switch (n % 2)
//{
//    case 0: Console.WriteLine("Even"); break;
//    case 1: Console.WriteLine("Odd"); break;
//}

// Task 17 (role)
//string role = "Admin";
//switch (role)
//{
//    case "Admin": Console.WriteLine("Full access"); break;
//    case "User": Console.WriteLine("Limited access"); break;
//    case "Guest": Console.WriteLine("Read only"); break;
//}

// Task 18 (menu)
//int choice = 1;
//switch (choice)
//{
//    case 1: Console.WriteLine("Start"); break;
//    case 2: Console.WriteLine("Settings"); break;
//    case 3: Console.WriteLine("Exit"); break;
//}

// ================= ADVANCED IF =================

// Task 1 (bonus)
int rating = 85;
if (rating >= 90)
    Console.WriteLine("Excellent + 20%");
else if (rating >= 75)
    Console.WriteLine("Very Good + 15%");
else if (rating >= 60)
    Console.WriteLine("Good + 10%");
else
    Console.WriteLine("No bonus");

// Task 2 (admission)
int gpa = 90;
bool passedEnglish = true;
bool recommendation = false;

if ((gpa >= 85 && passedEnglish) || recommendation)
    Console.WriteLine("Accepted");
else
    Console.WriteLine("Rejected");

// Task 3 (shipping)
double weight = 7;
if (weight <= 1)
    Console.WriteLine("$5");
else if (weight <= 5)
    Console.WriteLine("$10");
else if (weight <= 10)
    Console.WriteLine("$20");
else
    Console.WriteLine("$50 - Heavy package");

// Task 4 (login attempts)
string username = "admin";
string password = "1234";
int attempts = 2;

if (attempts > 3)
    Console.WriteLine("Account locked");
else if (username == "admin" && password == "1234")
    Console.WriteLine("Login successful");
else
    Console.WriteLine("Invalid credentials");

// ================= ADVANCED SWITCH =================

// Task 1 (restaurant)
int item = 2;
switch (item)
{
    case 1: Console.WriteLine("Burger $5"); break;
    case 2: Console.WriteLine("Pizza $8"); break;
    case 3: Console.WriteLine("Pasta $7"); break;
    case 4: Console.WriteLine("Salad $4"); break;
}

// Task 2 (grade meaning)
char g = 'B';
switch (g)
{
    case 'A': Console.WriteLine("Excellent"); break;
    case 'B': Console.WriteLine("Very Good"); break;
    case 'C': Console.WriteLine("Good"); break;
    case 'D': Console.WriteLine("Pass"); break;
    case 'F': Console.WriteLine("Fail"); break;
}

// Task 3 (ATM)
int atm = 1;
switch (atm)
{
    case 1: Console.WriteLine("Check Balance"); break;
    case 2: Console.WriteLine("Deposit"); break;
    case 3: Console.WriteLine("Withdraw"); break;
    case 4: Console.WriteLine("Exit"); break;
}

// Task 4 (calculator numbers)
int x = 6, y = 3, opNum = 1;

switch (opNum)
{
    case 1: Console.WriteLine(x + y); break;
    case 2: Console.WriteLine(x - y); break;
    case 3: Console.WriteLine(x * y); break;
    case 4: Console.WriteLine(x / y); break;
}

Console.ReadKey();
    }
}