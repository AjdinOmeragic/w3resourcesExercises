using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1,num2;
        Console.WriteLine("Input a first number(<100): ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Input a first number(>200): ");
        num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine(numberCheck(num1,num2));
    }
    
    public static bool numberCheck(int num1, int num2){
        if(num1 < 100 && num2 > 200){
            return true;
        } else{
            return false;
        }
    }
}