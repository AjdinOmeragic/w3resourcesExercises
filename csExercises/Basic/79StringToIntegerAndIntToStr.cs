using System;

class Program
{
    static void Main()
    {
        string strValue = "44";
        Console.WriteLine("Original value and type: {0}, {1}", strValue, strValue.GetType());
        int intValue = int.Parse(strValue);
        Console.WriteLine("Converting...:");
        Console.WriteLine("Converted: {0}, {1}", intValue, intValue.GetType());

        int originalIntValue = 55;
        Console.WriteLine("Original value and type: {0}, {1}", originalIntValue, originalIntValue.GetType());
        string convertedStrValue = originalIntValue.ToString();
        Console.WriteLine("Converting...:");
        Console.WriteLine("Converted: {0}, {1}", convertedStrValue, convertedStrValue.GetType());
    }
}
