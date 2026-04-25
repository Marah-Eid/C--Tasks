using System;
using System.IO;

string filePath = "data.txt";

try
{
    
    File.WriteAllLines(filePath, new string[]
    {
        "Name: Marah Eid",
        "Age: 22"
    });
    Console.WriteLine("File created and data written.\n");

    
    Console.WriteLine(" Reading file:");
    string[] lines = File.ReadAllLines(filePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }

    
    File.AppendAllText(filePath, "City: Amman\n");
    Console.WriteLine("\n New line appended.\n");

    
    Console.WriteLine(" File after appending:");
    foreach (string line in File.ReadAllLines(filePath))
    {
        Console.WriteLine(line);
    }
}
catch (IOException ex)
{
    Console.WriteLine($" File error: {ex.Message}");
}