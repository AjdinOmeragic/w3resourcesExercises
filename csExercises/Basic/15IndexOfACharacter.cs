/*
15. Write a C# program that removes a specified character from a non-empty string using the index of a character.
Test Data:
w3resource
Sample Output:
wresource
w3resourc
3resource
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a String: ");
        string str = Console.ReadLine();
        
        Console.WriteLine("Enter the index of the character to be removed: ");
        int index;
        
        if (int.TryParse(Console.ReadLine(), out index))
        {
            if (index >= 0 && index < str.Length)
            {
                Console.WriteLine(removeCharacter(str, index));
            }
            else
            {
                Console.WriteLine("Index doesn't exist");
            }
        }
        else
        {
            Console.WriteLine("Enter a valid index");
        }
    }

    public static string removeCharacter(string str, int index)
    {
        return str.Remove(index, 1);
    }
}
