using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(test("Python")); 
        Console.WriteLine(test("JS"));     
        Console.WriteLine(test("Code"));   
    }
    public static string test(string str){
        string newStr = "";
        if(str.Length < 3){
            newStr = str + str + str;
        } else{
            newStr = str.Substring(0,3) + str + str.Substring(0,3);
        }
        return newStr;
    }
}