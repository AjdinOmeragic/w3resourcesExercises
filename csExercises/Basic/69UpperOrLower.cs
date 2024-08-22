using System;

class Program
{
    static void Main()
    {
        Console.Write("String: ");
        string input = Console.ReadLine();

        if (IsAllLowercase(input))
        {
            Console.WriteLine("Only lowercase letters.");
        }
        else if (IsAllUppercase(input))
        {
            Console.WriteLine("Only uppercase letters.");
        }
        else
        {
            Console.WriteLine("Its a mix.");
        }
    }

    static bool IsAllLowercase(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsLower(c))
            {
                return false;
            }
        }
        return true;
    }

    static bool IsAllUppercase(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsUpper(c))
            {
                return false;
            }
        }
        return true;
    }
}
