using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test(78, 95));
        Console.WriteLine(test(20, 30));
        Console.WriteLine(test(21, 25));
        Console.WriteLine(test(28, 28));
    }
    public static int test(int num1, int num2){
        if(num1<31 && num1>19){
            return num1;
        } else if(num2<31 && num2>19){
            return num2;
        } else {
            return 0;
        }
    }
}