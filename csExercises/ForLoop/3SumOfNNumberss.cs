using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i = 0; i <= n; i++){
            sum+=i;
        }
        Console.WriteLine("{0}",sum);
    }
}