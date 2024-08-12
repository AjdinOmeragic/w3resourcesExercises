using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test(120, -1));
        Console.WriteLine(test(-1, 120));
        Console.WriteLine(test(2, 20));
    }
    public static bool test(int num1, int num2){
        if((num1 > 100 && num1 < 200) || (num2 > 100 && num2 < 200)){
            return true;
        } else {
            return false;
        }
    }
}