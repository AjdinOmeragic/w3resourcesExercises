using System;
using System.IO;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Adjust the file path as needed
        FileInfo file = new FileInfo("/Users/Korisnik/Desktop/w3resourcesExercises/Basic/1HelloName.cs");

        // Check if the file exists
        if (file.Exists)
        {
            Console.WriteLine("Size of the file: {0} bytes", file.Length);
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}
