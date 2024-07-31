/*
14. Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
Test Data:
Enter the amount of celsius: 30
Expected Output:
Kelvin = 303
Fahrenheit = 86
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Enter the Amount of Celcious: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("Kelvin = {0}", num + 273);
        Console.WriteLine("Faranhite = {0}", num * 18 / 10 + 32);
    }
}
