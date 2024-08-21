using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the full file path:");
        string filePath = Console.ReadLine();
        string fileName = Path.GetFileName(filePath);
        Console.WriteLine("The file name is: " + fileName);
    }
}
