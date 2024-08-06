using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        bool isValid1 = false;
        bool isValid2 = false;

        while (!isValid1)
        {
            Console.Write("Enter the First Number: ");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out num1))
            {
                isValid1 = true;
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }
        }

        while (!isValid2)
        {
            Console.Write("Enter the Second Number: ");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out num2))
            {
                isValid2 = true;
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }
        }
        Console.WriteLine("Output is: {0}", (num1+num2));
    }
}
