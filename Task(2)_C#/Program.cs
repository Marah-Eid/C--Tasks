// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//1

int a = 5, b = 3;

if (a < b)
    Console.WriteLine(a);
else
    Console.WriteLine(b);
//2
int num = -7;

if (num > 0)
    Console.WriteLine("The sign is +");
else if (num < 0)
    Console.WriteLine("The sign is -");
else
    Console.WriteLine("The number is zero");
//3
int x = 0, y = -1, z = 4;

if (x < y) { int temp = x; x = y; y = temp; }
if (x < z) { int temp = x; x = z; z = temp; }
if (y < z) { int temp = y; y = z; z = temp; }

Console.WriteLine($"{x}, {y}, {z}");
//4
int a1 = -5, a2 = -2, a3 = -6, a4 = 0, a5 = -1;

int max = a1;

if (a2 > max) max = a2;
if (a3 > max) max = a3;
if (a4 > max) max = a4;
if (a5 > max) max = a5;

Console.WriteLine(max);

//5
double km = 15;
double miles = km * 0.621371;

Console.WriteLine(miles);

//6
int hours = 5;
int minutes = 37;

int total = (hours * 60) + minutes;

Console.WriteLine($"Total: {total} minutes");


//7
int totalMinutes = 546;

int h = totalMinutes / 60;
int m = totalMinutes % 60;

Console.WriteLine($"{h} Hours, {m} Minutes");

//8
string[] sentences = {
    "Hello world",
    "C sharp is fun",
    "I love coding",
    "Practice daily",
    "Keep learning"
};

foreach (string s in sentences)
{
    Console.WriteLine(s.PadRight(25)); // fixed width
}

//9
string ReverseOdd(string input)
{
    string[] words = input.Split(' ');

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length % 2 != 0)
        {
            char[] arr = words[i].ToCharArray();
            Array.Reverse(arr);
            words[i] = new string(arr);
        }
    }

    return string.Join(" ", words);
}