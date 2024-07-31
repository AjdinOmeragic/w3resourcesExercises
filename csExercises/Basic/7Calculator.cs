using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1, num2;
        
        Console.WriteLine("Enter The First Number: ");
        num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter The Second NumberL: ");
        num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("{0} + {1} = {2}", num1,num2, num1+num2);
        Console.WriteLine("{0} - {1} = {2}", num1,num2, num1-num2);
        Console.WriteLine("{0} x {1} = {2}", num1,num2, num1*num2);
        Console.WriteLine("{0} / {1} = {2}", num1,num2, num1/num2);
        Console.WriteLine("{0} mod {1} = {2}", num1,num2, num1%num2);
    }
}
