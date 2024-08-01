/*
5. Write a C# Sharp program to create a string where 'if' is added to the front of a given string. If the string already begins with 'if', return it unchanged.

Sample Input:
"if else"
"else"
Expected Output:
if else
if else
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ifTest("if else"));
        Console.WriteLine(ifTest("else"));
    }
    
    public static string ifTest(string str){
        if(str.Length >= 1 && str.Substring(0,2).Equals("if")){
            return str;
        }else{
            return "if " + str;
        }
    }
}