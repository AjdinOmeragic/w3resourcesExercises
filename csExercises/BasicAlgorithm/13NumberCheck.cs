using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test(120, -1));
        Console.WriteLine(test(-1, 120));
        Console.WriteLine(test(2, 120));
    }
    public static bool test(int num1, int num2){
        if((num1 < 0 && num2 > 100) || (num1 > 100 && num2 < 0)){
            return true;
        } else {
            return false;
        }
    }
}