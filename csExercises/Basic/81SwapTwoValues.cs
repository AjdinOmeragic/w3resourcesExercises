using System;

class Program
{
    static void Main()
    {
        Console.Write("EEnter numb: ");
        int originalValue = int.Parse(Console.ReadLine());
        int swappedValue = (originalValue % 10) * 10 + (originalValue / 10);
        bool isGreaterThen = originalValue > swappedValue;
        Console.WriteLine("Check value: " + isGreaterThen);
    }
}
