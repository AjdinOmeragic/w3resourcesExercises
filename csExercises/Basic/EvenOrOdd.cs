using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is even.");
        }
        else
        {
            Console.WriteLine(number + " is odd.");
        }
        string result = (number % 2 == 0) ? "even" : "odd";
        Console.WriteLine("Using ternary operator: " + number + " is " + result + ".");
    }
}
