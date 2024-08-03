using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        int num;
        Console.WriteLine("Input Integer: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine(threeOrSeven(num));
    }
    public static bool threeOrSeven(int num){
        if(num>0 && (num%3==0 || num%7==0)){
            return true;
        } else {
            return false;
        }
    }
}