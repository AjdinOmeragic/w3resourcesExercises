/*
30. Write a C# program to convert a hexadecimal number to a decimal number.
Sample Output:
Hexadecimal number: 4B0
Convert to-
Decimal number: 1200
*/

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string hex = "4B0";
        int dec = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("Hexadecimnal: {0} \nDecimal: {1}",hex,dec);
    }
}