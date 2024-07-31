/*
13. Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
Test Data:
Enter a number: 5
Expected Output:
555
5 5
5 5
5 5
555
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Enter the number: ");
        num = int.Parse(Console.ReadLine());
        
        Console.WriteLine("");
        Console.WriteLine("{0}{0}{0}{0}", num); //Wouldnt display the last number so I added {0} an extra
        Console.WriteLine("{0} {0}", num);
        Console.WriteLine("{0} {0}", num);
        Console.WriteLine("{0} {0}", num);
        Console.WriteLine("{0}{0}{0}", num);
    }
}
