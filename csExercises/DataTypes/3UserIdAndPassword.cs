using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int attempts = 0;
        while (attempts++ < 3)
        {
            Console.Write("Enter Username: ");
            string userName = Console.ReadLine();
            Console.Write("Enter Password: ");
            int pas = int.Parse(Console.ReadLine());

            if (pas == 123456789 && userName == "Ajdin")
            {
                Console.WriteLine("Access Granted");
                return;
            }
            Console.WriteLine("Incorrect Username or Password.");
        }
        Console.WriteLine("Maximum attempts reached. Access Denied.");
    }
}
