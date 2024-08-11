using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test("Red"));
        Console.WriteLine(test("Green"));
        Console.WriteLine(test("1")); 
    }
    
    public static string test(string str)
    {
        if(str.Length > 1){
            return "d" + str + "d";
        }
        else{
            return str;
        }
    }
}
