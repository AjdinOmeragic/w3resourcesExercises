using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double r, circ;
        double Pi = 3.14;
        
        Console.WriteLine("Enter val: ");
        r = Convert.ToDouble(Console.ReadLine());
        
        circ = 2*Pi*r;
        Console.WriteLine("Perimeter of Circle : {0}", circ);
    }
}
