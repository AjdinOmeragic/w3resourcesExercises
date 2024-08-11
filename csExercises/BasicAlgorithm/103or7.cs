using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test(12));
        Console.WriteLine(test(3));
        Console.WriteLine(test(14));
        Console.WriteLine(test(37));
    }
    
    public static bool test(int num)
    {
        if(num % 3 == 0 || num % 7 == 0){
            return true;
        } else {
            return false;
        }
    }
}
