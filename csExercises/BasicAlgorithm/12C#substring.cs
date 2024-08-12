using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test("C# Sharp"));
        Console.WriteLine(test("C#"));
        Console.WriteLine(test("C++"));
    }
    public static bool test(string str){
        if(str.Substring(0,2) == "C#"){
            return true;
        } else {
            return false;
        }
    }
}