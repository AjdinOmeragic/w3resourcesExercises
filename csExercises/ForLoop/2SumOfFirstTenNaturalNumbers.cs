using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int sum = 0;
        for(int i = 0; i <= 10; i++){
            sum+=i;
        }
        Console.WriteLine("{0}",sum);
    }
}