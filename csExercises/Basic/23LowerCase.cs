/*23. Write a C# program to convert a given string into lowercase.
Sample Output:
write a c# sharp program to display the following pattern using the alphabet.
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "AJDIN";
        Console.WriteLine(str);
        str = str.ToLower();
        Console.WriteLine(str);
    }
}